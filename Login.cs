using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Database_Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpw.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM [user] WHERE user_name = @username AND password = @password";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isAdmin = (bool)reader["is_admin"];

                            if (isAdmin)
                            {
                                Dashboard ds = new Dashboard();
                                ds.Show();
                                this.Hide();
                            }
                            else
                            {
                                UserDashboard ud = new UserDashboard();
                                ud.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User doesn't exist or credentials are incorrect");
                        }
                    }
                }
            }
        }

    }
}
