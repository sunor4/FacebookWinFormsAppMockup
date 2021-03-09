using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookAppUI
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("Login To Facebook");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());
        }
    }
}
