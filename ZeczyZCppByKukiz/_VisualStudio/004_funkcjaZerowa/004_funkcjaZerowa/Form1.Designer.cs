namespace _004_funkcjaZerowa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_podaj_c = new System.Windows.Forms.TextBox();
            this.label_podaj_c = new System.Windows.Forms.Label();
            this.text_podaj_b = new System.Windows.Forms.TextBox();
            this.label_podaj_b = new System.Windows.Forms.Label();
            this.text_podaj_a = new System.Windows.Forms.TextBox();
            this.label_podaj_a = new System.Windows.Forms.Label();
            this.oblicz = new System.Windows.Forms.Button();
            this.miejscaZerowe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funkcjia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ax^2 + bx + c";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_podaj_c);
            this.groupBox2.Controls.Add(this.label_podaj_c);
            this.groupBox2.Controls.Add(this.text_podaj_b);
            this.groupBox2.Controls.Add(this.label_podaj_b);
            this.groupBox2.Controls.Add(this.text_podaj_a);
            this.groupBox2.Controls.Add(this.label_podaj_a);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zmienne";
            // 
            // text_podaj_c
            // 
            this.text_podaj_c.Location = new System.Drawing.Point(122, 69);
            this.text_podaj_c.Name = "text_podaj_c";
            this.text_podaj_c.Size = new System.Drawing.Size(43, 20);
            this.text_podaj_c.TabIndex = 5;
            // 
            // label_podaj_c
            // 
            this.label_podaj_c.AutoSize = true;
            this.label_podaj_c.Location = new System.Drawing.Point(7, 72);
            this.label_podaj_c.Name = "label_podaj_c";
            this.label_podaj_c.Size = new System.Drawing.Size(43, 13);
            this.label_podaj_c.TabIndex = 4;
            this.label_podaj_c.Text = "Podaj c";
            // 
            // text_podaj_b
            // 
            this.text_podaj_b.Location = new System.Drawing.Point(122, 43);
            this.text_podaj_b.Name = "text_podaj_b";
            this.text_podaj_b.Size = new System.Drawing.Size(43, 20);
            this.text_podaj_b.TabIndex = 3;
            // 
            // label_podaj_b
            // 
            this.label_podaj_b.AutoSize = true;
            this.label_podaj_b.Location = new System.Drawing.Point(7, 46);
            this.label_podaj_b.Name = "label_podaj_b";
            this.label_podaj_b.Size = new System.Drawing.Size(43, 13);
            this.label_podaj_b.TabIndex = 2;
            this.label_podaj_b.Text = "Podaj b";
            // 
            // text_podaj_a
            // 
            this.text_podaj_a.Location = new System.Drawing.Point(122, 17);
            this.text_podaj_a.Name = "text_podaj_a";
            this.text_podaj_a.Size = new System.Drawing.Size(43, 20);
            this.text_podaj_a.TabIndex = 1;
            // 
            // label_podaj_a
            // 
            this.label_podaj_a.AutoSize = true;
            this.label_podaj_a.Location = new System.Drawing.Point(7, 20);
            this.label_podaj_a.Name = "label_podaj_a";
            this.label_podaj_a.Size = new System.Drawing.Size(43, 13);
            this.label_podaj_a.TabIndex = 0;
            this.label_podaj_a.Text = "Podaj a";
            // 
            // oblicz
            // 
            this.oblicz.Location = new System.Drawing.Point(12, 230);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(171, 23);
            this.oblicz.TabIndex = 2;
            this.oblicz.Text = "oblicz";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // miejscaZerowe
            // 
            this.miejscaZerowe.AutoSize = true;
            this.miejscaZerowe.Location = new System.Drawing.Point(12, 260);
            this.miejscaZerowe.Name = "miejscaZerowe";
            this.miejscaZerowe.Size = new System.Drawing.Size(0, 13);
            this.miejscaZerowe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 385);
            this.Controls.Add(this.miejscaZerowe);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Miejsce zerowe funkcji";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_podaj_a;
        private System.Windows.Forms.Label label_podaj_a;
        private System.Windows.Forms.TextBox text_podaj_c;
        private System.Windows.Forms.Label label_podaj_c;
        private System.Windows.Forms.TextBox text_podaj_b;
        private System.Windows.Forms.Label label_podaj_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button oblicz;
        private System.Windows.Forms.Label miejscaZerowe;
    }
}

