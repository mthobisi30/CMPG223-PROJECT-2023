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
    public partial class InputBox : Form
    {
        public InputBox(string prompt)
        {
            InitializeComponent();
            label1.Text = prompt;
        }
        public string container { get; private set; }
        public string counter { get; private set; }
        private void btnOk_Click(object sender, EventArgs e)
        {
            container = txtInptBox.Text;
            counter = txtCounter.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
