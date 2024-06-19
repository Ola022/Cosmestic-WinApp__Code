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
    public partial class New_Treatment : Form
    {
        public New_Treatment()
        {
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        private void txtVisit_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Treatment_Load(object sender, EventArgs e)
        {
            getInfo();
        }
        void getInfo()
        {
            getTreatmentArea();
            getAllTreatmentArea();
            getTreatmentMode();
        }
        public void getTreatmentArea()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                string details = "SELECT (id) as [ID],(treatmentarea) as [Area of Treatment] from tbl_treatment_area'";

                OleDbCommand cmd = new OleDbCommand(details, con);
                //OleDbCommand cmd = new OleDbCommand("select * from tbl_users", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dgvAreaofTretment.DataSource = myDS.Tables["clinic"].DefaultView;
                if (dgvAreaofTretment.Rows.Count > 0)
                {
                    dgvAreaofTretment.Columns[0].Visible = false;
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
        public void getTreatmentMode()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                string details = "SELECT (id) as [ID], (treatmentmode) as [Mode of Treatment], (treatmentarea) as [Area of Treatment], (costpervisit) as [Cost per Visit], (costeffectivedate) as [Cost Effective Date] from tbl_treatment_mode'";

                OleDbCommand cmd = new OleDbCommand(details, con);
                //OleDbCommand cmd = new OleDbCommand("select * from tbl_users", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dgvTreatMode.DataSource = myDS.Tables["clinic"].DefaultView;
                //if (dgvTreatMode.Rows.Count > 0)
                //{
                    dgvTreatMode.Columns[0].Visible = false;
               // }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmbTreatAreaMode.ValueMember = "id";
                cmbTreatAreaMode.DisplayMember = "treatmentarea";
                cmbTreatAreaMode.DataSource = dt;

                con.Close();
            }

            catch (System.Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTreatArea.Text == "")
            {
                MessageBox.Show("Please fill all the Treatment Mode field ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection(conStr);
                    con.Open();
                    OleDbDataReader dr;
                    OleDbCommand cmd = new OleDbCommand();

                    cmd.CommandText = @"insert into tbl_treatment_area ([treatmentarea]) VALUES('" + txtTreatArea.Text + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Operation Sucessfull!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTreatArea.Text = String.Empty;
                    getInfo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation Not Sucessfull! " + ex.Message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTreatNameMode.Text == "" || txtCostPrice.Text == "" || cmbTreatAreaMode.Text == "-- Select Treatment Area  --")
            {
                MessageBox.Show("Please fill all the field ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection(conStr);
                    con.Open();
                    OleDbDataReader dr;
                    OleDbCommand cmd = new OleDbCommand();
                    DateTime dt = DateTime.Now;
                    var date = dt.ToString("yyyy-MM-dd");
                    cmd.CommandText = @"insert into tbl_treatment_mode ([treatmentmode], [treatmentarea], [costpervisit], [costeffectivedate], [treatmentareaid] ) VALUES('" +
                        txtTreatNameMode.Text + "','" + cmbTreatAreaMode.Text + "','" +txtCostPrice.Text + "','" + date +"','" + cmbTreatAreaMode.SelectedValue + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Operation Sucessfull!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTreatNameMode.Text = "" ;
                    txtCostPrice.Text = "" ;
                    getInfo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation Not Sucessfull! " + ex.Message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
