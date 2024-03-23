namespace Soft_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world!";
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
