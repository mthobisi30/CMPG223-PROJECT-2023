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
    public partial class frmImages : Form
    {
        public frmImages()
        {
            InitializeComponent();
        }
        private List<Image> images = new List<Image>(); // Declare the images list as a field
        private int currentIndex = 0;


        private void LoadImages()
        {
            // Load your images and add them to the images list
            images.Add(Properties.Resources.Image1);
            images.Add(Properties.Resources.Image2);
            images.Add(Properties.Resources.Image3);
            // Add more images as needed
        }
        private void UpdatePictureBox()
        {
            if (images.Count > 0)
            {
                pictureBox1.Image = images[currentIndex];
                lblImageNumber.Text = $"{currentIndex + 1}/{images.Count}";
            }
            else
            {
                pictureBox1.Image = null;
                lblImageNumber.Text = "No Images";
            }
        }
        private void frmImages_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            UpdatePictureBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            UpdatePictureBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmAccommodation accommodation = new frmAccommodation();
            accommodation.Show();
        }
    }
}
