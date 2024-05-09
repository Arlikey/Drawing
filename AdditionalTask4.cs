using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class AdditionalTask4 : Form
    {
        private List<Text> texts = new List<Text>();
        public AdditionalTask4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            texts.Add(new Text() { Value = textBox1.Text, Font = textBox1.Font, Color = textBox1.ForeColor, Point = new Point(e.X, e.Y) });

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Text t in texts)
            {
                g.DrawString(t.Value, t.Font, new SolidBrush(t.Color), t.Point);
            }
        }
    }

    public class Text
    {
        public string Value { get; set; }
        public Font Font { get; set; }
        public Color Color { get; set; }
        public Point Point { get; set; }

    }
}
