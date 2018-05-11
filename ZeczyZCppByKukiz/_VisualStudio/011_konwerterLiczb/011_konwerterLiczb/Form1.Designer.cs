namespace _011_konwerterLiczb
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
            this.textBox_multi = new System.Windows.Forms.TextBox();
            this.label_multi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_dec = new System.Windows.Forms.RadioButton();
            this.radioButton_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_oct = new System.Windows.Forms.RadioButton();
            this.radioButton_bin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_multi
            // 
            this.textBox_multi.Location = new System.Drawing.Point(14, 28);
            this.textBox_multi.Name = "textBox_multi";
            this.textBox_multi.Size = new System.Drawing.Size(216, 20);
            this.textBox_multi.TabIndex = 8;
            // 
            // label_multi
            // 
            this.label_multi.AutoSize = true;
            this.label_multi.Location = new System.Drawing.Point(105, 9);
            this.label_multi.Name = "label_multi";
            this.label_multi.Size = new System.Drawing.Size(29, 13);
            this.label_multi.TabIndex = 9;
            this.label_multi.Text = "DEC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_dec);
            this.groupBox1.Controls.Add(this.radioButton_hex);
            this.groupBox1.Controls.Add(this.radioButton_oct);
            this.groupBox1.Controls.Add(this.radioButton_bin);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 45);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_dec
            // 
            this.radioButton_dec.AutoSize = true;
            this.radioButton_dec.Checked = true;
            this.radioButton_dec.Location = new System.Drawing.Point(112, 19);
            this.radioButton_dec.Name = "radioButton_dec";
            this.radioButton_dec.Size = new System.Drawing.Size(47, 17);
            this.radioButton_dec.TabIndex = 3;
            this.radioButton_dec.TabStop = true;
            this.radioButton_dec.Text = "DEC";
            this.radioButton_dec.UseVisualStyleBackColor = true;
            this.radioButton_dec.CheckedChanged += new System.EventHandler(this.radioButton_dec_CheckedChanged);
            // 
            // radioButton_hex
            // 
            this.radioButton_hex.AutoSize = true;
            this.radioButton_hex.Location = new System.Drawing.Point(165, 19);
            this.radioButton_hex.Name = "radioButton_hex";
            this.radioButton_hex.Size = new System.Drawing.Size(47, 17);
            this.radioButton_hex.TabIndex = 2;
            this.radioButton_hex.Text = "HEX";
            this.radioButton_hex.UseVisualStyleBackColor = true;
            this.radioButton_hex.CheckedChanged += new System.EventHandler(this.radioButton_hex_CheckedChanged);
            // 
            // radioButton_oct
            // 
            this.radioButton_oct.AutoSize = true;
            this.radioButton_oct.Location = new System.Drawing.Point(59, 19);
            this.radioButton_oct.Name = "radioButton_oct";
            this.radioButton_oct.Size = new System.Drawing.Size(47, 17);
            this.radioButton_oct.TabIndex = 1;
            this.radioButton_oct.Text = "OCT";
            this.radioButton_oct.UseVisualStyleBackColor = true;
            this.radioButton_oct.CheckedChanged += new System.EventHandler(this.radioButton_oct_CheckedChanged);
            // 
            // radioButton_bin
            // 
            this.radioButton_bin.AutoSize = true;
            this.radioButton_bin.Location = new System.Drawing.Point(6, 19);
            this.radioButton_bin.Name = "radioButton_bin";
            this.radioButton_bin.Size = new System.Drawing.Size(43, 17);
            this.radioButton_bin.TabIndex = 0;
            this.radioButton_bin.Text = "BIN";
            this.radioButton_bin.UseVisualStyleBackColor = true;
            this.radioButton_bin.CheckedChanged += new System.EventHandler(this.radioButton_bin_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 121);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_multi);
            this.Controls.Add(this.textBox_multi);
            this.Name = "Form1";
            this.Text = "Konwerter liczb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_multi;
        private System.Windows.Forms.Label label_multi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_dec;
        private System.Windows.Forms.RadioButton radioButton_hex;
        private System.Windows.Forms.RadioButton radioButton_oct;
        private System.Windows.Forms.RadioButton radioButton_bin;
    }
}

