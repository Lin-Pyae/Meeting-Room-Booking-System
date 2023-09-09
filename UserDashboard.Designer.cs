
namespace Database_Final_Project
{
    partial class UserDashboard
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
            this.btnshowroom = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowroom
            // 
            this.btnshowroom.Location = new System.Drawing.Point(344, 133);
            this.btnshowroom.Name = "btnshowroom";
            this.btnshowroom.Size = new System.Drawing.Size(133, 23);
            this.btnshowroom.TabIndex = 0;
            this.btnshowroom.Text = "Check Rooms";
            this.btnshowroom.UseVisualStyleBackColor = true;
            this.btnshowroom.Click += new System.EventHandler(this.btnshowroom_Click);
            // 
            // btnbook
            // 
            this.btnbook.Location = new System.Drawing.Point(344, 192);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(133, 23);
            this.btnbook.TabIndex = 1;
            this.btnbook.Text = "Book Room";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.btnshowroom);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshowroom;
        private System.Windows.Forms.Button btnbook;
    }
}