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
    public partial class patientRegistration : Form
    {
        public patientRegistration()
        {
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        string mrno;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        void checkMrNo()
        {
            try
            {
                List<int> termsList = new List<int>();
                OleDbConnection con = new OleDbConnection(conStr);
                OleDbDataReader read;
                OleDbCommand command;
                
                con.Open();

                string scan = "SELECT mrno from tbl_users";
                command= new OleDbCommand(scan, con);
                read = command.ExecuteReader();
                int i = 1;
                while (read.Read())
                {
                    termsList.Add(Convert.ToInt32(read["mrno"]));
                }
                if (termsList.Count > 0)
                {
                    mrno = (termsList.Max() + 1).ToString();
                    txtMR.Text = mrno;
                }
                else
                {
                    mrno = "1";
                    txtMR.Text = mrno;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (var c in panReg.Controls)
            //{
            //    //if (c is ComboBox)
            //    //{
            //    //    ((ComboBox)c).Text = String.Empty;
            //    //}
            //    if (c is TextBox || c is ComboBox)
            //    {
            //        if(((TextBox)c).Text == String.Empty || ((ComboBox)c).Text == String.Empty)
            //        {
            //            MessageBox.Show("Please fill all the compulsory field ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        }
            //    }
            //}
            if (txtAddress.Text == "" || txtAge.Text == "" || txtMR.Text == "" || txtName.Text == "" || txtOccupation.Text == "" || txtPhone.Text == "" || cmbMarital.Text == "")
            {
                MessageBox.Show("Please fill all the compulsory field ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sex = "";
                if (rdbFemale.Checked)
                {
                    sex = "Female";
                }

                if (rdbMale.Checked)
                {
                    sex = "Male";
                }
                try
                {
                    checkMrNo();
                    OleDbConnection con = new OleDbConnection(conStr);
                    con.Open();
                    OleDbDataReader dr;
                    OleDbCommand cmd = new OleDbCommand();
                    var date = dtpRegister.Value.ToString("yyyy-MM-dd");

                    cmd.CommandText = @"insert into tbl_users ([mrno], [fullname], [age], [sex], [oldmr], [registerationdate], [maritalstatus], [phone], [occupation], [totalvisiting], [totalamount], [balance], [address]) VALUES('"
                        + Convert.ToInt32(txtMR.Text) + "','" + txtName.Text + "','" + txtAge.Text + "','" + sex + "','" + txtOldMR.Text + "','" + date + "','" + cmbMarital.Text + "','"
                        + txtPhone.Text + "','" + txtOccupation.Text + "','" + txtVisit.Text + "','" + txtTotalAmt.Text + "','" + txtBalance.Text + "','" + txtAddress.Text + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    // dr = cmd.ExecuteReader();
                    //   getInvoiceNo();
                    con.Close();
                    MessageBox.Show("Operation Sucessfull!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (var c in panReg.Controls)
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
                    txtAddress.Text = String.Empty;
                    rdbMale.Checked = true;
                    checkMrNo();
                    //  this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation Not Sucessfull! " + ex.Message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void patientRegistration_Load(object sender, EventArgs e)
        {
            checkMrNo();
            //OleDbConnection con = new OleDbConnection(conStr);
            //con.Open();
            //try
            //{
            //    OleDbDataAdapter da;
            //    DataTable dt;
            //    da = new OleDbDataAdapter("Select * From tbl_users ORDER BY CAST(mrno AS int) as mrno asc", con);
            //    dt = new DataTable();
            //    da.Fill(dt);

            //    DataRow dr = dt.NewRow();
            //    dr["mrno"] = "-- Select Doctor  --";
            //    dt.Rows.InsertAt(dr, 0);
            //    comboBox1.ValueMember = "id";
            //    comboBox1.DisplayMember = "mrno";
            //    comboBox1.DataSource = dt;
            //    //"SELECT * FROM tbl_users ORDER BY mrno DESC
            //    con.Close();
            //}

            //catch (System.Exception ex)
            //{
            //    con.Close();
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (numMr.Value != 0)
            {
                Billing billing = new Billing(Convert.ToInt16(numMr.Value));
                billing.ShowDialog();
                this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Supply MR Number ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
