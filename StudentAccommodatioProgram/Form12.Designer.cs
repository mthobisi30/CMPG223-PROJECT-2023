
namespace StudentAccommodatioProgram
{
    partial class frmAgent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewAccommodation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccommodation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnLease);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dataGridViewAccommodation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 493);
            this.panel1.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(460, 394);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(127, 23);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Generate reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLease
            // 
            this.btnLease.Location = new System.Drawing.Point(460, 347);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(127, 23);
            this.btnLease.TabIndex = 6;
            this.btnLease.Text = "Approve Lease";
            this.btnLease.UseVisualStyleBackColor = true;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Logout";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(460, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Availability";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Accommodation";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(460, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Accommodation";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewAccommodation
            // 
            this.dataGridViewAccommodation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccommodation.Location = new System.Drawing.Point(22, 62);
            this.dataGridViewAccommodation.Name = "dataGridViewAccommodation";
            this.dataGridViewAccommodation.Size = new System.Drawing.Size(413, 399);
            this.dataGridViewAccommodation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent Dashboard";
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 542);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgent";
            this.Text = "AGENT DASHBOARD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccommodation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAccommodation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLease;
    }
}