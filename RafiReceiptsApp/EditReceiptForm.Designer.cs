namespace RafiReceiptsApp
{
    partial class EditReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReceiptForm));
            panelEditReceipt = new Panel();
            lblEditReceipt = new Label();
            lblUSGType = new Label();
            cmbUSGType = new ComboBox();
            btnCancel = new Button();
            txtDoctorName = new TextBox();
            lblDoctorName = new Label();
            txtFee = new TextBox();
            labelFee = new Label();
            txtBP = new TextBox();
            lblBP = new Label();
            txtTemperature = new TextBox();
            lblTemperature = new Label();
            txtAddress = new TextBox();
            labelAddress = new Label();
            txtPatientName = new TextBox();
            labelName = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            panelEditReceipt.SuspendLayout();
            SuspendLayout();
            // 
            // panelEditReceipt
            // 
            panelEditReceipt.BackColor = Color.FromArgb(91, 42, 134);
            panelEditReceipt.Controls.Add(lblEditReceipt);
            panelEditReceipt.Dock = DockStyle.Top;
            panelEditReceipt.Location = new Point(0, 0);
            panelEditReceipt.Name = "panelEditReceipt";
            panelEditReceipt.Size = new Size(782, 75);
            panelEditReceipt.TabIndex = 0;
            // 
            // lblEditReceipt
            // 
            lblEditReceipt.Anchor = AnchorStyles.Top;
            lblEditReceipt.AutoSize = true;
            lblEditReceipt.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditReceipt.ForeColor = SystemColors.ButtonHighlight;
            lblEditReceipt.Location = new Point(278, 14);
            lblEditReceipt.Name = "lblEditReceipt";
            lblEditReceipt.Size = new Size(215, 47);
            lblEditReceipt.TabIndex = 2;
            lblEditReceipt.Text = "Edit Receipt";
            lblEditReceipt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUSGType
            // 
            lblUSGType.Anchor = AnchorStyles.None;
            lblUSGType.AutoSize = true;
            lblUSGType.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblUSGType.Location = new Point(140, 336);
            lblUSGType.Name = "lblUSGType";
            lblUSGType.Size = new Size(101, 30);
            lblUSGType.TabIndex = 30;
            lblUSGType.Text = "USG Type";
            lblUSGType.Visible = false;
            // 
            // cmbUSGType
            // 
            cmbUSGType.Anchor = AnchorStyles.None;
            cmbUSGType.BackColor = SystemColors.Menu;
            cmbUSGType.Font = new Font("Poppins", 10.2F);
            cmbUSGType.FormattingEnabled = true;
            cmbUSGType.Location = new Point(340, 328);
            cmbUSGType.Name = "cmbUSGType";
            cmbUSGType.Size = new Size(280, 38);
            cmbUSGType.TabIndex = 6;
            cmbUSGType.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(444, 444);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel [F1]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Anchor = AnchorStyles.None;
            txtDoctorName.BackColor = SystemColors.Menu;
            txtDoctorName.Font = new Font("Poppins", 10.2F);
            txtDoctorName.Location = new Point(340, 379);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(280, 33);
            txtDoctorName.TabIndex = 7;
            // 
            // lblDoctorName
            // 
            lblDoctorName.Anchor = AnchorStyles.None;
            lblDoctorName.AutoSize = true;
            lblDoctorName.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblDoctorName.Location = new Point(140, 382);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(137, 30);
            lblDoctorName.TabIndex = 26;
            lblDoctorName.Text = "Doctor Name";
            // 
            // txtFee
            // 
            txtFee.Anchor = AnchorStyles.None;
            txtFee.BackColor = SystemColors.Menu;
            txtFee.Font = new Font("Poppins", 10.2F);
            txtFee.Location = new Point(340, 184);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(280, 33);
            txtFee.TabIndex = 3;
            // 
            // labelFee
            // 
            labelFee.Anchor = AnchorStyles.None;
            labelFee.AutoSize = true;
            labelFee.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            labelFee.Location = new Point(140, 187);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(47, 30);
            labelFee.TabIndex = 20;
            labelFee.Text = "Fee";
            // 
            // txtBP
            // 
            txtBP.Anchor = AnchorStyles.None;
            txtBP.BackColor = SystemColors.Menu;
            txtBP.Font = new Font("Poppins", 10.2F);
            txtBP.Location = new Point(340, 281);
            txtBP.Name = "txtBP";
            txtBP.Size = new Size(280, 33);
            txtBP.TabIndex = 5;
            // 
            // lblBP
            // 
            lblBP.Anchor = AnchorStyles.None;
            lblBP.AutoSize = true;
            lblBP.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblBP.Location = new Point(140, 284);
            lblBP.Name = "lblBP";
            lblBP.Size = new Size(152, 30);
            lblBP.TabIndex = 24;
            lblBP.Text = "Blood Pressure";
            // 
            // txtTemperature
            // 
            txtTemperature.Anchor = AnchorStyles.None;
            txtTemperature.BackColor = SystemColors.Menu;
            txtTemperature.Font = new Font("Poppins", 10.2F);
            txtTemperature.Location = new Point(340, 233);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(280, 33);
            txtTemperature.TabIndex = 4;
            // 
            // lblTemperature
            // 
            lblTemperature.Anchor = AnchorStyles.None;
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblTemperature.Location = new Point(138, 236);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(135, 30);
            lblTemperature.TabIndex = 22;
            lblTemperature.Text = "Temperature";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.BackColor = SystemColors.Menu;
            txtAddress.Font = new Font("Poppins", 10.2F);
            txtAddress.Location = new Point(340, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 33);
            txtAddress.TabIndex = 2;
            // 
            // labelAddress
            // 
            labelAddress.Anchor = AnchorStyles.None;
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            labelAddress.Location = new Point(140, 141);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(88, 30);
            labelAddress.TabIndex = 18;
            labelAddress.Text = "Address";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.None;
            txtPatientName.BackColor = SystemColors.Menu;
            txtPatientName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientName.Location = new Point(340, 89);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(280, 33);
            txtPatientName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.None;
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(140, 96);
            labelName.Name = "labelName";
            labelName.Size = new Size(141, 30);
            labelName.TabIndex = 16;
            labelName.Text = "Patient Name";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(91, 42, 134);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(278, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save [F2]";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(617, 444);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete [DEL]";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // EditReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(782, 553);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(lblUSGType);
            Controls.Add(cmbUSGType);
            Controls.Add(btnCancel);
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
            Controls.Add(panelEditReceipt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(800, 600);
            Name = "EditReceiptForm";
            Text = "Update Record";
            panelEditReceipt.ResumeLayout(false);
            panelEditReceipt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelEditReceipt;
        private Label lblEditReceipt;
        private Label lblUSGType;
        private ComboBox cmbUSGType;
        private Button btnCancel;
        private TextBox txtDoctorName;
        private Label lblDoctorName;
        private TextBox txtFee;
        private Label labelFee;
        private TextBox txtBP;
        private Label lblBP;
        private TextBox txtTemperature;
        private Label lblTemperature;
        private TextBox txtAddress;
        private Label labelAddress;
        private TextBox txtPatientName;
        private Label labelName;
        private Button btnSave;
        private Button btnDelete;
    }
}