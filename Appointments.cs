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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Appointments_Load(object sender, EventArgs e)
        {
            getAllAppointment();
            getAllTreatmentMode();
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
                cmbMode.ValueMember = "id";
                cmbMode.DisplayMember = "treatmentmode";
                cmbMode.DataSource = dt;

                con.Close();
            }

            catch (System.Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void getAllAppointment()
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {

                string details = "SELECT (id) as [ID],(appointmentid) as [Appointment ID],(fullname) as [Name], (phone) as [Phone], (modeoftreatment) as [Mode of Treatment], (appointment_date) as [Date] from tbl_appointment ";

                OleDbCommand cmd = new OleDbCommand(details, con);
                //OleDbCommand cmd = new OleDbCommand("select * from tbl_users", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dataGridView1.DataSource = myDS.Tables["clinic"].DefaultView;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Record found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMode.Text == "-- Select Treatment Mode  --" || txtAppointment.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                {
                    MessageBox.Show("Please fill the field", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(conStr);
                    con.Open();
                    OleDbDataReader dr;
                    OleDbCommand cmd = new OleDbCommand();
                    var date = dtpDate.Value.ToString("yyyy-MM-dd");
                    var time = dtpTime.Value.ToString("hh :mm");

                    cmd.CommandText = @"insert into tbl_appointment ([appointmentid], [fullname], [phone], [modeoftreatment], [appointment_date], [appointment_time]) VALUES('"
                        + txtAppointment.Text + "','" + txtName.Text + "','" + txtPhone.Text + "','" + cmbMode.Text + "','" + date + "','" + time + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Operation Sucessfull!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getAllAppointment();
                    foreach (var c in panel2.Controls)
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
                    //  this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Not Sucessfull! " + ex.Message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        } 
    

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            try
            {
                var date = dtpSearch.Value.ToString("yyyy-MM-dd");

                string details = "SELECT (id) as [ID],(appointmentid) as [Appointment ID],(fullname) as [Name], (phone) as [Phone], (modeoftreatment) as [Mode of Treatment], (appointment_date) as [Date] from tbl_appointment WHERE  appointment_date='" + date + "'";

                OleDbCommand cmd = new OleDbCommand(details, con);
                //OleDbCommand cmd = new OleDbCommand("select * from tbl_users", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet myDS = new DataSet();
                da.Fill(myDS, "clinic");
                dataGridView1.DataSource = myDS.Tables["clinic"].DefaultView;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Width = 110;
                    dataGridView1.Columns[2].Width = 110;
                    dataGridView1.Columns[3].Width = 110;
                    dataGridView1.Columns[4].Width = 110;

                }
                else
                {
                    MessageBox.Show("No Record found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    lblClinicName.Visible = true;
                    int height = panDgv.Height;
                    int dataGridHeight = dataGridView1.Height;
                    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                    bitmap = new Bitmap(panDgv.Width, dataGridView1.Height);
                    panDgv.Height = panDgv.Height + (dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2);
                    panDgv.DrawToBitmap(bitmap, new  Rectangle(0, 0, panDgv.Width,  panDgv.Height ));
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();
                    panDgv.Height = height;
                    dataGridView1.Height = dataGridHeight;
                    lblClinicName.Visible = false;
                }
                else
                {
                    MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Argument, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    lblClinicName.Visible = true;
                    int height = panDgv.Height;
                    int dataGridHeight = dataGridView1.Height;
                    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                    bitmap = new Bitmap(panDgv.Width, dataGridView1.Height);
                    panDgv.Height = panDgv.Height + (dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2);
                    panDgv.DrawToBitmap(bitmap, new Rectangle(0, 0, panDgv.Width, panDgv.Height));
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();
                    panDgv.Height = height;
                    dataGridView1.Height = dataGridHeight;
                    lblClinicName.Visible = false;

                }
                else
                {
                    MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Argument, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
