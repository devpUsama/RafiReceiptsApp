namespace RafiReceiptsApp
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            dataGridHistory = new DataGridView();
            panelHistory = new Panel();
            labelHistory = new Label();
            labelHistoryPatient = new Label();
            grpTodaySummary = new GroupBox();
            lblDrFizzaSummary = new Label();
            btnPrintDaily = new Button();
            lblOthersSummary = new Label();
            lblDrJawadSummary = new Label();
            lblDrHamadSummary = new Label();
            lblDrZainSummary = new Label();
            lblTodayTotal = new Label();
            lblEcgSummary = new Label();
            lblUsgSummary = new Label();
            lblOpdSummary = new Label();
            grpMonthSummary = new GroupBox();
            btnPrintMonthly = new Button();
            lblMonthTotal = new Label();
            btnCancel = new Button();
            btnReprint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            panelHistory.SuspendLayout();
            grpTodaySummary.SuspendLayout();
            grpMonthSummary.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridHistory
            // 
            dataGridHistory.Anchor = AnchorStyles.None;
            dataGridHistory.BackgroundColor = SystemColors.Control;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistory.Location = new Point(26, 470);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.RowHeadersWidth = 51;
            dataGridHistory.Size = new Size(1203, 289);
            dataGridHistory.TabIndex = 0;
            dataGridHistory.CellDoubleClick += dataGridHistory_CellDoubleClick;
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.FromArgb(91, 42, 134);
            panelHistory.Controls.Add(labelHistory);
            panelHistory.Dock = DockStyle.Top;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(1262, 75);
            panelHistory.TabIndex = 1;
            // 
            // labelHistory
            // 
            labelHistory.Anchor = AnchorStyles.Top;
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistory.ForeColor = SystemColors.ButtonHighlight;
            labelHistory.Location = new Point(533, 9);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(183, 58);
            labelHistory.TabIndex = 1;
            labelHistory.Text = "Records";
            // 
            // labelHistoryPatient
            // 
            labelHistoryPatient.Anchor = AnchorStyles.None;
            labelHistoryPatient.AutoSize = true;
            labelHistoryPatient.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistoryPatient.ForeColor = Color.FromArgb(91, 42, 134);
            labelHistoryPatient.Location = new Point(59, 90);
            labelHistoryPatient.Name = "labelHistoryPatient";
            labelHistoryPatient.Size = new Size(195, 30);
            labelHistoryPatient.TabIndex = 6;
            labelHistoryPatient.Text = "Records of Patients";
            // 
            // grpTodaySummary
            // 
            grpTodaySummary.Anchor = AnchorStyles.None;
            grpTodaySummary.Controls.Add(lblDrFizzaSummary);
            grpTodaySummary.Controls.Add(btnPrintDaily);
            grpTodaySummary.Controls.Add(lblOthersSummary);
            grpTodaySummary.Controls.Add(lblDrJawadSummary);
            grpTodaySummary.Controls.Add(lblDrHamadSummary);
            grpTodaySummary.Controls.Add(lblDrZainSummary);
            grpTodaySummary.Controls.Add(lblTodayTotal);
            grpTodaySummary.Controls.Add(lblEcgSummary);
            grpTodaySummary.Controls.Add(lblUsgSummary);
            grpTodaySummary.Controls.Add(lblOpdSummary);
            grpTodaySummary.Location = new Point(59, 134);
            grpTodaySummary.Name = "grpTodaySummary";
            grpTodaySummary.Size = new Size(552, 326);
            grpTodaySummary.TabIndex = 7;
            grpTodaySummary.TabStop = false;
            grpTodaySummary.Text = "Today's Summary";
            // 
            // lblDrFizzaSummary
            // 
            lblDrFizzaSummary.Anchor = AnchorStyles.Top;
            lblDrFizzaSummary.AutoSize = true;
            lblDrFizzaSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrFizzaSummary.Location = new Point(42, 122);
            lblDrFizzaSummary.Name = "lblDrFizzaSummary";
            lblDrFizzaSummary.Size = new Size(181, 30);
            lblDrFizzaSummary.TabIndex = 28;
            lblDrFizzaSummary.Text = "Dr Fizza Summary";
            // 
            // btnPrintDaily
            // 
            btnPrintDaily.Anchor = AnchorStyles.Top;
            btnPrintDaily.BackColor = Color.WhiteSmoke;
            btnPrintDaily.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.FlatAppearance.BorderSize = 2;
            btnPrintDaily.FlatStyle = FlatStyle.Flat;
            btnPrintDaily.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintDaily.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.Location = new Point(390, 260);
            btnPrintDaily.Name = "btnPrintDaily";
            btnPrintDaily.Size = new Size(150, 50);
            btnPrintDaily.TabIndex = 27;
            btnPrintDaily.Text = "Print Today's";
            btnPrintDaily.UseVisualStyleBackColor = false;
            btnPrintDaily.Click += btnPrintDaily_Click;
            // 
            // lblOthersSummary
            // 
            lblOthersSummary.Anchor = AnchorStyles.Top;
            lblOthersSummary.AutoSize = true;
            lblOthersSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOthersSummary.Location = new Point(42, 198);
            lblOthersSummary.Name = "lblOthersSummary";
            lblOthersSummary.Size = new Size(143, 30);
            lblOthersSummary.TabIndex = 26;
            lblOthersSummary.Text = "Other Doctors";
            // 
            // lblDrJawadSummary
            // 
            lblDrJawadSummary.Anchor = AnchorStyles.Top;
            lblDrJawadSummary.AutoSize = true;
            lblDrJawadSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrJawadSummary.Location = new Point(42, 172);
            lblDrJawadSummary.Name = "lblDrJawadSummary";
            lblDrJawadSummary.Size = new Size(197, 30);
            lblDrJawadSummary.TabIndex = 25;
            lblDrJawadSummary.Text = "Dr Jawad Summary";
            // 
            // lblDrHamadSummary
            // 
            lblDrHamadSummary.Anchor = AnchorStyles.Top;
            lblDrHamadSummary.AutoSize = true;
            lblDrHamadSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrHamadSummary.Location = new Point(42, 148);
            lblDrHamadSummary.Name = "lblDrHamadSummary";
            lblDrHamadSummary.Size = new Size(204, 30);
            lblDrHamadSummary.TabIndex = 24;
            lblDrHamadSummary.Text = "Dr Hamad Summary";
            // 
            // lblDrZainSummary
            // 
            lblDrZainSummary.Anchor = AnchorStyles.Top;
            lblDrZainSummary.AutoSize = true;
            lblDrZainSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZainSummary.Location = new Point(42, 98);
            lblDrZainSummary.Name = "lblDrZainSummary";
            lblDrZainSummary.Size = new Size(175, 30);
            lblDrZainSummary.TabIndex = 23;
            lblDrZainSummary.Text = "Dr Zain Summary";
            // 
            // lblTodayTotal
            // 
            lblTodayTotal.Anchor = AnchorStyles.Top;
            lblTodayTotal.AutoSize = true;
            lblTodayTotal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTotal.ForeColor = Color.Red;
            lblTodayTotal.Location = new Point(42, 221);
            lblTodayTotal.Name = "lblTodayTotal";
            lblTodayTotal.Size = new Size(142, 30);
            lblTodayTotal.TabIndex = 22;
            lblTodayTotal.Text = "Overall Today";
            // 
            // lblEcgSummary
            // 
            lblEcgSummary.Anchor = AnchorStyles.Top;
            lblEcgSummary.AutoSize = true;
            lblEcgSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcgSummary.Location = new Point(42, 49);
            lblEcgSummary.Name = "lblEcgSummary";
            lblEcgSummary.Size = new Size(148, 30);
            lblEcgSummary.TabIndex = 21;
            lblEcgSummary.Text = "ECG Summary";
            // 
            // lblUsgSummary
            // 
            lblUsgSummary.Anchor = AnchorStyles.Top;
            lblUsgSummary.AutoSize = true;
            lblUsgSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsgSummary.Location = new Point(42, 74);
            lblUsgSummary.Name = "lblUsgSummary";
            lblUsgSummary.Size = new Size(147, 30);
            lblUsgSummary.TabIndex = 20;
            lblUsgSummary.Text = "USG Summary";
            // 
            // lblOpdSummary
            // 
            lblOpdSummary.Anchor = AnchorStyles.Top;
            lblOpdSummary.AutoSize = true;
            lblOpdSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpdSummary.Location = new Point(42, 23);
            lblOpdSummary.Name = "lblOpdSummary";
            lblOpdSummary.Size = new Size(148, 30);
            lblOpdSummary.TabIndex = 19;
            lblOpdSummary.Text = "OPD Summary";
            // 
            // grpMonthSummary
            // 
            grpMonthSummary.Anchor = AnchorStyles.None;
            grpMonthSummary.Controls.Add(btnPrintMonthly);
            grpMonthSummary.Controls.Add(lblMonthTotal);
            grpMonthSummary.Location = new Point(624, 134);
            grpMonthSummary.Name = "grpMonthSummary";
            grpMonthSummary.Size = new Size(548, 174);
            grpMonthSummary.TabIndex = 8;
            grpMonthSummary.TabStop = false;
            grpMonthSummary.Text = "Monthly Summary";
            // 
            // btnPrintMonthly
            // 
            btnPrintMonthly.Anchor = AnchorStyles.Top;
            btnPrintMonthly.BackColor = Color.WhiteSmoke;
            btnPrintMonthly.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.FlatAppearance.BorderSize = 2;
            btnPrintMonthly.FlatStyle = FlatStyle.Flat;
            btnPrintMonthly.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintMonthly.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.Location = new Point(392, 113);
            btnPrintMonthly.Name = "btnPrintMonthly";
            btnPrintMonthly.Size = new Size(150, 50);
            btnPrintMonthly.TabIndex = 24;
            btnPrintMonthly.Text = "Print Monthly";
            btnPrintMonthly.UseVisualStyleBackColor = false;
            btnPrintMonthly.Click += btnPrintMonthly_Click;
            // 
            // lblMonthTotal
            // 
            lblMonthTotal.Anchor = AnchorStyles.Top;
            lblMonthTotal.AutoSize = true;
            lblMonthTotal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthTotal.ForeColor = Color.Red;
            lblMonthTotal.Location = new Point(6, 37);
            lblMonthTotal.Name = "lblMonthTotal";
            lblMonthTotal.Size = new Size(376, 30);
            lblMonthTotal.TabIndex = 23;
            lblMonthTotal.Text = "This Month’s Total Tokens and Amount";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(1078, 779);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel [F1]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReprint
            // 
            btnReprint.Anchor = AnchorStyles.None;
            btnReprint.BackColor = Color.FromArgb(91, 42, 134);
            btnReprint.FlatStyle = FlatStyle.Flat;
            btnReprint.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprint.ForeColor = SystemColors.ButtonHighlight;
            btnReprint.Location = new Point(909, 779);
            btnReprint.Name = "btnReprint";
            btnReprint.Size = new Size(150, 50);
            btnReprint.TabIndex = 10;
            btnReprint.Text = "Re-Print [F4]";
            btnReprint.UseVisualStyleBackColor = false;
            btnReprint.Click += btnReprint_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1262, 853);
            Controls.Add(btnCancel);
            Controls.Add(btnReprint);
            Controls.Add(grpMonthSummary);
            Controls.Add(grpTodaySummary);
            Controls.Add(labelHistoryPatient);
            Controls.Add(panelHistory);
            Controls.Add(dataGridHistory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(1280, 720);
            Name = "HistoryForm";
            Text = "Records";
            Load += HistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).EndInit();
            panelHistory.ResumeLayout(false);
            panelHistory.PerformLayout();
            grpTodaySummary.ResumeLayout(false);
            grpTodaySummary.PerformLayout();
            grpMonthSummary.ResumeLayout(false);
            grpMonthSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridHistory;
        private Panel panelHistory;
        private Label labelHistory;
        private Label labelHistoryPatient;
        private GroupBox grpTodaySummary;
        private Label lblTodayTotal;
        private Label lblEcgSummary;
        private Label lblUsgSummary;
        private Label lblOpdSummary;
        private GroupBox grpMonthSummary;
        private Label lblMonthTotal;
        private Label lblOthersSummary;
        private Label lblDrJawadSummary;
        private Label lblDrHamadSummary;
        private Label lblDrZainSummary;
        private Button btnPrintDaily;
        private Button btnPrintMonthly;
        private Label lblDrFizzaSummary;
        private Button btnCancel;
        private Button btnReprint;
    }
}