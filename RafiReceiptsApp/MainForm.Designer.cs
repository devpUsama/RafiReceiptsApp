namespace RafiReceiptsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelHeader = new Panel();
            labelHeader = new Label();
            labelHeader2 = new Label();
            btnOPD = new Button();
            labelMainFeature = new Label();
            btnUSG = new Button();
            btnECG = new Button();
            labelOtherReceipt = new Label();
            btnDrZain = new Button();
            btnDrHammad = new Button();
            btnDrJawad = new Button();
            labelSystem = new Label();
            btnHistory = new Button();
            btnOtherReceipt = new Button();
            btnAdminPrices = new Button();
            panelMainButtons = new Panel();
            panelOtherButton = new Panel();
            btnDrAyesha = new Button();
            btnDrMinahil = new Button();
            btnDrZuhaib = new Button();
            btnDrTehreem = new Button();
            btnDrFizza = new Button();
            panelAdmin = new Panel();
            btnReturnReceipt = new Button();
            boxSignature = new PictureBox();
            btnCTScan = new Button();
            button2 = new Button();
            panelHeader.SuspendLayout();
            panelMainButtons.SuspendLayout();
            panelOtherButton.SuspendLayout();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxSignature).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(91, 42, 134);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1806, 93);
            panelHeader.TabIndex = 2;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = SystemColors.ButtonHighlight;
            labelHeader.Location = new Point(666, 15);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(430, 46);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Rafi Medical Complex";
            // 
            // labelHeader2
            // 
            labelHeader2.AutoSize = true;
            labelHeader2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader2.ForeColor = SystemColors.ActiveCaptionText;
            labelHeader2.Location = new Point(663, 213);
            labelHeader2.Margin = new Padding(4, 0, 4, 0);
            labelHeader2.Name = "labelHeader2";
            labelHeader2.Size = new Size(348, 29);
            labelHeader2.TabIndex = 3;
            labelHeader2.Text = "Appointment Receipt System";
            // 
            // btnOPD
            // 
            btnOPD.BackColor = Color.FromArgb(91, 42, 134);
            btnOPD.FlatStyle = FlatStyle.Flat;
            btnOPD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOPD.ForeColor = SystemColors.ButtonHighlight;
            btnOPD.Location = new Point(63, 70);
            btnOPD.Margin = new Padding(4, 3, 4, 3);
            btnOPD.Name = "btnOPD";
            btnOPD.Size = new Size(187, 63);
            btnOPD.TabIndex = 1;
            btnOPD.Text = "OPD [F1]";
            btnOPD.UseVisualStyleBackColor = false;
            btnOPD.Click += btnOPD_Click;
            // 
            // labelMainFeature
            // 
            labelMainFeature.AutoSize = true;
            labelMainFeature.BackColor = Color.WhiteSmoke;
            labelMainFeature.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMainFeature.ForeColor = Color.FromArgb(91, 42, 134);
            labelMainFeature.Location = new Point(63, 12);
            labelMainFeature.Margin = new Padding(4, 0, 4, 0);
            labelMainFeature.Name = "labelMainFeature";
            labelMainFeature.Size = new Size(162, 25);
            labelMainFeature.TabIndex = 0;
            labelMainFeature.Text = "Main Receipts";
            // 
            // btnUSG
            // 
            btnUSG.BackColor = Color.FromArgb(91, 42, 134);
            btnUSG.FlatStyle = FlatStyle.Flat;
            btnUSG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUSG.ForeColor = SystemColors.ButtonHighlight;
            btnUSG.Location = new Point(63, 141);
            btnUSG.Margin = new Padding(4, 3, 4, 3);
            btnUSG.Name = "btnUSG";
            btnUSG.Size = new Size(187, 63);
            btnUSG.TabIndex = 2;
            btnUSG.Text = "USG [F2]";
            btnUSG.UseVisualStyleBackColor = false;
            btnUSG.Click += btnUSG_Click;
            // 
            // btnECG
            // 
            btnECG.BackColor = Color.FromArgb(91, 42, 134);
            btnECG.FlatStyle = FlatStyle.Flat;
            btnECG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnECG.ForeColor = SystemColors.ButtonHighlight;
            btnECG.Location = new Point(63, 212);
            btnECG.Margin = new Padding(4, 3, 4, 3);
            btnECG.Name = "btnECG";
            btnECG.Size = new Size(187, 63);
            btnECG.TabIndex = 3;
            btnECG.Text = "ECG [F3]";
            btnECG.UseVisualStyleBackColor = false;
            btnECG.Click += btnECG_Click;
            // 
            // labelOtherReceipt
            // 
            labelOtherReceipt.AutoSize = true;
            labelOtherReceipt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOtherReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            labelOtherReceipt.Location = new Point(43, 10);
            labelOtherReceipt.Margin = new Padding(4, 0, 4, 0);
            labelOtherReceipt.Name = "labelOtherReceipt";
            labelOtherReceipt.Size = new Size(169, 25);
            labelOtherReceipt.TabIndex = 0;
            labelOtherReceipt.Text = "Other Receipts";
            // 
            // btnDrZain
            // 
            btnDrZain.BackColor = Color.WhiteSmoke;
            btnDrZain.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrZain.FlatAppearance.BorderSize = 2;
            btnDrZain.FlatStyle = FlatStyle.Flat;
            btnDrZain.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrZain.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrZain.Location = new Point(20, 63);
            btnDrZain.Margin = new Padding(4, 3, 4, 3);
            btnDrZain.Name = "btnDrZain";
            btnDrZain.Size = new Size(227, 63);
            btnDrZain.TabIndex = 1;
            btnDrZain.Text = "Dr Zain [F4]";
            btnDrZain.UseVisualStyleBackColor = false;
            btnDrZain.Click += btnDrZain_Click;
            // 
            // btnDrHammad
            // 
            btnDrHammad.BackColor = Color.WhiteSmoke;
            btnDrHammad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrHammad.FlatAppearance.BorderSize = 2;
            btnDrHammad.FlatStyle = FlatStyle.Flat;
            btnDrHammad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrHammad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrHammad.Location = new Point(20, 298);
            btnDrHammad.Margin = new Padding(4, 3, 4, 3);
            btnDrHammad.Name = "btnDrHammad";
            btnDrHammad.Size = new Size(227, 63);
            btnDrHammad.TabIndex = 3;
            btnDrHammad.Text = "Dr Hammad [F7]";
            btnDrHammad.UseVisualStyleBackColor = false;
            btnDrHammad.Click += btnDrHammad_Click;
            // 
            // btnDrJawad
            // 
            btnDrJawad.BackColor = Color.WhiteSmoke;
            btnDrJawad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrJawad.FlatAppearance.BorderSize = 2;
            btnDrJawad.FlatStyle = FlatStyle.Flat;
            btnDrJawad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrJawad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrJawad.Location = new Point(20, 218);
            btnDrJawad.Margin = new Padding(4, 3, 4, 3);
            btnDrJawad.Name = "btnDrJawad";
            btnDrJawad.Size = new Size(227, 63);
            btnDrJawad.TabIndex = 2;
            btnDrJawad.Text = "Dr Jawad [F6]";
            btnDrJawad.UseVisualStyleBackColor = false;
            btnDrJawad.Click += btnDrJawad_Click;
            // 
            // labelSystem
            // 
            labelSystem.AutoSize = true;
            labelSystem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSystem.ForeColor = Color.FromArgb(91, 42, 134);
            labelSystem.Location = new Point(63, 17);
            labelSystem.Margin = new Padding(4, 0, 4, 0);
            labelSystem.Name = "labelSystem";
            labelSystem.Size = new Size(223, 25);
            labelSystem.TabIndex = 0;
            labelSystem.Text = "System Preferances";
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.WhiteSmoke;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.Red;
            btnHistory.Location = new Point(63, 58);
            btnHistory.Margin = new Padding(4, 3, 4, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(187, 63);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "Records [F11]";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnOtherReceipt
            // 
            btnOtherReceipt.BackColor = Color.WhiteSmoke;
            btnOtherReceipt.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnOtherReceipt.FlatAppearance.BorderSize = 2;
            btnOtherReceipt.FlatStyle = FlatStyle.Flat;
            btnOtherReceipt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOtherReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            btnOtherReceipt.Location = new Point(20, 530);
            btnOtherReceipt.Margin = new Padding(4, 3, 4, 3);
            btnOtherReceipt.Name = "btnOtherReceipt";
            btnOtherReceipt.Size = new Size(227, 63);
            btnOtherReceipt.TabIndex = 4;
            btnOtherReceipt.Text = "Other [F10]";
            btnOtherReceipt.UseVisualStyleBackColor = false;
            btnOtherReceipt.Click += btnOtherReceipt_Click;
            // 
            // btnAdminPrices
            // 
            btnAdminPrices.BackColor = Color.WhiteSmoke;
            btnAdminPrices.FlatStyle = FlatStyle.Flat;
            btnAdminPrices.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPrices.ForeColor = Color.Red;
            btnAdminPrices.Location = new Point(63, 128);
            btnAdminPrices.Margin = new Padding(4, 3, 4, 3);
            btnAdminPrices.Name = "btnAdminPrices";
            btnAdminPrices.Size = new Size(187, 63);
            btnAdminPrices.TabIndex = 2;
            btnAdminPrices.Text = "Prices [F12]";
            btnAdminPrices.UseVisualStyleBackColor = false;
            btnAdminPrices.Click += btnAdminPrices_Click;
            // 
            // panelMainButtons
            // 
            panelMainButtons.BackColor = Color.WhiteSmoke;
            panelMainButtons.BorderStyle = BorderStyle.FixedSingle;
            panelMainButtons.Controls.Add(button2);
            panelMainButtons.Controls.Add(btnCTScan);
            panelMainButtons.Controls.Add(btnOPD);
            panelMainButtons.Controls.Add(btnECG);
            panelMainButtons.Controls.Add(btnUSG);
            panelMainButtons.Controls.Add(labelMainFeature);
            panelMainButtons.Location = new Point(490, 262);
            panelMainButtons.Margin = new Padding(4, 3, 4, 3);
            panelMainButtons.Name = "panelMainButtons";
            panelMainButtons.Size = new Size(302, 460);
            panelMainButtons.TabIndex = 1;
            // 
            // panelOtherButton
            // 
            panelOtherButton.BorderStyle = BorderStyle.FixedSingle;
            panelOtherButton.Controls.Add(btnDrAyesha);
            panelOtherButton.Controls.Add(btnDrMinahil);
            panelOtherButton.Controls.Add(btnDrZuhaib);
            panelOtherButton.Controls.Add(btnDrTehreem);
            panelOtherButton.Controls.Add(btnDrFizza);
            panelOtherButton.Controls.Add(labelOtherReceipt);
            panelOtherButton.Controls.Add(btnDrZain);
            panelOtherButton.Controls.Add(btnDrJawad);
            panelOtherButton.Controls.Add(btnOtherReceipt);
            panelOtherButton.Controls.Add(btnDrHammad);
            panelOtherButton.Location = new Point(824, 262);
            panelOtherButton.Margin = new Padding(4, 3, 4, 3);
            panelOtherButton.Name = "panelOtherButton";
            panelOtherButton.Size = new Size(519, 605);
            panelOtherButton.TabIndex = 2;
            // 
            // btnDrAyesha
            // 
            btnDrAyesha.BackColor = Color.WhiteSmoke;
            btnDrAyesha.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrAyesha.FlatAppearance.BorderSize = 2;
            btnDrAyesha.FlatStyle = FlatStyle.Flat;
            btnDrAyesha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrAyesha.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrAyesha.Location = new Point(267, 140);
            btnDrAyesha.Margin = new Padding(4, 3, 4, 3);
            btnDrAyesha.Name = "btnDrAyesha";
            btnDrAyesha.Size = new Size(227, 63);
            btnDrAyesha.TabIndex = 9;
            btnDrAyesha.Text = "Dr Ayesha [2]";
            btnDrAyesha.UseVisualStyleBackColor = false;
            btnDrAyesha.Click += btnDrAyesha_Click;
            // 
            // btnDrMinahil
            // 
            btnDrMinahil.BackColor = Color.WhiteSmoke;
            btnDrMinahil.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrMinahil.FlatAppearance.BorderSize = 2;
            btnDrMinahil.FlatStyle = FlatStyle.Flat;
            btnDrMinahil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrMinahil.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrMinahil.Location = new Point(267, 63);
            btnDrMinahil.Margin = new Padding(4, 3, 4, 3);
            btnDrMinahil.Name = "btnDrMinahil";
            btnDrMinahil.Size = new Size(227, 63);
            btnDrMinahil.TabIndex = 8;
            btnDrMinahil.Text = "Dr Minahil [1]";
            btnDrMinahil.UseVisualStyleBackColor = false;
            btnDrMinahil.Click += btnDrMinahil_Click;
            // 
            // btnDrZuhaib
            // 
            btnDrZuhaib.BackColor = Color.WhiteSmoke;
            btnDrZuhaib.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrZuhaib.FlatAppearance.BorderSize = 2;
            btnDrZuhaib.FlatStyle = FlatStyle.Flat;
            btnDrZuhaib.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrZuhaib.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrZuhaib.Location = new Point(20, 452);
            btnDrZuhaib.Margin = new Padding(4, 3, 4, 3);
            btnDrZuhaib.Name = "btnDrZuhaib";
            btnDrZuhaib.Size = new Size(227, 63);
            btnDrZuhaib.TabIndex = 7;
            btnDrZuhaib.Text = "Dr Zuhaib [F9]";
            btnDrZuhaib.UseVisualStyleBackColor = false;
            btnDrZuhaib.Click += btnDrZuhaib_Click;
            // 
            // btnDrTehreem
            // 
            btnDrTehreem.BackColor = Color.WhiteSmoke;
            btnDrTehreem.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrTehreem.FlatAppearance.BorderSize = 2;
            btnDrTehreem.FlatStyle = FlatStyle.Flat;
            btnDrTehreem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrTehreem.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrTehreem.Location = new Point(20, 375);
            btnDrTehreem.Margin = new Padding(4, 3, 4, 3);
            btnDrTehreem.Name = "btnDrTehreem";
            btnDrTehreem.Size = new Size(227, 63);
            btnDrTehreem.TabIndex = 6;
            btnDrTehreem.Text = "Dr Tehreem [F8]";
            btnDrTehreem.UseVisualStyleBackColor = false;
            btnDrTehreem.Click += btnDrTehreem_Click;
            // 
            // btnDrFizza
            // 
            btnDrFizza.BackColor = Color.WhiteSmoke;
            btnDrFizza.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrFizza.FlatAppearance.BorderSize = 2;
            btnDrFizza.FlatStyle = FlatStyle.Flat;
            btnDrFizza.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrFizza.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrFizza.Location = new Point(20, 140);
            btnDrFizza.Margin = new Padding(4, 3, 4, 3);
            btnDrFizza.Name = "btnDrFizza";
            btnDrFizza.Size = new Size(227, 63);
            btnDrFizza.TabIndex = 5;
            btnDrFizza.Text = "Dr Fizza [F5]";
            btnDrFizza.UseVisualStyleBackColor = false;
            btnDrFizza.Click += btnDrFizza_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BorderStyle = BorderStyle.FixedSingle;
            panelAdmin.Controls.Add(btnReturnReceipt);
            panelAdmin.Controls.Add(labelSystem);
            panelAdmin.Controls.Add(btnHistory);
            panelAdmin.Controls.Add(btnAdminPrices);
            panelAdmin.Location = new Point(490, 728);
            panelAdmin.Margin = new Padding(4, 3, 4, 3);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(302, 280);
            panelAdmin.TabIndex = 3;
            // 
            // btnReturnReceipt
            // 
            btnReturnReceipt.BackColor = Color.WhiteSmoke;
            btnReturnReceipt.FlatStyle = FlatStyle.Flat;
            btnReturnReceipt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnReceipt.ForeColor = Color.Red;
            btnReturnReceipt.Location = new Point(63, 202);
            btnReturnReceipt.Margin = new Padding(4, 3, 4, 3);
            btnReturnReceipt.Name = "btnReturnReceipt";
            btnReturnReceipt.Size = new Size(187, 63);
            btnReturnReceipt.TabIndex = 3;
            btnReturnReceipt.Text = "Return Receipt";
            btnReturnReceipt.UseVisualStyleBackColor = false;
            btnReturnReceipt.Visible = false;
            btnReturnReceipt.Click += btnReturnReceipt_Click;
            // 
            // boxSignature
            // 
            boxSignature.Image = Properties.Resources.devusama_siganture1;
            boxSignature.Location = new Point(1561, 1003);
            boxSignature.Margin = new Padding(4, 3, 4, 3);
            boxSignature.Name = "boxSignature";
            boxSignature.Size = new Size(227, 113);
            boxSignature.SizeMode = PictureBoxSizeMode.Zoom;
            boxSignature.TabIndex = 4;
            boxSignature.TabStop = false;
            // 
            // btnCTScan
            // 
            btnCTScan.BackColor = Color.FromArgb(91, 42, 134);
            btnCTScan.FlatStyle = FlatStyle.Flat;
            btnCTScan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCTScan.ForeColor = SystemColors.ButtonHighlight;
            btnCTScan.Location = new Point(63, 281);
            btnCTScan.Margin = new Padding(4, 3, 4, 3);
            btnCTScan.Name = "btnCTScan";
            btnCTScan.Size = new Size(187, 63);
            btnCTScan.TabIndex = 4;
            btnCTScan.Text = "CT Scan";
            btnCTScan.UseVisualStyleBackColor = false;
            btnCTScan.Click += btnCTScan_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(91, 42, 134);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(63, 350);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(187, 63);
            button2.TabIndex = 5;
            button2.Text = "XRay";
            button2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1806, 1050);
            Controls.Add(boxSignature);
            Controls.Add(panelAdmin);
            Controls.Add(panelOtherButton);
            Controls.Add(panelMainButtons);
            Controls.Add(labelHeader2);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1819, 1018);
            Name = "MainForm";
            Text = "Rafi Medical Complex";
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMainButtons.ResumeLayout(false);
            panelMainButtons.PerformLayout();
            panelOtherButton.ResumeLayout(false);
            panelOtherButton.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boxSignature).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelHeader;
        private Label labelHeader;
        private Label labelHeader2;
        private Button btnOPD;
        private Label labelMainFeature;
        private Button btnUSG;
        private Button btnECG;
        private Label labelOtherReceipt;
        private Button btnDrZain;
        private Button btnDrHammad;
        private Button btnDrJawad;
        private Label labelSystem;
        private Button btnHistory;
        private Button btnOtherReceipt;
        private Button btnAdminPrices;
        private Panel panelMainButtons;
        private Panel panelOtherButton;
        private Panel panelAdmin;
        private Button btnDrFizza;
        private Button btnReturnReceipt;
        private PictureBox boxSignature;
        private Button btnDrZuhaib;
        private Button btnDrTehreem;
        private Button btnDrMinahil;
        private Button btnDrAyesha;
        private Button button2;
        private Button btnCTScan;
    }
}
