using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolfs
{
    public partial class Form1 : Form
    {
        Isle isle;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(OnRepaint);
            this.Height = 600;
            this.Width = 600;
            isle = new Isle(new System.Drawing.PointF(1, 1));
        }

        private void OnRepaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            isle.DrawSprite(g);

        }
    }
}
