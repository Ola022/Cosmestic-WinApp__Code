namespace cosmesticClinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void utToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                patientRegistration Registration = new patientRegistration();
                Registration.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPatientBilling_Click(object sender, EventArgs e)
        {
            try
            {
                Billing billing = new Billing(0);
                billing.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                patientSerach patientSerach = new patientSerach();
                patientSerach.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBillReport_Click(object sender, EventArgs e)
        {
            try
            {
                report report = new report();
                report.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            try
            {

                Appointments appointments = new Appointments();
                appointments.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReg_MouseHover(object sender, EventArgs e)
        {
            setTooltips(sender, "Register Patient");
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            
            setTooltips(sender, "Search Patient");

        }

        private void btnBillReport_MouseHover(object sender, EventArgs e)
        {            
            setTooltips(sender, "Billing Report");

        }

        private void btnAppointment_MouseHover(object sender, EventArgs e)
        {
            setTooltips(sender, "Appointment");
        }

        private void btnPatientBilling_MouseHover(object sender, EventArgs e)
        {            
            setTooltips(sender, "Patient Billing");
        }

        private void btnTreatmentMode_Click(object sender, EventArgs e)
        {
            try {
                New_Treatment treat = new New_Treatment();
                treat.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTreatmentMode_MouseHover(object sender, EventArgs e)
        {
            setTooltips(sender, "Add New Treatment ");
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctors doc = new Doctors();
            doc.ShowDialog();
        }

        private void btnDoctors_MouseHover(object sender, EventArgs e)
        {
            setTooltips(sender, "Doctor ");
        }

        void setTooltips(object btnSender, string tip)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            if (btnSender != null)
                toolTip1.SetToolTip((Button)btnSender, tip);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are Sure you want Exist", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are Sure you want Exist", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}