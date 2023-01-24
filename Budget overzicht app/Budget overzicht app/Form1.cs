using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_overzicht_app
{
    public partial class budget_overzicht : Form
    {
        public budget_overzicht()
        {
            InitializeComponent();
        }

        void ink_toevoegen(string bedrag)
        {
            // Items toevoegen aan de lijst
            lb_ink_items.Items.Add(tb_ink_omschrijving.Text);
            lb_ink_bedragen.Items.Add(bedrag);

            // Totaal inkomsten berekenen
            double ink_totaal = 0;
            double uit_totaal = 0;
            for (int i = 0; i < lb_ink_bedragen.Items.Count; i++)
            {
                ink_totaal += Convert.ToDouble(lb_ink_bedragen.Items[i].ToString());
            }
            l_ink_totaal.Text = Convert.ToString(ink_totaal);

            // Status bepalen
            if (ink_totaal - uit_totaal < 0)
            {
                pb_status.Image = Image.FromFile("rood.jpg");
                l_result.Text = "Je hebt te weinig inkomsten ontvangen voor deze aankopen.";
            }

            if (ink_totaal - uit_totaal > 0)
            {
                pb_status.Image = Image.FromFile("groen.jpg");
                l_result.Text = "Je houdt nog geld over met deze aankopen.";
            }
        }

        void uit_toevoegen(string bedrag)
        {
            // Items toevoegen aan de lijst
            lb_uit_items.Items.Add(tb_uit_omschrijving.Text);
            lb_uit_bedragen.Items.Add(bedrag);

            // Totaal inkomsten berekenen
            double ink_totaal = 0;
            double uit_totaal = 0;
            for (int i = 0; i < lb_uit_bedragen.Items.Count; i++)
            {
                uit_totaal += Convert.ToDouble(lb_uit_bedragen.Items[i].ToString());
            }
            l_uit_totaal.Text = Convert.ToString(uit_totaal);

            // Status bepalen
            if (ink_totaal - uit_totaal < 0)
            {
                pb_status.Image = Image.FromFile("rood.jpg");
                l_result.Text = "Je hebt te weinig inkomsten ontvangen voor deze aankopen.";
            }

            if (ink_totaal - uit_totaal > 0)
            {
                pb_status.Image = Image.FromFile("groen.jpg");
                l_result.Text = "Je houdt nog geld over met deze aankopen.";
            }
        }

        void ink_verwijderen()
        {
            // Items toevoegen aan de lijst
            lb_ink_items.Items.Remove(lb_ink_items.SelectedItem);
            lb_ink_bedragen.Items.Remove(lb_ink_bedragen.SelectedItem);

            // Totaal inkomsten berekenen
            double ink_totaal = 0;
            double uit_totaal = 0;
            for (int i = 0; i < lb_ink_bedragen.Items.Count; i++)
            {
                ink_totaal += Convert.ToDouble(lb_ink_bedragen.Items[i].ToString());
            }
            l_ink_totaal.Text = Convert.ToString(ink_totaal);

            // Status bepalen
            if (ink_totaal - uit_totaal < 0)
            {
                pb_status.Image = Image.FromFile("rood.jpg");
                l_result.Text = "Je hebt te weinig inkomsten ontvangen voor deze aankopen.";
            }

            if (ink_totaal - uit_totaal > 0)
            {
                pb_status.Image = Image.FromFile("groen.jpg");
                l_result.Text = "Je houdt nog geld over met deze aankopen.";
            }
        }

        void uit_verwijderen()
        {
            // Items toevoegen aan de lijst
            lb_uit_items.Items.Remove(lb_uit_items.SelectedItem);
            lb_uit_bedragen.Items.Add(lb_uit_bedragen.SelectedItem);

            // Totaal inkomsten berekenen
            double ink_totaal = 0;
            double uit_totaal = 0;
            for (int i = 0; i < lb_uit_bedragen.Items.Count; i++)
            {
                uit_totaal += Convert.ToDouble(lb_uit_bedragen.Items[i].ToString());
            }
            l_uit_totaal.Text = Convert.ToString(uit_totaal);

            // Status bepalen
            if (ink_totaal - uit_totaal < 0)
            {
                pb_status.Image = Image.FromFile("rood.jpg");
                l_result.Text = "Je hebt te weinig inkomsten ontvangen voor deze aankopen.";
            }

            if (ink_totaal - uit_totaal > 0)
            {
                pb_status.Image = Image.FromFile("groen.jpg");
                l_result.Text = "Je houdt nog geld over met deze aankopen.";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ink_bedrag = tb_ink_bedrag.Text;
            ink_toevoegen(ink_bedrag);
        }

        private void B_uit_add_Click(object sender, EventArgs e)
        {
            string uit_bedrag = tb_uit_bedrag.Text;
            uit_toevoegen(uit_bedrag);
        }

        private void B_ink_plus_Click(object sender, EventArgs e)
        {
            string ink_bedrag = tb_ink_bedrag.Text;
            ink_toevoegen(ink_bedrag);
        }

        private void B_uit_plus_Click(object sender, EventArgs e)
        {
            string uit_bedrag = tb_uit_bedrag.Text;
            uit_toevoegen(uit_bedrag);
        }

        private void B_ink_min_Click(object sender, EventArgs e)
        {
            ink_verwijderen();
        }

        private void B_uit_min_Click(object sender, EventArgs e)
        {
            uit_verwijderen();
        }
    }
}
