using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cosmesticClinic
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        private void report_Load(object sender, EventArgs e)
        {
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
                cmbModeTreat.ValueMember = "id";
                cmbModeTreat.DisplayMember = "treatmentmode";
                cmbModeTreat.DataSource = dt;

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
        void searchReport()
        {
            
            try
            {
                //if (dataGridView1.Rows.Count > 0)
                //    dataGridView1.Rows.Clear();
                OleDbConnection con = new OleDbConnection(conStr);
                con.Open();
                var dt1 = DateTime.Parse(dtpTo.Text);
                var dt2 = DateTime.Parse(dtpFrom.Text);

                string details = "SELECT (id) as [ID],(mrno) as [MR No], (fullname) as [Name], (phone) as [Phone No], (visitno) as [Visit No], (treatmentarea) as [Mode of Treatment], (consultingdoctor) as [Doctor], " +
                    "(receiptno) as [Receipt No], (costprice) as [Cost Price], (discount) as [Discount], (amomunttopay) as [To be Pay], (amount) as [Amount Paid], (balance) as [Balance], (billingdate) as [Billing Date] from tbl_patient_billing WHERE consultingdoctor='"
                    + cmbDoctor.Text + "'and receivedby='" + cmbReveiced.Text + "'and billingdate between '" + dt1.ToString("yyyy-MM-dd") + "' and '" + dt2.ToString("yyyy-MM-dd") + "' order by billingdate desc";


                OleDbCommand cmd = new OleDbCommand(details, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Patient found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDayReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDayReport.Checked)
            {
                try
                {
                    //if (dataGridView1.Rows.Count > 0)
                    //    dataGridView1.Rows.Clear();

                    OleDbConnection con = new OleDbConnection(conStr);
                    con.Open();
                    var date = DateTime.Now.ToString("yyyy-MM-dd");

                    string details = "SELECT (id) as [ID],(mrno) as [MR No], (fullname) as [Name], (phone) as [Phone No], (visitno) as [Visit No], (treatmentarea) as [Mode of Treatment], (consultingdoctor) as [Doctor], " +
                        "(receiptno) as [Receipt No], (costprice) as [Cost Price], (discount) as [Discount], (amomunttopay) as [To be Pay], (amount) as [Amount Paid], (balance) as [Balance], (billingdate) as [Billing Date] from tbl_patient_billing WHERE billingdate='"
                        + date + "' order by billingdate desc";


                    OleDbCommand cmd = new OleDbCommand(details, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Columns[0].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No Patient found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //{
            //    dataGridView1.Row.
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchReport();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    lblClinicName.Visible = true;
                    int height = panDgv.Height;
                    int width = panDgv.Width;
                    int dataGridHeight = dataGridView1.Height;
                   // dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;

                    bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);

                    panDgv.Height = panDgv.Height + (dataGridView1.RowCount * dataGridView1.RowTemplate.Height );
                    panDgv.Width = panDgv.Width + dataGridView1.ColumnCount;
                    panDgv.DrawToBitmap(bitmap, new Rectangle(0, 0, panDgv.Width, panDgv.Height));
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();

                    panDgv.Height = height;
                    panDgv.Width = width;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    lblClinicName.Visible = true;
                    int height = panDgv.Height;
                    int width = panDgv.Width;
                    int dataGridHeight = dataGridView1.Height;
                    // dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;

                    bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);

                    panDgv.Height = panDgv.Height + (dataGridView1.RowCount * dataGridView1.RowTemplate.Height);
                    panDgv.Width = panDgv.Width + dataGridView1.ColumnCount;
                    panDgv.DrawToBitmap(bitmap, new Rectangle(0, 0, panDgv.Width, panDgv.Height));
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();

                    panDgv.Height = height;
                    panDgv.Width = width;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel._Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
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
