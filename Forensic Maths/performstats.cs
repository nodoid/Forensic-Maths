using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forensic_Maths
{
    public partial class performstats : Form
    {
        public performstats(int opt, List<double> ar)
        {
            InitializeComponent();
            doLayout(opt);
            switch (opt)
            {
                case 0:
                    basicStats(ar);
                    break;
                case 1:
                    distStats(ar);
                    break;
                case 2:
                    corrStats(ar);
                    break;
                case 3:
                    multStats(ar);
                    break;
                case 4:
                    varrStats(ar);
                    break;
            }
        }

        private void doLayout(int opt)
        { }
        private void basicStats(List<double> ar)
        { }
        private void distStats(List<double> ar)
        { }
        private void corrStats(List<double> ar)
        { }
        private void multStats(List<double> ar)
        { }
        private void varrStats(List<double> ar)
        { }

    }
}
