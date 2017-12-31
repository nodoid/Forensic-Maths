using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class vector : Form
    {
        public vector()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton o = (RadioButton)sender;
            if (o.Name == "radioButton1")
            {
                label1.Text = "1st vec mag";
                label2.Text = "1st vec phi";
                label3.Text = "1st vec theta";
                label4.Text = "2nd vec mag";
                label5.Text = "2nd vec phi";
                label6.Text = "2nd vec theta";
            }
            else
            {
                label1.Text = "1st vec X";
                label2.Text = "1st vec Y";
                label3.Text = "1st vec Z";
                label4.Text = "2nd vec X";
                label5.Text = "2nd vec Y";
                label6.Text = "2nd vec Z";
            }
        }
    }
}
