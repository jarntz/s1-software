namespace Rekenmachine_app
{
    partial class calculator
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
            this.label_getal1 = new System.Windows.Forms.Label();
            this.label_getal2 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_keer = new System.Windows.Forms.Button();
            this.label_uitkomst_title = new System.Windows.Forms.Label();
            this.label_uitkomst = new System.Windows.Forms.Label();
            this.button_delen = new System.Windows.Forms.Button();
            this.button_wortel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_getal1
            // 
            this.label_getal1.AutoSize = true;
            this.label_getal1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_getal1.Location = new System.Drawing.Point(26, 52);
            this.label_getal1.Name = "label_getal1";
            this.label_getal1.Size = new System.Drawing.Size(58, 18);
            this.label_getal1.TabIndex = 0;
            this.label_getal1.Text = "Getal 1";
            // 
            // label_getal2
            // 
            this.label_getal2.AutoSize = true;
            this.label_getal2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_getal2.Location = new System.Drawing.Point(206, 52);
            this.label_getal2.Name = "label_getal2";
            this.label_getal2.Size = new System.Drawing.Size(58, 18);
            this.label_getal2.TabIndex = 1;
            this.label_getal2.Text = "Getal 2";
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_1.Location = new System.Drawing.Point(29, 92);
            this.tb_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(152, 22);
            this.tb_1.TabIndex = 2;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.Location = new System.Drawing.Point(210, 92);
            this.tb_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(152, 22);
            this.tb_2.TabIndex = 3;
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(399, 91);
            this.button_plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(43, 28);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // button_keer
            // 
            this.button_keer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_keer.Location = new System.Drawing.Point(449, 91);
            this.button_keer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_keer.Name = "button_keer";
            this.button_keer.Size = new System.Drawing.Size(43, 28);
            this.button_keer.TabIndex = 5;
            this.button_keer.Text = "X";
            this.button_keer.UseVisualStyleBackColor = true;
            this.button_keer.Click += new System.EventHandler(this.Button_keer_Click);
            // 
            // label_uitkomst_title
            // 
            this.label_uitkomst_title.AutoSize = true;
            this.label_uitkomst_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uitkomst_title.Location = new System.Drawing.Point(26, 172);
            this.label_uitkomst_title.Name = "label_uitkomst_title";
            this.label_uitkomst_title.Size = new System.Drawing.Size(73, 18);
            this.label_uitkomst_title.TabIndex = 6;
            this.label_uitkomst_title.Text = "Uitkomst:";
            // 
            // label_uitkomst
            // 
            this.label_uitkomst.AutoSize = true;
            this.label_uitkomst.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uitkomst.Location = new System.Drawing.Point(105, 161);
            this.label_uitkomst.Name = "label_uitkomst";
            this.label_uitkomst.Size = new System.Drawing.Size(35, 37);
            this.label_uitkomst.TabIndex = 7;
            this.label_uitkomst.Text = "0";
            // 
            // button_delen
            // 
            this.button_delen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delen.Location = new System.Drawing.Point(498, 91);
            this.button_delen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delen.Name = "button_delen";
            this.button_delen.Size = new System.Drawing.Size(43, 28);
            this.button_delen.TabIndex = 8;
            this.button_delen.Text = "/";
            this.button_delen.UseVisualStyleBackColor = true;
            this.button_delen.Click += new System.EventHandler(this.Button_delen_Click);
            // 
            // button_wortel
            // 
            this.button_wortel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wortel.Location = new System.Drawing.Point(547, 91);
            this.button_wortel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_wortel.Name = "button_wortel";
            this.button_wortel.Size = new System.Drawing.Size(43, 28);
            this.button_wortel.TabIndex = 9;
            this.button_wortel.Text = "√";
            this.button_wortel.UseVisualStyleBackColor = true;
            this.button_wortel.Click += new System.EventHandler(this.Button_wortel_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(626, 241);
            this.Controls.Add(this.button_wortel);
            this.Controls.Add(this.button_delen);
            this.Controls.Add(this.label_uitkomst);
            this.Controls.Add(this.label_uitkomst_title);
            this.Controls.Add(this.button_keer);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label_getal2);
            this.Controls.Add(this.label_getal1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_getal1;
        private System.Windows.Forms.Label label_getal2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_keer;
        private System.Windows.Forms.Label label_uitkomst_title;
        private System.Windows.Forms.Label label_uitkomst;
        private System.Windows.Forms.Button button_delen;
        private System.Windows.Forms.Button button_wortel;
    }
}

