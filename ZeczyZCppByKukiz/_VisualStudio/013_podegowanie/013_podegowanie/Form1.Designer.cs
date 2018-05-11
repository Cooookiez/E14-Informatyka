namespace _013_podegowanie
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
            this.numericUpDown_podstawa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_podega = new System.Windows.Forms.NumericUpDown();
            this.label_wynik = new System.Windows.Forms.Label();
            this.button_pok_wynik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_podstawa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_podega)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_podstawa
            // 
            this.numericUpDown_podstawa.DecimalPlaces = 2;
            this.numericUpDown_podstawa.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_podstawa.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_podstawa.Location = new System.Drawing.Point(12, 39);
            this.numericUpDown_podstawa.Name = "numericUpDown_podstawa";
            this.numericUpDown_podstawa.Size = new System.Drawing.Size(124, 56);
            this.numericUpDown_podstawa.TabIndex = 0;
            this.numericUpDown_podstawa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_podega
            // 
            this.numericUpDown_podega.DecimalPlaces = 2;
            this.numericUpDown_podega.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_podega.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_podega.Location = new System.Drawing.Point(142, 12);
            this.numericUpDown_podega.Name = "numericUpDown_podega";
            this.numericUpDown_podega.Size = new System.Drawing.Size(124, 56);
            this.numericUpDown_podega.TabIndex = 1;
            // 
            // label_wynik
            // 
            this.label_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wynik.Location = new System.Drawing.Point(12, 98);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(254, 62);
            this.label_wynik.TabIndex = 2;
            this.label_wynik.Text = "Wynik";
            this.label_wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_pok_wynik
            // 
            this.button_pok_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pok_wynik.Location = new System.Drawing.Point(12, 163);
            this.button_pok_wynik.Name = "button_pok_wynik";
            this.button_pok_wynik.Size = new System.Drawing.Size(260, 56);
            this.button_pok_wynik.TabIndex = 3;
            this.button_pok_wynik.Text = "Oblicz";
            this.button_pok_wynik.UseVisualStyleBackColor = true;
            this.button_pok_wynik.Click += new System.EventHandler(this.button_pok_wynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.button_pok_wynik);
            this.Controls.Add(this.label_wynik);
            this.Controls.Add(this.numericUpDown_podega);
            this.Controls.Add(this.numericUpDown_podstawa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_podstawa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_podega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_podstawa;
        private System.Windows.Forms.NumericUpDown numericUpDown_podega;
        private System.Windows.Forms.Label label_wynik;
        private System.Windows.Forms.Button button_pok_wynik;
    }
}

