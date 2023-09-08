
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFacility
            // 
            this.txtFacility.Location = new System.Drawing.Point(283, 264);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(142, 20);
            this.txtFacility.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(460, 261);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add Facility";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvFacility
            // 
            this.dgvFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacility.Location = new System.Drawing.Point(283, 74);
            this.dgvFacility.Name = "dgvFacility";
            this.dgvFacility.Size = new System.Drawing.Size(252, 151);
            this.dgvFacility.TabIndex = 2;
            this.dgvFacility.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacility_CellClick);
            // 
            // Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFacility);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtFacility);
            this.Name = "Facility";
            this.Text = "Facility";
            this.Load += new System.EventHandler(this.Facility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvFacility;
    }
}