using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        private Shape currentShape;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += PictureBox1_Paint;
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }
        }
       private void DrawShape(Shape shape)
        {
            currentShape = shape;
            pictureBox1.Invalidate();
        }
        private void button1_click( object sender, EventArgs e)
        {
            int x1 = int.Parse(txtX1.Text);
            int y1 = int.Parse(txtY1.Text);

            if (Rpoint.Checked)
            {
                DrawShape(new PointShape(x1, y1));
            }
            else if (Rline.Checked)
            {
                int x2 = int.Parse(txtX2.Text);
                int y2 = int.Parse(txtY2.Text);
                DrawShape (new LineShape(x1,y1,x2,y2));
            }
            else if (Rtriangle.Checked)
            {
                int height = int.Parse(txtH.Text);
                DrawShape(new TriangleShape(x1, y1, height));
            }
        }
    }
}

abstract class Shape
{
    public abstract void Draw(Graphics g);
}
class PointShape : Shape
{
    private int x, y;

    public PointShape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }   
    public override void Draw(Graphics g)
        {
        g.FillRectangle(Brushes.Black, x, y, 1, 1);
        }
}

class LineShape : Shape
{
    private int x1, y1, x2, y2;

    public LineShape(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    
    public override void Draw(Graphics g)
    {
        g.DrawLine(Pens.Black, x1, y1, x2, y2);
    }
} 

class TriangleShape : Shape
{
    private int x1, y1, height;

    public TriangleShape (int x1, int y1, int height)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.height = height;
    }

    public override void Draw(Graphics g)
    {
        int x2 = x1 + height;
        int x3 = x1 - height;
        int y2 = y1 + height;

        g.DrawLine(Pens.Black, x1, y1, x2, y2);
        g.DrawLine(Pens.Black, x1, y1, x3, y2);
        g.DrawLine(Pens.Black, x1, y1, x3, y2);

    }
}

