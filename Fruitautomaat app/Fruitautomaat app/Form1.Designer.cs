namespace Fruitautomaat_app
{
    partial class Pb_machine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slotTimer = new System.Windows.Forms.Timer(this.components);
            this.pb_winner = new System.Windows.Forms.PictureBox();
            this.pb_button = new System.Windows.Forms.PictureBox();
            this.pb_slotright = new System.Windows.Forms.PictureBox();
            this.pb_slotcenter = new System.Windows.Forms.PictureBox();
            this.pb_slotleft = new System.Windows.Forms.PictureBox();
            this.pb_slotmachine = new System.Windows.Forms.PictureBox();
            this.button_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_winner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotmachine)).BeginInit();
            this.SuspendLayout();
            // 
            // slotTimer
            // 
            this.slotTimer.Interval = 50;
            this.slotTimer.Tick += new System.EventHandler(this.SlotTimer_Tick);
            // 
            // pb_winner
            // 
            this.pb_winner.Image = global::Fruitautomaat_app.Properties.Resources.winner_crop;
            this.pb_winner.Location = new System.Drawing.Point(206, 23);
            this.pb_winner.Name = "pb_winner";
            this.pb_winner.Size = new System.Drawing.Size(400, 400);
            this.pb_winner.TabIndex = 5;
            this.pb_winner.TabStop = false;
            this.pb_winner.Visible = false;
            // 
            // pb_button
            // 
            this.pb_button.Image = global::Fruitautomaat_app.Properties.Resources.slot_machine_button;
            this.pb_button.Location = new System.Drawing.Point(634, 44);
            this.pb_button.Name = "pb_button";
            this.pb_button.Size = new System.Drawing.Size(99, 105);
            this.pb_button.TabIndex = 4;
            this.pb_button.TabStop = false;
            this.pb_button.Click += new System.EventHandler(this.Pb_button_Click);
            // 
            // pb_slotright
            // 
            this.pb_slotright.Location = new System.Drawing.Point(440, 148);
            this.pb_slotright.Name = "pb_slotright";
            this.pb_slotright.Size = new System.Drawing.Size(114, 160);
            this.pb_slotright.TabIndex = 3;
            this.pb_slotright.TabStop = false;
            // 
            // pb_slotcenter
            // 
            this.pb_slotcenter.Location = new System.Drawing.Point(311, 148);
            this.pb_slotcenter.Name = "pb_slotcenter";
            this.pb_slotcenter.Size = new System.Drawing.Size(114, 160);
            this.pb_slotcenter.TabIndex = 2;
            this.pb_slotcenter.TabStop = false;
            // 
            // pb_slotleft
            // 
            this.pb_slotleft.Location = new System.Drawing.Point(183, 148);
            this.pb_slotleft.Name = "pb_slotleft";
            this.pb_slotleft.Size = new System.Drawing.Size(114, 160);
            this.pb_slotleft.TabIndex = 1;
            this.pb_slotleft.TabStop = false;
            // 
            // pb_slotmachine
            // 
            this.pb_slotmachine.Image = global::Fruitautomaat_app.Properties.Resources.slot_machine;
            this.pb_slotmachine.Location = new System.Drawing.Point(12, 23);
            this.pb_slotmachine.Name = "pb_slotmachine";
            this.pb_slotmachine.Size = new System.Drawing.Size(777, 390);
            this.pb_slotmachine.TabIndex = 0;
            this.pb_slotmachine.TabStop = false;
            // 
            // button_restart
            // 
            this.button_restart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_restart.Location = new System.Drawing.Point(634, 376);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(143, 47);
            this.button_restart.TabIndex = 6;
            this.button_restart.Text = "Nog een keer";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Visible = false;
            this.button_restart.Click += new System.EventHandler(this.Button_restart_Click);
            // 
            // Pb_machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.pb_winner);
            this.Controls.Add(this.pb_button);
            this.Controls.Add(this.pb_slotright);
            this.Controls.Add(this.pb_slotcenter);
            this.Controls.Add(this.pb_slotleft);
            this.Controls.Add(this.pb_slotmachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pb_machine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot machine!";
            ((System.ComponentModel.ISupportInitialize)(this.pb_winner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slotmachine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_slotmachine;
        private System.Windows.Forms.PictureBox pb_slotleft;
        private System.Windows.Forms.PictureBox pb_slotcenter;
        private System.Windows.Forms.PictureBox pb_slotright;
        private System.Windows.Forms.PictureBox pb_button;
        private System.Windows.Forms.Timer slotTimer;
        private System.Windows.Forms.PictureBox pb_winner;
        private System.Windows.Forms.Button button_restart;
    }
}

