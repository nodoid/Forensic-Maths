using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class Form1 : Form
    {
        private bool fileLoaded;
        private int statSelected;
        private List<double> analysis;

        public Form1()
        {
            InitializeComponent();
            fileLoaded = false;
            statSelected = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About sb = new About();
            sb.Show();
        }

        private void trianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangles tri = new Triangles();
            tri.Show();
        }

        private void complexArithmeticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complex xom = new complex();
            xom.Show();
        }

        private void vectorArithmeticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vector vec = new vector();
            vec.Show();
        }

        private void trigonometryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdvTrig adv = new AdvTrig();
            adv.Show();
        }

        private void simultaneousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simultaneous sim = new simultaneous();
            sim.Show();
        }

        private void gaussianReductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gaussian gauss = new gaussian(1);
            gauss.Show();
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gaussian gauss = new gaussian(2);
            gauss.Show();
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matricies mat = new matricies();
            mat.Show();
        }

        private void loadNewDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog1.InitialDirectory = path;
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            int colCount = 0;
            string[] colNames = {""};
            List<List<double>> rows = new List<List<double>>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader stream = new StreamReader(myStream);
                            string text = stream.ReadLine();
                            colNames = text.Split(',');
                            colCount = colNames.Length - 1;
                            colCount++;
                            String[] values = stream.ReadToEnd().Split(',');
                            List<string> csv = new List<string>();
                            foreach (string line in values)
                            {
                                if (!line.Contains("\r\n"))
                                    csv.Add(line);
                                else
                                {
                                    string[] one = line.Split('\r');
                                    string[] two = one[1].Split('\n');
                                    csv.Add(one[0]);
                                    csv.Add(two[1]);
                                }
                            }
                            int rowCount = csv.Count / colCount;
                            int j = 0;
                            for (int n = 0; n < rowCount; ++n)
                            {
                                List<double> row = new List<double>(colCount);
                                for (int i = 0; i < colCount; ++i)
                                {
                                    double f = Convert.ToDouble(csv[j++]);
                                    row.Add(f);
                                }
                                rows.Add(row);
                            }
                        }
                    }
                    basicStatisticsToolStripMenuItem.Enabled = distributionAndHistogramToolStripMenuItem.Enabled = true;
                    correlationToolStripMenuItem.Enabled = multipleRegressionToolStripMenuItem.Enabled = true;
                    varianceToolStripMenuItem.Enabled = true;
                    fileLoaded = true;
                    addWidgets(true, colCount, colNames);
                    analysis = rows[statSelected];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return;
                }
            }
        }

        private void addWidgets(bool test, int buttons, string [] text)
        {
            GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
            RadioButton[] radio = new RadioButton[buttons];
            Button button1 = new System.Windows.Forms.Button();

            if (test == false)
            {
                for (int n = 0; n < buttons; ++n)
                {
                    groupBox1.Controls.Remove(radio[n]);
                }
                groupBox1.Controls.Remove(button1);
                Controls.Remove(groupBox1);
                return;
            }

            int j = 0, k = 0;
            for (int n = 0; n < buttons; ++n)
            {
                radio[n] = new RadioButton();
                radio[n].AutoSize = true;
                radio[n].Checked = n == 0 ? true : false;
                radio[n].Location = new System.Drawing.Point(32 + (124 * j), 20 + (20 * k));
                radio[n].Name = "radioButton" + n.ToString();
                radio[n].Size = new System.Drawing.Size(85, 14);
                radio[n].TabIndex = 0;
                radio[n].TabStop = true;
                radio[n].Text = text[n];
                radio[n].UseVisualStyleBackColor = true;
                radio[n].Click += new EventHandler(radioSelected);
                j++;
                if (j == 5)
                {
                    k++;
                    j = 0;
                }
            }

            button1.Location = new System.Drawing.Point(552, 54);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Done";
            button1.Click += new EventHandler(dataSelected);
            button1.UseVisualStyleBackColor = true;

            groupBox1.Controls.Add(button1);
            for (int n = 0; n < buttons; ++n)
                groupBox1.Controls.Add(radio[n]);
            groupBox1.Location = new System.Drawing.Point(13, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(633, 93);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select the data for analysis";

            Controls.Add(groupBox1);
        }

        private void radioSelected(object o, EventArgs e)
        {
            RadioButton r = (RadioButton)o;
            for (int n = 0; n < 10; ++n)
                if (r.Name == "radioButton" + n.ToString())
                {
                    statSelected = n;
                    break;
                }
        }
        private void dataSelected(object o, EventArgs e)
        {
            string[] t = { "" };
            addWidgets(false, 10, t);
        }

        private void statsMenuSelected(object o, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)o;
            int opt = -1;
            switch (t.Name)
            {
                case "basicStatisticsToolStripMenuItem":
                    opt = 0;
                    break;
                case "distributionAndHistogramToolStripMenuItem":
                    opt = 1;
                    break;
                case "correlationToolStripMenuItem":
                    opt = 2;
                    break;
                case "multipleRegressionToolStripMenuItem":
                    opt = 3;
                    break;
                case "varianceToolStripMenuItem":
                    opt = 4;
                    break;
            }
            performstats ps = new performstats(opt, analysis);
            ps.Show();
        }

        private void _Click(object sender, EventArgs e)
        {

        }
    }

    class NumberBox : TextBox
    {
        public NumberBox()
        {
            this.CausesValidation = true;
            this.Validating += new CancelEventHandler(TextBox_Validation);
        }

        private void TextBox_Validation(object sender, CancelEventArgs e)
        {
            try
            {
                double value = System.Double.Parse(this.Text);
            }
            catch (System.Exception)
            {
                e.Cancel = true;
            }
        }
    }
}
