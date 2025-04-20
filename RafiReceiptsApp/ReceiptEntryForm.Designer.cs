namespace RafiReceiptsApp
{
    partial class ReceiptEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptEntryForm));
            panelHeadingReceipt = new Panel();
            lblTitle = new Label();
            labelName = new Label();
            txtPatientName = new TextBox();
            labelAddress = new Label();
            txtAddress = new TextBox();
            lblTemperature = new Label();
            txtTemperature = new TextBox();
            lblBP = new Label();
            txtBP = new TextBox();
            labelFee = new Label();
            txtFee = new TextBox();
            lblDoctorName = new Label();
            txtDoctorName = new TextBox();
            btnGenerate = new Button();
            cmbUSGType = new ComboBox();
            lblUSGType = new Label();
            btnCancel = new Button();
            panelHeadingReceipt.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeadingReceipt
            // 
            panelHeadingReceipt.BackColor = Color.FromArgb(91, 42, 134);
            panelHeadingReceipt.Controls.Add(lblTitle);
            panelHeadingReceipt.Dock = DockStyle.Top;
            panelHeadingReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            panelHeadingReceipt.Location = new Point(0, 0);
            panelHeadingReceipt.Name = "panelHeadingReceipt";
            panelHeadingReceipt.Size = new Size(782, 75);
            panelHeadingReceipt.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(201, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Appointment";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.None;
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            labelName.Location = new Point(157, 95);
            labelName.Name = "labelName";
            labelName.Size = new Size(141, 30);
            labelName.TabIndex = 1;
            labelName.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.None;
            txtPatientName.BackColor = SystemColors.Menu;
            txtPatientName.Font = new Font("Poppins", 10.2F);
            txtPatientName.Location = new Point(357, 92);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(280, 33);
            txtPatientName.TabIndex = 1;
            // 
            // labelAddress
            // 
            labelAddress.Anchor = AnchorStyles.None;
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            labelAddress.Location = new Point(157, 144);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(88, 30);
            labelAddress.TabIndex = 3;
            labelAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.BackColor = SystemColors.Menu;
            txtAddress.Font = new Font("Poppins", 10.2F);
            txtAddress.Location = new Point(357, 141);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 33);
            txtAddress.TabIndex = 2;
            // 
            // lblTemperature
            // 
            lblTemperature.Anchor = AnchorStyles.None;
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblTemperature.Location = new Point(157, 248);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(135, 30);
            lblTemperature.TabIndex = 7;
            lblTemperature.Text = "Temperature";
            // 
            // txtTemperature
            // 
            txtTemperature.Anchor = AnchorStyles.None;
            txtTemperature.BackColor = SystemColors.Menu;
            txtTemperature.Font = new Font("Poppins", 10.2F);
            txtTemperature.Location = new Point(357, 245);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(280, 33);
            txtTemperature.TabIndex = 4;
            // 
            // lblBP
            // 
            lblBP.Anchor = AnchorStyles.None;
            lblBP.AutoSize = true;
            lblBP.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblBP.Location = new Point(157, 298);
            lblBP.Name = "lblBP";
            lblBP.Size = new Size(152, 30);
            lblBP.TabIndex = 9;
            lblBP.Text = "Blood Pressure";
            // 
            // txtBP
            // 
            txtBP.Anchor = AnchorStyles.None;
            txtBP.BackColor = SystemColors.Menu;
            txtBP.Font = new Font("Poppins", 10.2F);
            txtBP.Location = new Point(357, 295);
            txtBP.Name = "txtBP";
            txtBP.Size = new Size(280, 33);
            txtBP.TabIndex = 5;
            // 
            // labelFee
            // 
            labelFee.Anchor = AnchorStyles.None;
            labelFee.AutoSize = true;
            labelFee.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            labelFee.Location = new Point(157, 195);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(47, 30);
            labelFee.TabIndex = 5;
            labelFee.Text = "Fee";
            // 
            // txtFee
            // 
            txtFee.Anchor = AnchorStyles.None;
            txtFee.BackColor = SystemColors.Menu;
            txtFee.Font = new Font("Poppins", 10.2F);
            txtFee.Location = new Point(357, 192);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(280, 33);
            txtFee.TabIndex = 3;
            // 
            // lblDoctorName
            // 
            lblDoctorName.Anchor = AnchorStyles.None;
            lblDoctorName.AutoSize = true;
            lblDoctorName.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblDoctorName.Location = new Point(157, 403);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(137, 30);
            lblDoctorName.TabIndex = 11;
            lblDoctorName.Text = "Doctor Name";
            // 
            // txtDoctorName
            // 
            txtDoctorName.Anchor = AnchorStyles.None;
            txtDoctorName.BackColor = SystemColors.Menu;
            txtDoctorName.Font = new Font("Poppins", 10.2F);
            txtDoctorName.Location = new Point(357, 400);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(280, 33);
            txtDoctorName.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.None;
            btnGenerate.BackColor = Color.FromArgb(91, 42, 134);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = SystemColors.ButtonHighlight;
            btnGenerate.Location = new Point(406, 458);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(155, 50);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate [F2]";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbUSGType
            // 
            cmbUSGType.Anchor = AnchorStyles.None;
            cmbUSGType.BackColor = SystemColors.Menu;
            cmbUSGType.Font = new Font("Poppins", 10.2F);
            cmbUSGType.FormattingEnabled = true;
            cmbUSGType.Location = new Point(357, 343);
            cmbUSGType.Name = "cmbUSGType";
            cmbUSGType.Size = new Size(280, 38);
            cmbUSGType.TabIndex = 6;
            cmbUSGType.Visible = false;
            cmbUSGType.SelectedIndexChanged += cmbUSGType_SelectedIndexChanged;
            // 
            // lblUSGType
            // 
            lblUSGType.Anchor = AnchorStyles.None;
            lblUSGType.AutoSize = true;
            lblUSGType.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblUSGType.Location = new Point(157, 351);
            lblUSGType.Name = "lblUSGType";
            lblUSGType.Size = new Size(101, 30);
            lblUSGType.TabIndex = 15;
            lblUSGType.Text = "USG Type";
            lblUSGType.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(580, 458);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel [Esc]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ReceiptEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(782, 553);
            Controls.Add(btnCancel);
            Controls.Add(lblUSGType);
            Controls.Add(cmbUSGType);
            Controls.Add(btnGenerate);
            Controls.Add(txtDoctorName);
            Controls.Add(lblDoctorName);
            Controls.Add(txtFee);
            Controls.Add(labelFee);
            Controls.Add(txtBP);
            Controls.Add(lblBP);
            Controls.Add(txtTemperature);
            Controls.Add(lblTemperature);
            Controls.Add(txtAddress);
            Controls.Add(labelAddress);
            Controls.Add(txtPatientName);
            Controls.Add(labelName);
            Controls.Add(panelHeadingReceipt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(800, 600);
            Name = "ReceiptEntryForm";
            Text = "Patient Slip";
            panelHeadingReceipt.ResumeLayout(false);
            panelHeadingReceipt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeadingReceipt;
        private Label lblTitle;
        private Label labelName;
        private TextBox txtPatientName;
        private Label labelAddress;
        private TextBox txtAddress;
        private Label lblTemperature;
        private TextBox txtTemperature;
        private Label lblBP;
        private TextBox txtBP;
        private Label labelFee;
        private TextBox txtFee;
        private Label lblDoctorName;
        private TextBox txtDoctorName;
        private Button btnGenerate;
        private ComboBox cmbUSGType;
        private Label lblUSGType;
        private Button btnCancel;
    }
}