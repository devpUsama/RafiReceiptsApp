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
            btnDrHamad = new Button();
            btnDrJawad = new Button();
            labelSystem = new Label();
            btnHistory = new Button();
            btnOtherReceipt = new Button();
            btnAdminPrices = new Button();
            panelMainButtons = new Panel();
            panelOtherButton = new Panel();
            btnDrFizza = new Button();
            panelAdmin = new Panel();
            btnReturnReceipt = new Button();
            boxSignature = new PictureBox();
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
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1262, 75);
            panelHeader.TabIndex = 2;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = SystemColors.ButtonHighlight;
            labelHeader.Location = new Point(441, 12);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(399, 52);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Rafi Medical Complex";
            // 
            // labelHeader2
            // 
            labelHeader2.Anchor = AnchorStyles.None;
            labelHeader2.AutoSize = true;
            labelHeader2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader2.ForeColor = SystemColors.ActiveCaptionText;
            labelHeader2.Location = new Point(474, 149);
            labelHeader2.Name = "labelHeader2";
            labelHeader2.Size = new Size(330, 36);
            labelHeader2.TabIndex = 3;
            labelHeader2.Text = "Appointment Receipt System";
            // 
            // btnOPD
            // 
            btnOPD.Anchor = AnchorStyles.None;
            btnOPD.BackColor = Color.FromArgb(91, 42, 134);
            btnOPD.FlatStyle = FlatStyle.Flat;
            btnOPD.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOPD.ForeColor = SystemColors.ButtonHighlight;
            btnOPD.Location = new Point(50, 56);
            btnOPD.Name = "btnOPD";
            btnOPD.Size = new Size(150, 50);
            btnOPD.TabIndex = 1;
            btnOPD.Text = "OPD [F1]";
            btnOPD.UseVisualStyleBackColor = false;
            btnOPD.Click += btnOPD_Click;
            // 
            // labelMainFeature
            // 
            labelMainFeature.Anchor = AnchorStyles.Top;
            labelMainFeature.AutoSize = true;
            labelMainFeature.BackColor = Color.WhiteSmoke;
            labelMainFeature.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMainFeature.ForeColor = Color.FromArgb(91, 42, 134);
            labelMainFeature.Location = new Point(50, 9);
            labelMainFeature.Name = "labelMainFeature";
            labelMainFeature.Size = new Size(144, 30);
            labelMainFeature.TabIndex = 0;
            labelMainFeature.Text = "Main Receipts";
            // 
            // btnUSG
            // 
            btnUSG.Anchor = AnchorStyles.None;
            btnUSG.BackColor = Color.FromArgb(91, 42, 134);
            btnUSG.FlatStyle = FlatStyle.Flat;
            btnUSG.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUSG.ForeColor = SystemColors.ButtonHighlight;
            btnUSG.Location = new Point(50, 120);
            btnUSG.Name = "btnUSG";
            btnUSG.Size = new Size(150, 50);
            btnUSG.TabIndex = 2;
            btnUSG.Text = "USG [F2]";
            btnUSG.UseVisualStyleBackColor = false;
            btnUSG.Click += btnUSG_Click;
            // 
            // btnECG
            // 
            btnECG.Anchor = AnchorStyles.None;
            btnECG.BackColor = Color.FromArgb(91, 42, 134);
            btnECG.FlatStyle = FlatStyle.Flat;
            btnECG.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnECG.ForeColor = SystemColors.ButtonHighlight;
            btnECG.Location = new Point(50, 185);
            btnECG.Name = "btnECG";
            btnECG.Size = new Size(150, 50);
            btnECG.TabIndex = 3;
            btnECG.Text = "ECG [F3]";
            btnECG.UseVisualStyleBackColor = false;
            btnECG.Click += btnECG_Click;
            // 
            // labelOtherReceipt
            // 
            labelOtherReceipt.Anchor = AnchorStyles.Top;
            labelOtherReceipt.AutoSize = true;
            labelOtherReceipt.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOtherReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            labelOtherReceipt.Location = new Point(55, 10);
            labelOtherReceipt.Name = "labelOtherReceipt";
            labelOtherReceipt.Size = new Size(151, 30);
            labelOtherReceipt.TabIndex = 0;
            labelOtherReceipt.Text = "Other Receipts";
            // 
            // btnDrZain
            // 
            btnDrZain.Anchor = AnchorStyles.Top;
            btnDrZain.BackColor = Color.WhiteSmoke;
            btnDrZain.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrZain.FlatAppearance.BorderSize = 2;
            btnDrZain.FlatStyle = FlatStyle.Flat;
            btnDrZain.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrZain.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrZain.Location = new Point(55, 56);
            btnDrZain.Name = "btnDrZain";
            btnDrZain.Size = new Size(150, 50);
            btnDrZain.TabIndex = 1;
            btnDrZain.Text = "Dr Zain [F4]";
            btnDrZain.UseVisualStyleBackColor = false;
            btnDrZain.Click += btnDrZain_Click;
            // 
            // btnDrHamad
            // 
            btnDrHamad.Anchor = AnchorStyles.Top;
            btnDrHamad.BackColor = Color.WhiteSmoke;
            btnDrHamad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrHamad.FlatAppearance.BorderSize = 2;
            btnDrHamad.FlatStyle = FlatStyle.Flat;
            btnDrHamad.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrHamad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrHamad.Location = new Point(51, 257);
            btnDrHamad.Name = "btnDrHamad";
            btnDrHamad.Size = new Size(161, 50);
            btnDrHamad.TabIndex = 3;
            btnDrHamad.Text = "Dr Hamad [F7]";
            btnDrHamad.UseVisualStyleBackColor = false;
            btnDrHamad.Click += btnDrHamad_Click;
            // 
            // btnDrJawad
            // 
            btnDrJawad.Anchor = AnchorStyles.Top;
            btnDrJawad.BackColor = Color.WhiteSmoke;
            btnDrJawad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrJawad.FlatAppearance.BorderSize = 2;
            btnDrJawad.FlatStyle = FlatStyle.Flat;
            btnDrJawad.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrJawad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrJawad.Location = new Point(51, 185);
            btnDrJawad.Name = "btnDrJawad";
            btnDrJawad.Size = new Size(161, 50);
            btnDrJawad.TabIndex = 2;
            btnDrJawad.Text = "Dr Jawad [F6]";
            btnDrJawad.UseVisualStyleBackColor = false;
            btnDrJawad.Click += btnDrJawad_Click;
            // 
            // labelSystem
            // 
            labelSystem.Anchor = AnchorStyles.Top;
            labelSystem.AutoSize = true;
            labelSystem.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSystem.ForeColor = Color.FromArgb(91, 42, 134);
            labelSystem.Location = new Point(38, 14);
            labelSystem.Name = "labelSystem";
            labelSystem.Size = new Size(202, 30);
            labelSystem.TabIndex = 0;
            labelSystem.Text = "System Preferances";
            // 
            // btnHistory
            // 
            btnHistory.Anchor = AnchorStyles.Top;
            btnHistory.BackColor = Color.WhiteSmoke;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.Red;
            btnHistory.Location = new Point(38, 47);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(150, 50);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "Records [F9]";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnOtherReceipt
            // 
            btnOtherReceipt.Anchor = AnchorStyles.Top;
            btnOtherReceipt.BackColor = Color.WhiteSmoke;
            btnOtherReceipt.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnOtherReceipt.FlatAppearance.BorderSize = 2;
            btnOtherReceipt.FlatStyle = FlatStyle.Flat;
            btnOtherReceipt.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOtherReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            btnOtherReceipt.Location = new Point(56, 318);
            btnOtherReceipt.Name = "btnOtherReceipt";
            btnOtherReceipt.Size = new Size(150, 50);
            btnOtherReceipt.TabIndex = 4;
            btnOtherReceipt.Text = "Other [F8]";
            btnOtherReceipt.UseVisualStyleBackColor = false;
            btnOtherReceipt.Click += btnOtherReceipt_Click;
            // 
            // btnAdminPrices
            // 
            btnAdminPrices.Anchor = AnchorStyles.Top;
            btnAdminPrices.BackColor = Color.WhiteSmoke;
            btnAdminPrices.FlatStyle = FlatStyle.Flat;
            btnAdminPrices.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPrices.ForeColor = Color.Red;
            btnAdminPrices.Location = new Point(201, 47);
            btnAdminPrices.Name = "btnAdminPrices";
            btnAdminPrices.Size = new Size(150, 50);
            btnAdminPrices.TabIndex = 2;
            btnAdminPrices.Text = "Prices [F10]";
            btnAdminPrices.UseVisualStyleBackColor = false;
            btnAdminPrices.Click += btnAdminPrices_Click;
            // 
            // panelMainButtons
            // 
            panelMainButtons.Anchor = AnchorStyles.None;
            panelMainButtons.BackColor = Color.WhiteSmoke;
            panelMainButtons.BorderStyle = BorderStyle.FixedSingle;
            panelMainButtons.Controls.Add(btnOPD);
            panelMainButtons.Controls.Add(btnECG);
            panelMainButtons.Controls.Add(btnUSG);
            panelMainButtons.Controls.Add(labelMainFeature);
            panelMainButtons.Location = new Point(336, 188);
            panelMainButtons.Name = "panelMainButtons";
            panelMainButtons.Size = new Size(242, 257);
            panelMainButtons.TabIndex = 1;
            // 
            // panelOtherButton
            // 
            panelOtherButton.Anchor = AnchorStyles.None;
            panelOtherButton.BorderStyle = BorderStyle.FixedSingle;
            panelOtherButton.Controls.Add(btnDrFizza);
            panelOtherButton.Controls.Add(labelOtherReceipt);
            panelOtherButton.Controls.Add(btnDrZain);
            panelOtherButton.Controls.Add(btnDrJawad);
            panelOtherButton.Controls.Add(btnOtherReceipt);
            panelOtherButton.Controls.Add(btnDrHamad);
            panelOtherButton.Location = new Point(708, 188);
            panelOtherButton.Name = "panelOtherButton";
            panelOtherButton.Size = new Size(247, 384);
            panelOtherButton.TabIndex = 2;
            // 
            // btnDrFizza
            // 
            btnDrFizza.Anchor = AnchorStyles.Top;
            btnDrFizza.BackColor = Color.WhiteSmoke;
            btnDrFizza.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrFizza.FlatAppearance.BorderSize = 2;
            btnDrFizza.FlatStyle = FlatStyle.Flat;
            btnDrFizza.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrFizza.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrFizza.Location = new Point(55, 120);
            btnDrFizza.Name = "btnDrFizza";
            btnDrFizza.Size = new Size(150, 50);
            btnDrFizza.TabIndex = 5;
            btnDrFizza.Text = "Dr Fizza [F5]";
            btnDrFizza.UseVisualStyleBackColor = false;
            btnDrFizza.Click += btnDrFizza_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.Anchor = AnchorStyles.None;
            panelAdmin.BorderStyle = BorderStyle.FixedSingle;
            panelAdmin.Controls.Add(btnReturnReceipt);
            panelAdmin.Controls.Add(labelSystem);
            panelAdmin.Controls.Add(btnHistory);
            panelAdmin.Controls.Add(btnAdminPrices);
            panelAdmin.Location = new Point(336, 451);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(364, 166);
            panelAdmin.TabIndex = 3;
            // 
            // btnReturnReceipt
            // 
            btnReturnReceipt.Anchor = AnchorStyles.Top;
            btnReturnReceipt.BackColor = Color.WhiteSmoke;
            btnReturnReceipt.FlatStyle = FlatStyle.Flat;
            btnReturnReceipt.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnReceipt.ForeColor = Color.Red;
            btnReturnReceipt.Location = new Point(83, 103);
            btnReturnReceipt.Name = "btnReturnReceipt";
            btnReturnReceipt.Size = new Size(222, 50);
            btnReturnReceipt.TabIndex = 3;
            btnReturnReceipt.Text = "Return Receipt [F11]";
            btnReturnReceipt.UseVisualStyleBackColor = false;
            btnReturnReceipt.Click += btnReturnReceipt_Click;
            // 
            // boxSignature
            // 
            boxSignature.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            boxSignature.Image = Properties.Resources.devusama_siganture1;
            boxSignature.Location = new Point(1068, 570);
            boxSignature.Name = "boxSignature";
            boxSignature.Size = new Size(182, 91);
            boxSignature.SizeMode = PictureBoxSizeMode.Zoom;
            boxSignature.TabIndex = 4;
            boxSignature.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1262, 673);
            Controls.Add(boxSignature);
            Controls.Add(panelAdmin);
            Controls.Add(panelOtherButton);
            Controls.Add(panelMainButtons);
            Controls.Add(labelHeader2);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Rafi Medical Complex";
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
        private Button btnDrHamad;
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
    }
}
