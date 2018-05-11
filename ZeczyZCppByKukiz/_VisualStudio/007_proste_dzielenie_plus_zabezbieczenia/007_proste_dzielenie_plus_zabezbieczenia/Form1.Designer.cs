namespace _007_proste_dzielenie_plus_zabezbieczenia
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
            this.button_oblicz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dzielenie_przez_co = new System.Windows.Forms.TextBox();
            this.textBox_dzielenie_co = new System.Windows.Forms.TextBox();
            this.checkBox_pokaz_exit = new System.Windows.Forms.CheckBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_wynik = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_wynik);
            this.groupBox1.Controls.Add(this.button_oblicz);
            this.groupBox1.Controls.Add(this.wynik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_dzielenie_przez_co);
            this.groupBox1.Controls.Add(this.textBox_dzielenie_co);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_oblicz
            // 
            this.button_oblicz.Location = new System.Drawing.Point(6, 46);
            this.button_oblicz.Name = "button_oblicz";
            this.button_oblicz.Size = new System.Drawing.Size(182, 23);
            this.button_oblicz.TabIndex = 5;
            this.button_oblicz.Text = "Oblicz";
            this.button_oblicz.UseVisualStyleBackColor = true;
            this.button_oblicz.Click += new System.EventHandler(this.button_oblicz_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Location = new System.Drawing.Point(156, 26);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(0, 13);
            this.wynik.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // textBox_dzielenie_przez_co
            // 
            this.textBox_dzielenie_przez_co.Location = new System.Drawing.Point(80, 20);
            this.textBox_dzielenie_przez_co.Name = "textBox_dzielenie_przez_co";
            this.textBox_dzielenie_przez_co.Size = new System.Drawing.Size(49, 20);
            this.textBox_dzielenie_przez_co.TabIndex = 1;
            this.textBox_dzielenie_przez_co.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_dzielenie_co
            // 
            this.textBox_dzielenie_co.Location = new System.Drawing.Point(7, 20);
            this.textBox_dzielenie_co.Name = "textBox_dzielenie_co";
            this.textBox_dzielenie_co.Size = new System.Drawing.Size(49, 20);
            this.textBox_dzielenie_co.TabIndex = 0;
            this.textBox_dzielenie_co.TextChanged += new System.EventHandler(this.textBox_dzielenie_co_TextChanged);
            // 
            // checkBox_pokaz_exit
            // 
            this.checkBox_pokaz_exit.AutoSize = true;
            this.checkBox_pokaz_exit.Location = new System.Drawing.Point(97, 203);
            this.checkBox_pokaz_exit.Name = "checkBox_pokaz_exit";
            this.checkBox_pokaz_exit.Size = new System.Drawing.Size(110, 17);
            this.checkBox_pokaz_exit.TabIndex = 1;
            this.checkBox_pokaz_exit.Text = "Odblokuj \"Wyjdź\"";
            this.checkBox_pokaz_exit.UseVisualStyleBackColor = true;
            this.checkBox_pokaz_exit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_exit
            // 
            this.button_exit.Enabled = false;
            this.button_exit.Location = new System.Drawing.Point(97, 226);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(110, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Wyjdź";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Location = new System.Drawing.Point(154, 23);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(35, 13);
            this.label_wynik.TabIndex = 6;
            this.label_wynik.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.checkBox_pokaz_exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dzielenie_przez_co;
        private System.Windows.Forms.TextBox textBox_dzielenie_co;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_oblicz;
        private System.Windows.Forms.CheckBox checkBox_pokaz_exit;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_wynik;
    }
}

