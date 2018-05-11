namespace spr_na_6
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
            this.rtb_consola = new System.Windows.Forms.RichTextBox();
            this.btt_losuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nUD_pokazDo = new System.Windows.Forms.NumericUpDown();
            this.btt_sprawdz = new System.Windows.Forms.Button();
            this.btt_clear = new System.Windows.Forms.Button();
            this.cB_tylkoParzyste = new System.Windows.Forms.CheckBox();
            this.btt_close = new System.Windows.Forms.Button();
            this.btt_autor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_pokazDo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_sprawdz);
            this.groupBox1.Controls.Add(this.nUD_pokazDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btt_losuj);
            this.groupBox1.Controls.Add(this.rtb_consola);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obliczenia";
            // 
            // rtb_consola
            // 
            this.rtb_consola.Location = new System.Drawing.Point(7, 20);
            this.rtb_consola.Name = "rtb_consola";
            this.rtb_consola.Size = new System.Drawing.Size(152, 74);
            this.rtb_consola.TabIndex = 0;
            this.rtb_consola.Text = "";
            // 
            // btt_losuj
            // 
            this.btt_losuj.Location = new System.Drawing.Point(165, 20);
            this.btt_losuj.Name = "btt_losuj";
            this.btt_losuj.Size = new System.Drawing.Size(112, 23);
            this.btt_losuj.TabIndex = 1;
            this.btt_losuj.Text = "Losuj 20";
            this.btt_losuj.UseVisualStyleBackColor = true;
            this.btt_losuj.Click += new System.EventHandler(this.btt_losuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pokaż do";
            // 
            // nUD_pokazDo
            // 
            this.nUD_pokazDo.Location = new System.Drawing.Point(214, 45);
            this.nUD_pokazDo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nUD_pokazDo.Name = "nUD_pokazDo";
            this.nUD_pokazDo.Size = new System.Drawing.Size(61, 20);
            this.nUD_pokazDo.TabIndex = 3;
            this.nUD_pokazDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_pokazDo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btt_sprawdz
            // 
            this.btt_sprawdz.Location = new System.Drawing.Point(166, 71);
            this.btt_sprawdz.Name = "btt_sprawdz";
            this.btt_sprawdz.Size = new System.Drawing.Size(109, 23);
            this.btt_sprawdz.TabIndex = 4;
            this.btt_sprawdz.Text = "Sprawdź";
            this.btt_sprawdz.UseVisualStyleBackColor = true;
            this.btt_sprawdz.Click += new System.EventHandler(this.btt_sprawdz_Click);
            // 
            // btt_clear
            // 
            this.btt_clear.Location = new System.Drawing.Point(20, 117);
            this.btt_clear.Name = "btt_clear";
            this.btt_clear.Size = new System.Drawing.Size(75, 23);
            this.btt_clear.TabIndex = 1;
            this.btt_clear.Text = "Czyść";
            this.btt_clear.UseVisualStyleBackColor = true;
            this.btt_clear.Click += new System.EventHandler(this.btt_clear_Click);
            // 
            // cB_tylkoParzyste
            // 
            this.cB_tylkoParzyste.AutoSize = true;
            this.cB_tylkoParzyste.Checked = true;
            this.cB_tylkoParzyste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_tylkoParzyste.Location = new System.Drawing.Point(195, 117);
            this.cB_tylkoParzyste.Name = "cB_tylkoParzyste";
            this.cB_tylkoParzyste.Size = new System.Drawing.Size(92, 17);
            this.cB_tylkoParzyste.TabIndex = 2;
            this.cB_tylkoParzyste.Text = "Tyko parzyste";
            this.cB_tylkoParzyste.UseVisualStyleBackColor = true;
            // 
            // btt_close
            // 
            this.btt_close.Location = new System.Drawing.Point(211, 150);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 23);
            this.btt_close.TabIndex = 3;
            this.btt_close.Text = "Zamknij";
            this.btt_close.UseVisualStyleBackColor = true;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // btt_autor
            // 
            this.btt_autor.Location = new System.Drawing.Point(20, 149);
            this.btt_autor.Name = "btt_autor";
            this.btt_autor.Size = new System.Drawing.Size(23, 23);
            this.btt_autor.TabIndex = 4;
            this.btt_autor.Text = "?";
            this.btt_autor.UseVisualStyleBackColor = true;
            this.btt_autor.Click += new System.EventHandler(this.btt_autor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 178);
            this.ControlBox = false;
            this.Controls.Add(this.btt_autor);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.cB_tylkoParzyste);
            this.Controls.Add(this.btt_clear);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Konsola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_pokazDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_losuj;
        private System.Windows.Forms.RichTextBox rtb_consola;
        private System.Windows.Forms.Button btt_sprawdz;
        private System.Windows.Forms.NumericUpDown nUD_pokazDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_clear;
        private System.Windows.Forms.CheckBox cB_tylkoParzyste;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_autor;
    }
}

