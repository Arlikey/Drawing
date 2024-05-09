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
    public partial class AdditionalTask3 : Form
    {
        private float[] dollarFluctuations = { 26.5f, 27.2f, 25.8f, 28.1f, 26.9f, 29.3f, 27.75f, 30.05f, 28.4f, 31.20f, 29.6f, 32f };
        Pen pen = new Pen(Color.Black, 3);
        int x = 80;
        Font font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
        public AdditionalTask3()
        {
            InitializeComponent();
        }

        private void AdditionalTask3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLines(pen, new Point[] {new Point(80, 50), new Point(80, 350), new Point(600, 350) });
            g.DrawString("Курс", font, Brushes.Black, 35, 200);
            g.DrawString("Месяцы", font, Brushes.Black, 310, 365);

            for (int i = 0; i < 12; i++)
            {
                g.FillRectangle(Brushes.Black, x += 10 + 30, 350- dollarFluctuations[i] * 5, 30, dollarFluctuations[i] * 5);
            }

            g.Dispose();
        }
    }
}
