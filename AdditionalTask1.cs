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
    public partial class AdditionalTask1 : Form
    {
        private List<Point> lines1 = new List<Point>();
        private List<Point> lines2 = new List<Point>();
        public AdditionalTask1()
        {
            InitializeComponent();
        }

        private void AdditionalTask1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < lines1.Count; i++)
            {
                g.DrawLine(Pens.Black, lines1[i], lines2[i]);
            }
        }

        private void AdditionalTask1_MouseDown(object sender, MouseEventArgs e)
        {
            lines1.Add(new Point(e.X, e.Y));
        }

        private void AdditionalTask1_MouseUp(object sender, MouseEventArgs e)
        {
            lines2.Add(new Point(e.X, e.Y));
            Invalidate();
        }
    }
}
