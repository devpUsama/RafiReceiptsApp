namespace RafiReceiptsApp
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            pictureBoxLoading = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            lblSplashScreen = new Label();
            siganture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siganture).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.Anchor = AnchorStyles.None;
            pictureBoxLoading.Image = Properties.Resources.rmc_logo_login_removebg_preview1;
            pictureBoxLoading.Location = new Point(14, 12);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(756, 309);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLoading.TabIndex = 1;
            pictureBoxLoading.TabStop = false;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 3000;
            Timer.Tick += Timer_Tick;
            // 
            // lblSplashScreen
            // 
            lblSplashScreen.Anchor = AnchorStyles.Top;
            lblSplashScreen.AutoSize = true;
            lblSplashScreen.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSplashScreen.ForeColor = Color.FromArgb(91, 42, 134);
            lblSplashScreen.Location = new Point(316, 346);
            lblSplashScreen.Name = "lblSplashScreen";
            lblSplashScreen.Size = new Size(172, 47);
            lblSplashScreen.TabIndex = 3;
            lblSplashScreen.Text = "Loading...";
            lblSplashScreen.TextAlign = ContentAlignment.TopCenter;
            // 
            // siganture
            // 
            siganture.Image = Properties.Resources.devusama_siganture1;
            siganture.Location = new Point(544, 346);
            siganture.Name = "siganture";
            siganture.Size = new Size(226, 95);
            siganture.SizeMode = PictureBoxSizeMode.Zoom;
            siganture.TabIndex = 4;
            siganture.TabStop = false;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(siganture);
            Controls.Add(lblSplashScreen);
            Controls.Add(pictureBoxLoading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashForm";
            Text = "Loading...";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)siganture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxLoading;
        private System.Windows.Forms.Timer Timer;
        private Label lblSplashScreen;
        private PictureBox siganture;
    }
}