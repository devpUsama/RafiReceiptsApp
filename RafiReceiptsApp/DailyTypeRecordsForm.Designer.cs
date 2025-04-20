namespace RafiReceiptsApp
{
    partial class DailyTypeRecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyTypeRecordsForm));
            panelDailyRecord = new Panel();
            lblDailyRecord = new Label();
            dgvRecords = new DataGridView();
            lblTitle = new Label();
            btnPrintSummary = new Button();
            lblTokenCount = new Label();
            lblTotalAmount = new Label();
            gbDailyRecords = new GroupBox();
            panelDailyRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            gbDailyRecords.SuspendLayout();
            SuspendLayout();
            // 
            // panelDailyRecord
            // 
            panelDailyRecord.BackColor = Color.FromArgb(91, 42, 134);
            panelDailyRecord.Controls.Add(lblDailyRecord);
            panelDailyRecord.Dock = DockStyle.Top;
            panelDailyRecord.Location = new Point(0, 0);
            panelDailyRecord.Name = "panelDailyRecord";
            panelDailyRecord.Size = new Size(1262, 75);
            panelDailyRecord.TabIndex = 0;
            // 
            // lblDailyRecord
            // 
            lblDailyRecord.Anchor = AnchorStyles.Top;
            lblDailyRecord.AutoSize = true;
            lblDailyRecord.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailyRecord.ForeColor = SystemColors.ButtonHighlight;
            lblDailyRecord.Location = new Point(518, 14);
            lblDailyRecord.Name = "lblDailyRecord";
            lblDailyRecord.Size = new Size(223, 47);
            lblDailyRecord.TabIndex = 2;
            lblDailyRecord.Text = "Daily Record";
            lblDailyRecord.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvRecords
            // 
            dgvRecords.Anchor = AnchorStyles.None;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(12, 255);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.Size = new Size(1238, 315);
            dgvRecords.TabIndex = 1;
            dgvRecords.CellDoubleClick += dgvRecords_CellDoubleClick;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(46, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 30);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Record";
            // 
            // btnPrintSummary
            // 
            btnPrintSummary.Anchor = AnchorStyles.None;
            btnPrintSummary.BackColor = Color.FromArgb(91, 42, 134);
            btnPrintSummary.FlatStyle = FlatStyle.Flat;
            btnPrintSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintSummary.ForeColor = SystemColors.ButtonHighlight;
            btnPrintSummary.Location = new Point(1021, 601);
            btnPrintSummary.Name = "btnPrintSummary";
            btnPrintSummary.Size = new Size(179, 50);
            btnPrintSummary.TabIndex = 21;
            btnPrintSummary.Text = "Print Record [F2]";
            btnPrintSummary.UseVisualStyleBackColor = false;
            btnPrintSummary.Click += btnPrintSummary_Click;
            // 
            // lblTokenCount
            // 
            lblTokenCount.Anchor = AnchorStyles.None;
            lblTokenCount.AutoSize = true;
            lblTokenCount.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTokenCount.Location = new Point(46, 62);
            lblTokenCount.Name = "lblTokenCount";
            lblTokenCount.Size = new Size(132, 30);
            lblTokenCount.TabIndex = 22;
            lblTokenCount.Text = "Token Count";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.None;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(46, 92);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(139, 30);
            lblTotalAmount.TabIndex = 23;
            lblTotalAmount.Text = "Total Amount";
            // 
            // gbDailyRecords
            // 
            gbDailyRecords.Anchor = AnchorStyles.None;
            gbDailyRecords.Controls.Add(lblTokenCount);
            gbDailyRecords.Controls.Add(lblTotalAmount);
            gbDailyRecords.Controls.Add(lblTitle);
            gbDailyRecords.Location = new Point(82, 94);
            gbDailyRecords.Name = "gbDailyRecords";
            gbDailyRecords.Size = new Size(564, 137);
            gbDailyRecords.TabIndex = 24;
            gbDailyRecords.TabStop = false;
            gbDailyRecords.Text = "Daily Individual Records";
            // 
            // DailyTypeRecordsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1262, 673);
            Controls.Add(gbDailyRecords);
            Controls.Add(btnPrintSummary);
            Controls.Add(dgvRecords);
            Controls.Add(panelDailyRecord);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "DailyTypeRecordsForm";
            Text = "Daily Individual Records";
            panelDailyRecord.ResumeLayout(false);
            panelDailyRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            gbDailyRecords.ResumeLayout(false);
            gbDailyRecords.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDailyRecord;
        private Label lblDailyRecord;
        private DataGridView dgvRecords;
        private Label lblTitle;
        private Button btnPrintSummary;
        private Label lblTokenCount;
        private Label lblTotalAmount;
        private GroupBox gbDailyRecords;
    }
}