using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class AdvTrig : Form
    {
        private int function;
        private string result;

        public AdvTrig()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton o = (RadioButton)sender;
            switch (o.Name)
            {
                case "radioButton2": function = 1;
                    break;
                case "radioButton3": function = 2;
                    break;
                default: function = 0;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = "0";
            results.Text = result;
        }
    }
}
