
namespace Database_Final_Project
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meetingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMeetingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meetingRoomToolStripMenuItem,
            this.facilityToolStripMenuItem,
            this.userToolStripMenuItem,
            this.bookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meetingRoomToolStripMenuItem
            // 
            this.meetingRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMeetingRoomToolStripMenuItem});
            this.meetingRoomToolStripMenuItem.Name = "meetingRoomToolStripMenuItem";
            this.meetingRoomToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.meetingRoomToolStripMenuItem.Text = "Meeting Room";
            // 
            // addMeetingRoomToolStripMenuItem
            // 
            this.addMeetingRoomToolStripMenuItem.Name = "addMeetingRoomToolStripMenuItem";
            this.addMeetingRoomToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.addMeetingRoomToolStripMenuItem.Text = "Add Meeting Room";
            this.addMeetingRoomToolStripMenuItem.Click += new System.EventHandler(this.addMeetingRoomToolStripMenuItem_Click);
            // 
            // facilityToolStripMenuItem
            // 
            this.facilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFacilityToolStripMenuItem});
            this.facilityToolStripMenuItem.Name = "facilityToolStripMenuItem";
            this.facilityToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.facilityToolStripMenuItem.Text = "Facility";
            // 
            // addFacilityToolStripMenuItem
            // 
            this.addFacilityToolStripMenuItem.Name = "addFacilityToolStripMenuItem";
            this.addFacilityToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.addFacilityToolStripMenuItem.Text = "Add Facility";
            this.addFacilityToolStripMenuItem.Click += new System.EventHandler(this.addFacilityToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookingToolStripMenuItem,
            this.checkRoomToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // addBookingToolStripMenuItem
            // 
            this.addBookingToolStripMenuItem.Name = "addBookingToolStripMenuItem";
            this.addBookingToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.addBookingToolStripMenuItem.Text = "Add Booking";
            this.addBookingToolStripMenuItem.Click += new System.EventHandler(this.addBookingToolStripMenuItem_Click);
            // 
            // checkRoomToolStripMenuItem
            // 
            this.checkRoomToolStripMenuItem.Name = "checkRoomToolStripMenuItem";
            this.checkRoomToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.checkRoomToolStripMenuItem.Text = "Check Room";
            this.checkRoomToolStripMenuItem.Click += new System.EventHandler(this.checkRoomToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Meeting Room Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meetingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMeetingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkRoomToolStripMenuItem;
    }
}