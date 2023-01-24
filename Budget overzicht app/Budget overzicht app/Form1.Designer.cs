namespace Budget_overzicht_app
{
    partial class budget_overzicht
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
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ink_omschrijving = new System.Windows.Forms.TextBox();
            this.tb_ink_bedrag = new System.Windows.Forms.TextBox();
            this.b_ink_add = new System.Windows.Forms.Button();
            this.lb_ink_items = new System.Windows.Forms.ListBox();
            this.lb_ink_bedragen = new System.Windows.Forms.ListBox();
            this.b_ink_plus = new System.Windows.Forms.Button();
            this.b_ink_min = new System.Windows.Forms.Button();
            this.l_ink_totaal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_uit_totaal = new System.Windows.Forms.Label();
            this.b_uit_min = new System.Windows.Forms.Button();
            this.b_uit_plus = new System.Windows.Forms.Button();
            this.lb_uit_bedragen = new System.Windows.Forms.ListBox();
            this.lb_uit_items = new System.Windows.Forms.ListBox();
            this.b_uit_add = new System.Windows.Forms.Button();
            this.tb_uit_bedrag = new System.Windows.Forms.TextBox();
            this.tb_uit_omschrijving = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.l_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(23, 41);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(252, 34);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Budget overzicht";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inkomsten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam of omschrijving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bedrag in €";
            // 
            // tb_ink_omschrijving
            // 
            this.tb_ink_omschrijving.Location = new System.Drawing.Point(29, 162);
            this.tb_ink_omschrijving.Name = "tb_ink_omschrijving";
            this.tb_ink_omschrijving.Size = new System.Drawing.Size(211, 20);
            this.tb_ink_omschrijving.TabIndex = 4;
            // 
            // tb_ink_bedrag
            // 
            this.tb_ink_bedrag.Location = new System.Drawing.Point(270, 162);
            this.tb_ink_bedrag.Name = "tb_ink_bedrag";
            this.tb_ink_bedrag.Size = new System.Drawing.Size(90, 20);
            this.tb_ink_bedrag.TabIndex = 5;
            // 
            // b_ink_add
            // 
            this.b_ink_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.b_ink_add.ForeColor = System.Drawing.Color.White;
            this.b_ink_add.Location = new System.Drawing.Point(28, 196);
            this.b_ink_add.Name = "b_ink_add";
            this.b_ink_add.Size = new System.Drawing.Size(96, 25);
            this.b_ink_add.TabIndex = 6;
            this.b_ink_add.Text = "Voeg toe";
            this.b_ink_add.UseVisualStyleBackColor = false;
            this.b_ink_add.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lb_ink_items
            // 
            this.lb_ink_items.FormattingEnabled = true;
            this.lb_ink_items.Location = new System.Drawing.Point(29, 254);
            this.lb_ink_items.Name = "lb_ink_items";
            this.lb_ink_items.Size = new System.Drawing.Size(211, 212);
            this.lb_ink_items.TabIndex = 7;
            // 
            // lb_ink_bedragen
            // 
            this.lb_ink_bedragen.FormattingEnabled = true;
            this.lb_ink_bedragen.Location = new System.Drawing.Point(270, 254);
            this.lb_ink_bedragen.Name = "lb_ink_bedragen";
            this.lb_ink_bedragen.Size = new System.Drawing.Size(90, 212);
            this.lb_ink_bedragen.TabIndex = 8;
            // 
            // b_ink_plus
            // 
            this.b_ink_plus.Location = new System.Drawing.Point(29, 488);
            this.b_ink_plus.Name = "b_ink_plus";
            this.b_ink_plus.Size = new System.Drawing.Size(32, 23);
            this.b_ink_plus.TabIndex = 9;
            this.b_ink_plus.Text = "+";
            this.b_ink_plus.UseVisualStyleBackColor = true;
            this.b_ink_plus.Click += new System.EventHandler(this.B_ink_plus_Click);
            // 
            // b_ink_min
            // 
            this.b_ink_min.Location = new System.Drawing.Point(57, 488);
            this.b_ink_min.Name = "b_ink_min";
            this.b_ink_min.Size = new System.Drawing.Size(32, 23);
            this.b_ink_min.TabIndex = 10;
            this.b_ink_min.Text = "-";
            this.b_ink_min.UseVisualStyleBackColor = true;
            this.b_ink_min.Click += new System.EventHandler(this.B_ink_min_Click);
            // 
            // l_ink_totaal
            // 
            this.l_ink_totaal.AutoSize = true;
            this.l_ink_totaal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ink_totaal.Location = new System.Drawing.Point(273, 488);
            this.l_ink_totaal.Name = "l_ink_totaal";
            this.l_ink_totaal.Size = new System.Drawing.Size(68, 32);
            this.l_ink_totaal.TabIndex = 11;
            this.l_ink_totaal.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Totaal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Totaal";
            // 
            // l_uit_totaal
            // 
            this.l_uit_totaal.AutoSize = true;
            this.l_uit_totaal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_uit_totaal.Location = new System.Drawing.Point(692, 488);
            this.l_uit_totaal.Name = "l_uit_totaal";
            this.l_uit_totaal.Size = new System.Drawing.Size(68, 32);
            this.l_uit_totaal.TabIndex = 23;
            this.l_uit_totaal.Text = "0,00";
            // 
            // b_uit_min
            // 
            this.b_uit_min.Location = new System.Drawing.Point(476, 488);
            this.b_uit_min.Name = "b_uit_min";
            this.b_uit_min.Size = new System.Drawing.Size(32, 23);
            this.b_uit_min.TabIndex = 22;
            this.b_uit_min.Text = "-";
            this.b_uit_min.UseVisualStyleBackColor = true;
            this.b_uit_min.Click += new System.EventHandler(this.B_uit_min_Click);
            // 
            // b_uit_plus
            // 
            this.b_uit_plus.Location = new System.Drawing.Point(448, 488);
            this.b_uit_plus.Name = "b_uit_plus";
            this.b_uit_plus.Size = new System.Drawing.Size(32, 23);
            this.b_uit_plus.TabIndex = 21;
            this.b_uit_plus.Text = "+";
            this.b_uit_plus.UseVisualStyleBackColor = true;
            this.b_uit_plus.Click += new System.EventHandler(this.B_uit_plus_Click);
            // 
            // lb_uit_bedragen
            // 
            this.lb_uit_bedragen.FormattingEnabled = true;
            this.lb_uit_bedragen.Location = new System.Drawing.Point(689, 254);
            this.lb_uit_bedragen.Name = "lb_uit_bedragen";
            this.lb_uit_bedragen.Size = new System.Drawing.Size(90, 212);
            this.lb_uit_bedragen.TabIndex = 20;
            // 
            // lb_uit_items
            // 
            this.lb_uit_items.FormattingEnabled = true;
            this.lb_uit_items.Location = new System.Drawing.Point(448, 254);
            this.lb_uit_items.Name = "lb_uit_items";
            this.lb_uit_items.Size = new System.Drawing.Size(211, 212);
            this.lb_uit_items.TabIndex = 19;
            // 
            // b_uit_add
            // 
            this.b_uit_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.b_uit_add.ForeColor = System.Drawing.Color.White;
            this.b_uit_add.Location = new System.Drawing.Point(447, 196);
            this.b_uit_add.Name = "b_uit_add";
            this.b_uit_add.Size = new System.Drawing.Size(96, 25);
            this.b_uit_add.TabIndex = 18;
            this.b_uit_add.Text = "Voeg toe";
            this.b_uit_add.UseVisualStyleBackColor = false;
            this.b_uit_add.Click += new System.EventHandler(this.B_uit_add_Click);
            // 
            // tb_uit_bedrag
            // 
            this.tb_uit_bedrag.Location = new System.Drawing.Point(689, 162);
            this.tb_uit_bedrag.Name = "tb_uit_bedrag";
            this.tb_uit_bedrag.Size = new System.Drawing.Size(90, 20);
            this.tb_uit_bedrag.TabIndex = 17;
            // 
            // tb_uit_omschrijving
            // 
            this.tb_uit_omschrijving.Location = new System.Drawing.Point(448, 162);
            this.tb_uit_omschrijving.Name = "tb_uit_omschrijving";
            this.tb_uit_omschrijving.Size = new System.Drawing.Size(211, 20);
            this.tb_uit_omschrijving.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bedrag in €";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(445, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Naam of omschrijving";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(444, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Uitgaven";
            // 
            // pb_status
            // 
            this.pb_status.Image = global::Budget_overzicht_app.Properties.Resources.groen;
            this.pb_status.Location = new System.Drawing.Point(29, 550);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(30, 30);
            this.pb_status.TabIndex = 25;
            this.pb_status.TabStop = false;
            // 
            // l_result
            // 
            this.l_result.AutoSize = true;
            this.l_result.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_result.Location = new System.Drawing.Point(83, 558);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(165, 16);
            this.l_result.TabIndex = 26;
            this.l_result.Text = "Vul eerst wat onderdelen in";
            // 
            // budget_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(814, 610);
            this.Controls.Add(this.l_result);
            this.Controls.Add(this.pb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_uit_totaal);
            this.Controls.Add(this.b_uit_min);
            this.Controls.Add(this.b_uit_plus);
            this.Controls.Add(this.lb_uit_bedragen);
            this.Controls.Add(this.lb_uit_items);
            this.Controls.Add(this.b_uit_add);
            this.Controls.Add(this.tb_uit_bedrag);
            this.Controls.Add(this.tb_uit_omschrijving);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_ink_totaal);
            this.Controls.Add(this.b_ink_min);
            this.Controls.Add(this.b_ink_plus);
            this.Controls.Add(this.lb_ink_bedragen);
            this.Controls.Add(this.lb_ink_items);
            this.Controls.Add(this.b_ink_add);
            this.Controls.Add(this.tb_ink_bedrag);
            this.Controls.Add(this.tb_ink_omschrijving);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "budget_overzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget overzicht";
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ink_omschrijving;
        private System.Windows.Forms.TextBox tb_ink_bedrag;
        private System.Windows.Forms.Button b_ink_add;
        private System.Windows.Forms.ListBox lb_ink_items;
        private System.Windows.Forms.ListBox lb_ink_bedragen;
        private System.Windows.Forms.Button b_ink_plus;
        private System.Windows.Forms.Button b_ink_min;
        private System.Windows.Forms.Label l_ink_totaal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_uit_totaal;
        private System.Windows.Forms.Button b_uit_min;
        private System.Windows.Forms.Button b_uit_plus;
        private System.Windows.Forms.ListBox lb_uit_bedragen;
        private System.Windows.Forms.ListBox lb_uit_items;
        private System.Windows.Forms.Button b_uit_add;
        private System.Windows.Forms.TextBox tb_uit_bedrag;
        private System.Windows.Forms.TextBox tb_uit_omschrijving;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Label l_result;
    }
}

