
namespace Database_Final_Project
{
    partial class UserRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtisadmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(368, 224);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(368, 67);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 1;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(368, 115);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(100, 20);
            this.txtpw.TabIndex = 2;
            // 
            // txtisadmin
            // 
            this.txtisadmin.AutoSize = true;
            this.txtisadmin.Location = new System.Drawing.Point(368, 168);
            this.txtisadmin.Name = "txtisadmin";
            this.txtisadmin.Size = new System.Drawing.Size(54, 17);
            this.txtisadmin.TabIndex = 4;
            this.txtisadmin.Text = "admin";
            this.txtisadmin.UseVisualStyleBackColor = true;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtisadmin);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnRegister);
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.CheckBox txtisadmin;
    }
}