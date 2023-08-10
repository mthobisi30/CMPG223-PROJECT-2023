
namespace StudentAccommodatioProgram
{
    partial class frmPayment
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBursary = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlEFT = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHolder = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBursar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFilePOP = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBursary.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.pnlEFT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbPayment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 162);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 524);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(644, 522);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 39);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(136, 109);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Amount(R):";
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Bursary",
            "EFT",
            "Cash"});
            this.cmbPayment.Location = new System.Drawing.Point(136, 40);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(126, 21);
            this.cmbPayment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose payment method:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Gateway";
            // 
            // pnlBursary
            // 
            this.pnlBursary.Controls.Add(this.label12);
            this.pnlBursary.Controls.Add(this.label14);
            this.pnlBursary.Controls.Add(this.txtCellphone);
            this.pnlBursary.Controls.Add(this.label11);
            this.pnlBursary.Controls.Add(this.txtBursar);
            this.pnlBursary.Controls.Add(this.button1);
            this.pnlBursary.Controls.Add(this.button2);
            this.pnlBursary.Controls.Add(this.txtMail);
            this.pnlBursary.Controls.Add(this.label4);
            this.pnlBursary.Controls.Add(this.label5);
            this.pnlBursary.Location = new System.Drawing.Point(323, 281);
            this.pnlBursary.Name = "pnlBursary";
            this.pnlBursary.Size = new System.Drawing.Size(288, 213);
            this.pnlBursary.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(136, 96);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(126, 20);
            this.txtMail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.label15);
            this.pnlCash.Controls.Add(this.txtBrowse);
            this.pnlCash.Controls.Add(this.btnBrowse);
            this.pnlCash.Controls.Add(this.btnUpload);
            this.pnlCash.Controls.Add(this.button4);
            this.pnlCash.Controls.Add(this.txtRef);
            this.pnlCash.Controls.Add(this.label6);
            this.pnlCash.Controls.Add(this.label7);
            this.pnlCash.Location = new System.Drawing.Point(644, 281);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(288, 213);
            this.pnlCash.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(142, 126);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(126, 20);
            this.txtRef.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Reference(Initials&Surname):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Upload Proof of Payment:";
            // 
            // pnlEFT
            // 
            this.pnlEFT.Controls.Add(this.label13);
            this.pnlEFT.Controls.Add(this.label10);
            this.pnlEFT.Controls.Add(this.txtAccNo);
            this.pnlEFT.Controls.Add(this.txtHolder);
            this.pnlEFT.Controls.Add(this.button5);
            this.pnlEFT.Controls.Add(this.button6);
            this.pnlEFT.Controls.Add(this.txtBank);
            this.pnlEFT.Controls.Add(this.label8);
            this.pnlEFT.Controls.Add(this.label9);
            this.pnlEFT.Location = new System.Drawing.Point(12, 281);
            this.pnlEFT.Name = "pnlEFT";
            this.pnlEFT.Size = new System.Drawing.Size(288, 213);
            this.pnlEFT.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Submit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(136, 99);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(126, 20);
            this.txtBank.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bank Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Account Holder:";
            // 
            // txtHolder
            // 
            this.txtHolder.Location = new System.Drawing.Point(136, 47);
            this.txtHolder.Name = "txtHolder";
            this.txtHolder.Size = new System.Drawing.Size(126, 20);
            this.txtHolder.TabIndex = 7;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(136, 157);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(126, 20);
            this.txtAccNo.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 524);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtBursar
            // 
            this.txtBursar.Location = new System.Drawing.Point(136, 49);
            this.txtBursar.Name = "txtBursar";
            this.txtBursar.Size = new System.Drawing.Size(126, 20);
            this.txtBursar.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Account Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bursar Name:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(136, 157);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(126, 20);
            this.txtCellphone.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cellphone:";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(97, 175);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(188, 70);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse File...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(9, 73);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(180, 20);
            this.txtBrowse.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(77, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "EFT PAYMENT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(64, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "BURSARY PAYMENT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "CASH PAYMENT";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 607);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlBursary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlEFT);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmPayment";
            this.Text = "PAYMENT GATEWAY";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBursary.ResumeLayout(false);
            this.pnlBursary.PerformLayout();
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlEFT.ResumeLayout(false);
            this.pnlEFT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlBursary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlEFT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBursar;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtHolder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFilePOP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}