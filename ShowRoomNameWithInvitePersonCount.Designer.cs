
namespace Database_Final_Project
{
    partial class ShowRoomNameWithInvitePersonCount
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
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnfind = new System.Windows.Forms.Button();
            this.gvList = new System.Windows.Forms.DataGridView();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtroom
            // 
            this.txtroom.FormattingEnabled = true;
            this.txtroom.Location = new System.Drawing.Point(133, 280);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(121, 21);
            this.txtroom.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "MM-dd-yyyy";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(301, 281);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(96, 20);
            this.txtDate.TabIndex = 6;
            // 
            // txtEnd
            // 
            this.txtEnd.CustomFormat = "  ";
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEnd.Location = new System.Drawing.Point(606, 281);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ShowUpDown = true;
            this.txtEnd.Size = new System.Drawing.Size(118, 20);
            this.txtEnd.TabIndex = 10;
            this.txtEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEnd_MouseDown_1);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(393, 318);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 11;
            this.btnfind.Text = "Submit";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // gvList
            // 
            this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvList.Location = new System.Drawing.Point(216, 62);
            this.gvList.Name = "gvList";
            this.gvList.Size = new System.Drawing.Size(424, 171);
            this.gvList.TabIndex = 12;
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "  ";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(447, 281);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(118, 20);
            this.startTime.TabIndex = 13;
            this.startTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startTime_KeyDown);
            this.startTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startTime_MouseDown_1);
            // 
            // ShowRoomNameWithInvitePersonCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.gvList);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtroom);
            this.Name = "ShowRoomNameWithInvitePersonCount";
            this.Text = "ShowRoomNameWithInvitePersonCount";
            this.Load += new System.EventHandler(this.ShowRoomNameWithInvitePersonCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtroom;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DataGridView gvList;
        private System.Windows.Forms.DateTimePicker startTime;
    }
}