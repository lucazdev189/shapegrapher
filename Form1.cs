using System.Drawing.Text;

namespace realgraphing
{
    public partial class Form1 : Form
    {
        int x, y, h, w;
        Pen p = new Pen(Color.Black, 10);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;

            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                g.DrawRectangle(p, shape);
            }
            else if (radioButton2.Checked)
            {
                g.DrawEllipse(p, shape);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            p.Color = colorDialog1.Color;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
        }
    }
}
