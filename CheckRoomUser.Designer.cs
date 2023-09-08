
namespace Database_Final_Project
{
    partial class CheckRoomUser
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnSpecificDate = new System.Windows.Forms.Button();
            this.SpecificDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(236, 50);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(412, 208);
            this.dgvRooms.TabIndex = 0;
            // 
            // btnSpecificDate
            // 
            this.btnSpecificDate.Location = new System.Drawing.Point(331, 277);
            this.btnSpecificDate.Name = "btnSpecificDate";
            this.btnSpecificDate.Size = new System.Drawing.Size(75, 23);
            this.btnSpecificDate.TabIndex = 1;
            this.btnSpecificDate.Text = "Find";
            this.btnSpecificDate.UseVisualStyleBackColor = true;
            this.btnSpecificDate.Click += new System.EventHandler(this.btnSpecificDate_Click);
            // 
            // SpecificDate
            // 
            this.SpecificDate.CustomFormat = "MM-dd-yyyy";
            this.SpecificDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SpecificDate.Location = new System.Drawing.Point(458, 280);
            this.SpecificDate.Name = "SpecificDate";
            this.SpecificDate.Size = new System.Drawing.Size(109, 20);
            this.SpecificDate.TabIndex = 2;
            // 
            // CheckRoomUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpecificDate);
            this.Controls.Add(this.btnSpecificDate);
            this.Controls.Add(this.dgvRooms);
            this.Name = "CheckRoomUser";
            this.Text = "CheckRoomUser";
            this.Load += new System.EventHandler(this.CheckRoomUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnSpecificDate;
        private System.Windows.Forms.DateTimePicker SpecificDate;
    }
}