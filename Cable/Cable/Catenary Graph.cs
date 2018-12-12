using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cable
{
    public partial class Catenary_Graph : Form
    {

        public Catenary_Graph(double c, double x)
        {
            InitializeComponent();
            for (double i = 0; i < x; i += 1)
            {
                chart1.Series[0].Points.AddXY(i, c * Math.Cosh(i / c));
            }

        }
    }
}
