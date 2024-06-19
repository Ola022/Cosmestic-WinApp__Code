namespace cosmesticClinic
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clinicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnTreatmentMode = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnBillReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPatientBilling = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clinicToolStripMenuItem,
            this.utToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // clinicToolStripMenuItem
            // 
            this.clinicToolStripMenuItem.Name = "clinicToolStripMenuItem";
            this.clinicToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.clinicToolStripMenuItem.Text = "Clinic";
            // 
            // utToolStripMenuItem
            // 
            this.utToolStripMenuItem.Name = "utToolStripMenuItem";
            this.utToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.utToolStripMenuItem.Text = "Utlities";
            this.utToolStripMenuItem.Click += new System.EventHandler(this.utToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.closeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Controls.Add(this.btnTreatmentMode);
            this.panel1.Controls.Add(this.btnAppointment);
            this.panel1.Controls.Add(this.btnBillReport);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnPatientBilling);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 97);
            this.panel1.TabIndex = 1;
            // 
            // btnDoctors
            // 
            this.btnDoctors.Image = global::cosmesticClinic.Properties.Resources.adddoctor;
            this.btnDoctors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoctors.Location = new System.Drawing.Point(554, 5);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(81, 85);
            this.btnDoctors.TabIndex = 6;
            this.btnDoctors.Text = "\r\nDoctors";
            this.btnDoctors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoctors.UseVisualStyleBackColor = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            this.btnDoctors.MouseHover += new System.EventHandler(this.btnDoctors_MouseHover);
            // 
            // btnTreatmentMode
            // 
            this.btnTreatmentMode.Image = global::cosmesticClinic.Properties.Resources.addtreat1;
            this.btnTreatmentMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTreatmentMode.Location = new System.Drawing.Point(456, 7);
            this.btnTreatmentMode.Name = "btnTreatmentMode";
            this.btnTreatmentMode.Size = new System.Drawing.Size(88, 85);
            this.btnTreatmentMode.TabIndex = 5;
            this.btnTreatmentMode.Text = "Treatment";
            this.btnTreatmentMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTreatmentMode.UseVisualStyleBackColor = true;
            this.btnTreatmentMode.Click += new System.EventHandler(this.btnTreatmentMode_Click);
            this.btnTreatmentMode.MouseHover += new System.EventHandler(this.btnTreatmentMode_MouseHover);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Image = global::cosmesticClinic.Properties.Resources.appoint;
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAppointment.Location = new System.Drawing.Point(359, 7);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(88, 85);
            this.btnAppointment.TabIndex = 4;
            this.btnAppointment.Text = "\r\nAppointment";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            this.btnAppointment.MouseHover += new System.EventHandler(this.btnAppointment_MouseHover);
            // 
            // btnBillReport
            // 
            this.btnBillReport.Image = global::cosmesticClinic.Properties.Resources.view_report;
            this.btnBillReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBillReport.Location = new System.Drawing.Point(272, 7);
            this.btnBillReport.Name = "btnBillReport";
            this.btnBillReport.Size = new System.Drawing.Size(81, 85);
            this.btnBillReport.TabIndex = 3;
            this.btnBillReport.Text = "\r\nBill Report";
            this.btnBillReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBillReport.UseVisualStyleBackColor = true;
            this.btnBillReport.Click += new System.EventHandler(this.btnBillReport_Click);
            this.btnBillReport.MouseHover += new System.EventHandler(this.btnBillReport_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::cosmesticClinic.Properties.Resources.search_user;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(185, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 85);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "\r\nSearch";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnPatientBilling
            // 
            this.btnPatientBilling.Image = global::cosmesticClinic.Properties.Resources.invoice;
            this.btnPatientBilling.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientBilling.Location = new System.Drawing.Point(98, 7);
            this.btnPatientBilling.Name = "btnPatientBilling";
            this.btnPatientBilling.Size = new System.Drawing.Size(81, 85);
            this.btnPatientBilling.TabIndex = 1;
            this.btnPatientBilling.Text = "Billing";
            this.btnPatientBilling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientBilling.UseVisualStyleBackColor = true;
            this.btnPatientBilling.Click += new System.EventHandler(this.btnPatientBilling_Click);
            this.btnPatientBilling.MouseHover += new System.EventHandler(this.btnPatientBilling_MouseHover);
            // 
            // btnReg
            // 
            this.btnReg.Image = global::cosmesticClinic.Properties.Resources.report2;
            this.btnReg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReg.Location = new System.Drawing.Point(11, 7);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(81, 85);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "\r\nRegistration\r\n";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.button1_Click);
            this.btnReg.MouseHover += new System.EventHandler(this.btnReg_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::cosmesticClinic.Properties.Resources.Attachment_1640965854;
            this.pictureBox1.Location = new System.Drawing.Point(413, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laser and Skin Clinic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 646);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laser and Skin Clinic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clinicToolStripMenuItem;
        private ToolStripMenuItem utToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Button btnAppointment;
        private Button btnBillReport;
        private Button btnSearch;
        private Button btnPatientBilling;
        private Button btnReg;
        private Button btnTreatmentMode;
        private Button btnDoctors;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
    }
}