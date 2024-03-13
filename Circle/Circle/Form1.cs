using System;
using System.Drawing;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        int[] m_p = new int[5];
        int index;

        public Form1()
        {
            InitializeComponent(GetName());
            pictureBox1.Paint += pictur*eBox1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Drawing ellipse";
            label1.Text = "Write numbers";
            button1.Text = "Draw";
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                index = 1;
                m_p[1] = Convert.ToInt32(textBox1.Text);
                m_p[2] = Convert.ToInt32(textBox2.Text);
                m_p[3] = Convert.ToInt32(textBox3.Text);
                m_p[4] = Convert.ToInt32(textBox4.Text);
                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Paint(object? sender, PaintEventArgs e)
        {
            if (index == 1)
            {
                Pen Brush = new Pen(Color.Green);
                e.Graphics.DrawEllipse(Brush, m_p[1], m_p[2], m_p[3], m_p[4]);
            }
        }
    }
}