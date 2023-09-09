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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpw.Text;
            bool isadmin = txtisadmin.Checked;

            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand($"INSERT INTO user (user_name, password, is_admin) VALUES ({username}, {password}, {isadmin})", con))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New User Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a new user.");
                    }
                }
            }
        }

    }
}
