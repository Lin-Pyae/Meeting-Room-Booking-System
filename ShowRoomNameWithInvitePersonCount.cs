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
    public partial class ShowRoomNameWithInvitePersonCount : Form
    {
        public ShowRoomNameWithInvitePersonCount()
        {
            InitializeComponent();
        }

        private void ShowRoomNameWithInvitePersonCount_Load(object sender, EventArgs e)
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
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string room = txtroom.Text;
            string date = txtDate.Value.ToString("MM/dd/yyyy");
            string start = $"{date} {startTime.Value.ToString("hh:mm:ss tt")}";
            string end = $"{date} {txtEnd.Value.ToString("hh:mm:ss tt")}";

            using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT COUNT(br.booking_id) AS [invited person], br.start_time AS start, br.end_time AS [end] FROM(invitees INNER JOIN booked_room AS br ON invitees.booking_id = br.booking_id) INNER JOIN meeting_rooms ON br.room_id = meeting_rooms.room_id WHERE meeting_rooms.room_name = @room AND br.start_time >= @start AND br.end_time <= @end GROUP BY meeting_rooms.room_name, br.start_time, br.end_time";

                    cmd.Parameters.AddWithValue("@room", room);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    gvList.DataSource = ds.Tables[0];
                }
            }
        }



        private void startTime_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void startTime_MouseDown_1(object sender, MouseEventArgs e)
        {
            startTime.CustomFormat = "hh:mm:ss tt";
        }

        private void txtEnd_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtEnd.CustomFormat = "hh:mm:ss tt";
        }
    }
}
