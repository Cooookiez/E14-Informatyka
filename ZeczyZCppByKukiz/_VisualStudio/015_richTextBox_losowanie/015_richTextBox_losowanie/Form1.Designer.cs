namespace _015_richTextBox_losowanie
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
            this.rtb_cout = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUD_od = new System.Windows.Forms.NumericUpDown();
            this.numUD_do = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUD_ile = new System.Windows.Forms.NumericUpDown();
            this.but_start = new System.Windows.Forms.Button();
            this.chB_powtarzaj = new System.Windows.Forms.CheckBox();
            this.chB_sort = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_od)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_do)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_ile)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_cout
            // 
            this.rtb_cout.Location = new System.Drawing.Point(13, 13);
            this.rtb_cout.Name = "rtb_cout";
            this.rtb_cout.Size = new System.Drawing.Size(275, 96);
            this.rtb_cout.TabIndex = 0;
            this.rtb_cout.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUD_do);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUD_od);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "od";
            // 
            // numUD_od
            // 
            this.numUD_od.Location = new System.Drawing.Point(32, 18);
            this.numUD_od.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_od.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUD_od.Name = "numUD_od";
            this.numUD_od.Size = new System.Drawing.Size(91, 20);
            this.numUD_od.TabIndex = 1;
            this.numUD_od.ValueChanged += new System.EventHandler(this.numUD_od_ValueChanged);
            // 
            // numUD_do
            // 
            this.numUD_do.Location = new System.Drawing.Point(156, 18);
            this.numUD_do.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUD_do.Name = "numUD_do";
            this.numUD_do.Size = new System.Drawing.Size(91, 20);
            this.numUD_do.TabIndex = 3;
            this.numUD_do.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_do.ValueChanged += new System.EventHandler(this.numUD_do_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "do";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numUD_ile);
            this.groupBox2.Location = new System.Drawing.Point(13, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ilość";
            // 
            // numUD_ile
            // 
            this.numUD_ile.Location = new System.Drawing.Point(10, 19);
            this.numUD_ile.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUD_ile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_ile.Name = "numUD_ile";
            this.numUD_ile.Size = new System.Drawing.Size(113, 20);
            this.numUD_ile.TabIndex = 2;
            this.numUD_ile.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD_ile.ValueChanged += new System.EventHandler(this.numUD_ile_ValueChanged);
            // 
            // but_start
            // 
            this.but_start.Location = new System.Drawing.Point(154, 179);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(134, 50);
            this.but_start.TabIndex = 3;
            this.but_start.Text = "Start";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // chB_powtarzaj
            // 
            this.chB_powtarzaj.AutoSize = true;
            this.chB_powtarzaj.Checked = true;
            this.chB_powtarzaj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_powtarzaj.Location = new System.Drawing.Point(23, 235);
            this.chB_powtarzaj.Name = "chB_powtarzaj";
            this.chB_powtarzaj.Size = new System.Drawing.Size(72, 17);
            this.chB_powtarzaj.TabIndex = 4;
            this.chB_powtarzaj.Text = "Powtarzaj";
            this.chB_powtarzaj.UseVisualStyleBackColor = true;
            // 
            // chB_sort
            // 
            this.chB_sort.AutoSize = true;
            this.chB_sort.Location = new System.Drawing.Point(101, 235);
            this.chB_sort.Name = "chB_sort";
            this.chB_sort.Size = new System.Drawing.Size(53, 17);
            this.chB_sort.TabIndex = 5;
            this.chB_sort.Text = "Sortuj";
            this.chB_sort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 322);
            this.Controls.Add(this.chB_sort);
            this.Controls.Add(this.chB_powtarzaj);
            this.Controls.Add(this.but_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtb_cout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_od)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_do)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_ile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_cout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUD_do;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUD_od;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numUD_ile;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.CheckBox chB_powtarzaj;
        private System.Windows.Forms.CheckBox chB_sort;
    }
}

