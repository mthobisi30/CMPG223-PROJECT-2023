
namespace StudentAccommodatioProgram
{
    partial class frmWelcome
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
            this.btnNext = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdbtnAgent = new System.Windows.Forms.RadioButton();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.rdbtnAgent);
            this.panel1.Controls.Add(this.rdbtnStudent);
            this.panel1.Location = new System.Drawing.Point(171, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 330);
            this.panel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(175, 263);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 27);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "WELCOME TO CAMPUS CASA !",
            "",
            "Whether you\'re a dedicated student embarking on your educational journey or ",
            "a diligent real estate agent facilitating seamless accommodations,",
            " we are thrilled to accommodate you.",
            "",
            "Thank you for choosing our program, ",
            "please indicate whether you are a student or agent below and then CLICK Next"});
            this.listBox1.Location = new System.Drawing.Point(41, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(393, 147);
            this.listBox1.TabIndex = 2;
            // 
            // rdbtnAgent
            // 
            this.rdbtnAgent.AutoSize = true;
            this.rdbtnAgent.Location = new System.Drawing.Point(248, 210);
            this.rdbtnAgent.Name = "rdbtnAgent";
            this.rdbtnAgent.Size = new System.Drawing.Size(53, 17);
            this.rdbtnAgent.TabIndex = 1;
            this.rdbtnAgent.TabStop = true;
            this.rdbtnAgent.Text = "Agent";
            this.rdbtnAgent.UseVisualStyleBackColor = true;
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.AutoSize = true;
            this.rdbtnStudent.Location = new System.Drawing.Point(91, 210);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(62, 17);
            this.rdbtnStudent.TabIndex = 0;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "Student";
            this.rdbtnStudent.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(171, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 50);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPUS CASA";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmWelcome";
            this.Text = "WELCOME PAGE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdbtnAgent;
        private System.Windows.Forms.RadioButton rdbtnStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

