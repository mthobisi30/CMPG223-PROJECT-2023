
namespace StudentAccommodatioProgram
{
    partial class frmLease
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtTerms = new System.Windows.Forms.RichTextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpArrival = new System.Windows.Forms.DateTimePicker();
            this.dpDeparture = new System.Windows.Forms.DateTimePicker();
            this.chkSigned = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFilePDF = new System.Windows.Forms.SaveFileDialog();
            this.rbtnYES = new System.Windows.Forms.RadioButton();
            this.rbtnNO = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnNO);
            this.panel1.Controls.Add(this.rbtnYES);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.chkSigned);
            this.panel1.Controls.Add(this.dpDeparture);
            this.panel1.Controls.Add(this.dpArrival);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chkTerms);
            this.panel1.Controls.Add(this.txtSignature);
            this.panel1.Controls.Add(this.rtTerms);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 629);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lease Agreement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Signature(Name):";
            // 
            // rtTerms
            // 
            this.rtTerms.Location = new System.Drawing.Point(18, 62);
            this.rtTerms.Name = "rtTerms";
            this.rtTerms.Size = new System.Drawing.Size(609, 199);
            this.rtTerms.TabIndex = 4;
            this.rtTerms.Text = "";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(109, 383);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(200, 20);
            this.txtSignature.TabIndex = 7;
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(18, 436);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(193, 17);
            this.chkTerms.TabIndex = 8;
            this.chkTerms.Text = "I Have read the Terms && Conditions";
            this.chkTerms.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Arrival Date:";
            // 
            // dpArrival
            // 
            this.dpArrival.Location = new System.Drawing.Point(109, 288);
            this.dpArrival.Name = "dpArrival";
            this.dpArrival.Size = new System.Drawing.Size(200, 20);
            this.dpArrival.TabIndex = 11;
            // 
            // dpDeparture
            // 
            this.dpDeparture.Location = new System.Drawing.Point(109, 336);
            this.dpDeparture.Name = "dpDeparture";
            this.dpDeparture.Size = new System.Drawing.Size(200, 20);
            this.dpDeparture.TabIndex = 12;
            // 
            // chkSigned
            // 
            this.chkSigned.AutoSize = true;
            this.chkSigned.Location = new System.Drawing.Point(18, 477);
            this.chkSigned.Name = "chkSigned";
            this.chkSigned.Size = new System.Drawing.Size(150, 17);
            this.chkSigned.TabIndex = 13;
            this.chkSigned.Text = "I have signed the contract";
            this.chkSigned.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 586);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(552, 586);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Download Contract:";
            // 
            // rbtnYES
            // 
            this.rbtnYES.AutoSize = true;
            this.rbtnYES.Location = new System.Drawing.Point(138, 519);
            this.rbtnYES.Name = "rbtnYES";
            this.rbtnYES.Size = new System.Drawing.Size(46, 17);
            this.rbtnYES.TabIndex = 18;
            this.rbtnYES.TabStop = true;
            this.rbtnYES.Text = "YES";
            this.rbtnYES.UseVisualStyleBackColor = true;
            // 
            // rbtnNO
            // 
            this.rbtnNO.AutoSize = true;
            this.rbtnNO.Location = new System.Drawing.Point(205, 518);
            this.rbtnNO.Name = "rbtnNO";
            this.rbtnNO.Size = new System.Drawing.Size(41, 17);
            this.rbtnNO.TabIndex = 19;
            this.rbtnNO.TabStop = true;
            this.rbtnNO.Text = "NO";
            this.rbtnNO.UseVisualStyleBackColor = true;
            // 
            // frmLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 655);
            this.Controls.Add(this.panel1);
            this.Name = "frmLease";
            this.Text = "LEASE AGREEMENT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnNO;
        private System.Windows.Forms.RadioButton rbtnYES;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkSigned;
        private System.Windows.Forms.DateTimePicker dpDeparture;
        private System.Windows.Forms.DateTimePicker dpArrival;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.RichTextBox rtTerms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFilePDF;
    }
}