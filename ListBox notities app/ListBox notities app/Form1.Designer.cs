namespace ListBox_notities_app
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
            this.tb = new System.Windows.Forms.TextBox();
            this.button_toevoegen = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.buttonplus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_counter = new System.Windows.Forms.Label();
            this.button_sorteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notitielijst";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(20, 89);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(232, 22);
            this.tb.TabIndex = 1;
            // 
            // button_toevoegen
            // 
            this.button_toevoegen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_toevoegen.Location = new System.Drawing.Point(270, 87);
            this.button_toevoegen.Name = "button_toevoegen";
            this.button_toevoegen.Size = new System.Drawing.Size(75, 26);
            this.button_toevoegen.TabIndex = 2;
            this.button_toevoegen.Text = "Voeg toe";
            this.button_toevoegen.UseVisualStyleBackColor = true;
            this.button_toevoegen.Click += new System.EventHandler(this.Button_toevoegen_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(20, 133);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(325, 199);
            this.lb.TabIndex = 3;
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplus.Location = new System.Drawing.Point(20, 351);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(28, 26);
            this.buttonplus.TabIndex = 4;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.Buttonplus_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aantal items:";
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counter.Location = new System.Drawing.Point(111, 394);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(35, 37);
            this.label_counter.TabIndex = 7;
            this.label_counter.Text = "0";
            // 
            // button_sorteer
            // 
            this.button_sorteer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sorteer.Location = new System.Drawing.Point(87, 351);
            this.button_sorteer.Name = "button_sorteer";
            this.button_sorteer.Size = new System.Drawing.Size(75, 26);
            this.button_sorteer.TabIndex = 8;
            this.button_sorteer.Text = "Sorteer";
            this.button_sorteer.UseVisualStyleBackColor = true;
            this.button_sorteer.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(366, 445);
            this.Controls.Add(this.button_sorteer);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button_toevoegen);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button button_toevoegen;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.Button button_sorteer;
    }
}

