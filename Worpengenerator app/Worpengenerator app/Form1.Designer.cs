namespace Worpengenerator_app
{
    partial class Worpengenerator
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
            this.gb_instellingen = new System.Windows.Forms.GroupBox();
            this.button_gooi = new System.Windows.Forms.Button();
            this.updown_aantalWorpen = new System.Windows.Forms.NumericUpDown();
            this.label_aantalWorpen = new System.Windows.Forms.Label();
            this.gb_resultaat = new System.Windows.Forms.GroupBox();
            this.label_worpen = new System.Windows.Forms.Label();
            this.lb_worpen = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label_totaal_title = new System.Windows.Forms.Label();
            this.label_totaal = new System.Windows.Forms.Label();
            this.label_aantalOgen = new System.Windows.Forms.Label();
            this.updown_maxogen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_hoogste = new System.Windows.Forms.Label();
            this.gb_instellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown_aantalWorpen)).BeginInit();
            this.gb_resultaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown_maxogen)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_instellingen
            // 
            this.gb_instellingen.Controls.Add(this.updown_maxogen);
            this.gb_instellingen.Controls.Add(this.label_aantalOgen);
            this.gb_instellingen.Controls.Add(this.button_gooi);
            this.gb_instellingen.Controls.Add(this.updown_aantalWorpen);
            this.gb_instellingen.Controls.Add(this.label_aantalWorpen);
            this.gb_instellingen.Location = new System.Drawing.Point(48, 56);
            this.gb_instellingen.Name = "gb_instellingen";
            this.gb_instellingen.Size = new System.Drawing.Size(273, 166);
            this.gb_instellingen.TabIndex = 0;
            this.gb_instellingen.TabStop = false;
            this.gb_instellingen.Text = "Instellingen";
            // 
            // button_gooi
            // 
            this.button_gooi.Location = new System.Drawing.Point(77, 127);
            this.button_gooi.Name = "button_gooi";
            this.button_gooi.Size = new System.Drawing.Size(110, 23);
            this.button_gooi.TabIndex = 2;
            this.button_gooi.Text = "Gooi dobbelstenen!";
            this.button_gooi.UseVisualStyleBackColor = true;
            this.button_gooi.Click += new System.EventHandler(this.Button_gooi_Click);
            // 
            // updown_aantalWorpen
            // 
            this.updown_aantalWorpen.Location = new System.Drawing.Point(147, 48);
            this.updown_aantalWorpen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_aantalWorpen.Name = "updown_aantalWorpen";
            this.updown_aantalWorpen.Size = new System.Drawing.Size(120, 20);
            this.updown_aantalWorpen.TabIndex = 1;
            this.updown_aantalWorpen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_aantalWorpen
            // 
            this.label_aantalWorpen.AutoSize = true;
            this.label_aantalWorpen.Location = new System.Drawing.Point(6, 50);
            this.label_aantalWorpen.Name = "label_aantalWorpen";
            this.label_aantalWorpen.Size = new System.Drawing.Size(78, 13);
            this.label_aantalWorpen.TabIndex = 0;
            this.label_aantalWorpen.Text = "Aantal worpen:";
            // 
            // gb_resultaat
            // 
            this.gb_resultaat.Controls.Add(this.label_hoogste);
            this.gb_resultaat.Controls.Add(this.label1);
            this.gb_resultaat.Controls.Add(this.label_totaal);
            this.gb_resultaat.Controls.Add(this.label_totaal_title);
            this.gb_resultaat.Controls.Add(this.label_worpen);
            this.gb_resultaat.Controls.Add(this.lb_worpen);
            this.gb_resultaat.Location = new System.Drawing.Point(389, 56);
            this.gb_resultaat.Name = "gb_resultaat";
            this.gb_resultaat.Size = new System.Drawing.Size(175, 309);
            this.gb_resultaat.TabIndex = 1;
            this.gb_resultaat.TabStop = false;
            this.gb_resultaat.Text = "Resultaat";
            // 
            // label_worpen
            // 
            this.label_worpen.AutoSize = true;
            this.label_worpen.Location = new System.Drawing.Point(6, 38);
            this.label_worpen.Name = "label_worpen";
            this.label_worpen.Size = new System.Drawing.Size(45, 13);
            this.label_worpen.TabIndex = 1;
            this.label_worpen.Text = "Worpen";
            // 
            // lb_worpen
            // 
            this.lb_worpen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_worpen.FormattingEnabled = true;
            this.lb_worpen.ItemHeight = 22;
            this.lb_worpen.Location = new System.Drawing.Point(6, 63);
            this.lb_worpen.Name = "lb_worpen";
            this.lb_worpen.Size = new System.Drawing.Size(163, 158);
            this.lb_worpen.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label_totaal_title
            // 
            this.label_totaal_title.AutoSize = true;
            this.label_totaal_title.Location = new System.Drawing.Point(3, 268);
            this.label_totaal_title.Name = "label_totaal_title";
            this.label_totaal_title.Size = new System.Drawing.Size(99, 13);
            this.label_totaal_title.TabIndex = 2;
            this.label_totaal_title.Text = "Totaal aantal ogen:";
            // 
            // label_totaal
            // 
            this.label_totaal.AutoSize = true;
            this.label_totaal.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totaal.Location = new System.Drawing.Point(118, 254);
            this.label_totaal.Name = "label_totaal";
            this.label_totaal.Size = new System.Drawing.Size(35, 37);
            this.label_totaal.TabIndex = 3;
            this.label_totaal.Text = "0";
            // 
            // label_aantalOgen
            // 
            this.label_aantalOgen.AutoSize = true;
            this.label_aantalOgen.Location = new System.Drawing.Point(6, 92);
            this.label_aantalOgen.Name = "label_aantalOgen";
            this.label_aantalOgen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_aantalOgen.Size = new System.Drawing.Size(98, 13);
            this.label_aantalOgen.TabIndex = 3;
            this.label_aantalOgen.Text = "Max. aantal ogenL:";
            // 
            // updown_maxogen
            // 
            this.updown_maxogen.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updown_maxogen.Location = new System.Drawing.Point(147, 90);
            this.updown_maxogen.Name = "updown_maxogen";
            this.updown_maxogen.Size = new System.Drawing.Size(120, 20);
            this.updown_maxogen.TabIndex = 4;
            this.updown_maxogen.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label_hoogste
            // 
            this.label_hoogste.AutoSize = true;
            this.label_hoogste.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoogste.Location = new System.Drawing.Point(121, 278);
            this.label_hoogste.Name = "label_hoogste";
            this.label_hoogste.Size = new System.Drawing.Size(0, 19);
            this.label_hoogste.TabIndex = 5;
            // 
            // Worpengenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(631, 421);
            this.Controls.Add(this.gb_resultaat);
            this.Controls.Add(this.gb_instellingen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Worpengenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worpengenerator";
            this.gb_instellingen.ResumeLayout(false);
            this.gb_instellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown_aantalWorpen)).EndInit();
            this.gb_resultaat.ResumeLayout(false);
            this.gb_resultaat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown_maxogen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_instellingen;
        private System.Windows.Forms.Button button_gooi;
        private System.Windows.Forms.NumericUpDown updown_aantalWorpen;
        private System.Windows.Forms.Label label_aantalWorpen;
        private System.Windows.Forms.GroupBox gb_resultaat;
        private System.Windows.Forms.Label label_worpen;
        private System.Windows.Forms.ListBox lb_worpen;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label_totaal;
        private System.Windows.Forms.Label label_totaal_title;
        private System.Windows.Forms.NumericUpDown updown_maxogen;
        private System.Windows.Forms.Label label_aantalOgen;
        private System.Windows.Forms.Label label_hoogste;
        private System.Windows.Forms.Label label1;
    }
}

