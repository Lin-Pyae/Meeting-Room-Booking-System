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
        }
    }
}
