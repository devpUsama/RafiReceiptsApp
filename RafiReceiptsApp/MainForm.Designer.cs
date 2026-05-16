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
            btnDrZuhaib = new Button();
            btnDrTehreem = new Button();
            btnDrFizza = new Button();
            panelAdmin = new Panel();
            btnReturnReceipt = new Button();
            boxSignature = new PictureBox();
            btnDrMinahil = new Button();
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
            panelHeader.Margin = new Padding(7, 5, 7, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2686, 153);
            panelHeader.TabIndex = 2;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = SystemColors.ButtonHighlight;
            labelHeader.Location = new Point(940, 25);
            labelHeader.Margin = new Padding(7, 0, 7, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(693, 75);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Rafi Medical Complex";
            // 
            // labelHeader2
            // 
            labelHeader2.Anchor = AnchorStyles.None;
            labelHeader2.AutoSize = true;
            labelHeader2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader2.ForeColor = SystemColors.ActiveCaptionText;
            labelHeader2.Location = new Point(1001, 276);
            labelHeader2.Margin = new Padding(7, 0, 7, 0);
            labelHeader2.Name = "labelHeader2";
            labelHeader2.Size = new Size(561, 46);
            labelHeader2.TabIndex = 3;
            labelHeader2.Text = "Appointment Receipt System";
            // 
            // btnOPD
            // 
            btnOPD.Anchor = AnchorStyles.None;
            btnOPD.BackColor = Color.FromArgb(91, 42, 134);
            btnOPD.FlatStyle = FlatStyle.Flat;
            btnOPD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOPD.ForeColor = SystemColors.ButtonHighlight;
            btnOPD.Location = new Point(107, 115);
            btnOPD.Margin = new Padding(7, 5, 7, 5);
            btnOPD.Name = "btnOPD";
            btnOPD.Size = new Size(318, 104);
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
            labelMainFeature.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMainFeature.ForeColor = Color.FromArgb(91, 42, 134);
            labelMainFeature.Location = new Point(107, 19);
            labelMainFeature.Margin = new Padding(7, 0, 7, 0);
            labelMainFeature.Name = "labelMainFeature";
            labelMainFeature.Size = new Size(246, 39);
            labelMainFeature.TabIndex = 0;
            labelMainFeature.Text = "Main Receipts";
            // 
            // btnUSG
            // 
            btnUSG.Anchor = AnchorStyles.None;
            btnUSG.BackColor = Color.FromArgb(91, 42, 134);
            btnUSG.FlatStyle = FlatStyle.Flat;
            btnUSG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUSG.ForeColor = SystemColors.ButtonHighlight;
            btnUSG.Location = new Point(107, 246);
            btnUSG.Margin = new Padding(7, 5, 7, 5);
            btnUSG.Name = "btnUSG";
            btnUSG.Size = new Size(318, 104);
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
            btnECG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnECG.ForeColor = SystemColors.ButtonHighlight;
            btnECG.Location = new Point(107, 380);
            btnECG.Margin = new Padding(7, 5, 7, 5);
            btnECG.Name = "btnECG";
            btnECG.Size = new Size(318, 104);
            btnECG.TabIndex = 3;
            btnECG.Text = "ECG [F3]";
            btnECG.UseVisualStyleBackColor = false;
            btnECG.Click += btnECG_Click;
            // 
            // labelOtherReceipt
            // 
            labelOtherReceipt.Anchor = AnchorStyles.Top;
            labelOtherReceipt.AutoSize = true;
            labelOtherReceipt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOtherReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            labelOtherReceipt.Location = new Point(73, 16);
            labelOtherReceipt.Margin = new Padding(7, 0, 7, 0);
            labelOtherReceipt.Name = "labelOtherReceipt";
            labelOtherReceipt.Size = new Size(257, 39);
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
            btnDrZain.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrZain.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrZain.Location = new Point(34, 103);
            btnDrZain.Margin = new Padding(7, 5, 7, 5);
            btnDrZain.Name = "btnDrZain";
            btnDrZain.Size = new Size(386, 104);
            btnDrZain.TabIndex = 1;
            btnDrZain.Text = "Dr Zain [F4]";
            btnDrZain.UseVisualStyleBackColor = false;
            btnDrZain.Click += btnDrZain_Click;
            // 
            // btnDrHammad
            // 
            btnDrHammad.Anchor = AnchorStyles.Top;
            btnDrHammad.BackColor = Color.WhiteSmoke;
            btnDrHammad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrHammad.FlatAppearance.BorderSize = 2;
            btnDrHammad.FlatStyle = FlatStyle.Flat;
            btnDrHammad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrHammad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrHammad.Location = new Point(34, 489);
            btnDrHammad.Margin = new Padding(7, 5, 7, 5);
            btnDrHammad.Name = "btnDrHammad";
            btnDrHammad.Size = new Size(386, 104);
            btnDrHammad.TabIndex = 3;
            btnDrHammad.Text = "Dr Hammad [F7]";
            btnDrHammad.UseVisualStyleBackColor = false;
            btnDrHammad.Click += btnDrHammad_Click;
            // 
            // btnDrJawad
            // 
            btnDrJawad.Anchor = AnchorStyles.Top;
            btnDrJawad.BackColor = Color.WhiteSmoke;
            btnDrJawad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrJawad.FlatAppearance.BorderSize = 2;
            btnDrJawad.FlatStyle = FlatStyle.Flat;
            btnDrJawad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrJawad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrJawad.Location = new Point(34, 358);
            btnDrJawad.Margin = new Padding(7, 5, 7, 5);
            btnDrJawad.Name = "btnDrJawad";
            btnDrJawad.Size = new Size(386, 104);
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
            labelSystem.Location = new Point(107, 27);
            labelSystem.Margin = new Padding(7, 0, 7, 0);
            labelSystem.Name = "labelSystem";
            labelSystem.Size = new Size(340, 39);
            labelSystem.TabIndex = 0;
            labelSystem.Text = "System Preferances";
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.WhiteSmoke;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.Red;
            btnHistory.Location = new Point(107, 96);
            btnHistory.Margin = new Padding(7, 5, 7, 5);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(318, 104);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "Records [F11]";
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
            btnOtherReceipt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOtherReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            btnOtherReceipt.Location = new Point(34, 869);
            btnOtherReceipt.Margin = new Padding(7, 5, 7, 5);
            btnOtherReceipt.Name = "btnOtherReceipt";
            btnOtherReceipt.Size = new Size(386, 104);
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
            btnAdminPrices.Location = new Point(107, 210);
            btnAdminPrices.Margin = new Padding(7, 5, 7, 5);
            btnAdminPrices.Name = "btnAdminPrices";
            btnAdminPrices.Size = new Size(318, 104);
            btnAdminPrices.TabIndex = 2;
            btnAdminPrices.Text = "Prices [F12]";
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
            panelMainButtons.Location = new Point(707, 355);
            panelMainButtons.Margin = new Padding(7, 5, 7, 5);
            panelMainButtons.Name = "panelMainButtons";
            panelMainButtons.Size = new Size(512, 524);
            panelMainButtons.TabIndex = 1;
            // 
            // panelOtherButton
            // 
            panelOtherButton.Anchor = AnchorStyles.None;
            panelOtherButton.BorderStyle = BorderStyle.FixedSingle;
            panelOtherButton.Controls.Add(btnDrMinahil);
            panelOtherButton.Controls.Add(btnDrZuhaib);
            panelOtherButton.Controls.Add(btnDrTehreem);
            panelOtherButton.Controls.Add(btnDrFizza);
            panelOtherButton.Controls.Add(labelOtherReceipt);
            panelOtherButton.Controls.Add(btnDrZain);
            panelOtherButton.Controls.Add(btnDrJawad);
            panelOtherButton.Controls.Add(btnOtherReceipt);
            panelOtherButton.Controls.Add(btnDrHammad);
            panelOtherButton.Location = new Point(1275, 356);
            panelOtherButton.Margin = new Padding(7, 5, 7, 5);
            panelOtherButton.Name = "panelOtherButton";
            panelOtherButton.Size = new Size(880, 991);
            panelOtherButton.TabIndex = 2;
            // 
            // btnDrZuhaib
            // 
            btnDrZuhaib.Anchor = AnchorStyles.Top;
            btnDrZuhaib.BackColor = Color.WhiteSmoke;
            btnDrZuhaib.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrZuhaib.FlatAppearance.BorderSize = 2;
            btnDrZuhaib.FlatStyle = FlatStyle.Flat;
            btnDrZuhaib.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrZuhaib.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrZuhaib.Location = new Point(34, 740);
            btnDrZuhaib.Margin = new Padding(7, 5, 7, 5);
            btnDrZuhaib.Name = "btnDrZuhaib";
            btnDrZuhaib.Size = new Size(386, 104);
            btnDrZuhaib.TabIndex = 7;
            btnDrZuhaib.Text = "Dr Zuhaib [F9]";
            btnDrZuhaib.UseVisualStyleBackColor = false;
            btnDrZuhaib.Click += btnDrZuhaib_Click;
            // 
            // btnDrTehreem
            // 
            btnDrTehreem.Anchor = AnchorStyles.Top;
            btnDrTehreem.BackColor = Color.WhiteSmoke;
            btnDrTehreem.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrTehreem.FlatAppearance.BorderSize = 2;
            btnDrTehreem.FlatStyle = FlatStyle.Flat;
            btnDrTehreem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrTehreem.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrTehreem.Location = new Point(34, 615);
            btnDrTehreem.Margin = new Padding(7, 5, 7, 5);
            btnDrTehreem.Name = "btnDrTehreem";
            btnDrTehreem.Size = new Size(386, 104);
            btnDrTehreem.TabIndex = 6;
            btnDrTehreem.Text = "Dr Tehreem [F8]";
            btnDrTehreem.UseVisualStyleBackColor = false;
            btnDrTehreem.Click += btnDrTehreem_Click;
            // 
            // btnDrFizza
            // 
            btnDrFizza.Anchor = AnchorStyles.Top;
            btnDrFizza.BackColor = Color.WhiteSmoke;
            btnDrFizza.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrFizza.FlatAppearance.BorderSize = 2;
            btnDrFizza.FlatStyle = FlatStyle.Flat;
            btnDrFizza.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrFizza.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrFizza.Location = new Point(34, 229);
            btnDrFizza.Margin = new Padding(7, 5, 7, 5);
            btnDrFizza.Name = "btnDrFizza";
            btnDrFizza.Size = new Size(386, 104);
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
            panelAdmin.Location = new Point(707, 889);
            panelAdmin.Margin = new Padding(7, 5, 7, 5);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(512, 458);
            panelAdmin.TabIndex = 3;
            // 
            // btnReturnReceipt
            // 
            btnReturnReceipt.BackColor = Color.WhiteSmoke;
            btnReturnReceipt.FlatStyle = FlatStyle.Flat;
            btnReturnReceipt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnReceipt.ForeColor = Color.Red;
            btnReturnReceipt.Location = new Point(107, 330);
            btnReturnReceipt.Margin = new Padding(7, 5, 7, 5);
            btnReturnReceipt.Name = "btnReturnReceipt";
            btnReturnReceipt.Size = new Size(318, 104);
            btnReturnReceipt.TabIndex = 3;
            btnReturnReceipt.Text = "Return Receipt";
            btnReturnReceipt.UseVisualStyleBackColor = false;
            btnReturnReceipt.Click += btnReturnReceipt_Click;
            // 
            // boxSignature
            // 
            boxSignature.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            boxSignature.Image = Properties.Resources.devusama_siganture1;
            boxSignature.Location = new Point(2268, 1443);
            boxSignature.Margin = new Padding(7, 5, 7, 5);
            boxSignature.Name = "boxSignature";
            boxSignature.Size = new Size(386, 186);
            boxSignature.SizeMode = PictureBoxSizeMode.Zoom;
            boxSignature.TabIndex = 4;
            boxSignature.TabStop = false;
            // 
            // btnDrMinahil
            // 
            btnDrMinahil.Anchor = AnchorStyles.Top;
            btnDrMinahil.BackColor = Color.WhiteSmoke;
            btnDrMinahil.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDrMinahil.FlatAppearance.BorderSize = 2;
            btnDrMinahil.FlatStyle = FlatStyle.Flat;
            btnDrMinahil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrMinahil.ForeColor = Color.FromArgb(91, 42, 134);
            btnDrMinahil.Location = new Point(453, 103);
            btnDrMinahil.Margin = new Padding(7, 5, 7, 5);
            btnDrMinahil.Name = "btnDrMinahil";
            btnDrMinahil.Size = new Size(386, 104);
            btnDrMinahil.TabIndex = 8;
            btnDrMinahil.Text = "Dr Minahil [1]";
            btnDrMinahil.UseVisualStyleBackColor = false;
            btnDrMinahil.Click += btnDrMinahil_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2686, 1670);
            Controls.Add(boxSignature);
            Controls.Add(panelAdmin);
            Controls.Add(panelOtherButton);
            Controls.Add(panelMainButtons);
            Controls.Add(labelHeader2);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(7, 5, 7, 5);
            MinimumSize = new Size(2679, 1351);
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
    }
}
