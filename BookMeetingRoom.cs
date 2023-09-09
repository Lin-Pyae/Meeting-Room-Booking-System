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
            int user_id = Int32.Parse(txtuser.SelectedValue.ToString());
            int room = Int32.Parse(txtroom.SelectedValue.ToString());
            string date = txtDate.Value.ToString("MM/dd/yyyy");
            string startTime = $"{date} {dateTimePicker1.Value.ToString("hh:mm:ss tt")}";
            string endTime = $"{date} {txtEnd.Value.ToString("hh:mm:ss tt")}";

            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO booked_room (room_id, user_id, [date], start_time, end_time) VALUES (?, ?, ?, ?, ?)", con))
                {
                    cmd.Parameters.AddWithValue("room_id", room);
                    cmd.Parameters.AddWithValue("user_id", user_id);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("start_time", startTime);
                    cmd.Parameters.AddWithValue("end_time", endTime);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking Success");
                    }
                    else
                    {
                        MessageBox.Show("Failed to book a room");
                    }
                }
            }



        }

        private void txtroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
