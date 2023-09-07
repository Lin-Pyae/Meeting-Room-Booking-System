
namespace Database_Final_Project
{
    partial class BookMeetingRoom
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
            this.txtroom = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.ComboBox();
            this.usertxt = new System.Windows.Forms.Label();
            this.roomtxt = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.endtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtroom
            // 
            this.txtroom.FormattingEnabled = true;
            this.txtroom.Location = new System.Drawing.Point(340, 137);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(96, 21);
            this.txtroom.TabIndex = 0;
            // 
            // txtuser
            // 
            this.txtuser.FormattingEnabled = true;
            this.txtuser.Location = new System.Drawing.Point(340, 95);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(96, 21);
            this.txtuser.TabIndex = 1;
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(231, 95);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(60, 13);
            this.usertxt.TabIndex = 2;
            this.usertxt.Text = "User Name";
            // 
            // roomtxt
            // 
            this.roomtxt.AutoSize = true;
            this.roomtxt.Location = new System.Drawing.Point(231, 145);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(66, 13);
            this.roomtxt.TabIndex = 3;
            this.roomtxt.Text = "Room Name";
            // 
            // datetxt
            // 
            this.datetxt.AutoSize = true;
            this.datetxt.Location = new System.Drawing.Point(261, 195);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(30, 13);
            this.datetxt.TabIndex = 4;
            this.datetxt.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "MM-dd-yyyy";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(340, 188);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(96, 20);
            this.txtDate.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.CustomFormat = "  ";
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEnd.Location = new System.Drawing.Point(340, 273);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ShowUpDown = true;
            this.txtEnd.Size = new System.Drawing.Size(118, 20);
            this.txtEnd.TabIndex = 6;
            this.txtEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEnd_MouseDown);
            // 
            // endtxt
            // 
            this.endtxt.AutoSize = true;
            this.endtxt.Location = new System.Drawing.Point(242, 280);
            this.endtxt.Name = "endtxt";
            this.endtxt.Size = new System.Drawing.Size(52, 13);
            this.endtxt.TabIndex = 7;
            this.endtxt.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "End Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(245, 326);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book Room";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // BookMeetingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.endtxt);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.roomtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtroom);
            this.Name = "BookMeetingRoom";
            this.Text = "BookMeetingRoom";
            this.Load += new System.EventHandler(this.BookMeetingRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtroom;
        private System.Windows.Forms.ComboBox txtuser;
        private System.Windows.Forms.Label usertxt;
        private System.Windows.Forms.Label roomtxt;
        private System.Windows.Forms.Label datetxt;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.Label endtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBook;
    }
}