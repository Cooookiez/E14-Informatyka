namespace _013_LosowanieLiczb
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
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_od = new System.Windows.Forms.NumericUpDown();
            this.numeric_do = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeric_ile = new System.Windows.Forms.NumericUpDown();
            this.button_losuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_od)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_do)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numeric_do);
            this.groupBox1.Controls.Add(this.numeric_od);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przedział";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do";
            // 
            // numeric_od
            // 
            this.numeric_od.Location = new System.Drawing.Point(10, 36);
            this.numeric_od.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_od.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numeric_od.Name = "numeric_od";
            this.numeric_od.Size = new System.Drawing.Size(85, 20);
            this.numeric_od.TabIndex = 2;
            this.numeric_od.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // numeric_do
            // 
            this.numeric_do.Location = new System.Drawing.Point(107, 36);
            this.numeric_do.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_do.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numeric_do.Name = "numeric_do";
            this.numeric_do.Size = new System.Drawing.Size(85, 20);
            this.numeric_do.TabIndex = 3;
            this.numeric_do.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numeric_ile);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ilość";
            // 
            // numeric_ile
            // 
            this.numeric_ile.Location = new System.Drawing.Point(7, 20);
            this.numeric_ile.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_ile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_ile.Name = "numeric_ile";
            this.numeric_ile.Size = new System.Drawing.Size(87, 20);
            this.numeric_ile.TabIndex = 0;
            this.numeric_ile.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_losuj
            // 
            this.button_losuj.Location = new System.Drawing.Point(123, 94);
            this.button_losuj.Name = "button_losuj";
            this.button_losuj.Size = new System.Drawing.Size(92, 46);
            this.button_losuj.TabIndex = 2;
            this.button_losuj.Text = "Losuj";
            this.button_losuj.UseVisualStyleBackColor = true;
            this.button_losuj.Click += new System.EventHandler(this.button_losuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 155);
            this.Controls.Add(this.button_losuj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_od)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_do)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numeric_do;
        private System.Windows.Forms.NumericUpDown numeric_od;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numeric_ile;
        private System.Windows.Forms.Button button_losuj;
    }
}

