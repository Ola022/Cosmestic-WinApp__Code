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
    public partial class patientSerach : Form
    {
        public patientSerach()
        {
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        private void patientSerach_Load(object sender, EventArgs e)
        {
            getAllPatient();
            getAllTreatmentMode();
            getAllDoctors();
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in panel1.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = String.Empty;
                }
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
            getAllPatient();
        }

        //if (Regex.IsMatch(numQtyy.Text, "[^0-9]"))
        //  {
        //      MessageBox.Show("Please enter only numbers.");
        //      numQtyy.Text = numQtyy.Text.Remove(numQtyy.Text.Length - 1);
        //      numQtyy.Select(); // = numQtyy.Text.Length;
        //  }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtPhone.Text = txtPhone.Text.Trim();
            cmbDoctor.Text = cmbDoctor.Text.Trim();
            cmbTreatment.Text = cmbTreatment.Text.Trim();

            try
            {
                OleDbConnection con = new OleDbConnection(conStr);
                con.Open();
                string details = "SELECT (id) as [ID],(mrno) as [MR No],(totalvisiting) as [Visit No], (fullname) as [Name], (age) as [Age], (sex) as [Sex], (address) as [Address], (phone) as [Phone No], (modeoftreatment) as [Mode of Treatment], (consultingdoctor) as [Consulting Doctor] from tbl_users WHERE fullname='"
                    + txtName.Text + "'and phone='" + txtPhone.Text + "'and modeoftreatment='" + cmbTreatment.Text + "'and consultingdoctor='" + cmbDoctor.Text + "'";

                OleDbCommand cmd = new OleDbCommand(details, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dataGridView2.DataSource = myDS.Tables["clinic"].DefaultView;
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Record found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        public void getAllPatient()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                string details = "SELECT (id) as [ID],(mrno) as [MR No],(totalvisiting) as [Visit No], (fullname) as [Name], (age) as [Age], (sex) as [Sex], (address) as [Address], (phone) as [Phone No], (modeoftreatment) as [Mode of Treatment], (consultingdoctor) as [Consulting Doctor] from tbl_users ";
                OleDbCommand cmd = new OleDbCommand(details, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dataGridView2.DataSource = myDS.Tables["clinic"].DefaultView;
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Columns[0].Visible = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // txtPhone.Text = "";
            getPatientBySearch("fullname", txtName.Text);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            // txtName.Text = "";
            getPatientBySearch("phone", txtPhone.Text);
        }

        public void getPatientBySearch(string words, string text)
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                string details = string.Format("SELECT (id) as [ID],(mrno) as [MR No],(totalvisiting) as [Visit No], (fullname) as [Name], (age) as [Age], (sex) as [Sex], (address) as [Address], (phone) as [Phone No], (modeoftreatment) as [Mode of Treatment]," +
                    " (consultingdoctor) as [Consulting Doctor] from tbl_users WHERE {0} LIKE '{1}%'", words, text);

                OleDbCommand cmd = new OleDbCommand(details, con);
                //OleDbCommand cmd = new OleDbCommand("select * from tbl_users", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dataGridView2.DataSource = myDS.Tables["clinic"].DefaultView;
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Columns[0].Visible = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTreatment.Text != "-- Select Treatment Mode  --")
            {
                getPatientBySearch("modeoftreatment", cmbTreatment.Text);
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.Text != "-- Select Doctor  --")
            {
                getPatientBySearch("consultingdoctor", cmbDoctor.Text);
            }
        }
    }
}
