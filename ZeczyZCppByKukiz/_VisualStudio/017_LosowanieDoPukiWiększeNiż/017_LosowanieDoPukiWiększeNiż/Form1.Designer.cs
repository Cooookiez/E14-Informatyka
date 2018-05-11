namespace _017_LosowanieDoPukiWiększeNiż
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
            this.rtb_losy = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_NPar = new System.Windows.Forms.CheckBox();
            this.cB_Par = new System.Windows.Forms.CheckBox();
            this.numGranica = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGranica)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_losy
            // 
            this.rtb_losy.Location = new System.Drawing.Point(16, 29);
            this.rtb_losy.Name = "rtb_losy";
            this.rtb_losy.Size = new System.Drawing.Size(157, 180);
            this.rtb_losy.TabIndex = 0;
            this.rtb_losy.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Losowanie z przedziału 0 - 1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_NPar);
            this.groupBox1.Controls.Add(this.cB_Par);
            this.groupBox1.Controls.Add(this.numGranica);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia";
            // 
            // cB_NPar
            // 
            this.cB_NPar.AutoSize = true;
            this.cB_NPar.Checked = true;
            this.cB_NPar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_NPar.Location = new System.Drawing.Point(10, 70);
            this.cB_NPar.Name = "cB_NPar";
            this.cB_NPar.Size = new System.Drawing.Size(84, 17);
            this.cB_NPar.TabIndex = 3;
            this.cB_NPar.Text = "Nie parzyste";
            this.cB_NPar.UseVisualStyleBackColor = true;
            // 
            // cB_Par
            // 
            this.cB_Par.AutoSize = true;
            this.cB_Par.Checked = true;
            this.cB_Par.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_Par.Location = new System.Drawing.Point(10, 46);
            this.cB_Par.Name = "cB_Par";
            this.cB_Par.Size = new System.Drawing.Size(66, 17);
            this.cB_Par.TabIndex = 2;
            this.cB_Par.Text = "Parzyste";
            this.cB_Par.UseVisualStyleBackColor = true;
            // 
            // numGranica
            // 
            this.numGranica.Location = new System.Drawing.Point(58, 20);
            this.numGranica.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGranica.Name = "numGranica";
            this.numGranica.Size = new System.Drawing.Size(93, 20);
            this.numGranica.TabIndex = 1;
            this.numGranica.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Granica";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Czyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Losuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_losy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGranica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_losy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cB_Par;
        private System.Windows.Forms.NumericUpDown numGranica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cB_NPar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

