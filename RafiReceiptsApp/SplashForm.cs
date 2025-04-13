using System;
using System.Windows.Forms;
using System.Drawing;


namespace RafiReceiptsApp
{
    public partial class SplashForm : Form
    {
        
        public SplashForm()
        {
            InitializeComponent();
            // Set Form properties programmatically (or set these in the Designer)
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Size = new Size(800, 500);
            this.BackColor = Color.White; // or any light neutral color

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Timer != null)
            {
                Timer.Stop();
                Timer.Dispose();
                this.Close();
            }
        }
    }
}
