namespace cosmesticClinic
{
    partial class Billing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.cmbTreatArea = new System.Windows.Forms.ComboBox();
            this.numMRNo = new System.Windows.Forms.NumericUpDown();
            this.txtVisitNo = new System.Windows.Forms.TextBox();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtpBillingDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.chkAutoPrint = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRePrint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbRecievedBy = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCostPerVisit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMRNo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbTreatment);
            this.panel1.Controls.Add(this.cmbTreatArea);
            this.panel1.Controls.Add(this.numMRNo);
            this.panel1.Controls.Add(this.txtVisitNo);
            this.panel1.Controls.Add(this.txtReceiptNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbDoctor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 100);
            this.panel1.TabIndex = 1;
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(78, 63);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(148, 23);
            this.cmbTreatment.TabIndex = 40;
            this.cmbTreatment.SelectedIndexChanged += new System.EventHandler(this.cmbTreatment_SelectedIndexChanged);
            // 
            // cmbTreatArea
            // 
            this.cmbTreatArea.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTreatArea.FormattingEnabled = true;
            this.cmbTreatArea.Location = new System.Drawing.Point(354, 61);
            this.cmbTreatArea.Name = "cmbTreatArea";
            this.cmbTreatArea.Size = new System.Drawing.Size(148, 23);
            this.cmbTreatArea.TabIndex = 39;
            this.cmbTreatArea.SelectedIndexChanged += new System.EventHandler(this.cmbTreatArea_SelectedIndexChanged);
            // 
            // numMRNo
            // 
            this.numMRNo.Location = new System.Drawing.Point(78, 21);
            this.numMRNo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMRNo.Name = "numMRNo";
            this.numMRNo.Size = new System.Drawing.Size(148, 23);
            this.numMRNo.TabIndex = 38;
            // 
            // txtVisitNo
            // 
            this.txtVisitNo.Location = new System.Drawing.Point(631, 19);
            this.txtVisitNo.Name = "txtVisitNo";
            this.txtVisitNo.Size = new System.Drawing.Size(148, 23);
            this.txtVisitNo.TabIndex = 37;
            this.txtVisitNo.TextChanged += new System.EventHandler(this.txtVisitNo_TextChanged);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(354, 18);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(148, 23);
            this.txtReceiptNo.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Receipt No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Visit No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "MR No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Area of Treatment";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(631, 63);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(148, 23);
            this.cmbDoctor.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Consulting Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Treatment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(313, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT BILLING ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(4, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 52);
            this.panel2.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(632, 14);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(148, 23);
            this.textBox8.TabIndex = 39;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(283, 14);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(339, 23);
            this.textBox7.TabIndex = 38;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(173, 14);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(104, 23);
            this.textBox6.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 23);
            this.textBox3.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.dtpBillingDate);
            this.panel3.Controls.Add(this.txtAmountPaid);
            this.panel3.Controls.Add(this.chkAutoPrint);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtToPay);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cmbRecievedBy);
            this.panel3.Controls.Add(this.txtBalance);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCostPerVisit);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(4, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 263);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 60;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numericUpDown1_Scroll);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // dtpBillingDate
            // 
            this.dtpBillingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBillingDate.Location = new System.Drawing.Point(410, 114);
            this.dtpBillingDate.Name = "dtpBillingDate";
            this.dtpBillingDate.Size = new System.Drawing.Size(120, 23);
            this.dtpBillingDate.TabIndex = 59;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(410, 67);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(120, 23);
            this.txtAmountPaid.TabIndex = 58;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            // 
            // chkAutoPrint
            // 
            this.chkAutoPrint.AutoSize = true;
            this.chkAutoPrint.Location = new System.Drawing.Point(410, 220);
            this.chkAutoPrint.Name = "chkAutoPrint";
            this.chkAutoPrint.Size = new System.Drawing.Size(80, 19);
            this.chkAutoPrint.TabIndex = 57;
            this.chkAutoPrint.Text = "Auto Print";
            this.chkAutoPrint.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnRePrint);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnRegistration);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(578, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 216);
            this.panel4.TabIndex = 56;
            // 
            // btnRePrint
            // 
            this.btnRePrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRePrint.Location = new System.Drawing.Point(21, 170);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(133, 28);
            this.btnRePrint.TabIndex = 8;
            this.btnRePrint.Text = "Re-Print";
            this.btnRePrint.UseVisualStyleBackColor = true;
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Location = new System.Drawing.Point(21, 119);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 28);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Location = new System.Drawing.Point(21, 68);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(133, 28);
            this.btnRegistration.TabIndex = 6;
            this.btnRegistration.Text = "Preview";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(21, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Billing Date";
            // 
            // txtToPay
            // 
            this.txtToPay.Location = new System.Drawing.Point(410, 23);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(120, 23);
            this.txtToPay.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "To Be Paid";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(299, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 48;
            this.label15.Text = "Amount Paid";
            // 
            // cmbRecievedBy
            // 
            this.cmbRecievedBy.BackColor = System.Drawing.SystemColors.Control;
            this.cmbRecievedBy.FormattingEnabled = true;
            this.cmbRecievedBy.Items.AddRange(new object[] {
            "Administrator",
            "Staff",
            "Patient"});
            this.cmbRecievedBy.Location = new System.Drawing.Point(139, 164);
            this.cmbRecievedBy.Name = "cmbRecievedBy";
            this.cmbRecievedBy.Size = new System.Drawing.Size(120, 23);
            this.cmbRecievedBy.TabIndex = 47;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(139, 121);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(120, 23);
            this.txtBalance.TabIndex = 46;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Recieved By";
            // 
            // txtCostPerVisit
            // 
            this.txtCostPerVisit.Enabled = false;
            this.txtCostPerVisit.Location = new System.Drawing.Point(139, 27);
            this.txtCostPerVisit.Name = "txtCostPerVisit";
            this.txtCostPerVisit.Size = new System.Drawing.Size(120, 23);
            this.txtCostPerVisit.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Cost Per Visit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Discount";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMRNo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtVisitNo;
        private TextBox txtReceiptNo;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private ComboBox cmbDoctor;
        private Label label3;
        private Label label2;
        private NumericUpDown numMRNo;
        private ComboBox cmbTreatArea;
        private Panel panel2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox3;
        private Panel panel3;
        private Label label12;
        private TextBox txtToPay;
        private Label label14;
        private Label label15;
        private ComboBox cmbRecievedBy;
        private TextBox txtBalance;
        private Label label10;
        private Label label11;
        private TextBox txtCostPerVisit;
        private Label label8;
        private Label label9;
        private CheckBox chkAutoPrint;
        private Panel panel4;
        private Button btnRePrint;
        private Button btnPrint;
        private Button btnRegistration;
        private Button btnSave;
        private ComboBox cmbTreatment;
        private TextBox txtAmountPaid;
        private DateTimePicker dtpBillingDate;
        private NumericUpDown numericUpDown1;
    }
}