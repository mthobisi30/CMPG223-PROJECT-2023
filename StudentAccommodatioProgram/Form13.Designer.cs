
namespace StudentAccommodatioProgram
{
    partial class frmAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccomName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtrentAmt = new System.Windows.Forms.TextBox();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShared = new System.Windows.Forms.TextBox();
            this.txtFacilities = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpots = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkWifi = new System.Windows.Forms.CheckBox();
            this.chkParking = new System.Windows.Forms.CheckBox();
            this.rdMales = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMixed = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accommodation Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Accommodation address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accommodation Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rent Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Agent Name:";
            // 
            // txtAccomName
            // 
            this.txtAccomName.Location = new System.Drawing.Point(178, 13);
            this.txtAccomName.Name = "txtAccomName";
            this.txtAccomName.Size = new System.Drawing.Size(171, 20);
            this.txtAccomName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(178, 54);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtrentAmt
            // 
            this.txtrentAmt.Location = new System.Drawing.Point(178, 138);
            this.txtrentAmt.Name = "txtrentAmt";
            this.txtrentAmt.Size = new System.Drawing.Size(171, 20);
            this.txtrentAmt.TabIndex = 8;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(178, 186);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(171, 20);
            this.txtAgentName.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(253, 360);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Student House",
            "Apartment",
            ""});
            this.cmbType.Location = new System.Drawing.Point(178, 97);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(171, 21);
            this.cmbType.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shared Rooms(Number):";
            // 
            // txtShared
            // 
            this.txtShared.Location = new System.Drawing.Point(178, 236);
            this.txtShared.Name = "txtShared";
            this.txtShared.Size = new System.Drawing.Size(41, 20);
            this.txtShared.TabIndex = 14;
            // 
            // txtFacilities
            // 
            this.txtFacilities.Location = new System.Drawing.Point(178, 277);
            this.txtFacilities.Name = "txtFacilities";
            this.txtFacilities.Size = new System.Drawing.Size(171, 20);
            this.txtFacilities.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Shared Facilities:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(594, 251);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(272, 99);
            this.txtDescription.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Description and extra Information:";
            // 
            // txtSpots
            // 
            this.txtSpots.Location = new System.Drawing.Point(594, 150);
            this.txtSpots.Name = "txtSpots";
            this.txtSpots.Size = new System.Drawing.Size(41, 20);
            this.txtSpots.TabIndex = 24;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(594, 21);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(41, 20);
            this.txtDistance.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "WIFI Availability:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Number of Spots Available:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Parking Availability:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(423, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "gender diversity:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(423, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Distance To Campus:";
            // 
            // chkWifi
            // 
            this.chkWifi.AutoSize = true;
            this.chkWifi.Location = new System.Drawing.Point(594, 197);
            this.chkWifi.Name = "chkWifi";
            this.chkWifi.Size = new System.Drawing.Size(69, 17);
            this.chkWifi.TabIndex = 31;
            this.chkWifi.Text = "Available";
            this.chkWifi.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            this.chkParking.AutoSize = true;
            this.chkParking.Location = new System.Drawing.Point(594, 105);
            this.chkParking.Name = "chkParking";
            this.chkParking.Size = new System.Drawing.Size(69, 17);
            this.chkParking.TabIndex = 32;
            this.chkParking.Text = "Available";
            this.chkParking.UseVisualStyleBackColor = true;
            // 
            // rdMales
            // 
            this.rdMales.AutoSize = true;
            this.rdMales.Location = new System.Drawing.Point(594, 62);
            this.rdMales.Name = "rdMales";
            this.rdMales.Size = new System.Drawing.Size(72, 17);
            this.rdMales.TabIndex = 33;
            this.rdMales.TabStop = true;
            this.rdMales.Text = "Male Only";
            this.rdMales.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(701, 62);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(83, 17);
            this.rdFemale.TabIndex = 34;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female Only";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMixed
            // 
            this.rdMixed.AutoSize = true;
            this.rdMixed.Location = new System.Drawing.Point(811, 62);
            this.rdMixed.Name = "rdMixed";
            this.rdMixed.Size = new System.Drawing.Size(53, 17);
            this.rdMixed.TabIndex = 35;
            this.rdMixed.TabStop = true;
            this.rdMixed.Text = "Mixed";
            this.rdMixed.UseVisualStyleBackColor = true;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 395);
            this.Controls.Add(this.rdMixed);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMales);
            this.Controls.Add(this.chkParking);
            this.Controls.Add(this.chkWifi);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSpots);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFacilities);
            this.Controls.Add(this.txtShared);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.txtrentAmt);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAccomName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdd";
            this.Text = "Add New Accommodation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccomName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtrentAmt;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShared;
        private System.Windows.Forms.TextBox txtFacilities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSpots;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkWifi;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.RadioButton rdMales;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMixed;
    }
}