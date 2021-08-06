using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace BetterGameLauncher
{
    public partial class MainWindow : Form
    {
        private string steamPath;
        private string selectedGame;
        private Dictionary<string, int> installedGames = new Dictionary<string, int>();

        VirtualConsole console = new VirtualConsole();
        ProcessManager process = new ProcessManager();
        public MainWindow()
        {
            InitializeComponent();

            console.textBox = virtualConsole;
            process.console = console;

            findInstalledGames();
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Idle;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            RegistryKey settings = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\BetterGameLauncher");
            if (settings != null)
            {
                steamPath = (string)settings.GetValue("SteamPath", "C:\\Windows\\Program Files (x86)\\Steam\\steam.exe");
                selectedGame = (string)settings.GetValue("SelectedGame", "");

                steamPath_Textbox.Text = steamPath;
                gamesListCombo.SelectedItem = selectedGame;

                settings.Close();
            }
        }

        public void findInstalledGames()
        {
            RegistryKey games = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam\Apps");
            string[] gamesList = games.GetSubKeyNames();
            games.Close();
            for (int i = 0; i < gamesList.Length; i++)
            {
                RegistryKey game = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam\Apps\" + gamesList[i]);
                int isInstalled = (int)game.GetValue("Installed", 0);
                string name = (string)game.GetValue("Name");
                if (name == null || name == "") continue;
                if (isInstalled == 1)
                {
                    installedGames.Add(name, int.Parse(gamesList[i]));
                    gamesListCombo.Items.Add(name);
                    console.Write("Found game: " + name, 0);
                }
            }
        }

        private void LaunchGameButton_Click(object sender, EventArgs e)
        {
            if ((string)gamesListCombo.SelectedItem == null)
            {
                console.Write($"Game not selected. Reverting operations...", VirtualConsole.writeTypes.Warning);
                return;
            }

            int gameId = installedGames[(string)gamesListCombo.SelectedItem];

            using (Process proc = process.Find("steam"))
            {
                if (proc != null)
                    process.Kill(proc);
                else
                {
                    console.Write("No steam processes was found", VirtualConsole.writeTypes.Info);
                }
            }

            ProcessStartInfo procInfo = new ProcessStartInfo();
            procInfo.FileName = steamPath;
            procInfo.Arguments = $"-no-browser -nofriendsui -nobigpicture -silent -applaunch {gameId}";
            procInfo.WindowStyle = ProcessWindowStyle.Hidden;
            procInfo.CreateNoWindow = true;

            console.Write($"Launching...", VirtualConsole.writeTypes.Info);

            process.Start(procInfo, ProcessPriorityClass.Idle);

            console.Write($"Launched Optimized steam with game! ID: {gameId}", VirtualConsole.writeTypes.Ok);
        }

        private void SteamPathChooseButton_Click(object sender, EventArgs e)
        {
            steamFileBrowser.ShowDialog();
        }

        private void steamFileBrowser_FileOk(object sender, CancelEventArgs e)
        {
            RegistryKey settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BetterGameLauncher");

            steamPath = steamFileBrowser.FileName;
            steamPath_Textbox.Text = steamPath;

            settings.SetValue("SteamPath", steamPath);
            settings.Close();
        }

        private void KillSteamButton_Click(object sender, EventArgs e)
        {
            using (Process proc = process.Find("steam"))
            {
                if (proc != null)
                    process.Kill(proc);
                else
                {
                    console.Write("No steam processes was found", VirtualConsole.writeTypes.Error);
                }
            }
        }

        private void gamesListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistryKey settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BetterGameLauncher");

            settings.SetValue("SelectedGame", gamesListCombo.SelectedItem);
        }
    }
}
