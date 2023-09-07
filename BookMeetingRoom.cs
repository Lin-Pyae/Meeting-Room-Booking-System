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
    public partial class BookMeetingRoom : Form
    {
        public BookMeetingRoom()
        {
            InitializeComponent();
        }

        private void BookMeetingRoom_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();

            // Populate the first ComboBox (room)
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM [meeting_rooms]";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "meeting_rooms");

            txtroom.DataSource = ds.Tables["meeting_rooms"];
            txtroom.DisplayMember = "room_name";
            txtroom.ValueMember = "room_id";

            // Populate the second ComboBox (secondRoom)
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.CommandText = "SELECT * FROM [user]";
            cmd2.Connection = con;
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "another_table");

            txtuser.DataSource = ds2.Tables["another_table"];
            txtuser.DisplayMember = "user_name"; // Replace with the appropriate column name
            txtuser.ValueMember = "user_id";     // Replace with the appropriate column name

            con.Close();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm:ss tt";
        }

        private void txtEnd_MouseDown(object sender, MouseEventArgs e)
        {
            txtEnd.CustomFormat = "hh:mm:ss tt";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int user_id = Int32.Parse(txtuser.Text);
            string room = txtroom.Text;

            
        }
    }
}
