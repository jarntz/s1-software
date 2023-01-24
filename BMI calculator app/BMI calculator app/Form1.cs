using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calculator_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double gewicht;
            gewicht = Convert.ToDouble(tb_gewicht.Text);

            double lengte;
            lengte = Convert.ToDouble(tb_lengte.Text);

            label_uitkomst.Text = Convert.ToString(gewicht / (lengte * lengte));

            double bmi;
            bmi = Convert.ToDouble(label_uitkomst.Text);
            label_uitkomst.Text = Convert.ToString(Math.Round(bmi, 2));

        }
    }
}
