namespace _006_odbezbiecz_guzik
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
            this.button_wlacz_zamknij = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_odbezbiecz = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_onoff_exit2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_gura_odbezbieczona = new System.Windows.Forms.CheckBox();
            this.button_exit2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_wlacz_zamknij);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_wlacz_zamknij
            // 
            this.button_wlacz_zamknij.Enabled = false;
            this.button_wlacz_zamknij.Location = new System.Drawing.Point(7, 19);
            this.button_wlacz_zamknij.Name = "button_wlacz_zamknij";
            this.button_wlacz_zamknij.Size = new System.Drawing.Size(187, 37);
            this.button_wlacz_zamknij.TabIndex = 0;
            this.button_wlacz_zamknij.Text = "Włącz guzik \"Wyjdź\"";
            this.button_wlacz_zamknij.UseVisualStyleBackColor = true;
            this.button_wlacz_zamknij.Click += new System.EventHandler(this.button_wlacz_zamknij_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_odbezbiecz);
            this.groupBox2.Location = new System.Drawing.Point(13, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button_odbezbiecz
            // 
            this.button_odbezbiecz.Location = new System.Drawing.Point(7, 19);
            this.button_odbezbiecz.Name = "button_odbezbiecz";
            this.button_odbezbiecz.Size = new System.Drawing.Size(187, 37);
            this.button_odbezbiecz.TabIndex = 0;
            this.button_odbezbiecz.Text = "Odbezbiecz";
            this.button_odbezbiecz.UseVisualStyleBackColor = true;
            this.button_odbezbiecz.Click += new System.EventHandler(this.button_odbezbiecz_Click);
            // 
            // button_exit
            // 
            this.button_exit.Enabled = false;
            this.button_exit.Location = new System.Drawing.Point(20, 149);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(187, 37);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Wyjdź";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_onoff_exit2);
            this.groupBox3.Location = new System.Drawing.Point(220, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // checkBox_onoff_exit2
            // 
            this.checkBox_onoff_exit2.AutoSize = true;
            this.checkBox_onoff_exit2.Enabled = false;
            this.checkBox_onoff_exit2.Location = new System.Drawing.Point(7, 30);
            this.checkBox_onoff_exit2.Name = "checkBox_onoff_exit2";
            this.checkBox_onoff_exit2.Size = new System.Drawing.Size(87, 17);
            this.checkBox_onoff_exit2.TabIndex = 0;
            this.checkBox_onoff_exit2.Text = "Można wyjść";
            this.checkBox_onoff_exit2.UseVisualStyleBackColor = true;
            this.checkBox_onoff_exit2.CheckedChanged += new System.EventHandler(this.checkBox_onoff_exit2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_gura_odbezbieczona);
            this.groupBox4.Location = new System.Drawing.Point(220, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 62);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // checkBox_gura_odbezbieczona
            // 
            this.checkBox_gura_odbezbieczona.AutoSize = true;
            this.checkBox_gura_odbezbieczona.Location = new System.Drawing.Point(7, 30);
            this.checkBox_gura_odbezbieczona.Name = "checkBox_gura_odbezbieczona";
            this.checkBox_gura_odbezbieczona.Size = new System.Drawing.Size(106, 17);
            this.checkBox_gura_odbezbieczona.TabIndex = 0;
            this.checkBox_gura_odbezbieczona.Text = "Odbezbiecz gure";
            this.checkBox_gura_odbezbieczona.UseVisualStyleBackColor = true;
            this.checkBox_gura_odbezbieczona.CheckedChanged += new System.EventHandler(this.checkBox_gura_odbezbieczona_CheckedChanged);
            // 
            // button_exit2
            // 
            this.button_exit2.Enabled = false;
            this.button_exit2.Location = new System.Drawing.Point(227, 149);
            this.button_exit2.Name = "button_exit2";
            this.button_exit2.Size = new System.Drawing.Size(187, 37);
            this.button_exit2.TabIndex = 5;
            this.button_exit2.Text = "Wyjdź";
            this.button_exit2.UseVisualStyleBackColor = true;
            this.button_exit2.Click += new System.EventHandler(this.button_exit2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 203);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_wlacz_zamknij;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_odbezbiecz;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_onoff_exit2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_gura_odbezbieczona;
        private System.Windows.Forms.Button button_exit2;
    }
}

