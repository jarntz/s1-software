using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wisselkoers_app
{
    public partial class Wisselkoers : Form
    {
        public Wisselkoers()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_right_Click(object sender, EventArgs e)
        {
            double euro;
            euro = Convert.ToDouble(tb_euro.Text);

            double koers;
            koers = Convert.ToDouble(updown_koers.Value);

            tb_dollar.Text = Convert.ToString(euro * koers);
        }

        private void Button_left_Click(object sender, EventArgs e)
        {
            double dollar;
            dollar = Convert.ToDouble(tb_dollar.Text);

            double koers;
            koers = Convert.ToDouble(updown_koers.Value);

            tb_euro.Text = Convert.ToString(dollar / koers);
        }

        private void Label_dollar_Click(object sender, EventArgs e)
        {
            if (label_dollar.Text == "$")
            {
                label_dollar.Text = "¥";
                label_koers.Text = "Koers: € 1 = ¥";
            }

            else
            {
                label_dollar.Text = "$";
                label_koers.Text = "Koers: € 1 = $";
            }
        }
    }
}
