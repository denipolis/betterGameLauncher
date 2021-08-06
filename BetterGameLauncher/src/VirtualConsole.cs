using System;

namespace BetterGameLauncher
{
    public class VirtualConsole
    {
        public enum writeTypes { Info, Ok, Error, Warning };
        public System.Windows.Forms.TextBox textBox;
        public void Write(string text, writeTypes type)
        {
            textBox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}] [{type.ToString().ToUpper()}] {text}");
            textBox.AppendText(Environment.NewLine);
        }
    }
}
