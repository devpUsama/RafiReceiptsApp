namespace RafiReceiptsApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelLogin = new Panel();
            labelHeader = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(91, 42, 134);
            panelLogin.Controls.Add(labelHeader);
            panelLogin.Dock = DockStyle.Top;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(782, 75);
            panelLogin.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = SystemColors.ButtonHighlight;
            labelHeader.Location = new Point(313, 9);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(132, 52);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Log In";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = SystemColors.Menu;
            txtPassword.Font = new Font("Poppins", 10.2F);
            txtPassword.Location = new Point(366, 445);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 33);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblPassword.Location = new Point(166, 448);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 30);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = SystemColors.Menu;
            txtUsername.Font = new Font("Poppins", 10.2F);
            txtUsername.Location = new Point(366, 396);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 33);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblUsername.Location = new Point(166, 399);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 30);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "User Name";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(91, 42, 134);
            btnExit.Location = new Point(399, 489);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 11;
            btnExit.Text = "Cancel [F1]";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(91, 42, 134);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(225, 489);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 50);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Log In [F2]";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.rmc_logo_login_removebg_preview1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(782, 553);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(panelLogin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "LoginForm";
            Text = "Welcome";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogin;
        private Label labelHeader;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnExit;
        private Button btnLogin;
    }
}