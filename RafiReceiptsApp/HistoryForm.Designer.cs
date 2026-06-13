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
            lblDrAyeshaSummary = new Label();
            lblDrMinahilSummary = new Label();
            lblDrZuhaibSummary = new Label();
            lblDrTehreemSummary = new Label();
            lblDrFizzaSummary = new Label();
            btnPrintDaily = new Button();
            lblOthersSummary = new Label();
            lblDrJawadSummary = new Label();
            lblDrHammadSummary = new Label();
            lblDrZainSummary = new Label();
            lblTodayTotal = new Label();
            lblEcgSummary = new Label();
            lblUsgSummary = new Label();
            lblOpdSummary = new Label();
            grpMonthSummary = new GroupBox();
            lblDrAyeshaSummaryMonth = new Label();
            lblDrMinahilSummaryMonth = new Label();
            lblDrZuhaibSummaryMonth = new Label();
            lblDrTehreemSummaryMonth = new Label();
            lblDrFizzaSummaryMonth = new Label();
            lblOthersSummaryMonth = new Label();
            lblDrJawadSummaryMonth = new Label();
            lblDrHammadSummaryMonth = new Label();
            lblDrZainSummaryMonth = new Label();
            lblEcgSummaryMonth = new Label();
            lblUsgSummaryMonth = new Label();
            lblOpdSummaryMonth = new Label();
            btnPrintMonthly = new Button();
            lblMonthTotal = new Label();
            btnCancel = new Button();
            btnReprint = new Button();
            gbIndividualRecords = new GroupBox();
            btnDailyDrMinahil = new Button();
            btnDailyDrZuhaib = new Button();
            btnDailyDrTehreem = new Button();
            btnDailyOther = new Button();
            btnDailyDrJawad = new Button();
            btnDailyDrHammad = new Button();
            btnDailyDrFizza = new Button();
            btnDailyDrZain = new Button();
            btnDailyUSG = new Button();
            btnDailyECG = new Button();
            btnDailyOPD = new Button();
            btnDailyDrAyesha = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            panelHistory.SuspendLayout();
            grpTodaySummary.SuspendLayout();
            grpMonthSummary.SuspendLayout();
            gbIndividualRecords.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridHistory
            // 
            dataGridHistory.BackgroundColor = SystemColors.Control;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistory.Location = new Point(23, 544);
            dataGridHistory.Margin = new Padding(3, 2, 3, 2);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.RowHeadersWidth = 51;
            dataGridHistory.Size = new Size(1053, 152);
            dataGridHistory.TabIndex = 0;
            dataGridHistory.CellDoubleClick += dataGridHistory_CellDoubleClick;
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.FromArgb(91, 42, 134);
            panelHistory.Controls.Add(labelHistory);
            panelHistory.Dock = DockStyle.Top;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Margin = new Padding(3, 2, 3, 2);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(1348, 56);
            panelHistory.TabIndex = 1;
            // 
            // labelHistory
            // 
            labelHistory.Anchor = AnchorStyles.Top;
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistory.ForeColor = SystemColors.ButtonHighlight;
            labelHistory.Location = new Point(588, 7);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(134, 36);
            labelHistory.TabIndex = 1;
            labelHistory.Text = "Records";
            // 
            // labelHistoryPatient
            // 
            labelHistoryPatient.AutoSize = true;
            labelHistoryPatient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistoryPatient.ForeColor = Color.FromArgb(91, 42, 134);
            labelHistoryPatient.Location = new Point(52, 71);
            labelHistoryPatient.Name = "labelHistoryPatient";
            labelHistoryPatient.Size = new Size(151, 17);
            labelHistoryPatient.TabIndex = 6;
            labelHistoryPatient.Text = "Records of Patients";
            // 
            // grpTodaySummary
            // 
            grpTodaySummary.Controls.Add(lblDrAyeshaSummary);
            grpTodaySummary.Controls.Add(lblDrMinahilSummary);
            grpTodaySummary.Controls.Add(lblDrZuhaibSummary);
            grpTodaySummary.Controls.Add(lblDrTehreemSummary);
            grpTodaySummary.Controls.Add(lblDrFizzaSummary);
            grpTodaySummary.Controls.Add(btnPrintDaily);
            grpTodaySummary.Controls.Add(lblOthersSummary);
            grpTodaySummary.Controls.Add(lblDrJawadSummary);
            grpTodaySummary.Controls.Add(lblDrHammadSummary);
            grpTodaySummary.Controls.Add(lblDrZainSummary);
            grpTodaySummary.Controls.Add(lblTodayTotal);
            grpTodaySummary.Controls.Add(lblEcgSummary);
            grpTodaySummary.Controls.Add(lblUsgSummary);
            grpTodaySummary.Controls.Add(lblOpdSummary);
            grpTodaySummary.Location = new Point(52, 95);
            grpTodaySummary.Margin = new Padding(3, 2, 3, 2);
            grpTodaySummary.Name = "grpTodaySummary";
            grpTodaySummary.Padding = new Padding(3, 2, 3, 2);
            grpTodaySummary.Size = new Size(483, 286);
            grpTodaySummary.TabIndex = 7;
            grpTodaySummary.TabStop = false;
            grpTodaySummary.Text = "Today's Summary";
            // 
            // lblDrAyeshaSummary
            // 
            lblDrAyeshaSummary.AutoSize = true;
            lblDrAyeshaSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrAyeshaSummary.Location = new Point(36, 194);
            lblDrAyeshaSummary.Name = "lblDrAyeshaSummary";
            lblDrAyeshaSummary.Size = new Size(154, 17);
            lblDrAyeshaSummary.TabIndex = 32;
            lblDrAyeshaSummary.Text = "Dr Ayesha Summary";
            // 
            // lblDrMinahilSummary
            // 
            lblDrMinahilSummary.AutoSize = true;
            lblDrMinahilSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrMinahilSummary.Location = new Point(37, 176);
            lblDrMinahilSummary.Name = "lblDrMinahilSummary";
            lblDrMinahilSummary.Size = new Size(152, 17);
            lblDrMinahilSummary.TabIndex = 31;
            lblDrMinahilSummary.Text = "Dr Minahil Summary";
            // 
            // lblDrZuhaibSummary
            // 
            lblDrZuhaibSummary.AutoSize = true;
            lblDrZuhaibSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZuhaibSummary.Location = new Point(37, 159);
            lblDrZuhaibSummary.Name = "lblDrZuhaibSummary";
            lblDrZuhaibSummary.Size = new Size(151, 17);
            lblDrZuhaibSummary.TabIndex = 30;
            lblDrZuhaibSummary.Text = "Dr Zuhaib Summary";
            // 
            // lblDrTehreemSummary
            // 
            lblDrTehreemSummary.AutoSize = true;
            lblDrTehreemSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrTehreemSummary.Location = new Point(37, 142);
            lblDrTehreemSummary.Name = "lblDrTehreemSummary";
            lblDrTehreemSummary.Size = new Size(165, 17);
            lblDrTehreemSummary.TabIndex = 29;
            lblDrTehreemSummary.Text = "Dr Tehreem Summary";
            // 
            // lblDrFizzaSummary
            // 
            lblDrFizzaSummary.AutoSize = true;
            lblDrFizzaSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrFizzaSummary.Location = new Point(37, 87);
            lblDrFizzaSummary.Name = "lblDrFizzaSummary";
            lblDrFizzaSummary.Size = new Size(139, 17);
            lblDrFizzaSummary.TabIndex = 28;
            lblDrFizzaSummary.Text = "Dr Fizza Summary";
            // 
            // btnPrintDaily
            // 
            btnPrintDaily.BackColor = Color.WhiteSmoke;
            btnPrintDaily.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.FlatAppearance.BorderSize = 2;
            btnPrintDaily.FlatStyle = FlatStyle.Flat;
            btnPrintDaily.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintDaily.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.Location = new Point(356, 245);
            btnPrintDaily.Margin = new Padding(3, 2, 3, 2);
            btnPrintDaily.Name = "btnPrintDaily";
            btnPrintDaily.Size = new Size(123, 38);
            btnPrintDaily.TabIndex = 27;
            btnPrintDaily.Text = "Print Today's";
            btnPrintDaily.UseVisualStyleBackColor = false;
            btnPrintDaily.Click += btnPrintDaily_Click;
            // 
            // lblOthersSummary
            // 
            lblOthersSummary.AutoSize = true;
            lblOthersSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOthersSummary.Location = new Point(37, 210);
            lblOthersSummary.Name = "lblOthersSummary";
            lblOthersSummary.Size = new Size(110, 17);
            lblOthersSummary.TabIndex = 26;
            lblOthersSummary.Text = "Other Doctors";
            // 
            // lblDrJawadSummary
            // 
            lblDrJawadSummary.AutoSize = true;
            lblDrJawadSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrJawadSummary.Location = new Point(37, 123);
            lblDrJawadSummary.Name = "lblDrJawadSummary";
            lblDrJawadSummary.Size = new Size(146, 17);
            lblDrJawadSummary.TabIndex = 25;
            lblDrJawadSummary.Text = "Dr Jawad Summary";
            // 
            // lblDrHammadSummary
            // 
            lblDrHammadSummary.AutoSize = true;
            lblDrHammadSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrHammadSummary.Location = new Point(37, 105);
            lblDrHammadSummary.Name = "lblDrHammadSummary";
            lblDrHammadSummary.Size = new Size(163, 17);
            lblDrHammadSummary.TabIndex = 24;
            lblDrHammadSummary.Text = "Dr Hammad Summary";
            // 
            // lblDrZainSummary
            // 
            lblDrZainSummary.AutoSize = true;
            lblDrZainSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZainSummary.Location = new Point(37, 69);
            lblDrZainSummary.Name = "lblDrZainSummary";
            lblDrZainSummary.Size = new Size(133, 17);
            lblDrZainSummary.TabIndex = 23;
            lblDrZainSummary.Text = "Dr Zain Summary";
            // 
            // lblTodayTotal
            // 
            lblTodayTotal.AutoSize = true;
            lblTodayTotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTotal.ForeColor = Color.Red;
            lblTodayTotal.Location = new Point(37, 227);
            lblTodayTotal.Name = "lblTodayTotal";
            lblTodayTotal.Size = new Size(110, 17);
            lblTodayTotal.TabIndex = 22;
            lblTodayTotal.Text = "Overall Today";
            // 
            // lblEcgSummary
            // 
            lblEcgSummary.AutoSize = true;
            lblEcgSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcgSummary.Location = new Point(37, 34);
            lblEcgSummary.Name = "lblEcgSummary";
            lblEcgSummary.Size = new Size(111, 17);
            lblEcgSummary.TabIndex = 21;
            lblEcgSummary.Text = "ECG Summary";
            // 
            // lblUsgSummary
            // 
            lblUsgSummary.AutoSize = true;
            lblUsgSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsgSummary.Location = new Point(37, 51);
            lblUsgSummary.Name = "lblUsgSummary";
            lblUsgSummary.Size = new Size(112, 17);
            lblUsgSummary.TabIndex = 20;
            lblUsgSummary.Text = "USG Summary";
            // 
            // lblOpdSummary
            // 
            lblOpdSummary.AutoSize = true;
            lblOpdSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpdSummary.Location = new Point(37, 17);
            lblOpdSummary.Name = "lblOpdSummary";
            lblOpdSummary.Size = new Size(112, 17);
            lblOpdSummary.TabIndex = 19;
            lblOpdSummary.Text = "OPD Summary";
            // 
            // grpMonthSummary
            // 
            grpMonthSummary.Controls.Add(lblDrAyeshaSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrMinahilSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrZuhaibSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrTehreemSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrFizzaSummaryMonth);
            grpMonthSummary.Controls.Add(lblOthersSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrJawadSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrHammadSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrZainSummaryMonth);
            grpMonthSummary.Controls.Add(lblEcgSummaryMonth);
            grpMonthSummary.Controls.Add(lblUsgSummaryMonth);
            grpMonthSummary.Controls.Add(lblOpdSummaryMonth);
            grpMonthSummary.Controls.Add(btnPrintMonthly);
            grpMonthSummary.Controls.Add(lblMonthTotal);
            grpMonthSummary.Location = new Point(546, 95);
            grpMonthSummary.Margin = new Padding(3, 2, 3, 2);
            grpMonthSummary.Name = "grpMonthSummary";
            grpMonthSummary.Padding = new Padding(3, 2, 3, 2);
            grpMonthSummary.Size = new Size(480, 286);
            grpMonthSummary.TabIndex = 8;
            grpMonthSummary.TabStop = false;
            grpMonthSummary.Text = "Monthly Summary";
            // 
            // lblDrAyeshaSummaryMonth
            // 
            lblDrAyeshaSummaryMonth.AutoSize = true;
            lblDrAyeshaSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrAyeshaSummaryMonth.Location = new Point(7, 192);
            lblDrAyeshaSummaryMonth.Name = "lblDrAyeshaSummaryMonth";
            lblDrAyeshaSummaryMonth.Size = new Size(154, 17);
            lblDrAyeshaSummaryMonth.TabIndex = 42;
            lblDrAyeshaSummaryMonth.Text = "Dr Ayesha Summary";
            // 
            // lblDrMinahilSummaryMonth
            // 
            lblDrMinahilSummaryMonth.AutoSize = true;
            lblDrMinahilSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrMinahilSummaryMonth.Location = new Point(7, 175);
            lblDrMinahilSummaryMonth.Name = "lblDrMinahilSummaryMonth";
            lblDrMinahilSummaryMonth.Size = new Size(152, 17);
            lblDrMinahilSummaryMonth.TabIndex = 41;
            lblDrMinahilSummaryMonth.Text = "Dr Minahil Summary";
            // 
            // lblDrZuhaibSummaryMonth
            // 
            lblDrZuhaibSummaryMonth.AutoSize = true;
            lblDrZuhaibSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZuhaibSummaryMonth.Location = new Point(7, 158);
            lblDrZuhaibSummaryMonth.Name = "lblDrZuhaibSummaryMonth";
            lblDrZuhaibSummaryMonth.Size = new Size(151, 17);
            lblDrZuhaibSummaryMonth.TabIndex = 40;
            lblDrZuhaibSummaryMonth.Text = "Dr Zuhaib Summary";
            // 
            // lblDrTehreemSummaryMonth
            // 
            lblDrTehreemSummaryMonth.AutoSize = true;
            lblDrTehreemSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrTehreemSummaryMonth.Location = new Point(7, 141);
            lblDrTehreemSummaryMonth.Name = "lblDrTehreemSummaryMonth";
            lblDrTehreemSummaryMonth.Size = new Size(165, 17);
            lblDrTehreemSummaryMonth.TabIndex = 39;
            lblDrTehreemSummaryMonth.Text = "Dr Tehreem Summary";
            // 
            // lblDrFizzaSummaryMonth
            // 
            lblDrFizzaSummaryMonth.AutoSize = true;
            lblDrFizzaSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrFizzaSummaryMonth.Location = new Point(7, 88);
            lblDrFizzaSummaryMonth.Name = "lblDrFizzaSummaryMonth";
            lblDrFizzaSummaryMonth.Size = new Size(139, 17);
            lblDrFizzaSummaryMonth.TabIndex = 38;
            lblDrFizzaSummaryMonth.Text = "Dr Fizza Summary";
            // 
            // lblOthersSummaryMonth
            // 
            lblOthersSummaryMonth.AutoSize = true;
            lblOthersSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOthersSummaryMonth.Location = new Point(6, 209);
            lblOthersSummaryMonth.Name = "lblOthersSummaryMonth";
            lblOthersSummaryMonth.Size = new Size(110, 17);
            lblOthersSummaryMonth.TabIndex = 37;
            lblOthersSummaryMonth.Text = "Other Doctors";
            // 
            // lblDrJawadSummaryMonth
            // 
            lblDrJawadSummaryMonth.AutoSize = true;
            lblDrJawadSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrJawadSummaryMonth.Location = new Point(7, 123);
            lblDrJawadSummaryMonth.Name = "lblDrJawadSummaryMonth";
            lblDrJawadSummaryMonth.Size = new Size(146, 17);
            lblDrJawadSummaryMonth.TabIndex = 36;
            lblDrJawadSummaryMonth.Text = "Dr Jawad Summary";
            lblDrJawadSummaryMonth.Click += label5_Click;
            // 
            // lblDrHammadSummaryMonth
            // 
            lblDrHammadSummaryMonth.AutoSize = true;
            lblDrHammadSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrHammadSummaryMonth.Location = new Point(7, 106);
            lblDrHammadSummaryMonth.Name = "lblDrHammadSummaryMonth";
            lblDrHammadSummaryMonth.Size = new Size(163, 17);
            lblDrHammadSummaryMonth.TabIndex = 35;
            lblDrHammadSummaryMonth.Text = "Dr Hammad Summary";
            // 
            // lblDrZainSummaryMonth
            // 
            lblDrZainSummaryMonth.AutoSize = true;
            lblDrZainSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZainSummaryMonth.Location = new Point(7, 70);
            lblDrZainSummaryMonth.Name = "lblDrZainSummaryMonth";
            lblDrZainSummaryMonth.Size = new Size(133, 17);
            lblDrZainSummaryMonth.TabIndex = 34;
            lblDrZainSummaryMonth.Text = "Dr Zain Summary";
            // 
            // lblEcgSummaryMonth
            // 
            lblEcgSummaryMonth.AutoSize = true;
            lblEcgSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcgSummaryMonth.Location = new Point(7, 34);
            lblEcgSummaryMonth.Name = "lblEcgSummaryMonth";
            lblEcgSummaryMonth.Size = new Size(111, 17);
            lblEcgSummaryMonth.TabIndex = 33;
            lblEcgSummaryMonth.Text = "ECG Summary";
            // 
            // lblUsgSummaryMonth
            // 
            lblUsgSummaryMonth.AutoSize = true;
            lblUsgSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsgSummaryMonth.Location = new Point(7, 52);
            lblUsgSummaryMonth.Name = "lblUsgSummaryMonth";
            lblUsgSummaryMonth.Size = new Size(112, 17);
            lblUsgSummaryMonth.TabIndex = 32;
            lblUsgSummaryMonth.Text = "USG Summary";
            // 
            // lblOpdSummaryMonth
            // 
            lblOpdSummaryMonth.AutoSize = true;
            lblOpdSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpdSummaryMonth.Location = new Point(7, 16);
            lblOpdSummaryMonth.Name = "lblOpdSummaryMonth";
            lblOpdSummaryMonth.Size = new Size(112, 17);
            lblOpdSummaryMonth.TabIndex = 31;
            lblOpdSummaryMonth.Text = "OPD Summary";
            // 
            // btnPrintMonthly
            // 
            btnPrintMonthly.BackColor = Color.WhiteSmoke;
            btnPrintMonthly.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.FlatAppearance.BorderSize = 2;
            btnPrintMonthly.FlatStyle = FlatStyle.Flat;
            btnPrintMonthly.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintMonthly.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.Location = new Point(345, 247);
            btnPrintMonthly.Margin = new Padding(3, 2, 3, 2);
            btnPrintMonthly.Name = "btnPrintMonthly";
            btnPrintMonthly.Size = new Size(131, 38);
            btnPrintMonthly.TabIndex = 24;
            btnPrintMonthly.Text = "Print Monthly";
            btnPrintMonthly.UseVisualStyleBackColor = false;
            btnPrintMonthly.Click += btnPrintMonthly_Click;
            // 
            // lblMonthTotal
            // 
            lblMonthTotal.AutoSize = true;
            lblMonthTotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthTotal.ForeColor = Color.Red;
            lblMonthTotal.Location = new Point(6, 226);
            lblMonthTotal.Name = "lblMonthTotal";
            lblMonthTotal.Size = new Size(291, 17);
            lblMonthTotal.TabIndex = 23;
            lblMonthTotal.Text = "This Month’s Total Tokens and Amount";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(943, 712);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 38);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel [Esc]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReprint
            // 
            btnReprint.BackColor = Color.FromArgb(91, 42, 134);
            btnReprint.FlatStyle = FlatStyle.Flat;
            btnReprint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprint.ForeColor = SystemColors.ButtonHighlight;
            btnReprint.Location = new Point(795, 712);
            btnReprint.Margin = new Padding(3, 2, 3, 2);
            btnReprint.Name = "btnReprint";
            btnReprint.Size = new Size(131, 38);
            btnReprint.TabIndex = 10;
            btnReprint.Text = "Re-Print [F4]";
            btnReprint.UseVisualStyleBackColor = false;
            btnReprint.Click += btnReprint_Click;
            // 
            // gbIndividualRecords
            // 
            gbIndividualRecords.Controls.Add(btnDailyDrAyesha);
            gbIndividualRecords.Controls.Add(btnDailyDrMinahil);
            gbIndividualRecords.Controls.Add(btnDailyDrZuhaib);
            gbIndividualRecords.Controls.Add(btnDailyDrTehreem);
            gbIndividualRecords.Controls.Add(btnDailyOther);
            gbIndividualRecords.Controls.Add(btnDailyDrJawad);
            gbIndividualRecords.Controls.Add(btnDailyDrHammad);
            gbIndividualRecords.Controls.Add(btnDailyDrFizza);
            gbIndividualRecords.Controls.Add(btnDailyDrZain);
            gbIndividualRecords.Controls.Add(btnDailyUSG);
            gbIndividualRecords.Controls.Add(btnDailyECG);
            gbIndividualRecords.Controls.Add(btnDailyOPD);
            gbIndividualRecords.Location = new Point(52, 400);
            gbIndividualRecords.Margin = new Padding(3, 2, 3, 2);
            gbIndividualRecords.Name = "gbIndividualRecords";
            gbIndividualRecords.Padding = new Padding(3, 2, 3, 2);
            gbIndividualRecords.Size = new Size(974, 123);
            gbIndividualRecords.TabIndex = 12;
            gbIndividualRecords.TabStop = false;
            gbIndividualRecords.Text = "Individual Records";
            // 
            // btnDailyDrMinahil
            // 
            btnDailyDrMinahil.BackColor = Color.WhiteSmoke;
            btnDailyDrMinahil.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrMinahil.FlatAppearance.BorderSize = 2;
            btnDailyDrMinahil.FlatStyle = FlatStyle.Flat;
            btnDailyDrMinahil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrMinahil.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrMinahil.Location = new Point(509, 68);
            btnDailyDrMinahil.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrMinahil.Name = "btnDailyDrMinahil";
            btnDailyDrMinahil.Size = new Size(131, 38);
            btnDailyDrMinahil.TabIndex = 38;
            btnDailyDrMinahil.Text = "Dr Minahil";
            btnDailyDrMinahil.UseVisualStyleBackColor = false;
            btnDailyDrMinahil.Click += btnDailyDrMinahil_Click;
            // 
            // btnDailyDrZuhaib
            // 
            btnDailyDrZuhaib.BackColor = Color.WhiteSmoke;
            btnDailyDrZuhaib.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZuhaib.FlatAppearance.BorderSize = 2;
            btnDailyDrZuhaib.FlatStyle = FlatStyle.Flat;
            btnDailyDrZuhaib.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrZuhaib.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZuhaib.Location = new Point(349, 68);
            btnDailyDrZuhaib.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrZuhaib.Name = "btnDailyDrZuhaib";
            btnDailyDrZuhaib.Size = new Size(131, 38);
            btnDailyDrZuhaib.TabIndex = 37;
            btnDailyDrZuhaib.Text = "Dr Zuhaib";
            btnDailyDrZuhaib.UseVisualStyleBackColor = false;
            btnDailyDrZuhaib.Click += btnDailyDrZuhaib_Click;
            // 
            // btnDailyDrTehreem
            // 
            btnDailyDrTehreem.BackColor = Color.WhiteSmoke;
            btnDailyDrTehreem.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrTehreem.FlatAppearance.BorderSize = 2;
            btnDailyDrTehreem.FlatStyle = FlatStyle.Flat;
            btnDailyDrTehreem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrTehreem.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrTehreem.Location = new Point(190, 68);
            btnDailyDrTehreem.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrTehreem.Name = "btnDailyDrTehreem";
            btnDailyDrTehreem.Size = new Size(131, 38);
            btnDailyDrTehreem.TabIndex = 36;
            btnDailyDrTehreem.Text = "Dr Tehreem";
            btnDailyDrTehreem.UseVisualStyleBackColor = false;
            btnDailyDrTehreem.Click += btnDailyDrTehreem_Click;
            // 
            // btnDailyOther
            // 
            btnDailyOther.BackColor = Color.WhiteSmoke;
            btnDailyOther.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyOther.FlatAppearance.BorderSize = 2;
            btnDailyOther.FlatStyle = FlatStyle.Flat;
            btnDailyOther.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyOther.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyOther.Location = new Point(825, 68);
            btnDailyOther.Margin = new Padding(3, 2, 3, 2);
            btnDailyOther.Name = "btnDailyOther";
            btnDailyOther.Size = new Size(131, 38);
            btnDailyOther.TabIndex = 35;
            btnDailyOther.Text = "Others";
            btnDailyOther.UseVisualStyleBackColor = false;
            btnDailyOther.Click += btnDailyOther_Click;
            // 
            // btnDailyDrJawad
            // 
            btnDailyDrJawad.BackColor = Color.WhiteSmoke;
            btnDailyDrJawad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrJawad.FlatAppearance.BorderSize = 2;
            btnDailyDrJawad.FlatStyle = FlatStyle.Flat;
            btnDailyDrJawad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrJawad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrJawad.Location = new Point(30, 68);
            btnDailyDrJawad.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrJawad.Name = "btnDailyDrJawad";
            btnDailyDrJawad.Size = new Size(131, 38);
            btnDailyDrJawad.TabIndex = 34;
            btnDailyDrJawad.Text = "Dr Jawad";
            btnDailyDrJawad.UseVisualStyleBackColor = false;
            btnDailyDrJawad.Click += btnDailyDrJawad_Click;
            // 
            // btnDailyDrHammad
            // 
            btnDailyDrHammad.BackColor = Color.WhiteSmoke;
            btnDailyDrHammad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrHammad.FlatAppearance.BorderSize = 2;
            btnDailyDrHammad.FlatStyle = FlatStyle.Flat;
            btnDailyDrHammad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrHammad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrHammad.Location = new Point(825, 20);
            btnDailyDrHammad.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrHammad.Name = "btnDailyDrHammad";
            btnDailyDrHammad.Size = new Size(131, 38);
            btnDailyDrHammad.TabIndex = 33;
            btnDailyDrHammad.Text = "Dr Hammad";
            btnDailyDrHammad.UseVisualStyleBackColor = false;
            btnDailyDrHammad.Click += btnDailyDrHammad_Click;
            // 
            // btnDailyDrFizza
            // 
            btnDailyDrFizza.BackColor = Color.WhiteSmoke;
            btnDailyDrFizza.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrFizza.FlatAppearance.BorderSize = 2;
            btnDailyDrFizza.FlatStyle = FlatStyle.Flat;
            btnDailyDrFizza.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrFizza.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrFizza.Location = new Point(666, 20);
            btnDailyDrFizza.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrFizza.Name = "btnDailyDrFizza";
            btnDailyDrFizza.Size = new Size(131, 38);
            btnDailyDrFizza.TabIndex = 32;
            btnDailyDrFizza.Text = "Dr Fizza";
            btnDailyDrFizza.UseVisualStyleBackColor = false;
            btnDailyDrFizza.Click += btnDailyDrFizza_Click;
            // 
            // btnDailyDrZain
            // 
            btnDailyDrZain.BackColor = Color.WhiteSmoke;
            btnDailyDrZain.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZain.FlatAppearance.BorderSize = 2;
            btnDailyDrZain.FlatStyle = FlatStyle.Flat;
            btnDailyDrZain.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrZain.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZain.Location = new Point(508, 20);
            btnDailyDrZain.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrZain.Name = "btnDailyDrZain";
            btnDailyDrZain.Size = new Size(131, 38);
            btnDailyDrZain.TabIndex = 31;
            btnDailyDrZain.Text = "Dr Zain";
            btnDailyDrZain.UseVisualStyleBackColor = false;
            btnDailyDrZain.Click += btnDailyDrZain_Click;
            // 
            // btnDailyUSG
            // 
            btnDailyUSG.BackColor = Color.WhiteSmoke;
            btnDailyUSG.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyUSG.FlatAppearance.BorderSize = 2;
            btnDailyUSG.FlatStyle = FlatStyle.Flat;
            btnDailyUSG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyUSG.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyUSG.Location = new Point(349, 20);
            btnDailyUSG.Margin = new Padding(3, 2, 3, 2);
            btnDailyUSG.Name = "btnDailyUSG";
            btnDailyUSG.Size = new Size(131, 38);
            btnDailyUSG.TabIndex = 30;
            btnDailyUSG.Text = "USG";
            btnDailyUSG.UseVisualStyleBackColor = false;
            btnDailyUSG.Click += btnDailyUSG_Click;
            // 
            // btnDailyECG
            // 
            btnDailyECG.BackColor = Color.WhiteSmoke;
            btnDailyECG.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyECG.FlatAppearance.BorderSize = 2;
            btnDailyECG.FlatStyle = FlatStyle.Flat;
            btnDailyECG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyECG.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyECG.Location = new Point(189, 20);
            btnDailyECG.Margin = new Padding(3, 2, 3, 2);
            btnDailyECG.Name = "btnDailyECG";
            btnDailyECG.Size = new Size(131, 38);
            btnDailyECG.TabIndex = 29;
            btnDailyECG.Text = "ECG";
            btnDailyECG.UseVisualStyleBackColor = false;
            btnDailyECG.Click += btnDailyECG_Click;
            // 
            // btnDailyOPD
            // 
            btnDailyOPD.BackColor = Color.WhiteSmoke;
            btnDailyOPD.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyOPD.FlatAppearance.BorderSize = 2;
            btnDailyOPD.FlatStyle = FlatStyle.Flat;
            btnDailyOPD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyOPD.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyOPD.Location = new Point(30, 20);
            btnDailyOPD.Margin = new Padding(3, 2, 3, 2);
            btnDailyOPD.Name = "btnDailyOPD";
            btnDailyOPD.Size = new Size(131, 38);
            btnDailyOPD.TabIndex = 28;
            btnDailyOPD.Text = "OPD";
            btnDailyOPD.UseVisualStyleBackColor = false;
            btnDailyOPD.Click += btnDailyOPD_Click;
            // 
            // btnDailyDrAyesha
            // 
            btnDailyDrAyesha.BackColor = Color.WhiteSmoke;
            btnDailyDrAyesha.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrAyesha.FlatAppearance.BorderSize = 2;
            btnDailyDrAyesha.FlatStyle = FlatStyle.Flat;
            btnDailyDrAyesha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrAyesha.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrAyesha.Location = new Point(666, 68);
            btnDailyDrAyesha.Margin = new Padding(3, 2, 3, 2);
            btnDailyDrAyesha.Name = "btnDailyDrAyesha";
            btnDailyDrAyesha.Size = new Size(131, 38);
            btnDailyDrAyesha.TabIndex = 39;
            btnDailyDrAyesha.Text = "Dr Ayesha";
            btnDailyDrAyesha.UseVisualStyleBackColor = false;
            btnDailyDrAyesha.Click += btnDailyDrAyesha_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1348, 687);
            Controls.Add(gbIndividualRecords);
            Controls.Add(btnCancel);
            Controls.Add(btnReprint);
            Controls.Add(grpMonthSummary);
            Controls.Add(grpTodaySummary);
            Controls.Add(labelHistoryPatient);
            Controls.Add(panelHistory);
            Controls.Add(dataGridHistory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(720, 576);
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
            gbIndividualRecords.ResumeLayout(false);
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
        private Label lblDrHammadSummary;
        private Label lblDrZainSummary;
        private Button btnPrintDaily;
        private Button btnPrintMonthly;
        private Label lblDrFizzaSummary;
        private Button btnCancel;
        private Button btnReprint;
        private GroupBox gbIndividualRecords;
        private Button btnDailyOther;
        private Button btnDailyDrJawad;
        private Button btnDailyDrHammad;
        private Button btnDailyDrFizza;
        private Button btnDailyDrZain;
        private Button btnDailyUSG;
        private Button btnDailyECG;
        private Button btnDailyOPD;
        private Label lblDrZuhaibSummary;
        private Label lblDrTehreemSummary;
        private Button btnDailyDrZuhaib;
        private Button btnDailyDrTehreem;
        private Label lblDrZuhaibSummaryMonth;
        private Label lblDrTehreemSummaryMonth;
        private Label lblDrFizzaSummaryMonth;
        private Label lblOthersSummaryMonth;
        private Label lblDrJawadSummaryMonth;
        private Label lblDrHammadSummaryMonth;
        private Label lblDrZainSummaryMonth;
        private Label lblEcgSummaryMonth;
        private Label lblUsgSummaryMonth;
        private Label lblOpdSummaryMonth;
        private Label lblDrMinahilSummary;
        private Label lblDrMinahilSummaryMonth;
        private Button btnDailyDrMinahil;
        private Label lblDrAyeshaSummary;
        private Label lblDrAyeshaSummaryMonth;
        private Button btnDailyDrAyesha;
    }
}