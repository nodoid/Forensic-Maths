using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class gaussian : Form
    {
        private NumberBox[] nbArray;
        private Label[] rdArray;
        private int rowcount, option;

        public gaussian(int opt)
        {
            InitializeComponent();
            switch (opt)
            {
                case 1:
                    Text = "Gaussian Reduction";
                    numericUpDown1.Minimum = 2;
                    numericUpDown1.Maximum = 10;
                    numericUpDown1.Value = 2;
                    groupBox1.Text = "Data";
                    groupBox2.Text = "Reduced array";
                    rowcount = 2;
                    break;
                case 2:
                    Text = "Matrix inversion";
                    numericUpDown1.Minimum = 3;
                    numericUpDown1.Maximum = 6;
                    numericUpDown1.Value = 3;
                    groupBox1.Text = "Original matrix";
                    groupBox2.Text = "Inverted matrix";
                    rowcount = 3;
                    break;
            }
            drawBoxes(rowcount);
            option = opt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int boxes = (int)numericUpDown1.Value;
            if (rowcount > boxes)
                removeBoxes(rowcount);
            drawBoxes(boxes);
        }

        private void removeBoxes(int number)
        {
            int ar = Convert.ToInt32(Math.Pow(number, 2));
            for (int n = 0; n < ar; ++n)
            {
                groupBox1.Controls.Remove(nbArray[n]);
                groupBox2.Controls.Remove(rdArray[n]);
            }
            rowcount = number;
        }

        private void drawBoxes(int number)
        {
            int ar = number;
            int b = ar;
            int p = 0; // position
            int r = 0; // current row
            ar = Convert.ToInt32(Math.Pow(ar, 2));
            NumberBox[] tmp = new NumberBox[ar]; // do it for the smallest size
            Label[] lbl = new Label[ar];
            int t = 0;
            int m = 40;
            for (int n = 0; n < ar; ++n)
            {
                m += 40;
                tmp[n] = new NumberBox();
                tmp[n].Location = new System.Drawing.Point(7 + p, 20 + (26 * r));
                tmp[n].Name = "numberBox" + n.ToString();
                tmp[n].Size = new System.Drawing.Size(42, 20);
                tmp[n].TabIndex = n;

                lbl[n] = new Label();
                lbl[n].Location = new System.Drawing.Point(7 + p, 20 + (26 * r));
                lbl[n].Name = "label" + m.ToString();
                lbl[n].Text = "0";
                lbl[n].Size = new System.Drawing.Size(42, 20);
                lbl[n].TabIndex = m;

                groupBox1.Controls.Add(tmp[n]);
                groupBox2.Controls.Add(lbl[n]);

                p += 48;
                if (t + 1 != b)
                    t++;
                else
                {
                    t = 0;
                    r++;
                    p = 0;
                }
            }

            int z = 8 + b * 48;
            int y = 8 + (b * 26) + 16;
            groupBox1.Size = new System.Drawing.Size(z, y);
            groupBox2.Location = new System.Drawing.Point(32 + b * 48, 43);
            groupBox2.Size = new System.Drawing.Size(z, y);
            this.clear.Location = new System.Drawing.Point(16, y + 48);
            this.calc.Location = new System.Drawing.Point(97, y + 48);
            ClientSize = new System.Drawing.Size(z * 2 + 32, y + 80);
            nbArray = tmp;
            rdArray = lbl;
            rowcount = number;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            removeBoxes(rowcount);
            if (option == 1)
                numericUpDown1.Value = rowcount = 2;
            else
                numericUpDown1.Value = rowcount = 3;
        }
    }
}
