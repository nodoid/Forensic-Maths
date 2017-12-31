using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class simultaneous : Form
    {
        private int lines;
        public simultaneous()
        {
            InitializeComponent();
            line1op1.SelectedIndex = line2op1.SelectedIndex = line3op1.SelectedIndex = 0;
            line4op1.SelectedIndex = line5op1.SelectedIndex = line6op1.SelectedIndex = line7op1.SelectedIndex = 0;
            line1op2.SelectedIndex = line2op2.SelectedIndex = line3op2.SelectedIndex = 0;
            line4op2.SelectedIndex = line5op2.SelectedIndex = line6op2.SelectedIndex = line7op2.SelectedIndex = 0;
            lines = 2; // actual number of equations - makes life simpler!
        }

        private void lineCheckChange(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int t = 0;
            switch (cb.Name)
            {
                case "line3e": t = 3;
                    break;
                case "line4e": t = 4;
                    break;
                case "line5e": t = 5;
                    break;
                case "line6e": t = 6;
                    break;
                case "line7e": t = 7;
                    break;
            }
            if (t == lines)
            {
                enableGadgets(lines, cb.CheckState == CheckState.Checked ? true : false);
                lines--;
                return;
            }
            if (t < lines)
            {
                cb.Checked = true;
                return;
            }
            if (t != lines + 1) // clicked not the next one in the list
            {
                cb.Checked = false;
                return;
            }
            lines++;
            enableGadgets(lines, cb.CheckState == CheckState.Checked ? true : false);
            if (cb.CheckState == CheckState.Unchecked)
                lines--;
        }

        private void enableGadgets(int lines, bool state)
        {
            switch (lines)
            {
                case 3: line3x1.Enabled = line3op1.Enabled = line3x2.Enabled = line3op2.Enabled = line3x3.Enabled = line3c.Enabled = state;
                    break;
                case 4: line4x1.Enabled = line4op1.Enabled = line4x2.Enabled = line4op2.Enabled = line4x3.Enabled = line4c.Enabled = state;
                    break;
                case 5: line5x1.Enabled = line5op1.Enabled = line5x2.Enabled = line5op2.Enabled = line5x3.Enabled = line5c.Enabled = state;
                    break;
                case 6: line6x1.Enabled = line6op1.Enabled = line6x2.Enabled = line6op2.Enabled = line6x3.Enabled = line6c.Enabled = state;
                    break;
                case 7: line7x1.Enabled = line7op1.Enabled = line7x2.Enabled = line7op2.Enabled = line7x3.Enabled = line7c.Enabled = state;
                    break;
            }
        }
    }
}
