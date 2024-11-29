using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Indra_Pic_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
          //clear the picture
            pictureBox1.Image = null;
        }

        private void backgroundbutton_Click(object sender, EventArgs e)
        {
          //show the color dialog box.if the user click ok then changes the background color of picture box control
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
          //close the picture viewer
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          //if the user check it then change the picture box SizeMode property to "stretch" else "normal"
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
