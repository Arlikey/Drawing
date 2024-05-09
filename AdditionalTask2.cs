using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class AdditionalTask2 : Form
    {
        Label countClickLabel;
        public AdditionalTask2()
        {
            InitializeComponent();
        }

        private void AdditionalTask2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath shape = new GraphicsPath();
            shape.AddEllipse(0, 0, 300, 300);
            Region = new Region(shape);
        }

        private void AdditionalTask2_Load(object sender, EventArgs e)
        {
            countClickLabel = new Label()
            {
                Location = new Point(110, 110),
                Text = "0"
            };

            Controls.Add(countClickLabel);
        }

        private void AdditionalTask2_Click(object sender, EventArgs e)
        {
            int clicks = int.Parse(countClickLabel.Text);
            clicks++;
            countClickLabel.Text = clicks.ToString();
        }
    }
}
