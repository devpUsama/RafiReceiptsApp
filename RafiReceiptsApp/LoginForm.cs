using System;
using System.Windows.Forms;

namespace RafiReceiptsApp
{
    public partial class LoginForm : Form
    {




        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check for F2 to submit
            if (keyData == Keys.F2)
            {
                // Perform the click for the save/generate button.
                btnLogin.PerformClick();
                return true;
            }
            // Check for F3 to cancel
            else if (keyData == Keys.F1)
            {
                btnExit.PerformClick();
                return true;
            }


            // Check if Enter is pressed (ignore if it's a multiline textbox)
            if (keyData == Keys.Enter && !(this.ActiveControl is TextBox tb && tb.Multiline))
            {
                // Move focus to the next control.
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        // Hardcoded credentials for demonstration.
        // In production, use secure storage and password hashing.
        private const string ValidUsername = "admin";
        private const string ValidPassword = "rmc123";

        public LoginForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);

            // Optional: set form properties to disable resizing.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == ValidUsername && password == ValidPassword)
            {
                // Credentials valid.
                // Open the main form.
                this.Hide(); // Hide login form.

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

                // Once main form is closed, exit the application.
                Application.Exit();
            }
            else
            {
                // Invalid credentials.
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
    }
}
