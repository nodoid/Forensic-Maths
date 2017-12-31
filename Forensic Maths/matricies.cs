using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class matricies : Form
    {
        private NumberBox[] mat1;
        private NumberBox[] mat2;
        private Label[] lab;
        private int mat1x, mat1y, mat2x, mat2y;

        public matricies()
        {
            InitializeComponent();
            mat1x = mat1y = mat2x = mat2y = 2;
            drawBoxes((int)x1min.Value, (int)x1max.Value, true);
            drawBoxes((int)x2min.Value, (int)x2max.Value, false);
            
        }

        private void drawBoxes(int x1min, int x1max, bool choice)
        {
            NumberBox[] tmp = new NumberBox[x1min * x1max]; 
            int t = 0;
            int p = 0; // position
            int r = 0; // current row
            if (choice == true)
            {
                mat1x = x1min;
                mat1y = x1max;
            }
            else
            {
                mat2x = x1min;
                mat2y = x1max;
            }

            int m = 0;
            for (int n = 0; n < x1min * x1max; ++n)
            {
                m = choice == true ? n : n + 65;
                tmp[n] = new NumberBox();
                tmp[n].Location = new System.Drawing.Point(7 + p, 20 + (26 * r));
                tmp[n].Name = "numberBox" + m.ToString();
                tmp[n].Size = new System.Drawing.Size(42, 20);
                tmp[n].TabIndex = m;
                if (choice == true)
                    groupBox1.Controls.Add(tmp[n]);
                else
                    groupBox2.Controls.Add(tmp[n]);

                p += 48;
                if (t + 1 != x1min)
                    t++;
                else
                {
                    t = 0;
                    r++;
                    p = 0;
                }
            }
            if (choice == true)
                mat1 = tmp;
            else
                mat2 = tmp;

            // generate the results box

            int l = mat1x > mat2x ? mat1x : mat2x;
            int l2 = mat1y > mat2y ? mat1y : mat2y;
            m = 130;
            p = r = 0;
            Label[] lbl = new Label[l * l2];
            for (int n = 0; n < l * l2; ++n)
            {
                m += n;
                lbl[n] = new Label();
                lbl[n].Location = new System.Drawing.Point(7 + p, 20 + (26 * r));
                lbl[n].Name = "label" + m.ToString();
                lbl[n].Text = "0";
                lbl[n].Size = new System.Drawing.Size(42, 20);
                lbl[n].TabIndex = m;
                groupBox3.Controls.Add(lbl[n]);

                p += 48;
                if (t + 1 != l)
                    t++;
                else
                {
                    t = 0;
                    r++;
                    p = 0;
                }
            }

            int z = 8 + mat1x * 48;
            int z2 = 8 + mat2x * 48;
            int y = 8 + (mat1y * 26) + 16;
            int y2 = 8 + (mat2y * 26) + 16;
            
            groupBox1.Size = new System.Drawing.Size(z, y);
            groupBox2.Location = new System.Drawing.Point(24 + z, 42);
            groupBox2.Size = new System.Drawing.Size(z2, y2);
            groupBox3.Location = new System.Drawing.Point(32 + z + z2, 42);
            groupBox3.Size = new System.Drawing.Size((mat1x > mat2x ? z : z2), (mat1y > mat2y ? y : y2));
            this.clear.Location = new System.Drawing.Point(16, y > y2 ? y + 48 : y2 + 48);
            this.multiply.Location = new System.Drawing.Point(97, y > y2 ? y + 48 : y2 + 48);

            int winx = 8 + z + 8 + z2 + (z > z2 ? z : z2) + 32;
            ClientSize = new System.Drawing.Size(z * 3 + 32 < 388 ? 388 : winx, y > y2 ? y + 80 : y2 + 80);
            lab = lbl;
        }

        private void number_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            switch (num.Name)
            {
                case "x1min":
                case "x1max":
                    if (mat1y > num.Value)
                        removeBoxes(mat1y, true);
                    drawBoxes((int)x1min.Value, (int)x1max.Value, true);
                    break;
                case "x2max":
                case "x2min":
                    if (mat2y > num.Value)
                        removeBoxes(mat2y, false);
                    drawBoxes((int)x2min.Value, (int)x2max.Value, false);
                    break;
            }
        }

        private void removeBoxes(int number, bool box)
        {
            int ar = box == true ? mat1x * mat1y : mat2x * mat2y;
            for (int n = ar - (box == true ? mat1x : mat2x); n < ar; ++n)
            {
                if (box == true) 
                    groupBox1.Controls.Remove(mat1[n]);
                else
                    groupBox2.Controls.Remove(mat2[n]);
                groupBox3.Controls.Remove(lab[n]);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            removeBoxes(mat1y, true);
            removeBoxes(mat2y, false);
            x1min.Value = x1max.Value = x2min.Value = x2max.Value = 2;
        }
    }
}
