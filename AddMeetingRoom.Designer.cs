
namespace Database_Final_Project
{
    partial class AddMeetingRoom
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
            this.roomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoomCapacity = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.Label();
            this.addRoombtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chklfacility = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgmeetingroom = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmeetingroom)).BeginInit();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(96, 52);
            this.roomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(98, 20);
            this.roomName.TabIndex = 0;
            this.roomName.Text = "Room Name";
            this.roomName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(298, 52);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(148, 26);
            this.txtRoomName.TabIndex = 1;
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.Location = new System.Drawing.Point(298, 102);
            this.txtRoomCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(148, 26);
            this.txtRoomCapacity.TabIndex = 3;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(96, 102);
            this.capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(117, 20);
            this.capacity.TabIndex = 2;
            this.capacity.Text = "Room Capacity";
            this.capacity.Click += new System.EventHandler(this.label2_Click);
            // 
            // addRoombtn
            // 
            this.addRoombtn.Location = new System.Drawing.Point(334, 259);
            this.addRoombtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addRoombtn.Name = "addRoombtn";
            this.addRoombtn.Size = new System.Drawing.Size(112, 35);
            this.addRoombtn.TabIndex = 4;
            this.addRoombtn.Text = "Add Room";
            this.addRoombtn.UseVisualStyleBackColor = true;
            this.addRoombtn.Click += new System.EventHandler(this.addRoombtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chklfacility);
            this.groupBox1.Controls.Add(this.addRoombtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRoomCapacity);
            this.groupBox1.Controls.Add(this.capacity);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.roomName);
            this.groupBox1.Location = new System.Drawing.Point(128, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Meeting Room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chklfacility
            // 
            this.chklfacility.FormattingEnabled = true;
            this.chklfacility.Location = new System.Drawing.Point(298, 156);
            this.chklfacility.Name = "chklfacility";
            this.chklfacility.Size = new System.Drawing.Size(148, 73);
            this.chklfacility.TabIndex = 5;
            this.chklfacility.SelectedIndexChanged += new System.EventHandler(this.chklfacility_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Included Facility";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dvgmeetingroom
            // 
            this.dvgmeetingroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgmeetingroom.Location = new System.Drawing.Point(128, 422);
            this.dvgmeetingroom.Name = "dvgmeetingroom";
            this.dvgmeetingroom.RowHeadersWidth = 62;
            this.dvgmeetingroom.RowTemplate.Height = 28;
            this.dvgmeetingroom.Size = new System.Drawing.Size(596, 248);
            this.dvgmeetingroom.TabIndex = 6;
            // 
            // AddMeetingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 682);
            this.Controls.Add(this.dvgmeetingroom);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMeetingRoom";
            this.Text = "Meeting Room";
            this.Load += new System.EventHandler(this.AddMeetingRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmeetingroom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Button addRoombtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chklfacility;
        private System.Windows.Forms.DataGridView dvgmeetingroom;
    }
}