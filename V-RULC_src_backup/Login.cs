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

namespace TEST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            //Clear incorrect login details on click
            usernametxtbox.Text = "";
            passwordtxtbox.Clear();
            usernametxtbox.Focus();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //Check username password and load app
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Deakin\Sem3\ProjectDelivery\TVRULC_V1.01\TVRULC\custDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[Login] Where Username='" + usernametxtbox.Text + "' and Password='" + passwordtxtbox.Text + "'", sqlCon);
            DataTable Logindt = new DataTable();
            sqlDataAdapter.Fill(Logindt);

            if (Logindt.Rows.Count == 1)
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
