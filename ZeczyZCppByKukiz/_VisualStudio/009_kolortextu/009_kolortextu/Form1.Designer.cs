namespace _009_kolortextu
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
            this.label_szkola = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.radioButton_yellow = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_szkola
            // 
            this.label_szkola.AutoSize = true;
            this.label_szkola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_szkola.ForeColor = System.Drawing.Color.Red;
            this.label_szkola.Location = new System.Drawing.Point(12, 9);
            this.label_szkola.Name = "label_szkola";
            this.label_szkola.Size = new System.Drawing.Size(246, 31);
            this.label_szkola.TabIndex = 0;
            this.label_szkola.Text = "Zespół Szkół ne 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_yellow);
            this.groupBox1.Controls.Add(this.radioButton_blue);
            this.groupBox1.Controls.Add(this.radioButton_green);
            this.groupBox1.Controls.Add(this.radioButton_red);
            this.groupBox1.Location = new System.Drawing.Point(18, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Checked = true;
            this.radioButton_red.ForeColor = System.Drawing.Color.Red;
            this.radioButton_red.Location = new System.Drawing.Point(7, 20);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(71, 17);
            this.radioButton_red.TabIndex = 0;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "Czerwony";
            this.radioButton_red.UseVisualStyleBackColor = true;
            this.radioButton_red.CheckedChanged += new System.EventHandler(this.radioButton_red_CheckedChanged);
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.ForeColor = System.Drawing.Color.Green;
            this.radioButton_green.Location = new System.Drawing.Point(7, 44);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(59, 17);
            this.radioButton_green.TabIndex = 1;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "Zielony";
            this.radioButton_green.UseVisualStyleBackColor = true;
            this.radioButton_green.CheckedChanged += new System.EventHandler(this.radioButton_green_CheckedChanged);
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.ForeColor = System.Drawing.Color.Blue;
            this.radioButton_blue.Location = new System.Drawing.Point(149, 20);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(68, 17);
            this.radioButton_blue.TabIndex = 2;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "Niebieski";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            this.radioButton_blue.CheckedChanged += new System.EventHandler(this.radioButton_blue_CheckedChanged);
            // 
            // radioButton_yellow
            // 
            this.radioButton_yellow.AutoSize = true;
            this.radioButton_yellow.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_yellow.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton_yellow.Location = new System.Drawing.Point(148, 44);
            this.radioButton_yellow.Name = "radioButton_yellow";
            this.radioButton_yellow.Size = new System.Drawing.Size(50, 17);
            this.radioButton_yellow.TabIndex = 3;
            this.radioButton_yellow.Text = "Żółty";
            this.radioButton_yellow.UseVisualStyleBackColor = false;
            this.radioButton_yellow.CheckedChanged += new System.EventHandler(this.radioButton_yellow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_szkola);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_szkola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_yellow;
        private System.Windows.Forms.RadioButton radioButton_blue;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.RadioButton radioButton_red;
    }
}

