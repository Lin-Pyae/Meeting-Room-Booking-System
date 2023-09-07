
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
            this.topic = new System.Windows.Forms.Label();
            this.addroombtn = new System.Windows.Forms.Button();
            this.showroombtn = new System.Windows.Forms.Button();
            this.bookroombtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topic
            // 
            this.topic.AutoSize = true;
            this.topic.Location = new System.Drawing.Point(344, 32);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(155, 13);
            this.topic.TabIndex = 0;
            this.topic.Text = "Meeting Room Booking System";
            // 
            // addroombtn
            // 
            this.addroombtn.Location = new System.Drawing.Point(363, 107);
            this.addroombtn.Name = "addroombtn";
            this.addroombtn.Size = new System.Drawing.Size(120, 23);
            this.addroombtn.TabIndex = 1;
            this.addroombtn.Text = "Add Meeting Room";
            this.addroombtn.UseVisualStyleBackColor = true;
            this.addroombtn.Click += new System.EventHandler(this.addroombtn_Click);
            // 
            // showroombtn
            // 
            this.showroombtn.Location = new System.Drawing.Point(363, 155);
            this.showroombtn.Name = "showroombtn";
            this.showroombtn.Size = new System.Drawing.Size(120, 23);
            this.showroombtn.TabIndex = 2;
            this.showroombtn.Text = "Show Meeting Rooms";
            this.showroombtn.UseVisualStyleBackColor = true;
            this.showroombtn.Click += new System.EventHandler(this.showroombtn_Click);
            // 
            // bookroombtn
            // 
            this.bookroombtn.Location = new System.Drawing.Point(383, 215);
            this.bookroombtn.Name = "bookroombtn";
            this.bookroombtn.Size = new System.Drawing.Size(75, 23);
            this.bookroombtn.TabIndex = 3;
            this.bookroombtn.Text = "Book Room";
            this.bookroombtn.UseVisualStyleBackColor = true;
            this.bookroombtn.Click += new System.EventHandler(this.bookroombtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookroombtn);
            this.Controls.Add(this.showroombtn);
            this.Controls.Add(this.addroombtn);
            this.Controls.Add(this.topic);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic;
        private System.Windows.Forms.Button addroombtn;
        private System.Windows.Forms.Button showroombtn;
        private System.Windows.Forms.Button bookroombtn;
    }
}