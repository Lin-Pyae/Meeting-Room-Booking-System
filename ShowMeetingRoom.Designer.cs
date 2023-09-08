
namespace Database_Final_Project
{
    partial class ShowMeetingRoom
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
            this.gvRoomList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRoomList
            // 
            this.gvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRoomList.Location = new System.Drawing.Point(12, 12);
            this.gvRoomList.Name = "gvRoomList";
            this.gvRoomList.Size = new System.Drawing.Size(763, 339);
            this.gvRoomList.TabIndex = 0;
            this.gvRoomList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRoomList_CellClick);
            // 
            // ShowMeetingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvRoomList);
            this.Name = "ShowMeetingRoom";
            this.Text = "ShowMeetingRoom";
            this.Load += new System.EventHandler(this.ShowMeetingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRoomList;
    }
}