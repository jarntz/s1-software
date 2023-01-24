namespace Bloeddruk_app
{
    partial class bloeddruk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_leeftijd = new System.Windows.Forms.TextBox();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.rb_vrouw = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_bovendruk = new System.Windows.Forms.TextBox();
            this.tb_onderdruk = new System.Windows.Forms.TextBox();
            this.tb_naam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b_meet = new System.Windows.Forms.Button();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.l_status = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.l_info = new System.Windows.Forms.Label();
            this.b_leeg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bloeddruk meten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leeftijd";
            // 
            // tb_leeftijd
            // 
            this.tb_leeftijd.Location = new System.Drawing.Point(146, 150);
            this.tb_leeftijd.Name = "tb_leeftijd";
            this.tb_leeftijd.Size = new System.Drawing.Size(100, 20);
            this.tb_leeftijd.TabIndex = 2;
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Location = new System.Drawing.Point(148, 176);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(46, 17);
            this.rb_man.TabIndex = 3;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "Man";
            this.rb_man.UseVisualStyleBackColor = true;
            // 
            // rb_vrouw
            // 
            this.rb_vrouw.AutoSize = true;
            this.rb_vrouw.Location = new System.Drawing.Point(214, 176);
            this.rb_vrouw.Name = "rb_vrouw";
            this.rb_vrouw.Size = new System.Drawing.Size(55, 17);
            this.rb_vrouw.TabIndex = 4;
            this.rb_vrouw.TabStop = true;
            this.rb_vrouw.Text = "Vrouw";
            this.rb_vrouw.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geslacht";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bovendruk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Onderdruk";
            // 
            // tb_bovendruk
            // 
            this.tb_bovendruk.Location = new System.Drawing.Point(148, 226);
            this.tb_bovendruk.Name = "tb_bovendruk";
            this.tb_bovendruk.Size = new System.Drawing.Size(100, 20);
            this.tb_bovendruk.TabIndex = 5;
            // 
            // tb_onderdruk
            // 
            this.tb_onderdruk.Location = new System.Drawing.Point(148, 255);
            this.tb_onderdruk.Name = "tb_onderdruk";
            this.tb_onderdruk.Size = new System.Drawing.Size(100, 20);
            this.tb_onderdruk.TabIndex = 6;
            // 
            // tb_naam
            // 
            this.tb_naam.Location = new System.Drawing.Point(146, 124);
            this.tb_naam.Name = "tb_naam";
            this.tb_naam.Size = new System.Drawing.Size(100, 20);
            this.tb_naam.TabIndex = 1;
            this.tb_naam.TextChanged += new System.EventHandler(this.Tb_naam_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naam";
            // 
            // b_meet
            // 
            this.b_meet.Location = new System.Drawing.Point(35, 321);
            this.b_meet.Name = "b_meet";
            this.b_meet.Size = new System.Drawing.Size(95, 39);
            this.b_meet.TabIndex = 7;
            this.b_meet.Text = "Meet";
            this.b_meet.UseVisualStyleBackColor = true;
            this.b_meet.Click += new System.EventHandler(this.B_meet_Click);
            // 
            // pb_status
            // 
            this.pb_status.Location = new System.Drawing.Point(355, 113);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(48, 48);
            this.pb_status.TabIndex = 13;
            this.pb_status.TabStop = false;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_status.Location = new System.Drawing.Point(424, 122);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(0, 32);
            this.l_status.TabIndex = 14;
            // 
            // lb_result
            // 
            this.lb_result.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.ItemHeight = 16;
            this.lb_result.Location = new System.Drawing.Point(430, 212);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(263, 148);
            this.lb_result.TabIndex = 15;
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_info.Location = new System.Drawing.Point(429, 166);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(0, 17);
            this.l_info.TabIndex = 16;
            // 
            // b_leeg
            // 
            this.b_leeg.Location = new System.Drawing.Point(355, 321);
            this.b_leeg.Name = "b_leeg";
            this.b_leeg.Size = new System.Drawing.Size(69, 39);
            this.b_leeg.TabIndex = 8;
            this.b_leeg.Text = "Leeg";
            this.b_leeg.UseVisualStyleBackColor = true;
            this.b_leeg.Click += new System.EventHandler(this.B_leeg_Click);
            // 
            // bloeddruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(729, 394);
            this.Controls.Add(this.b_leeg);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.pb_status);
            this.Controls.Add(this.b_meet);
            this.Controls.Add(this.tb_naam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_onderdruk);
            this.Controls.Add(this.tb_bovendruk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_vrouw);
            this.Controls.Add(this.rb_man);
            this.Controls.Add(this.tb_leeftijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "bloeddruk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloeddruk";
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_leeftijd;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.RadioButton rb_vrouw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_bovendruk;
        private System.Windows.Forms.TextBox tb_onderdruk;
        private System.Windows.Forms.TextBox tb_naam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_meet;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Button b_leeg;
    }
}

