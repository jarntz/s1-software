namespace BMI_calculator_app
{
    partial class Form1
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
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.rb_vrouw = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.fb_leeftijd = new System.Windows.Forms.TextBox();
            this.tb_lengte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_gewicht = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_uitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI berekenen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Je geslacht:";
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_man.Location = new System.Drawing.Point(125, 98);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(51, 20);
            this.rb_man.TabIndex = 2;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "Man";
            this.rb_man.UseVisualStyleBackColor = true;
            // 
            // rb_vrouw
            // 
            this.rb_vrouw.AutoSize = true;
            this.rb_vrouw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_vrouw.Location = new System.Drawing.Point(125, 124);
            this.rb_vrouw.Name = "rb_vrouw";
            this.rb_vrouw.Size = new System.Drawing.Size(62, 20);
            this.rb_vrouw.TabIndex = 3;
            this.rb_vrouw.TabStop = true;
            this.rb_vrouw.Text = "Vrouw";
            this.rb_vrouw.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Je leeftijd";
            // 
            // fb_leeftijd
            // 
            this.fb_leeftijd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fb_leeftijd.Location = new System.Drawing.Point(125, 183);
            this.fb_leeftijd.Name = "fb_leeftijd";
            this.fb_leeftijd.Size = new System.Drawing.Size(100, 22);
            this.fb_leeftijd.TabIndex = 5;
            // 
            // tb_lengte
            // 
            this.tb_lengte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lengte.Location = new System.Drawing.Point(125, 224);
            this.tb_lengte.Name = "tb_lengte";
            this.tb_lengte.Size = new System.Drawing.Size(100, 22);
            this.tb_lengte.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Je lengte:";
            // 
            // tb_gewicht
            // 
            this.tb_gewicht.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gewicht.Location = new System.Drawing.Point(125, 265);
            this.tb_gewicht.Name = "tb_gewicht";
            this.tb_gewicht.Size = new System.Drawing.Size(100, 22);
            this.tb_gewicht.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Je gewicht:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "jaar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "cm";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(19, 318);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(88, 28);
            this.button.TabIndex = 13;
            this.button.Text = "Bereken";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Je BMI is:";
            // 
            // label_uitkomst
            // 
            this.label_uitkomst.AutoSize = true;
            this.label_uitkomst.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uitkomst.Location = new System.Drawing.Point(95, 392);
            this.label_uitkomst.Name = "label_uitkomst";
            this.label_uitkomst.Size = new System.Drawing.Size(35, 37);
            this.label_uitkomst.TabIndex = 15;
            this.label_uitkomst.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(364, 464);
            this.Controls.Add(this.label_uitkomst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_gewicht);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_lengte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fb_leeftijd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_vrouw);
            this.Controls.Add(this.rb_man);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.RadioButton rb_vrouw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fb_leeftijd;
        private System.Windows.Forms.TextBox tb_lengte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_gewicht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_uitkomst;
    }
}

