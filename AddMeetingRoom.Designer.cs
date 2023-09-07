
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
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(216, 72);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(66, 13);
            this.roomName.TabIndex = 0;
            this.roomName.Text = "Room Name";
            this.roomName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(321, 69);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomName.TabIndex = 1;
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.Location = new System.Drawing.Point(321, 115);
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtRoomCapacity.TabIndex = 3;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(216, 118);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(79, 13);
            this.capacity.TabIndex = 2;
            this.capacity.Text = "Room Capacity";
            this.capacity.Click += new System.EventHandler(this.label2_Click);
            // 
            // addRoombtn
            // 
            this.addRoombtn.Location = new System.Drawing.Point(220, 185);
            this.addRoombtn.Name = "addRoombtn";
            this.addRoombtn.Size = new System.Drawing.Size(75, 23);
            this.addRoombtn.TabIndex = 4;
            this.addRoombtn.Text = "Add Room";
            this.addRoombtn.UseVisualStyleBackColor = true;
            this.addRoombtn.Click += new System.EventHandler(this.addRoombtn_Click);
            // 
            // AddMeetingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRoombtn);
            this.Controls.Add(this.txtRoomCapacity);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.roomName);
            this.Name = "AddMeetingRoom";
            this.Text = "Add Meeting Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Button addRoombtn;
    }
}