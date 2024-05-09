using System.Drawing.Drawing2D;

namespace Drawing
{
    public partial class Form1 : Form
    {
        private List<RectangleF> rectangles = new List<RectangleF>();
        private List<Brush> brushes = new List<Brush>();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < rectangles.Count; i++)
            {
                g.FillEllipse(brushes[i], rectangles[i]);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            rectangles.Add(new RectangleF(new PointF(e.X, e.Y), new Size(r.Next(10,50), r.Next(10, 50))));
            brushes.Add(new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256))));
            Invalidate();
        }
        
    } 
}
