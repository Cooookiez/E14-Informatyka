namespace _008_ktura_liczba_wieksza
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
            this.textBox_nr1 = new System.Windows.Forms.TextBox();
            this.textBox_nr2 = new System.Windows.Forms.TextBox();
            this.label_znak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nr1
            // 
            this.textBox_nr1.Location = new System.Drawing.Point(13, 13);
            this.textBox_nr1.Name = "textBox_nr1";
            this.textBox_nr1.Size = new System.Drawing.Size(100, 20);
            this.textBox_nr1.TabIndex = 0;
            this.textBox_nr1.TextChanged += new System.EventHandler(this.textBox_nr1_TextChanged);
            // 
            // textBox_nr2
            // 
            this.textBox_nr2.Location = new System.Drawing.Point(172, 12);
            this.textBox_nr2.Name = "textBox_nr2";
            this.textBox_nr2.Size = new System.Drawing.Size(100, 20);
            this.textBox_nr2.TabIndex = 1;
            this.textBox_nr2.TextChanged += new System.EventHandler(this.textBox_nr2_TextChanged);
            // 
            // label_znak
            // 
            this.label_znak.AutoSize = true;
            this.label_znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_znak.Location = new System.Drawing.Point(129, 12);
            this.label_znak.Name = "label_znak";
            this.label_znak.Size = new System.Drawing.Size(24, 25);
            this.label_znak.TabIndex = 2;
            this.label_znak.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 51);
            this.Controls.Add(this.label_znak);
            this.Controls.Add(this.textBox_nr2);
            this.Controls.Add(this.textBox_nr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nr1;
        private System.Windows.Forms.TextBox textBox_nr2;
        private System.Windows.Forms.Label label_znak;
    }
}

