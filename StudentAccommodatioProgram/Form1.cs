using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodatioProgram
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(rdbtnStudent.Checked)
            {
                frmRegisterStudent registerStudent = new frmRegisterStudent();
                registerStudent.Show();
            }
            else if(rdbtnAgent.Checked)
            {
                frmRegistratioAgent registratioAgent = new frmRegistratioAgent();
                registratioAgent.Show();
            }
            else
            { 
                MessageBox.Show("Please select whether you are a student or an agent.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
    }
}
