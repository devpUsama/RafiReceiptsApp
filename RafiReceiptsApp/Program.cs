using System;
using System.Windows.Forms;

namespace RafiReceiptsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen first.
            using (SplashForm splash = new SplashForm())
            {
                splash.ShowDialog(); // This blocks until the splash closes (after 3 seconds)
            }
            // Start with LoginForm.
            Application.Run(new LoginForm());
        }
    }
}
