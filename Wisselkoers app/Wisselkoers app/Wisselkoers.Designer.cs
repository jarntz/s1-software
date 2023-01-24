namespace Wisselkoers_app
{
    partial class Wisselkoers
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
            this.label_wisselkoers = new System.Windows.Forms.Label();
            this.label_euro = new System.Windows.Forms.Label();
            this.label_dollar = new System.Windows.Forms.Label();
            this.tb_euro = new System.Windows.Forms.TextBox();
            this.tb_dollar = new System.Windows.Forms.TextBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.label_koers = new System.Windows.Forms.Label();
            this.updown_koers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.updown_koers)).BeginInit();
            this.SuspendLayout();
            // 
            // label_wisselkoers
            // 
            this.label_wisselkoers.AutoSize = true;
            this.label_wisselkoers.Location = new System.Drawing.Point(189, 30);
            this.label_wisselkoers.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label_wisselkoers.Name = "label_wisselkoers";
            this.label_wisselkoers.Size = new System.Drawing.Size(208, 37);
            this.label_wisselkoers.TabIndex = 0;
            this.label_wisselkoers.Text = "Wisselkoers";
            this.label_wisselkoers.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_euro
            // 
            this.label_euro.AutoSize = true;
            this.label_euro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_euro.Location = new System.Drawing.Point(32, 147);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(53, 55);
            this.label_euro.TabIndex = 1;
            this.label_euro.Text = "€";
            // 
            // label_dollar
            // 
            this.label_dollar.AutoSize = true;
            this.label_dollar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dollar.Location = new System.Drawing.Point(505, 147);
            this.label_dollar.Name = "label_dollar";
            this.label_dollar.Size = new System.Drawing.Size(53, 55);
            this.label_dollar.TabIndex = 2;
            this.label_dollar.Text = "$";
            this.label_dollar.Click += new System.EventHandler(this.Label_dollar_Click);
            // 
            // tb_euro
            // 
            this.tb_euro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_euro.Location = new System.Drawing.Point(119, 165);
            this.tb_euro.Name = "tb_euro";
            this.tb_euro.Size = new System.Drawing.Size(100, 22);
            this.tb_euro.TabIndex = 3;
            this.tb_euro.Text = "1";
            // 
            // tb_dollar
            // 
            this.tb_dollar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dollar.Location = new System.Drawing.Point(360, 165);
            this.tb_dollar.Name = "tb_dollar";
            this.tb_dollar.Size = new System.Drawing.Size(100, 22);
            this.tb_dollar.TabIndex = 4;
            this.tb_dollar.Text = "1";
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left.Location = new System.Drawing.Point(238, 165);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(48, 23);
            this.button_left.TabIndex = 5;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.Button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right.Location = new System.Drawing.Point(292, 165);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(48, 23);
            this.button_right.TabIndex = 6;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.Button_right_Click);
            // 
            // label_koers
            // 
            this.label_koers.AutoSize = true;
            this.label_koers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_koers.Location = new System.Drawing.Point(210, 259);
            this.label_koers.Name = "label_koers";
            this.label_koers.Size = new System.Drawing.Size(91, 16);
            this.label_koers.TabIndex = 7;
            this.label_koers.Text = "Koers: € 1 = $";
            // 
            // updown_koers
            // 
            this.updown_koers.DecimalPlaces = 2;
            this.updown_koers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updown_koers.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.updown_koers.Location = new System.Drawing.Point(303, 257);
            this.updown_koers.Name = "updown_koers";
            this.updown_koers.Size = new System.Drawing.Size(70, 22);
            this.updown_koers.TabIndex = 8;
            this.updown_koers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Wisselkoers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(590, 315);
            this.Controls.Add(this.updown_koers);
            this.Controls.Add(this.label_koers);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.tb_dollar);
            this.Controls.Add(this.tb_euro);
            this.Controls.Add(this.label_dollar);
            this.Controls.Add(this.label_euro);
            this.Controls.Add(this.label_wisselkoers);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "Wisselkoers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wisselkoers";
            ((System.ComponentModel.ISupportInitialize)(this.updown_koers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wisselkoers;
        private System.Windows.Forms.Label label_euro;
        private System.Windows.Forms.Label label_dollar;
        private System.Windows.Forms.TextBox tb_euro;
        private System.Windows.Forms.TextBox tb_dollar;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Label label_koers;
        private System.Windows.Forms.NumericUpDown updown_koers;
    }
}

