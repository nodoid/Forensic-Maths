using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class complex : Form
    {
        private string result;

        public complex()
        {
            InitializeComponent();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            result = "0";
            results.Text = result;
        }
    }
}
