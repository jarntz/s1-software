using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worpengenerator_app
{
    public partial class Worpengenerator : Form
    {
        public Worpengenerator()
        {
            InitializeComponent();
        }

        private void Button_gooi_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int worpen = Convert.ToInt32(updown_aantalWorpen.Value);
            int totaalOgen = Convert.ToInt32(label_totaal.Text);
            Random aantal_ogen = new Random();
            int maxaantal_ogen = Convert.ToInt32(updown_maxogen.Value);

            lb_worpen.Items.Clear();
            totaalOgen = 0;

            while (counter < worpen)
            {
                int ogen = aantal_ogen.Next(1, maxaantal_ogen);
                lb_worpen.Items.Add(ogen);
                totaalOgen = totaalOgen + ogen;
                label_totaal.Text = Convert.ToString(totaalOgen);
                counter++;
            }

        }
    }
}
