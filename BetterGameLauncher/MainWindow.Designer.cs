
namespace BetterGameLauncher
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SteamPathChooseButton = new System.Windows.Forms.Button();
            this.steamFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.steamPath_Textbox = new System.Windows.Forms.TextBox();
            this.gamesListCombo = new System.Windows.Forms.ComboBox();
            this.virtualConsole = new System.Windows.Forms.TextBox();
            this.KillSteamButton = new System.Windows.Forms.Button();
            this.LaunchGameButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Steam Path:";
            // 
            // SteamPathChooseButton
            // 
            this.SteamPathChooseButton.Location = new System.Drawing.Point(335, 39);
            this.SteamPathChooseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SteamPathChooseButton.Name = "SteamPathChooseButton";
            this.SteamPathChooseButton.Size = new System.Drawing.Size(28, 25);
            this.SteamPathChooseButton.TabIndex = 3;
            this.SteamPathChooseButton.Text = "...";
            this.toolTip1.SetToolTip(this.SteamPathChooseButton, "Browse...");
            this.SteamPathChooseButton.UseVisualStyleBackColor = true;
            this.SteamPathChooseButton.Click += new System.EventHandler(this.SteamPathChooseButton_Click);
            // 
            // steamFileBrowser
            // 
            this.steamFileBrowser.FileName = "steam.exe";
            this.steamFileBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.steamFileBrowser_FileOk);
            // 
            // steamPath_Textbox
            // 
            this.steamPath_Textbox.Location = new System.Drawing.Point(80, 41);
            this.steamPath_Textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.steamPath_Textbox.Name = "steamPath_Textbox";
            this.steamPath_Textbox.ReadOnly = true;
            this.steamPath_Textbox.Size = new System.Drawing.Size(251, 23);
            this.steamPath_Textbox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.steamPath_Textbox, "Full path to your steam.exe file");
            // 
            // gamesListCombo
            // 
            this.gamesListCombo.FormattingEnabled = true;
            this.gamesListCombo.Location = new System.Drawing.Point(80, 12);
            this.gamesListCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gamesListCombo.Name = "gamesListCombo";
            this.gamesListCombo.Size = new System.Drawing.Size(283, 23);
            this.gamesListCombo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.gamesListCombo, "Better Game Launcher automatically searches for the games\r\nyou installed, you jus" +
        "t have to select one of them.");
            this.gamesListCombo.SelectedIndexChanged += new System.EventHandler(this.gamesListCombo_SelectedIndexChanged);
            // 
            // virtualConsole
            // 
            this.virtualConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.virtualConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.virtualConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.virtualConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.virtualConsole.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.virtualConsole.ForeColor = System.Drawing.Color.White;
            this.virtualConsole.Location = new System.Drawing.Point(0, 112);
            this.virtualConsole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.virtualConsole.Multiline = true;
            this.virtualConsole.Name = "virtualConsole";
            this.virtualConsole.Size = new System.Drawing.Size(374, 128);
            this.virtualConsole.TabIndex = 50;
            this.toolTip1.SetToolTip(this.virtualConsole, "Console, that displays information about activities.");
            // 
            // KillSteamButton
            // 
            this.KillSteamButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KillSteamButton.Location = new System.Drawing.Point(0, 0);
            this.KillSteamButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.KillSteamButton.Name = "KillSteamButton";
            this.KillSteamButton.Size = new System.Drawing.Size(188, 36);
            this.KillSteamButton.TabIndex = 5;
            this.KillSteamButton.Text = "Kill Steam Processes";
            this.toolTip1.SetToolTip(this.KillSteamButton, "Kill running steam processes, can help you in different situations");
            this.KillSteamButton.UseVisualStyleBackColor = true;
            this.KillSteamButton.Click += new System.EventHandler(this.KillSteamButton_Click);
            // 
            // LaunchGameButton
            // 
            this.LaunchGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.LaunchGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LaunchGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaunchGameButton.Location = new System.Drawing.Point(0, 0);
            this.LaunchGameButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LaunchGameButton.Name = "LaunchGameButton";
            this.LaunchGameButton.Size = new System.Drawing.Size(185, 36);
            this.LaunchGameButton.TabIndex = 1;
            this.LaunchGameButton.Text = "Launch Optimized Game";
            this.toolTip1.SetToolTip(this.LaunchGameButton, "Launch game with special optimizations");
            this.LaunchGameButton.UseVisualStyleBackColor = true;
            this.LaunchGameButton.Click += new System.EventHandler(this.LaunchGameButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LaunchGameButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.KillSteamButton);
            this.splitContainer1.Size = new System.Drawing.Size(374, 36);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 240);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gamesListCombo);
            this.Controls.Add(this.SteamPathChooseButton);
            this.Controls.Add(this.steamPath_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.virtualConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Better Game Launcher by arcanum";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SteamPathChooseButton;
        private System.Windows.Forms.OpenFileDialog steamFileBrowser;
        private System.Windows.Forms.TextBox steamPath_Textbox;
        private System.Windows.Forms.ComboBox gamesListCombo;
        public System.Windows.Forms.TextBox virtualConsole;
        private System.Windows.Forms.Button KillSteamButton;
        private System.Windows.Forms.Button LaunchGameButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}