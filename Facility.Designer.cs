
namespace Database_Final_Project
{
    partial class Facility
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
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvFacility = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFacility
            // 
            this.txtFacility.Location = new System.Drawing.Point(153, 59);
            this.txtFacility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(211, 26);
            this.txtFacility.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(252, 111);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 35);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add Facility";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvFacility
            // 
            this.dgvFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacility.Location = new System.Drawing.Point(151, 224);
            this.dgvFacility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFacility.Name = "dgvFacility";
            this.dgvFacility.RowHeadersWidth = 62;
            this.dgvFacility.Size = new System.Drawing.Size(429, 231);
            this.dgvFacility.TabIndex = 2;
            this.dgvFacility.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacility_CellClick);
            this.dgvFacility.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacility_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facility Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtFacility);
            this.groupBox1.Location = new System.Drawing.Point(151, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Facility";
            // 
            // Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFacility);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Facility";
            this.Text = "Facility";
            this.Load += new System.EventHandler(this.Facility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvFacility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}