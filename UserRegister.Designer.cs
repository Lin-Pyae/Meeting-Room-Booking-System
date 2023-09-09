
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvgUser = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(284, 248);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(284, 64);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(148, 26);
            this.txtusername.TabIndex = 1;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(284, 123);
            this.txtpw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(148, 26);
            this.txtpw.TabIndex = 2;
            // 
            // txtisadmin
            // 
            this.txtisadmin.AutoSize = true;
            this.txtisadmin.Location = new System.Drawing.Point(284, 195);
            this.txtisadmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtisadmin.Name = "txtisadmin";
            this.txtisadmin.Size = new System.Drawing.Size(78, 24);
            this.txtisadmin.TabIndex = 4;
            this.txtisadmin.Text = "admin";
            this.txtisadmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtisadmin);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtpw);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Location = new System.Drawing.Point(50, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 326);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // gvgUser
            // 
            this.gvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvgUser.Location = new System.Drawing.Point(50, 397);
            this.gvgUser.Name = "gvgUser";
            this.gvgUser.RowHeadersWidth = 62;
            this.gvgUser.RowTemplate.Height = 28;
            this.gvgUser.Size = new System.Drawing.Size(586, 206);
            this.gvgUser.TabIndex = 6;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 650);
            this.Controls.Add(this.gvgUser);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserRegister";
            this.Text = "User Registeration";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.CheckBox txtisadmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvgUser;
    }
}