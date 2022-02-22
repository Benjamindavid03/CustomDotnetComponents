﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blaze.Winform
{
    public partial class ImagePicker : UserControl
    {
        public ImagePicker()
        {
            InitializeComponent();
        }

        private void B_TextField_Load(object sender, EventArgs e)
        {

        }

        #region ControlProperties
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets or gets the image view")]
        [DisplayName("Image view")]
        public PictureBoxSizeMode ImageView
        {
            get
            {
                return (this.pictureBox1.SizeMode );
            }
            set
            {
                this.pictureBox1.SizeMode = value;
            }
        }

        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("sets or gets the selected image")]
        [DisplayName("Selected Image")]
        public String SelectedImage
        {
            get
            {
                return (this.pictureBox1.ImageLocation);
            }
            set
            {
                this.pictureBox1.ImageLocation = value;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select the image from your computer";
            openFileDialog1.Filter = "JPG files(*.jpg) | *.jpg | JPEG files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != null)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }

        }
    }
}
