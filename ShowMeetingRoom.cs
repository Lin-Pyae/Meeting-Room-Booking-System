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
    public partial class ShowMeetingRoom : Form
    {
        public ShowMeetingRoom()
        {
            InitializeComponent();
        }

        private void ShowMeetingRoom_Load(object sender, EventArgs e)
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
            gvRoomList.DataSource = ds.Tables[0];
            gvRoomList.CellClick += new DataGridViewCellEventHandler(this.gvRoomList_CellClick);
        }

        private void gvRoomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = gvRoomList.Rows[e.RowIndex];

                if (!selectedRow.IsNewRow) // Check if it's not a new row
                {
                    // Ask for confirmation before deleting the row
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int selectedRowID = Convert.ToInt32(selectedRow.Cells["room_id"].Value); // Assuming "ID" is the name of your unique identifier column

                        // Delete the row from the DataGridView
                        gvRoomList.Rows.Remove(selectedRow);

                        // Update your database: Delete the corresponding row
                        DeleteRowFromDatabase(selectedRowID);
                    }
                }
            }
        }

        private void DeleteRowFromDatabase(int rowID)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
                {
                    con.Open();

                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = "DELETE FROM [meeting_rooms] WHERE room_id = @ID";
                        cmd.Parameters.AddWithValue("@ID", rowID);
                        cmd.Connection = con;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete row from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
