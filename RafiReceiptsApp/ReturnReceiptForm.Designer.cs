namespace RafiReceiptsApp
{
    partial class ReturnReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnReceiptForm));
            panelReturnReceipt = new Panel();
            lblTitle = new Label();
            lblReceiptId = new Label();
            txtReceiptId = new TextBox();
            btnLoadReceipt = new Button();
            grpBoxPatient = new GroupBox();
            txtFee = new TextBox();
            txtAddress = new TextBox();
            lblFee = new Label();
            lblAddress = new Label();
            txtPatientName = new TextBox();
            lblPatientName = new Label();
            btnCancel = new Button();
            btnSubmitReturn = new Button();
            panelReturnReceipt.SuspendLayout();
            grpBoxPatient.SuspendLayout();
            SuspendLayout();
            // 
            // panelReturnReceipt
            // 
            panelReturnReceipt.BackColor = Color.FromArgb(91, 42, 134);
            panelReturnReceipt.Controls.Add(lblTitle);
            panelReturnReceipt.Dock = DockStyle.Top;
            panelReturnReceipt.Location = new Point(0, 0);
            panelReturnReceipt.Name = "panelReturnReceipt";
            panelReturnReceipt.Size = new Size(782, 75);
            panelReturnReceipt.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(247, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Return Receipt";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblReceiptId
            // 
            lblReceiptId.Anchor = AnchorStyles.None;
            lblReceiptId.AutoSize = true;
            lblReceiptId.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblReceiptId.Location = new Point(94, 128);
            lblReceiptId.Name = "lblReceiptId";
            lblReceiptId.Size = new Size(166, 30);
            lblReceiptId.TabIndex = 2;
            lblReceiptId.Text = "Enter Receipt ID:";
            // 
            // txtReceiptId
            // 
            txtReceiptId.Anchor = AnchorStyles.None;
            txtReceiptId.BackColor = SystemColors.Menu;
            txtReceiptId.Font = new Font("Poppins", 10.2F);
            txtReceiptId.Location = new Point(284, 125);
            txtReceiptId.Name = "txtReceiptId";
            txtReceiptId.Size = new Size(199, 33);
            txtReceiptId.TabIndex = 3;
            // 
            // btnLoadReceipt
            // 
            btnLoadReceipt.Anchor = AnchorStyles.None;
            btnLoadReceipt.BackColor = Color.WhiteSmoke;
            btnLoadReceipt.FlatAppearance.BorderSize = 2;
            btnLoadReceipt.FlatStyle = FlatStyle.Flat;
            btnLoadReceipt.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadReceipt.ForeColor = Color.FromArgb(91, 42, 134);
            btnLoadReceipt.Location = new Point(500, 118);
            btnLoadReceipt.Name = "btnLoadReceipt";
            btnLoadReceipt.Size = new Size(192, 50);
            btnLoadReceipt.TabIndex = 10;
            btnLoadReceipt.Text = "Load Receipt [F2]";
            btnLoadReceipt.UseVisualStyleBackColor = false;
            btnLoadReceipt.Click += btnLoadReceipt_Click;
            // 
            // grpBoxPatient
            // 
            grpBoxPatient.Anchor = AnchorStyles.None;
            grpBoxPatient.Controls.Add(txtFee);
            grpBoxPatient.Controls.Add(txtAddress);
            grpBoxPatient.Controls.Add(lblFee);
            grpBoxPatient.Controls.Add(lblAddress);
            grpBoxPatient.Controls.Add(txtPatientName);
            grpBoxPatient.Controls.Add(lblPatientName);
            grpBoxPatient.Location = new Point(94, 200);
            grpBoxPatient.Name = "grpBoxPatient";
            grpBoxPatient.Size = new Size(598, 218);
            grpBoxPatient.TabIndex = 11;
            grpBoxPatient.TabStop = false;
            grpBoxPatient.Text = "Patient Details";
            // 
            // txtFee
            // 
            txtFee.Anchor = AnchorStyles.None;
            txtFee.BackColor = SystemColors.Menu;
            txtFee.Font = new Font("Poppins", 10.2F);
            txtFee.Location = new Point(277, 141);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(240, 33);
            txtFee.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.BackColor = SystemColors.Menu;
            txtAddress.Font = new Font("Poppins", 10.2F);
            txtAddress.Location = new Point(277, 97);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 33);
            txtAddress.TabIndex = 7;
            // 
            // lblFee
            // 
            lblFee.Anchor = AnchorStyles.None;
            lblFee.AutoSize = true;
            lblFee.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblFee.Location = new Point(55, 144);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(47, 30);
            lblFee.TabIndex = 6;
            lblFee.Text = "Fee";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblAddress.Location = new Point(55, 100);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(88, 30);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.None;
            txtPatientName.BackColor = SystemColors.Menu;
            txtPatientName.Font = new Font("Poppins", 10.2F);
            txtPatientName.Location = new Point(277, 50);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(240, 33);
            txtPatientName.TabIndex = 4;
            // 
            // lblPatientName
            // 
            lblPatientName.Anchor = AnchorStyles.None;
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            lblPatientName.Location = new Point(55, 53);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(141, 30);
            lblPatientName.TabIndex = 3;
            lblPatientName.Text = "Patient Name";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(540, 442);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel [F1]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmitReturn
            // 
            btnSubmitReturn.Anchor = AnchorStyles.None;
            btnSubmitReturn.BackColor = Color.FromArgb(91, 42, 134);
            btnSubmitReturn.FlatStyle = FlatStyle.Flat;
            btnSubmitReturn.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitReturn.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitReturn.Location = new Point(371, 442);
            btnSubmitReturn.Name = "btnSubmitReturn";
            btnSubmitReturn.Size = new Size(150, 50);
            btnSubmitReturn.TabIndex = 12;
            btnSubmitReturn.Text = "Save [F3]";
            btnSubmitReturn.UseVisualStyleBackColor = false;
            btnSubmitReturn.Click += btnSubmitReturn_Click;
            // 
            // ReturnReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(782, 553);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmitReturn);
            Controls.Add(grpBoxPatient);
            Controls.Add(btnLoadReceipt);
            Controls.Add(txtReceiptId);
            Controls.Add(lblReceiptId);
            Controls.Add(panelReturnReceipt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReturnReceiptForm";
            Text = "Return";
            panelReturnReceipt.ResumeLayout(false);
            panelReturnReceipt.PerformLayout();
            grpBoxPatient.ResumeLayout(false);
            grpBoxPatient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelReturnReceipt;
        private Label lblTitle;
        private Label lblReceiptId;
        private TextBox txtReceiptId;
        private Button btnLoadReceipt;
        private GroupBox grpBoxPatient;
        private TextBox txtFee;
        private TextBox txtAddress;
        private Label lblFee;
        private Label lblAddress;
        private TextBox txtPatientName;
        private Label lblPatientName;
        private Button btnCancel;
        private Button btnSubmitReturn;
    }
}