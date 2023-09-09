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
            bool is_admin = txtisadmin.Checked;
            
            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO [user] ([user_name],[password],[is_admin]) VALUES (?,?,?)", con))
                {
                    cmd.Parameters.AddWithValue("user_name", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("is_admin", is_admin);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New User Added");
                        UserRegister_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a new user.");
                    }
                }
            }
        }
     
        private void UserRegister_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Select * from [user]";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            con.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            gvgUser.DataSource = ds.Tables[0];
            gvgUser.Columns[2].Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}