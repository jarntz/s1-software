using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;                 // zo kan er audio afgespeeld worden

namespace Fruitautomaat_app
{
    public partial class Pb_machine : Form
    {
        Random randomImage = new Random();  // er wordt een random getal gegenereerd

        public Pb_machine()
        {
            InitializeComponent();

            System.Media.SoundPlayer start = new SoundPlayer("start.wav");
            start.Play();
        }

        private void Pb_button_Click(object sender, EventArgs e)
        {
            // de timer start en het Mario Kart spinner geluid start
            System.Media.SoundPlayer geluidseffect = new SoundPlayer("sound.wav");
            geluidseffect.Play();

            slotTimer.Start();
        }

        int elapsedSlotTime = 0;

        private void SlotTimer_Tick(object sender, EventArgs e)
        {
            elapsedSlotTime++;

            // er zijn 7 fruitstukken in de machine
            const int aantalImages = 3;

            // er wordt er 1 gekozen en in de picturebox gezet, dit voor alle 3 de picture boxen
            int imageNumberLeft = randomImage.Next(aantalImages) + 1;
            string imageNameLeft = string.Format("fruit{0}.jpg", imageNumberLeft);
            pb_slotleft.Image = Image.FromFile(imageNameLeft);

            int imageNumberCenter = randomImage.Next(aantalImages) + 1;
            string imageNameCenter = string.Format("fruit{0}.jpg", imageNumberCenter);
            pb_slotcenter.Image = Image.FromFile(imageNameCenter);

            int imageNumberRight = randomImage.Next(aantalImages) + 1;
            string imageNameRight = string.Format("fruit{0}.jpg", imageNumberRight);
            pb_slotright.Image = Image.FromFile(imageNameRight);

            // als de timer voorbij is stopt de machine met spinnen
            if (elapsedSlotTime > 25)
            {
                slotTimer.Stop();
                elapsedSlotTime = 0;

                // als je de jackspot hebt wordt het nog leuker!
                if (imageNumberLeft == imageNumberCenter && imageNumberLeft == imageNumberRight)
                {
                    System.Media.SoundPlayer jackpot = new SoundPlayer("jackpot.wav");
                    jackpot.Play();

                    pb_winner.Visible = true;
                    button_restart.Visible = true;

                    pb_slotmachine.Visible = false;
                    pb_button.Visible = false;
                    pb_slotleft.Visible = false;
                    pb_slotcenter.Visible = false;
                    pb_slotright.Visible = false;

                    this.BackColor = Color.FromArgb(62, 64, 164);
                }
            }
        }

        private void Button_restart_Click(object sender, EventArgs e)
        {
            pb_winner.Visible = false;
            button_restart.Visible = false;

            pb_slotmachine.Visible = true;
            pb_button.Visible = true;
            pb_slotleft.Visible = true;
            pb_slotcenter.Visible = true;
            pb_slotright.Visible = true;

            this.BackColor = Color.FromArgb(255, 255, 255);

            System.Media.SoundPlayer start = new SoundPlayer("start.wav");
            start.Play();
        }
    }
}
