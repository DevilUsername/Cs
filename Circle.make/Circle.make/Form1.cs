using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle.make
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.Black;
        private bool fillCircle = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float radius) && float.TryParse(textBox2.Text, out float Xcord) && float.TryParse(textBox3.Text, out float Ycord) && radius > 0 && Xcord >= 0 && Ycord >= 0 && Xcord + radius <= pictureBox1.Width && Ycord + radius <= pictureBox1.Height){
                /* using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                 {
                     using (Graphics graphics = Graphics.FromImage(bmp))
                     {
                         graphics.Clear(Color.White);
                         using (SolidBrush brush = new SolidBrush(selectedColor))
                         {
                             graphics.FillEllipse(brush, Xcord, Ycord, radius * 2, radius * 2);
                         }
                     }
                     pictureBox1.Image = bmp;*/
                /* using (Graphics graphics = pictureBox1.CreateGraphics())
                 {
                     graphics.Clear(Color.White);
                     using (Pen pen = new Pen(selectedColor))
                     {
                         graphics.DrawEllipse(pen, Xcord, Ycord, radius * 2, radius * 2);
                     }
                 }*/

                using (Graphics graphics = pictureBox1.CreateGraphics())
                {
                    graphics.Clear(Color.White);
                    using (Pen pen = new Pen(selectedColor))
                    {
                        if (fillCircle)
                        {
                            using (SolidBrush brush = new SolidBrush(selectedColor))
                            {
                                graphics.FillEllipse(brush, Xcord, Ycord, radius * 2, radius * 2);
                            }
                        }
                        else
                        {
                            graphics.DrawEllipse(pen, Xcord, Ycord, radius * 2, radius * 2);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please,write correct data of radius and coordinates.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
            
                Color newColor = colorDialog.Color;
                listBox1.Items.Add(newColor);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColor = (Color)listBox1.SelectedItem; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fillCircle = checkBox1.Checked;
        }
    }
}
