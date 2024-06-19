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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
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

                    cmd.CommandText = @"insert into tbl_doctor ([description]) VALUES('" + txtDescription.Text + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Operation Sucessfull!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescription.Text = String.Empty;
                    getAllTreatmentArea();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation Not Sucessfull! " + ex.Message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public void getAllTreatmentArea()
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
                
                dt.Rows.InsertAt(dr, 0);
                ltbDescription.ValueMember = "id";
                ltbDescription.DisplayMember = "description";
                ltbDescription.DataSource = dt;

                con.Close();
            }

            catch (System.Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            getAllTreatmentArea();
        }
    }
}
