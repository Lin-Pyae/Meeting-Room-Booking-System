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
    public partial class AddMeetingRoom : Form
    {
        public AddMeetingRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addRoombtn_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text;
            int capacity = Int32.Parse(txtRoomCapacity.Text);

            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO meeting_rooms (room_name, capacity) VALUES (?, ?)", con))
                {
                    cmd.Parameters.AddWithValue("room_name", roomName);
                    cmd.Parameters.AddWithValue("capacity", capacity);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Room Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a new room.");
                    }
                }
            }

        }
    }
}
