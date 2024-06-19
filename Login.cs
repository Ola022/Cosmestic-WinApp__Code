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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        private string conStr = connectionString.constr;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(conStr);
            try
            {
                if (txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty))
                {

                    MessageBox.Show("Enter your login Details, USERNAME & PASSWORD", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();
                    OleDbDataReader read;

                    string details = "SELECT * from tbl_User_login WHERE username='" + txtUser.Text + "' and password='" + txtPass.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(details, con);

                    read = cmd.ExecuteReader();

                    if (read.Read() == true)
                    {
                        con.Close();
                        this.Hide();
                        Form1 form = new Form1();                        
                        form.ShowDialog();                   
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("User not Found ", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.Text = "admin";
            txtUser.Text = "admin";
        }
    }
}
