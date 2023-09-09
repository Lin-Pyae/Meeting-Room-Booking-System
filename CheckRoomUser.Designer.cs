
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
            this.btnStart = new System.Windows.Forms.DateTimePicker();
            this.btnEnd = new System.Windows.Forms.DateTimePicker();
            this.btntimeStamp = new System.Windows.Forms.Button();
            this.boxroomName = new System.Windows.Forms.ComboBox();
            this.btnShowInvitee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRooms.Location = new System.Drawing.Point(113, 302);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 62;
            this.dgvRooms.Size = new System.Drawing.Size(752, 320);
            this.dgvRooms.TabIndex = 0;
            // 
            // btnSpecificDate
            // 
            this.btnSpecificDate.Location = new System.Drawing.Point(306, 32);
            this.btnSpecificDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpecificDate.Name = "btnSpecificDate";
            this.btnSpecificDate.Size = new System.Drawing.Size(112, 44);
            this.btnSpecificDate.TabIndex = 1;
            this.btnSpecificDate.Text = "Check";
            this.btnSpecificDate.UseVisualStyleBackColor = true;
            this.btnSpecificDate.Click += new System.EventHandler(this.btnSpecificDate_Click);
            // 
            // SpecificDate
            // 
            this.SpecificDate.CustomFormat = "MM-dd-yyyy";
            this.SpecificDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SpecificDate.Location = new System.Drawing.Point(37, 32);
            this.SpecificDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecificDate.Name = "SpecificDate";
            this.SpecificDate.Size = new System.Drawing.Size(162, 26);
            this.SpecificDate.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.CustomFormat = "  ";
            this.btnStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.btnStart.Location = new System.Drawing.Point(29, 24);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShowUpDown = true;
            this.btnStart.Size = new System.Drawing.Size(172, 26);
            this.btnStart.TabIndex = 4;
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            // 
            // btnEnd
            // 
            this.btnEnd.CustomFormat = "  ";
            this.btnEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.btnEnd.Location = new System.Drawing.Point(29, 78);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.ShowUpDown = true;
            this.btnEnd.Size = new System.Drawing.Size(172, 26);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEnd_MouseDown);
            // 
            // btntimeStamp
            // 
            this.btntimeStamp.Location = new System.Drawing.Point(300, 47);
            this.btntimeStamp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimeStamp.Name = "btntimeStamp";
            this.btntimeStamp.Size = new System.Drawing.Size(112, 37);
            this.btntimeStamp.TabIndex = 6;
            this.btntimeStamp.Text = "Check";
            this.btntimeStamp.UseVisualStyleBackColor = true;
            this.btntimeStamp.Click += new System.EventHandler(this.btntimeStamp_Click);
            // 
            // boxroomName
            // 
            this.boxroomName.FormattingEnabled = true;
            this.boxroomName.Location = new System.Drawing.Point(34, 32);
            this.boxroomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxroomName.Name = "boxroomName";
            this.boxroomName.Size = new System.Drawing.Size(172, 28);
            this.boxroomName.TabIndex = 7;
            // 
            // btnShowInvitee
            // 
            this.btnShowInvitee.Location = new System.Drawing.Point(299, 33);
            this.btnShowInvitee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowInvitee.Name = "btnShowInvitee";
            this.btnShowInvitee.Size = new System.Drawing.Size(112, 43);
            this.btnShowInvitee.TabIndex = 8;
            this.btnShowInvitee.Text = "Check";
            this.btnShowInvitee.UseVisualStyleBackColor = true;
            this.btnShowInvitee.Click += new System.EventHandler(this.btnShowInvitee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpecificDate);
            this.groupBox1.Controls.Add(this.btnSpecificDate);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search with date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntimeStamp);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(254, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "check with time";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowInvitee);
            this.groupBox3.Controls.Add(this.boxroomName);
            this.groupBox3.Location = new System.Drawing.Point(520, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 84);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check with room name";
            // 
            // CheckRoomUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRooms);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckRoomUser";
            this.Text = "CheckRoomUser";
            this.Load += new System.EventHandler(this.CheckRoomUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnSpecificDate;
        private System.Windows.Forms.DateTimePicker SpecificDate;
        private System.Windows.Forms.DateTimePicker btnStart;
        private System.Windows.Forms.DateTimePicker btnEnd;
        private System.Windows.Forms.Button btntimeStamp;
        private System.Windows.Forms.ComboBox boxroomName;
        private System.Windows.Forms.Button btnShowInvitee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}