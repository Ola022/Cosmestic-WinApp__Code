using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cosmesticClinic
{
    public partial class Billing : Form
    {

        int _MR_No;
        public Billing(int _No)
        {
            _MR_No = _No;
            InitializeComponent();
        }
        string phone = "";
        string fullname = "";
        private string conStr = connectionString.constr;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Billing_Load(object sender, EventArgs e)
        {
            numMRNo.Value = _MR_No;
            getAllDoctors();
            getAllTreatmentMode();
            getAllTreatmentArea();
        }

        public void getAllTreatmentMode()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter("Select * From tbl_treatment_mode ", con);
                dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["treatmentmode"] = "-- Select Treatment Mode  --";
                dt.Rows.InsertAt(dr, 0);
                cmbTreatment.ValueMember = "id";
                cmbTreatment.DisplayMember = "treatmentmode";
                cmbTreatment.DataSource = dt;

                con.Close();
            }

            catch (System.Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void getAllTreatmentArea()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter("Select * From tbl_treatment_area ", con);
                dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["treatmentarea"] = "-- Select Treatment Area  --";
                dt.Rows.InsertAt(dr, 0);
                cmbTreatArea.ValueMember = "id";
                cmbTreatArea.DisplayMember = "treatmentarea";
                cmbTreatArea.DataSource = dt;

                con.Close();
            }

            catch (System.Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void getAllDoctors()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                OleDbDataAdapter da;
                DataTable dt;
                da = new OleDbDataAdapter("Select * From tbl_doctor ", con);
                dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["description"] = "-- Select Doctor  --";
                dt.Rows.InsertAt(dr, 0);
                cmbDoctor.ValueMember = "id";
                cmbDoctor.DisplayMember = "description";
                cmbDoctor.DataSource = dt;

                con.Close();
            }

            catch (System.Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        bool checkMrNo()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(conStr);
                OleDbDataReader read;
                con.Open();

                string details = @"SELECT * from tbl_users WHERE mrno='" + numMRNo.Text + "'";
                OleDbCommand cmd = new OleDbCommand(details, con);
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    fullname = Convert.ToString(read["fullname"]);
                    phone = Convert.ToString(read["phone"]);
                    con.Close();
                    return true;

                }
                else
                {
                    con.Close();
                    MessageBox.Show("No Record Found with MR No " + numMRNo.Text, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

}

        bool checkBiilling()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(conStr);
                OleDbDataReader read;
                con.Open();

                string details = "SELECT * from tbl_patient_billing WHERE mrno='" + numMRNo.Text + "'";
                OleDbCommand cmd = new OleDbCommand(details, con);
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    con.Close();
                    return true;

                }
                else
                {
                    con.Close();
                    MessageBox.Show("No Record Found with MR No " + numMRNo.Text, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(numMRNo.Value == 0 || numMRNo.Text == "")
            {
                MessageBox.Show("Please enter the patient MR No(MR Number) ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ( numericUpDown1.Text == "" || cmbDoctor.Text == "" || cmbRecievedBy.Text == "" || cmbTreatArea.Text == "" || cmbTreatment.Text == "" || txtAmountPaid.Text == "" || txtBalance.Text == "" || txtCostPerVisit.Text == "" || txtReceiptNo.Text == "" || txtToPay.Text == "" || txtVisitNo.Text == "")
            {
                MessageBox.Show("Please fill all the compulsory field ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkMrNo())
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection(conStr);
                        con.Open();
                        OleDbDataReader dr;
                        OleDbCommand cmd = new OleDbCommand();
                        var date = dtpBillingDate.Value.ToString("yyyy-MM-dd");


                        cmd.CommandText = @"insert into tbl_patient_billing ([amount], [balance], [billingdate], [costprice], [receiptno], [amomunttopay], [visitno], [discount], [consultingdoctor], [receivedby], [treatmentarea], [treatment], [mrno], [fullname], [phone]) VALUES('"
                            + txtAmountPaid.Text + "','" + txtBalance.Text + "','" + date + "','" + txtCostPerVisit.Text + "','" + txtReceiptNo.Text + "','" + txtToPay.Text + "','" + txtVisitNo.Text + "','"
                            + numericUpDown1.Text + "','" + cmbDoctor.Text + "','" + cmbRecievedBy.Text + "','" + cmbTreatArea.Text + "','" + cmbTreatment.Text + "','" + numMRNo.Text + "','" + fullname + "','" + phone + "')";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        int reader;
                        string stmt = "UPDATE tbl_users SET modeoftreatment='" + cmbTreatment.Text + "',consultingdoctor ='" + cmbDoctor.Text + "' ,totalvisiting ='" + txtVisitNo.Text + "' WHERE mrno='" + numMRNo.Text + "'";
                        OleDbCommand cmdd = new OleDbCommand(stmt, con);
                        reader = cmdd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Operation Sucessfull!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (chkAutoPrint.Checked)
                        {
                            printInvoice printInvoice = new printInvoice(Convert.ToInt32(numMRNo.Value), "Print");
                            printInvoice.ShowDialog();
                        }
                       // this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Operation Not Sucessfull! " + ex.Message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (checkBiilling())
            {
                printInvoice printInvoice = new printInvoice(Convert.ToInt32(numMRNo.Value), "Print");
                printInvoice.ShowDialog();
            }
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            if (checkBiilling())
            {
                printInvoice printInvoice = new printInvoice(Convert.ToInt32(numMRNo.Value), "Print");
                printInvoice.ShowDialog();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (checkBiilling())
            {
                printInvoice printInvoice = new printInvoice(Convert.ToInt32(numMRNo.Value), "");
                printInvoice.ShowDialog();
            }
        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTreatment.Text != "-- Select Treatment Mode  --")
            {
                OleDbConnection con = new OleDbConnection(conStr);
                con.Open();
                try
                {
                    OleDbDataAdapter da;
                    DataTable dt;
                    da = new OleDbDataAdapter("Select * From tbl_treatment_mode  WHERE treatmentmode='" + cmbTreatment.Text + "'", con);
                    dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["treatmentarea"] = "-- Select Treatment Area  --";
                    dt.Rows.InsertAt(dr, 0);
                    cmbTreatArea.ValueMember = "id";
                    cmbTreatArea.DisplayMember = "treatmentarea";
                    cmbTreatArea.DataSource = dt;
                    txtToPay.Text = "";
                    con.Close();
                }

                catch (System.Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void cmbTreatArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTreatArea.Text != "-- Select Treatment Area  --")
            {
                try
                {
                    OleDbConnection con = new OleDbConnection(conStr);
                    OleDbDataReader read;
                    con.Open();

                    string details = "SELECT * from tbl_treatment_mode WHERE treatmentmode='" + cmbTreatment.Text + "' and treatmentarea='" + cmbTreatArea.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(details, con);
                    read = cmd.ExecuteReader();

                    if (read.Read() == true)
                    {
                        txtCostPerVisit.Text = Convert.ToString(read["costpervisit"]);
                        if(txtVisitNo.Text != "")
                            txtToPay.Text = (Convert.ToInt32(txtCostPerVisit.Text) * Convert.ToInt32(txtVisitNo.Text)).ToString();
                        con.Close();
                        discount();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Record not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtVisitNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTreatArea.Text != "-- Select Treatment Area  --" && cmbTreatment.Text != "-- Select Treatment Mode  --")
                {
                    if (txtVisitNo.Text != "")
                        txtToPay.Text = (Convert.ToInt32(txtCostPerVisit.Text) * Convert.ToInt32(txtVisitNo.Text)).ToString();

                    if (txtCostPerVisit.Text != "" && txtVisitNo.Text != "" && txtAmountPaid.Text != "")
                    {
                        txtBalance.Text = (((Convert.ToInt32(txtVisitNo.Text) * Convert.ToInt32(txtCostPerVisit.Text))
                            - numericUpDown1.Value) - Convert.ToInt32(txtAmountPaid.Text)).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  Input" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void discount()
        {
            try
            {
                if (txtToPay.Text != "")
                {
                    txtAmountPaid.Text = (Convert.ToInt32(txtToPay.Text) - numericUpDown1.Value).ToString();
                }
                if (numericUpDown1.Value == 0)
                    txtAmountPaid.Text = txtToPay.Text;

                if (txtCostPerVisit.Text != "" && txtVisitNo.Text != "" && txtAmountPaid.Text != "")
                {
                    txtBalance.Text = (((Convert.ToInt32(txtVisitNo.Text) * Convert.ToInt32(txtCostPerVisit.Text))
                        - numericUpDown1.Value) - Convert.ToInt32(txtAmountPaid.Text)).ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid  Input" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            discount();
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            discount();
        }

        private void numericUpDown1_Scroll(object sender, ScrollEventArgs e)
        {
            discount();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCostPerVisit.Text != "" && txtVisitNo.Text != "" && txtAmountPaid.Text != "")
                {
                    txtBalance.Text = (((Convert.ToInt32(txtVisitNo.Text) * Convert.ToInt32(txtCostPerVisit.Text))
                        - numericUpDown1.Value)  - Convert.ToInt32(txtAmountPaid.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
