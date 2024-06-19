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
    public partial class printInvoice : Form
    {
        int _mrno;
        string _action;
        public printInvoice(int _mrNumber, string action)
        {
            _mrno = _mrNumber;
            _action = action;
            InitializeComponent();
        }
        private string conStr = connectionString.constr;
        
        private void printInvoice_Load(object sender, EventArgs e)
        {
            getBillDetail();
            if(_action == "Print")
            {
                btnSave.PerformClick();
                this.Close();
            }
        }

        public void getBillDetail()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(conStr);
                OleDbDataReader read;
                con.Open();
                
                string details = "SELECT * from tbl_patient_billing WHERE mrno='" + Convert.ToString(_mrno)+ "'";
                OleDbCommand cmd = new OleDbCommand(details, con);
                read = cmd.ExecuteReader();
           
                if (read.Read() == true)
                {
                    lblAmount.Text = Convert.ToString(read["amount"]);
                    lblBalance.Text = Convert.ToString(read["balance"]);
                    lblBillingDate.Text = Convert.ToString(read["billingdate"]);
                    lblCostPer.Text = Convert.ToString(read["costprice"]);
                    lblDiscount.Text = Convert.ToString(read["discount"]);
                    lblDoctor.Text = Convert.ToString(read["consultingdoctor"]);
                    lblMrNo.Text = Convert.ToString(read["mrno"]);
                    lblReceiptNo.Text = Convert.ToString(read["receiptno"]);
                    lblReceived.Text = Convert.ToString(read["receivedby"]);
                    lblTobePaid.Text = Convert.ToString(read["amomunttopay"]);
                    lblTreatArea.Text = Convert.ToString(read["treatmentarea"]);
                    lblTreatment.Text = Convert.ToString(read["treatment"]);
                    lblVisit.Text = Convert.ToString(read["visitno"]);
                    lblFullname.Text = Convert.ToString(read["fullname"]);
                    con.Close();                    

                }
                else
                {
                    con.Close();
                    MessageBox.Show("No Patient with MR No " + _mrno , "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrintDialog myPrintDialog = new PrintDialog();
            Bitmap memoryImage = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(memoryImage, panel1.ClientRectangle);
            if (myPrintDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Printing.PrinterSettings values;
                values = myPrintDialog.PrinterSettings;
                myPrintDialog.Document = printDocument1;
                printDocument1.PrintController = new StandardPrintController();
                printDocument1.Print();
            }
            printDocument1.Dispose();
        }

        
    }
}
