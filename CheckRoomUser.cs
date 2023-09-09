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
    public partial class CheckRoomUser : Form
    {
        public CheckRoomUser()
        {
            InitializeComponent();
        }

        private void btnSpecificDate_Click(object sender, EventArgs e)
        {
            string specificDate = SpecificDate.Value.ToString("MM/dd/yyyy");

            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT meeting_rooms.room_name AS [room name], meeting_rooms.capacity AS [room capacity], booked_room.date AS [date] FROM booked_room INNER JOIN meeting_rooms ON booked_room.room_id = meeting_rooms.room_id WHERE[date] = @sdate";

                    cmd.Parameters.AddWithValue("@sdate", specificDate);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvRooms.DataSource = ds.Tables[0];
                }
            }
        }

        private void CheckRoomUser_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Select * from [meeting_rooms]";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvRooms.DataSource = ds.Tables[0];

            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.CommandText = "SELECT * FROM [meeting_rooms]";
            cmd1.Connection = con;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "meeting_rooms");

            boxroomName.DataSource = ds1.Tables["meeting_rooms"];
            boxroomName.DisplayMember = "room_name";
            boxroomName.ValueMember = "room_id";
        }

        private void btnroom_facility_Click(object sender, EventArgs e)
        {
            // Set your Access database file path.
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User\\OneDrive\\Documents\\Meeting Room Booking System.accdb";

            // Define your query.
            string query = @"
        SELECT meeting_rooms.room_name AS room, ConcatenateFacilities(meeting_rooms.room_id) AS facility
        FROM (room_facility INNER JOIN meeting_rooms ON room_facility.room_id = meeting_rooms.room_id) 
        INNER JOIN facilities ON room_facility.facility_id = facilities.facility_id
        GROUP BY meeting_rooms.room_name, meeting_rooms.room_id;
    ";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView.
                        dgvRooms.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            btnStart.CustomFormat = "hh:mm:ss tt";
        }

        private void btnEnd_MouseDown(object sender, MouseEventArgs e)
        {
            btnEnd.CustomFormat = "hh:mm:ss tt";
        }

        private void btntimeStamp_Click(object sender, EventArgs e)
        {
            string specificDate = SpecificDate.Value.ToString("MM/dd/yyyy");
            string startTime = $"{specificDate} {btnStart.Value.ToString("hh:mm:ss tt")}";
            string endTime = $"{specificDate} {btnEnd.Value.ToString("hh:mm:ss tt")}";
            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT meeting_rooms.room_name AS room, user.user_name AS [user], start_time, end_time FROM(booked_room INNER JOIN meeting_rooms ON booked_room.room_id = meeting_rooms.room_id) INNER JOIN[user] ON booked_room.user_id = user.user_id WHERE(booked_room.start_time <= @startTime) AND (booked_room.end_time >= @endTime);";

                    cmd.Parameters.AddWithValue("@startTime", endTime);
                    cmd.Parameters.AddWithValue("@endTime", startTime);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvRooms.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnShowInvitee_Click(object sender, EventArgs e)
        {
            string specificDate = SpecificDate.Value.ToString("MM/dd/yyyy");
            string startTime = $"{specificDate} {btnStart.Value.ToString("hh:mm:ss tt")}";
            string endTime = $"{specificDate} {btnEnd.Value.ToString("hh:mm:ss tt")}";
            int room = Int32.Parse(boxroomName.SelectedValue.ToString());

            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT invitee_user.user_name AS Invitee, room_user.user_name AS host, meeting_rooms.room_name AS room_name, br.start_time AS start, br.end_time AS [end] FROM(((invitees AS i INNER JOIN[user] AS invitee_user ON i.invitee = invitee_user.user_id) INNER JOIN booked_room AS br ON i.booking_id = br.booking_id) INNER JOIN[user] AS room_user ON br.user_id = room_user.user_id) INNER JOIN meeting_rooms ON br.room_id = meeting_rooms.room_id WHERE(meeting_rooms.room_id = @roomID) and (br.start_time <= @startTime) AND (br.end_time >= @endTime);";

                    cmd.Parameters.AddWithValue("@roomID", room);
                    cmd.Parameters.AddWithValue("@startTime", endTime);
                    cmd.Parameters.AddWithValue("@endTime", startTime);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvRooms.DataSource = ds.Tables[0];
                }
            }

        }
    }
}