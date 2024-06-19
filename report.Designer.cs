namespace cosmesticClinic
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.label1 = new System.Windows.Forms.Label();
            this.chkDayReport = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbModeTreat = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbReveiced = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panDgv = new System.Windows.Forms.Panel();
            this.lblClinicName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(275, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILLING  REPORT";
            // 
            // chkDayReport
            // 
            this.chkDayReport.AutoSize = true;
            this.chkDayReport.Location = new System.Drawing.Point(9, 65);
            this.chkDayReport.Name = "chkDayReport";
            this.chkDayReport.Size = new System.Drawing.Size(118, 19);
            this.chkDayReport.TabIndex = 58;
            this.chkDayReport.Text = "Report of the Day";
            this.chkDayReport.UseVisualStyleBackColor = true;
            this.chkDayReport.CheckedChanged += new System.EventHandler(this.chkDayReport_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(638, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 19);
            this.radioButton1.TabIndex = 59;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Summary";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(726, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 19);
            this.radioButton2.TabIndex = 60;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Details";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.cmbModeTreat);
            this.panel1.Controls.Add(this.cmbDoctor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbReveiced);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 100);
            this.panel1.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Reveiced By";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(387, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(148, 23);
            this.dtpTo.TabIndex = 42;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(116, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(148, 23);
            this.dtpFrom.TabIndex = 41;
            // 
            // cmbModeTreat
            // 
            this.cmbModeTreat.BackColor = System.Drawing.SystemColors.Control;
            this.cmbModeTreat.FormattingEnabled = true;
            this.cmbModeTreat.Location = new System.Drawing.Point(116, 63);
            this.cmbModeTreat.Name = "cmbModeTreat";
            this.cmbModeTreat.Size = new System.Drawing.Size(148, 23);
            this.cmbModeTreat.TabIndex = 40;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(389, 63);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(148, 23);
            this.cmbDoctor.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "From Date";
            // 
            // cmbReveiced
            // 
            this.cmbReveiced.BackColor = System.Drawing.SystemColors.Control;
            this.cmbReveiced.FormattingEnabled = true;
            this.cmbReveiced.Items.AddRange(new object[] {
            "Administrator",
            "Staff",
            "Patient"});
            this.cmbReveiced.Location = new System.Drawing.Point(631, 63);
            this.cmbReveiced.Name = "cmbReveiced";
            this.cmbReveiced.Size = new System.Drawing.Size(148, 23);
            this.cmbReveiced.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Consulting Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mode of Treatment";
            // 
            // panDgv
            // 
            this.panDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panDgv.Controls.Add(this.lblClinicName);
            this.panDgv.Controls.Add(this.dataGridView1);
            this.panDgv.Location = new System.Drawing.Point(5, 257);
            this.panDgv.Name = "panDgv";
            this.panDgv.Size = new System.Drawing.Size(789, 289);
            this.panDgv.TabIndex = 62;
            // 
            // lblClinicName
            // 
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClinicName.Location = new System.Drawing.Point(308, 0);
            this.lblClinicName.Name = "lblClinicName";
            this.lblClinicName.Size = new System.Drawing.Size(166, 21);
            this.lblClinicName.TabIndex = 66;
            this.lblClinicName.Text = "Laser and Skin Clinic\r\n";
            this.lblClinicName.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(784, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(5, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 58);
            this.panel3.TabIndex = 63;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(552, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(278, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Print Preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(4, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 558);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chkDayReport);
            this.Controls.Add(this.label1);
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Information";
            this.Load += new System.EventHandler(this.report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panDgv.ResumeLayout(false);
            this.panDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox chkDayReport;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Label label5;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private ComboBox cmbModeTreat;
        private ComboBox cmbDoctor;
        private Label label4;
        private Label label7;
        private ComboBox cmbReveiced;
        private Label label3;
        private Label label2;
        private Panel panDgv;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button button1;
        private Button button3;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label lblClinicName;
    }
}