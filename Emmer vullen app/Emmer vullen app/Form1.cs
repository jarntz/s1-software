using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Emmer_vullen_app
{
    public partial class emmer_vullen : Form
    {
        public emmer_vullen()
        {
            InitializeComponent();

            Thread.Sleep(100); //doe niks voor 100 ms
            Application.DoEvents(); //update UI
        }

        private void Button_Click_1(object sender, EventArgs e)
        {
            for (vpb.Value = 0; vpb.Value < vpb.Maximum;)
            {
                int emmer = Convert.ToInt32(tb_emmer.Text);
                int beker = Convert.ToInt32(tb_beker.Text);

                vpb.Maximum = emmer * 100;
                vpb.Value = vpb.Value + beker;

                System.Threading.Thread.Sleep(100); //doe niks voor 100 ms
                Application.DoEvents(); //update UI
            }
        }
    }
}
