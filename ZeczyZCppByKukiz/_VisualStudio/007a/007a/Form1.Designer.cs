namespace _007a
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_co = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_przez_co = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_wynik = new System.Windows.Forms.Label();
            this.button_oblicz = new System.Windows.Forms.Button();
            this.checkBox_odblokuj_exit = new System.Windows.Forms.CheckBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_oblicz);
            this.groupBox1.Controls.Add(this.label_wynik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_przez_co);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_co);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox_co
            // 
            resources.ApplyResources(this.textBox_co, "textBox_co");
            this.textBox_co.Name = "textBox_co";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_przez_co
            // 
            resources.ApplyResources(this.textBox_przez_co, "textBox_przez_co");
            this.textBox_przez_co.Name = "textBox_przez_co";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label_wynik
            // 
            resources.ApplyResources(this.label_wynik, "label_wynik");
            this.label_wynik.Name = "label_wynik";
            // 
            // button_oblicz
            // 
            this.button_oblicz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_oblicz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button_oblicz, "button_oblicz");
            this.button_oblicz.Name = "button_oblicz";
            this.button_oblicz.UseVisualStyleBackColor = true;
            this.button_oblicz.Click += new System.EventHandler(this.button_oblicz_Click);
            // 
            // checkBox_odblokuj_exit
            // 
            resources.ApplyResources(this.checkBox_odblokuj_exit, "checkBox_odblokuj_exit");
            this.checkBox_odblokuj_exit.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_odblokuj_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_odblokuj_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_odblokuj_exit.Name = "checkBox_odblokuj_exit";
            this.checkBox_odblokuj_exit.UseVisualStyleBackColor = false;
            this.checkBox_odblokuj_exit.CheckedChanged += new System.EventHandler(this.checkBox_odblokuj_exit_CheckedChanged);
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.Name = "button_exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_007a.Properties.Resources._bez_znaku_wodnego__jigoku_shoujo_art_wallpaper_1920x1080;
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.checkBox_odblokuj_exit);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_co;
        private System.Windows.Forms.Button button_oblicz;
        private System.Windows.Forms.Label label_wynik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_przez_co;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_odblokuj_exit;
        private System.Windows.Forms.Button button_exit;
    }
}

