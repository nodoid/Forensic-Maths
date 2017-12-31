using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class Triangles : Form
    {
        public Triangles()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(drawTriangle);
            //drawTriangle();
        }

        private void drawTriangle(object o, PaintEventArgs e)
        {
           Pen brush = new Pen(Color.SeaGreen, 1.75f);
            Point[] points = {new Point(55, 200), new Point(430, 200), new Point(270, 25) };
            e.Graphics.DrawPolygon(brush, points);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
