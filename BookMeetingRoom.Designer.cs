
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtroom
            // 
            this.txtroom.FormattingEnabled = true;
            this.txtroom.Location = new System.Drawing.Point(292, 108);
            this.txtroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(142, 28);
            this.txtroom.TabIndex = 0;
            this.txtroom.SelectedIndexChanged += new System.EventHandler(this.txtroom_SelectedIndexChanged);
            // 
            // txtuser
            // 
            this.txtuser.FormattingEnabled = true;
            this.txtuser.Location = new System.Drawing.Point(292, 58);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(142, 28);
            this.txtuser.TabIndex = 1;
            this.txtuser.SelectedIndexChanged += new System.EventHandler(this.txtuser_SelectedIndexChanged);
            // 
            // usertxt
            // 
            this.usertxt.AutoSize = true;
            this.usertxt.Location = new System.Drawing.Point(128, 58);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(89, 20);
            this.usertxt.TabIndex = 2;
            this.usertxt.Text = "User Name";
            // 
            // roomtxt
            // 
            this.roomtxt.AutoSize = true;
            this.roomtxt.Location = new System.Drawing.Point(128, 108);
            this.roomtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(98, 20);
            this.roomtxt.TabIndex = 3;
            this.roomtxt.Text = "Room Name";
            // 
            // datetxt
            // 
            this.datetxt.AutoSize = true;
            this.datetxt.Location = new System.Drawing.Point(128, 162);
            this.datetxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(44, 20);
            this.datetxt.TabIndex = 4;
            this.datetxt.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "MM-dd-yyyy";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(292, 162);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(142, 26);
            this.txtDate.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.CustomFormat = "  ";
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEnd.Location = new System.Drawing.Point(292, 271);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ShowUpDown = true;
            this.txtEnd.Size = new System.Drawing.Size(175, 26);
            this.txtEnd.TabIndex = 6;
            this.txtEnd.ValueChanged += new System.EventHandler(this.txtEnd_ValueChanged);
            this.txtEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEnd_MouseDown);
            // 
            // endtxt
            // 
            this.endtxt.AutoSize = true;
            this.endtxt.Location = new System.Drawing.Point(134, 271);
            this.endtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endtxt.Name = "endtxt";
            this.endtxt.Size = new System.Drawing.Size(76, 20);
            this.endtxt.TabIndex = 7;
            this.endtxt.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 214);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(355, 349);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(112, 35);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book Room";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.endtxt);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.datetxt);
            this.groupBox1.Controls.Add(this.roomtxt);
            this.groupBox1.Controls.Add(this.usertxt);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.txtroom);
            this.groupBox1.Location = new System.Drawing.Point(116, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 413);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BookMeetingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookMeetingRoom";
            this.Text = "BookMeetingRoom";
            this.Load += new System.EventHandler(this.BookMeetingRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}