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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnshowroom_Click(object sender, EventArgs e)
        {
            CheckRoomUser cr = new CheckRoomUser();
            cr.Show();
        }
    }
}
