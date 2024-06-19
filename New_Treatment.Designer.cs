namespace cosmesticClinic
{
    partial class New_Treatment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTreatAreaMode = new System.Windows.Forms.ComboBox();
            this.dgvTreatMode = new System.Windows.Forms.DataGridView();
            this.btnSaveTreatMode = new System.Windows.Forms.Button();
            this.txtTreatNameMode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAreaofTretment = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTreatArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatMode)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaofTretment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(572, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mode of Treatment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtCostPrice);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbTreatAreaMode);
            this.panel5.Controls.Add(this.dgvTreatMode);
            this.panel5.Controls.Add(this.btnSaveTreatMode);
            this.panel5.Controls.Add(this.txtTreatNameMode);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(552, 490);
            this.panel5.TabIndex = 66;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 80;
            this.label3.Text = "Area of Treatment";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(13, 142);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(285, 23);
            this.txtCostPrice.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Cost Per Visit";
            // 
            // cmbTreatAreaMode
            // 
            this.cmbTreatAreaMode.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTreatAreaMode.FormattingEnabled = true;
            this.cmbTreatAreaMode.Items.AddRange(new object[] {
            "Single",
            "Dating",
            "Married",
            "Divorce"});
            this.cmbTreatAreaMode.Location = new System.Drawing.Point(13, 89);
            this.cmbTreatAreaMode.Name = "cmbTreatAreaMode";
            this.cmbTreatAreaMode.Size = new System.Drawing.Size(285, 23);
            this.cmbTreatAreaMode.TabIndex = 76;
            // 
            // dgvTreatMode
            // 
            this.dgvTreatMode.AllowUserToAddRows = false;
            this.dgvTreatMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatMode.Location = new System.Drawing.Point(13, 179);
            this.dgvTreatMode.Name = "dgvTreatMode";
            this.dgvTreatMode.RowHeadersVisible = false;
            this.dgvTreatMode.RowTemplate.Height = 25;
            this.dgvTreatMode.Size = new System.Drawing.Size(525, 290);
            this.dgvTreatMode.TabIndex = 75;
            // 
            // btnSaveTreatMode
            // 
            this.btnSaveTreatMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveTreatMode.Location = new System.Drawing.Point(345, 82);
            this.btnSaveTreatMode.Name = "btnSaveTreatMode";
            this.btnSaveTreatMode.Size = new System.Drawing.Size(123, 34);
            this.btnSaveTreatMode.TabIndex = 74;
            this.btnSaveTreatMode.Text = "Save";
            this.btnSaveTreatMode.UseVisualStyleBackColor = true;
            this.btnSaveTreatMode.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTreatNameMode
            // 
            this.txtTreatNameMode.Location = new System.Drawing.Point(13, 37);
            this.txtTreatNameMode.Name = "txtTreatNameMode";
            this.txtTreatNameMode.Size = new System.Drawing.Size(285, 23);
            this.txtTreatNameMode.TabIndex = 73;
            this.txtTreatNameMode.TextChanged += new System.EventHandler(this.txtVisit_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(13, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 72;
            this.label13.Text = "Treatment Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Area of Treatment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvAreaofTretment);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTreatArea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 488);
            this.panel1.TabIndex = 67;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvAreaofTretment
            // 
            this.dgvAreaofTretment.AllowUserToAddRows = false;
            this.dgvAreaofTretment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAreaofTretment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAreaofTretment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaofTretment.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAreaofTretment.Location = new System.Drawing.Point(13, 118);
            this.dgvAreaofTretment.Name = "dgvAreaofTretment";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreaofTretment.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAreaofTretment.RowHeadersVisible = false;
            this.dgvAreaofTretment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAreaofTretment.RowTemplate.Height = 25;
            this.dgvAreaofTretment.Size = new System.Drawing.Size(525, 359);
            this.dgvAreaofTretment.TabIndex = 75;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(359, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 74;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTreatArea
            // 
            this.txtTreatArea.Location = new System.Drawing.Point(27, 62);
            this.txtTreatArea.Name = "txtTreatArea";
            this.txtTreatArea.Size = new System.Drawing.Size(257, 23);
            this.txtTreatArea.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Area Name";
            // 
            // New_Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "New_Treatment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Treatment";
            this.Load += new System.EventHandler(this.New_Treatment_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatMode)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaofTretment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel5;
        private TextBox txtTreatNameMode;
        private Label label13;
        private Button btnSaveTreatMode;
        private DataGridView dgvTreatMode;
        private Panel panel1;
        private DataGridView dgvAreaofTretment;
        private Button button1;
        private TextBox txtTreatArea;
        private Label label1;
        private Label label3;
        private TextBox txtCostPrice;
        private Label label2;
        private ComboBox cmbTreatAreaMode;
    }
}