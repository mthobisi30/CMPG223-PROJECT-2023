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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        public string accName => txtAccomName.Text;
        public string address => txtAddress.Text;
        public string type => cmbType.SelectedItem.ToString();
        public decimal rent => decimal.Parse(txtrentAmt.Text);
        public string agentName => txtAgentName.Text;
        public decimal Distance => decimal.Parse( txtDistance.Text);
        public Boolean parking => chkParking.Checked;
        public Boolean wifi => chkWifi.Checked;
        public int numberSpots => int.Parse(txtSpots.Text);
        private  string Gender()
        {
            if(rdMales.Checked)
            {
                return "Male";
            }
            else if(rdFemale.Checked)
            {
                return "Female";
            }
            else if (rdMixed.Checked)
            {
                return "Mixed";
            }
            else
            {
                return "Unspecified";
            }
        }
        public string gender => Gender();
        public string description => txtDescription.Text;

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmAgent agent = new frmAgent();
        }
    }
}
