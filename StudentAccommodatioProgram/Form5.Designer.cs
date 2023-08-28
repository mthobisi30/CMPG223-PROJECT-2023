
namespace StudentAccommodatioProgram
{
    partial class frmAccommodation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.btnGallery = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.rdApartments = new System.Windows.Forms.RadioButton();
            this.rdFlats = new System.Windows.Forms.RadioButton();
            this.rdHouse = new System.Windows.Forms.RadioButton();
            this.rdLofts = new System.Windows.Forms.RadioButton();
            this.rdHome = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblList);
            this.panel1.Controls.Add(this.btnGallery);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Controls.Add(this.rdApartments);
            this.panel1.Controls.Add(this.rdFlats);
            this.panel1.Controls.Add(this.rdHouse);
            this.panel1.Controls.Add(this.rdLofts);
            this.panel1.Controls.Add(this.rdHome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 418);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Accommodation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Specifications:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(10, 124);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(161, 17);
            this.lblList.TabIndex = 9;
            this.lblList.Text = "List of Accommodations:";
            // 
            // btnGallery
            // 
            this.btnGallery.Location = new System.Drawing.Point(508, 269);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(108, 23);
            this.btnGallery.TabIndex = 8;
            this.btnGallery.Text = "View Gallery";
            this.btnGallery.UseVisualStyleBackColor = true;
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(508, 360);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(108, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select && Continue";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(508, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(189, 165);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(285, 226);
            this.txtDisplay.TabIndex = 5;
            // 
            // rdApartments
            // 
            this.rdApartments.AutoSize = true;
            this.rdApartments.Location = new System.Drawing.Point(13, 332);
            this.rdApartments.Name = "rdApartments";
            this.rdApartments.Size = new System.Drawing.Size(130, 17);
            this.rdApartments.TabIndex = 4;
            this.rdApartments.TabStop = true;
            this.rdApartments.Text = "StayHome Apartments";
            this.rdApartments.UseVisualStyleBackColor = true;
            this.rdApartments.CheckedChanged += new System.EventHandler(this.rdApartments_CheckedChanged);
            // 
            // rdFlats
            // 
            this.rdFlats.AutoSize = true;
            this.rdFlats.Location = new System.Drawing.Point(13, 287);
            this.rdFlats.Name = "rdFlats";
            this.rdFlats.Size = new System.Drawing.Size(88, 17);
            this.rdFlats.TabIndex = 3;
            this.rdFlats.TabStop = true;
            this.rdFlats.Text = "Campus Flats";
            this.rdFlats.UseVisualStyleBackColor = true;
            this.rdFlats.CheckedChanged += new System.EventHandler(this.rdFlats_CheckedChanged);
            // 
            // rdHouse
            // 
            this.rdHouse.AutoSize = true;
            this.rdHouse.Location = new System.Drawing.Point(13, 243);
            this.rdHouse.Name = "rdHouse";
            this.rdHouse.Size = new System.Drawing.Size(127, 17);
            this.rdHouse.TabIndex = 2;
            this.rdHouse.TabStop = true;
            this.rdHouse.Text = "Student Living House";
            this.rdHouse.UseVisualStyleBackColor = true;
            this.rdHouse.CheckedChanged += new System.EventHandler(this.rdHouse_CheckedChanged);
            // 
            // rdLofts
            // 
            this.rdLofts.AutoSize = true;
            this.rdLofts.Location = new System.Drawing.Point(13, 207);
            this.rdLofts.Name = "rdLofts";
            this.rdLofts.Size = new System.Drawing.Size(100, 17);
            this.rdLofts.TabIndex = 1;
            this.rdLofts.TabStop = true;
            this.rdLofts.Text = "StudySafe Lofts";
            this.rdLofts.UseVisualStyleBackColor = true;
            this.rdLofts.CheckedChanged += new System.EventHandler(this.rdLofts_CheckedChanged);
            // 
            // rdHome
            // 
            this.rdHome.AutoSize = true;
            this.rdHome.Location = new System.Drawing.Point(13, 166);
            this.rdHome.Name = "rdHome";
            this.rdHome.Size = new System.Drawing.Size(82, 17);
            this.rdHome.TabIndex = 0;
            this.rdHome.TabStop = true;
            this.rdHome.Text = "Away Home";
            this.rdHome.UseVisualStyleBackColor = true;
            this.rdHome.CheckedChanged += new System.EventHandler(this.rdHome_CheckedChanged);
            // 
            // frmAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccommodation";
            this.Text = "Accommodation Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnGallery;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.RadioButton rdApartments;
        private System.Windows.Forms.RadioButton rdFlats;
        private System.Windows.Forms.RadioButton rdHouse;
        private System.Windows.Forms.RadioButton rdLofts;
        private System.Windows.Forms.RadioButton rdHome;
    }
}