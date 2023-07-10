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
using System.Configuration;


namespace WindowsFormsApp5
{
    public partial class frmlogin : Form
    {
        private string connectionString = @"Data Source=DESKTOP-S6OPJRN\SQLEXPRESS;Initial Catalog=BILLING;Integrated Security=True";

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (UserAuthentication(username, password))
            {
                frmbilligdetails frmbillingdetails = new frmbilligdetails();
                frmbillingdetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter a valid username and password");
            }
        }

        private bool UserAuthentication(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}