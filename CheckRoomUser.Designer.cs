
namespace Database_Final_Project
{
    partial class CheckRoomUser
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnSpecificDate = new System.Windows.Forms.Button();
            this.SpecificDate = new System.Windows.Forms.DateTimePicker();
            this.btnroom_facility = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.DateTimePicker();
            this.btnEnd = new System.Windows.Forms.DateTimePicker();
            this.btntimeStamp = new System.Windows.Forms.Button();
            this.boxroomName = new System.Windows.Forms.ComboBox();
            this.btnShowInvitee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(110, 46);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(604, 208);
            this.dgvRooms.TabIndex = 0;
            // 
            // btnSpecificDate
            // 
            this.btnSpecificDate.Location = new System.Drawing.Point(236, 312);
            this.btnSpecificDate.Name = "btnSpecificDate";
            this.btnSpecificDate.Size = new System.Drawing.Size(75, 23);
            this.btnSpecificDate.TabIndex = 1;
            this.btnSpecificDate.Text = "Find";
            this.btnSpecificDate.UseVisualStyleBackColor = true;
            this.btnSpecificDate.Click += new System.EventHandler(this.btnSpecificDate_Click);
            // 
            // SpecificDate
            // 
            this.SpecificDate.CustomFormat = "MM-dd-yyyy";
            this.SpecificDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SpecificDate.Location = new System.Drawing.Point(236, 276);
            this.SpecificDate.Name = "SpecificDate";
            this.SpecificDate.Size = new System.Drawing.Size(109, 20);
            this.SpecificDate.TabIndex = 2;
            // 
            // btnroom_facility
            // 
            this.btnroom_facility.Location = new System.Drawing.Point(597, 273);
            this.btnroom_facility.Name = "btnroom_facility";
            this.btnroom_facility.Size = new System.Drawing.Size(117, 23);
            this.btnroom_facility.TabIndex = 3;
            this.btnroom_facility.Text = "Check Room Facility";
            this.btnroom_facility.UseVisualStyleBackColor = true;
            this.btnroom_facility.Click += new System.EventHandler(this.btnroom_facility_Click);
            // 
            // btnStart
            // 
            this.btnStart.CustomFormat = "  ";
            this.btnStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.btnStart.Location = new System.Drawing.Point(416, 276);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShowUpDown = true;
            this.btnStart.Size = new System.Drawing.Size(116, 20);
            this.btnStart.TabIndex = 4;
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            // 
            // btnEnd
            // 
            this.btnEnd.CustomFormat = "  ";
            this.btnEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.btnEnd.Location = new System.Drawing.Point(416, 315);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.ShowUpDown = true;
            this.btnEnd.Size = new System.Drawing.Size(116, 20);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEnd_MouseDown);
            // 
            // btntimeStamp
            // 
            this.btntimeStamp.Location = new System.Drawing.Point(416, 370);
            this.btntimeStamp.Name = "btntimeStamp";
            this.btntimeStamp.Size = new System.Drawing.Size(116, 23);
            this.btntimeStamp.TabIndex = 6;
            this.btntimeStamp.Text = "Check Time";
            this.btntimeStamp.UseVisualStyleBackColor = true;
            this.btntimeStamp.Click += new System.EventHandler(this.btntimeStamp_Click);
            // 
            // boxroomName
            // 
            this.boxroomName.FormattingEnabled = true;
            this.boxroomName.Location = new System.Drawing.Point(236, 372);
            this.boxroomName.Name = "boxroomName";
            this.boxroomName.Size = new System.Drawing.Size(121, 21);
            this.boxroomName.TabIndex = 7;
            // 
            // btnShowInvitee
            // 
            this.btnShowInvitee.Location = new System.Drawing.Point(236, 415);
            this.btnShowInvitee.Name = "btnShowInvitee";
            this.btnShowInvitee.Size = new System.Drawing.Size(112, 23);
            this.btnShowInvitee.TabIndex = 8;
            this.btnShowInvitee.Text = "Show Invitee";
            this.btnShowInvitee.UseVisualStyleBackColor = true;
            this.btnShowInvitee.Click += new System.EventHandler(this.btnShowInvitee_Click);
            // 
            // CheckRoomUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowInvitee);
            this.Controls.Add(this.boxroomName);
            this.Controls.Add(this.btntimeStamp);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnroom_facility);
            this.Controls.Add(this.SpecificDate);
            this.Controls.Add(this.btnSpecificDate);
            this.Controls.Add(this.dgvRooms);
            this.Name = "CheckRoomUser";
            this.Text = "CheckRoomUser";
            this.Load += new System.EventHandler(this.CheckRoomUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnSpecificDate;
        private System.Windows.Forms.DateTimePicker SpecificDate;
        private System.Windows.Forms.Button btnroom_facility;
        private System.Windows.Forms.DateTimePicker btnStart;
        private System.Windows.Forms.DateTimePicker btnEnd;
        private System.Windows.Forms.Button btntimeStamp;
        private System.Windows.Forms.ComboBox boxroomName;
        private System.Windows.Forms.Button btnShowInvitee;
    }
}