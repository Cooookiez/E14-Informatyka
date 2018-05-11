namespace _005_checkbox
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
            this.checkBox_odp_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_odp_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_odp_3 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_kobieta = new System.Windows.Forms.RadioButton();
            this.radioButton_mezcyzna = new System.Windows.Forms.RadioButton();
            this.button_sprawdz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_odp_3);
            this.groupBox1.Controls.Add(this.checkBox_odp_2);
            this.groupBox1.Controls.Add(this.checkBox_odp_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz kilka";
            // 
            // checkBox_odp_1
            // 
            this.checkBox_odp_1.AutoSize = true;
            this.checkBox_odp_1.Checked = true;
            this.checkBox_odp_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_odp_1.Location = new System.Drawing.Point(6, 19);
            this.checkBox_odp_1.Name = "checkBox_odp_1";
            this.checkBox_odp_1.Size = new System.Drawing.Size(53, 17);
            this.checkBox_odp_1.TabIndex = 1;
            this.checkBox_odp_1.Text = "odp 1";
            this.checkBox_odp_1.UseVisualStyleBackColor = true;
            // 
            // checkBox_odp_2
            // 
            this.checkBox_odp_2.AutoSize = true;
            this.checkBox_odp_2.Location = new System.Drawing.Point(6, 43);
            this.checkBox_odp_2.Name = "checkBox_odp_2";
            this.checkBox_odp_2.Size = new System.Drawing.Size(53, 17);
            this.checkBox_odp_2.TabIndex = 2;
            this.checkBox_odp_2.Text = "odp 2";
            this.checkBox_odp_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_odp_3
            // 
            this.checkBox_odp_3.AutoSize = true;
            this.checkBox_odp_3.Location = new System.Drawing.Point(6, 67);
            this.checkBox_odp_3.Name = "checkBox_odp_3";
            this.checkBox_odp_3.Size = new System.Drawing.Size(53, 17);
            this.checkBox_odp_3.TabIndex = 3;
            this.checkBox_odp_3.Text = "odp 3";
            this.checkBox_odp_3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_kobieta);
            this.groupBox2.Controls.Add(this.radioButton_mezcyzna);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Płeć";
            // 
            // radioButton_kobieta
            // 
            this.radioButton_kobieta.AutoSize = true;
            this.radioButton_kobieta.Location = new System.Drawing.Point(160, 19);
            this.radioButton_kobieta.Name = "radioButton_kobieta";
            this.radioButton_kobieta.Size = new System.Drawing.Size(61, 17);
            this.radioButton_kobieta.TabIndex = 7;
            this.radioButton_kobieta.Text = "Kobieta";
            this.radioButton_kobieta.UseVisualStyleBackColor = true;
            // 
            // radioButton_mezcyzna
            // 
            this.radioButton_mezcyzna.AutoSize = true;
            this.radioButton_mezcyzna.Checked = true;
            this.radioButton_mezcyzna.Location = new System.Drawing.Point(76, 19);
            this.radioButton_mezcyzna.Name = "radioButton_mezcyzna";
            this.radioButton_mezcyzna.Size = new System.Drawing.Size(78, 17);
            this.radioButton_mezcyzna.TabIndex = 6;
            this.radioButton_mezcyzna.TabStop = true;
            this.radioButton_mezcyzna.Text = "Męszcyzna";
            this.radioButton_mezcyzna.UseVisualStyleBackColor = true;
            // 
            // button_sprawdz
            // 
            this.button_sprawdz.Location = new System.Drawing.Point(12, 162);
            this.button_sprawdz.Name = "button_sprawdz";
            this.button_sprawdz.Size = new System.Drawing.Size(300, 23);
            this.button_sprawdz.TabIndex = 2;
            this.button_sprawdz.Text = "Sprawdź";
            this.button_sprawdz.UseVisualStyleBackColor = true;
            this.button_sprawdz.Click += new System.EventHandler(this.button_sprawdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 198);
            this.Controls.Add(this.button_sprawdz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(340, 237);
            this.MinimumSize = new System.Drawing.Size(340, 237);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_odp_3;
        private System.Windows.Forms.CheckBox checkBox_odp_2;
        private System.Windows.Forms.CheckBox checkBox_odp_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_kobieta;
        private System.Windows.Forms.RadioButton radioButton_mezcyzna;
        private System.Windows.Forms.Button button_sprawdz;
    }
}

