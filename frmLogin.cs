using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MarcIversenBecl191200
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marci\Documents\loginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from dbo.login Where username = '" + txtBrugernavn.Text.Trim() + "' and password = '" + txtAdgangskode.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                frmMain objfrmMain = new frmMain();
                this.Hide();
                objfrmMain.Show();
            }
            else
            {
                MessageBox.Show("Brugernavn eller adgangskoden er forkert");
            }
        }

        private void txtAdgangskode_TextChanged(object sender, EventArgs e)
        {
            txtAdgangskode.PasswordChar = '*';
        }
    }
}
