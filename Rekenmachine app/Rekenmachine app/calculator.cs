using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine_app
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            double getal1;
            getal1 = Convert.ToDouble(tb_1.Text);

            double getal2;
            getal2 = Convert.ToDouble(tb_2.Text);

            label_uitkomst.Text = Convert.ToString(getal1 + getal2);

            // Als de uitkomst kleiner is dan 0, wordt het label rood gekleurd.
            double uitkomst;
            uitkomst = Convert.ToDouble(label_uitkomst.Text);
            if (uitkomst < 0)
            {
                label_uitkomst.ForeColor = Color.Red;
            }
            else
            {
                label_uitkomst.ForeColor = Color.Black;
            }
        }

        private void Button_keer_Click(object sender, EventArgs e)
        {
            double getal1;
            getal1 = Convert.ToDouble(tb_1.Text);

            double getal2;
            getal2 = Convert.ToDouble(tb_2.Text);

            label_uitkomst.Text = Convert.ToString(getal1 * getal2);

            // Als de uitkomst kleiner is dan 0, wordt het label rood gekleurd.
            double uitkomst;
            uitkomst = Convert.ToDouble(label_uitkomst.Text);
            if (uitkomst < 0)
            {
                label_uitkomst.ForeColor = Color.Red;
            }
            else
            {
                label_uitkomst.ForeColor = Color.Black;
            }
        }

        private void Button_delen_Click(object sender, EventArgs e)
        {
            double getal1;
            getal1 = Convert.ToDouble(tb_1.Text);

            double getal2;
            getal2 = Convert.ToDouble(tb_2.Text);

            label_uitkomst.Text = Convert.ToString(getal1 / getal2);

            // Als de uitkomst kleiner is dan 0, wordt het label rood gekleurd.
            double uitkomst;
            uitkomst = Convert.ToDouble(label_uitkomst.Text);
            if (uitkomst < 0)
            {
                label_uitkomst.ForeColor = Color.Red;
            }
            else
            {
                label_uitkomst.ForeColor = Color.Black;
            }

            // Als Getal 2 = 0 geldt, wordt er niets berekend.
            if (tb_2.Text == "0")
            {
                label_uitkomst.Text = "Geen uitkomst";
            }
        }

        private void Button_wortel_Click(object sender, EventArgs e)
        {
            double getal1;
            getal1 = Convert.ToDouble(tb_1.Text);

            label_uitkomst.Text = Convert.ToString(Math.Sqrt(getal1));

            // Het getal onder de wortel kan niet negatief zijn.
            double wortelpositief;
            wortelpositief = Convert.ToDouble(tb_1.Text);
            if (wortelpositief < 0)
            {
                label_uitkomst.Text = "Geen uitkomst";
            }
        }
    }
}
