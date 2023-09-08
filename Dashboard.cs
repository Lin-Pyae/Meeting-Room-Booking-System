using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Final_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void showroombtn_Click(object sender, EventArgs e)
        {
            ShowMeetingRoom sm = new ShowMeetingRoom();
            sm.Show();
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            AddMeetingRoom am = new AddMeetingRoom();
            am.Show();
        }

        private void bookroombtn_Click(object sender, EventArgs e)
        {
            BookMeetingRoom br = new BookMeetingRoom();
            br.Show();
        }

        private void btnAddFacility_Click(object sender, EventArgs e)
        {
            Facility fa = new Facility();
            fa.Show();
        }
    }
}
