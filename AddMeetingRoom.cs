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
using System.Runtime.InteropServices;
using Access = Microsoft.Office.Interop.Access;

namespace Database_Final_Project
{
    public partial class AddMeetingRoom : Form
    {
        public AddMeetingRoom()
        {
            InitializeComponent();
            LoadFacilities();
        }

        private void LoadFacilities()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Select * from [facilities]";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            chklfacility.DataSource = ds.Tables[0];
            chklfacility.DisplayMember = "facility_name";
            chklfacility.ValueMember = "facility_id";
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
            List<string> selectedFacilities = new List<string>();

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
                        int room_id = _get_created_room(con);
                        for (int i = 0; i < chklfacility.Items.Count; i++)
                        {
                            if (chklfacility.GetItemChecked(i))
                            {
                                DataRowView selectedItem = (DataRowView)chklfacility.Items[i];
                                int facility_id = Convert.ToInt32(selectedItem["facility_id"]);
                                _insert_into_facility_room(con, room_id, facility_id);
                            }
                        }

                        MessageBox.Show("Room created successfully");
                        _load_meeting_room(con);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a new room.");
                    }
                }
            }

        }
        private int _get_created_room(OleDbConnection conn)
        {
            //OleDbConnection con = new OleDbConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            //con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Select top 1 * from meeting_rooms order by room_id desc";
            cmd.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int roomId = 0;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Access the "room_id" column from the first row in the first table (assuming it exists)
                roomId = Convert.ToInt32(ds.Tables[0].Rows[0]["room_id"]);
                return roomId;

                // Now 'roomId' contains the value of the "room_id" column for the most recent record.
            }
            else
            {
                MessageBox.Show("Error Occured and no room is created");
            }
            return roomId;
        }
        private void _insert_into_facility_room(OleDbConnection conn, int room_id, int facility_id)
        {
            string insertQuery = "INSERT INTO room_facility (room_id, facility_id) VALUES (@room_id, @facility_id)";

            // Create an OleDbCommand object and set the connection and query
            using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
            {
                // Add parameters to the query to avoid SQL injection
                cmd.Parameters.AddWithValue("@room_id", room_id);
                cmd.Parameters.AddWithValue("@facility_id", facility_id);

                // Execute the query
                cmd.ExecuteNonQuery();
            }

            }
        private void _load_meeting_room(OleDbConnection conn)
        {
            Access.Application accessApp = null;
            Access.Dao.Database db = null;
            Access.Dao.Recordset recordset = null;

            try
            {
                // Get the running instance of Microsoft Access.
                accessApp = (Access.Application)Marshal.GetActiveObject("Access.Application");
                db = accessApp.CurrentDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return;
            }

            try
            {
                // Call your Access query (which includes your VB function).
                accessApp.DoCmd.OpenQuery("concact_room_facility");
                recordset = db.OpenRecordset("concact_room_facility");
                DataTable resultTable = new DataTable();
                for(int i=0;i<recordset.Fields.Count; i++)
                {
                    resultTable.Columns.Add(recordset.Fields[i].Name, typeof(string));
                }
                while (!recordset.EOF)
                {
                    DataRow newRow = resultTable.NewRow();
                    for(int i =0; i< recordset.Fields.Count; i++)
                    {
                        newRow[i] = recordset.Fields[i].Value;
                    }
                    resultTable.Rows.Add(newRow);
                    recordset.MoveNext();
                }
                dvgmeetingroom.DataSource = resultTable;
                // Optionally, display a message indicating success.
                MessageBox.Show("Query executed successfully.", "Success");
                DataTable resulttable = new DataTable();
                //accessApp.DoCmd.TransferSpreadsheet(Access.AcDataTransferType.acExport, Access.AcSpreadSheetType.acSpreadsheetTypeExcel12Xml, "concat_facility_result", "C:\\Path\\To\\OutputFile.xlsx", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                // Release the COM object.
                if (accessApp != null)
                {
                    Marshal.ReleaseComObject(accessApp);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chklfacility_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMeetingRoom_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            _load_meeting_room(con);

        }
    }
}
