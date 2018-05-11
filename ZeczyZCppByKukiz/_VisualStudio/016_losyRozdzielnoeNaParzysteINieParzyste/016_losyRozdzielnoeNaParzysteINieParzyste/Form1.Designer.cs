namespace _016_losyRozdzielnoeNaParzysteINieParzyste
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
            this.rtb_parzyste = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_nieParzyste = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_czyscPar = new System.Windows.Forms.Button();
            this.btt_czyscNPar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_ParCount = new System.Windows.Forms.Label();
            this.lb_NParCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_parzyste
            // 
            this.rtb_parzyste.Location = new System.Drawing.Point(15, 25);
            this.rtb_parzyste.Name = "rtb_parzyste";
            this.rtb_parzyste.Size = new System.Drawing.Size(180, 100);
            this.rtb_parzyste.TabIndex = 0;
            this.rtb_parzyste.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parzyste";
            // 
            // rtb_nieParzyste
            // 
            this.rtb_nieParzyste.Location = new System.Drawing.Point(203, 25);
            this.rtb_nieParzyste.Name = "rtb_nieParzyste";
            this.rtb_nieParzyste.Size = new System.Drawing.Size(180, 100);
            this.rtb_nieParzyste.TabIndex = 2;
            this.rtb_nieParzyste.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nie parzyste";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btt_czyscPar
            // 
            this.btt_czyscPar.Location = new System.Drawing.Point(15, 132);
            this.btt_czyscPar.Name = "btt_czyscPar";
            this.btt_czyscPar.Size = new System.Drawing.Size(179, 23);
            this.btt_czyscPar.TabIndex = 4;
            this.btt_czyscPar.Text = "Czyść parzyste";
            this.btt_czyscPar.UseVisualStyleBackColor = true;
            this.btt_czyscPar.Click += new System.EventHandler(this.btt_czyscPar_Click);
            // 
            // btt_czyscNPar
            // 
            this.btt_czyscNPar.Location = new System.Drawing.Point(200, 131);
            this.btt_czyscNPar.Name = "btt_czyscNPar";
            this.btt_czyscNPar.Size = new System.Drawing.Size(183, 23);
            this.btt_czyscNPar.TabIndex = 5;
            this.btt_czyscNPar.Text = "Czyść nie parzyste";
            this.btt_czyscNPar.UseVisualStyleBackColor = true;
            this.btt_czyscNPar.Click += new System.EventHandler(this.btt_czyscNPar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Losuj 20 liczb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_ParCount
            // 
            this.lb_ParCount.AutoSize = true;
            this.lb_ParCount.Location = new System.Drawing.Point(65, 9);
            this.lb_ParCount.Name = "lb_ParCount";
            this.lb_ParCount.Size = new System.Drawing.Size(19, 13);
            this.lb_ParCount.TabIndex = 7;
            this.lb_ParCount.Text = "(0)";
            // 
            // lb_NParCount
            // 
            this.lb_NParCount.AutoSize = true;
            this.lb_NParCount.Location = new System.Drawing.Point(272, 9);
            this.lb_NParCount.Name = "lb_NParCount";
            this.lb_NParCount.Size = new System.Drawing.Size(19, 13);
            this.lb_NParCount.TabIndex = 8;
            this.lb_NParCount.Text = "(0)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 228);
            this.Controls.Add(this.lb_NParCount);
            this.Controls.Add(this.lb_ParCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btt_czyscNPar);
            this.Controls.Add(this.btt_czyscPar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_nieParzyste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_parzyste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_parzyste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_nieParzyste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_czyscPar;
        private System.Windows.Forms.Button btt_czyscNPar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_ParCount;
        private System.Windows.Forms.Label lb_NParCount;
    }
}

