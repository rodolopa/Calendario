using System;
using System.Windows.Forms;
using TelerikWinFormsApp1.UI;

namespace TelerikWinFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OutlookCalendarForm());
        }
    }
}
