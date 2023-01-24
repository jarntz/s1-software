using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloeddruk_app
{
    public partial class bloeddruk : Form
    {
        public bloeddruk()
        {
            InitializeComponent();
        }

        private void B_meet_Click(object sender, EventArgs e)
        {
            info_klant();
            controleer_klant();
        }

        void info_klant()
        {
            string info_naam = tb_naam.Text;
            int info_leeftijd = Convert.ToInt32(tb_leeftijd.Text);

            string info_bovendrukS = tb_bovendruk.Text;
            int info_bovendruk = Convert.ToInt32(info_bovendrukS);

            string info_onderdrukS = tb_onderdruk.Text;
            int info_onderdruk = Convert.ToInt32(info_onderdrukS);

            bool info_risico = bepaal_risico(info_leeftijd);

            if (info_bovendruk <= 90 && info_onderdruk <= 60)
            {
                legen();
                l_status.Text = "Te laag";
                pb_status.Image = Image.FromFile("laag.png");
                lb_result.Items.Add("Naam: " + info_naam);
                lb_result.Items.Add("Leeftijd: " + info_leeftijd);
                lb_result.Items.Add("Bovendruk: " + info_bovendrukS);
                lb_result.Items.Add("Onderdruk: " + info_onderdrukS);
                lb_result.Items.Add(" ");
            }
            else if (info_bovendruk <= 120 && info_onderdruk <= 80)
            {
                legen();
                pb_status.Image = Image.FromFile("optimaal.png");
                l_status.Text = "Optimaal";
                lb_result.Items.Add("Naam: " + info_naam);
                lb_result.Items.Add("Leeftijd: " + info_leeftijd);
                lb_result.Items.Add("Bovendruk: " + info_bovendrukS);
                lb_result.Items.Add("Onderdruk: " + info_onderdrukS);
                lb_result.Items.Add(" ");
            }
            else if (info_bovendruk <= 140 && info_onderdruk <= 90)
            {
                legen();
                pb_status.Image = Image.FromFile("normaal.png");
                l_status.Text = "Normaal";
                lb_result.Items.Add("Naam: " + info_naam);
                lb_result.Items.Add("Leeftijd: " + info_leeftijd);
                lb_result.Items.Add("Bovendruk: " + info_bovendrukS);
                lb_result.Items.Add("Onderdruk: " + info_onderdrukS);
                lb_result.Items.Add(" ");
            }
            else if (info_bovendruk >= 160 && info_onderdruk >= 90)
            {
                legen();
                if (info_risico == true)
                {
                    l_info.Text = "Patiënt heeft extra aandacht nodig";
                }
                pb_status.Image = Image.FromFile("hoog.png");
                l_status.Text = "Te hoog";
                lb_result.Items.Add("Naam: " + info_naam);
                lb_result.Items.Add("Leeftijd: " + info_leeftijd);
                lb_result.Items.Add("Bovendruk: " + info_bovendrukS);
                lb_result.Items.Add("Onderdruk: " + info_onderdrukS);
                lb_result.Items.Add(" ");
            }
            else
            {
                legen();
                l_status.Text = "Onmogelijk";
                pb_status.Image = Image.FromFile("onmogelijk.png");
                lb_result.Items.Add("Meting mislukt");
                lb_result.Items.Add(" ");
            }
        }

        void controleer_klant()
        {
            if (rb_man.Checked)
            {
                b_meet.BackColor = Color.Blue;
                b_meet.ForeColor = Color.White;
            }
            if (rb_vrouw.Checked)
            {
                b_meet.BackColor = Color.DeepPink;
                b_meet.ForeColor = Color.White;
            }
        }

        public bool bepaal_risico(int info_leeftijd)
        {
            string leeftijd = tb_leeftijd.Text;
            bool risico = false;

            if (rb_man.Checked)
            {
                if (info_leeftijd > 65)
                {
                    risico = true;
                }
            }
            if (rb_vrouw.Checked)
            {
                if (info_leeftijd > 67)
                {
                    risico = true;
                }
            }

            return risico;
        }

        private void Tb_naam_TextChanged_1(object sender, EventArgs e)
        {
            string klant_naam = tb_naam.Text;
            if (klant_naam == "Paashaas")
            {
                int easteregg = 0;
                while (easteregg < 10)
                {
                    MessageBox.Show("Happy Easter", "Easter egg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    easteregg++;
                }
            }
        }

        private void B_leeg_Click(object sender, EventArgs e)
        {
            lb_result.Items.Clear();
        }

        void legen()
        {
            l_info.Text = "";
        }
    }
}