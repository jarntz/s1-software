using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_notities_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_toevoegen_Click(object sender, EventArgs e)
        {
            lb.Items.Add(tb.Text);

            label_counter.Text = lb.Items.Count.ToString();
        }

        private void Buttonplus_Click(object sender, EventArgs e)
        {
            lb.Items.Add(tb.Text);

            label_counter.Text = lb.Items.Count.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lb.Items.Remove(tb.Text);

            label_counter.Text = lb.Items.Count.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lb.Sorted = true;
        }
    }
}
