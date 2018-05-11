namespace _010_Mapka_kraju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_panstwa = new System.Windows.Forms.GroupBox();
            this.radioButton_panstwa_usa = new System.Windows.Forms.RadioButton();
            this.radioButton_panstwa_anglia = new System.Windows.Forms.RadioButton();
            this.radioButton_panstwa_francja = new System.Windows.Forms.RadioButton();
            this.radioButton_panstwa_norwegia = new System.Windows.Forms.RadioButton();
            this.radioButton_panstwa_polska = new System.Windows.Forms.RadioButton();
            this.pictureBox_mapa = new System.Windows.Forms.PictureBox();
            this.button1_help = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_panstwa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_panstwa
            // 
            this.groupBox_panstwa.Controls.Add(this.radioButton_panstwa_usa);
            this.groupBox_panstwa.Controls.Add(this.radioButton_panstwa_anglia);
            this.groupBox_panstwa.Controls.Add(this.radioButton_panstwa_francja);
            this.groupBox_panstwa.Controls.Add(this.radioButton_panstwa_norwegia);
            this.groupBox_panstwa.Controls.Add(this.radioButton_panstwa_polska);
            this.groupBox_panstwa.Location = new System.Drawing.Point(12, 12);
            this.groupBox_panstwa.Name = "groupBox_panstwa";
            this.groupBox_panstwa.Size = new System.Drawing.Size(85, 144);
            this.groupBox_panstwa.TabIndex = 0;
            this.groupBox_panstwa.TabStop = false;
            this.groupBox_panstwa.Enter += new System.EventHandler(this.groupBox_panstwa_Enter);
            // 
            // radioButton_panstwa_usa
            // 
            this.radioButton_panstwa_usa.AutoSize = true;
            this.radioButton_panstwa_usa.Location = new System.Drawing.Point(7, 112);
            this.radioButton_panstwa_usa.Name = "radioButton_panstwa_usa";
            this.radioButton_panstwa_usa.Size = new System.Drawing.Size(56, 17);
            this.radioButton_panstwa_usa.TabIndex = 4;
            this.radioButton_panstwa_usa.TabStop = true;
            this.radioButton_panstwa_usa.Text = "U.S.A.";
            this.radioButton_panstwa_usa.UseVisualStyleBackColor = true;
            this.radioButton_panstwa_usa.CheckedChanged += new System.EventHandler(this.radioButton_panstwa_usa_CheckedChanged);
            // 
            // radioButton_panstwa_anglia
            // 
            this.radioButton_panstwa_anglia.AutoSize = true;
            this.radioButton_panstwa_anglia.Location = new System.Drawing.Point(7, 89);
            this.radioButton_panstwa_anglia.Name = "radioButton_panstwa_anglia";
            this.radioButton_panstwa_anglia.Size = new System.Drawing.Size(54, 17);
            this.radioButton_panstwa_anglia.TabIndex = 3;
            this.radioButton_panstwa_anglia.TabStop = true;
            this.radioButton_panstwa_anglia.Text = "Anglia";
            this.radioButton_panstwa_anglia.UseVisualStyleBackColor = true;
            this.radioButton_panstwa_anglia.CheckedChanged += new System.EventHandler(this.radioButton_panstwa_anglia_CheckedChanged);
            // 
            // radioButton_panstwa_francja
            // 
            this.radioButton_panstwa_francja.AutoSize = true;
            this.radioButton_panstwa_francja.Location = new System.Drawing.Point(7, 66);
            this.radioButton_panstwa_francja.Name = "radioButton_panstwa_francja";
            this.radioButton_panstwa_francja.Size = new System.Drawing.Size(60, 17);
            this.radioButton_panstwa_francja.TabIndex = 2;
            this.radioButton_panstwa_francja.TabStop = true;
            this.radioButton_panstwa_francja.Text = "Francja";
            this.radioButton_panstwa_francja.UseVisualStyleBackColor = true;
            this.radioButton_panstwa_francja.CheckedChanged += new System.EventHandler(this.radioButton_panstwa_francja_CheckedChanged);
            // 
            // radioButton_panstwa_norwegia
            // 
            this.radioButton_panstwa_norwegia.AutoSize = true;
            this.radioButton_panstwa_norwegia.Location = new System.Drawing.Point(7, 43);
            this.radioButton_panstwa_norwegia.Name = "radioButton_panstwa_norwegia";
            this.radioButton_panstwa_norwegia.Size = new System.Drawing.Size(70, 17);
            this.radioButton_panstwa_norwegia.TabIndex = 1;
            this.radioButton_panstwa_norwegia.TabStop = true;
            this.radioButton_panstwa_norwegia.Text = "Norwegia";
            this.radioButton_panstwa_norwegia.UseVisualStyleBackColor = true;
            this.radioButton_panstwa_norwegia.CheckedChanged += new System.EventHandler(this.radioButton_panstwa_norwegia_CheckedChanged);
            // 
            // radioButton_panstwa_polska
            // 
            this.radioButton_panstwa_polska.AutoSize = true;
            this.radioButton_panstwa_polska.Location = new System.Drawing.Point(7, 20);
            this.radioButton_panstwa_polska.Name = "radioButton_panstwa_polska";
            this.radioButton_panstwa_polska.Size = new System.Drawing.Size(57, 17);
            this.radioButton_panstwa_polska.TabIndex = 0;
            this.radioButton_panstwa_polska.TabStop = true;
            this.radioButton_panstwa_polska.Text = "Polska";
            this.radioButton_panstwa_polska.UseVisualStyleBackColor = true;
            this.radioButton_panstwa_polska.CheckedChanged += new System.EventHandler(this.radioButton_panstwa_polska_CheckedChanged);
            // 
            // pictureBox_mapa
            // 
            this.pictureBox_mapa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_mapa.Image")));
            this.pictureBox_mapa.Location = new System.Drawing.Point(103, 12);
            this.pictureBox_mapa.Name = "pictureBox_mapa";
            this.pictureBox_mapa.Size = new System.Drawing.Size(335, 304);
            this.pictureBox_mapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_mapa.TabIndex = 1;
            this.pictureBox_mapa.TabStop = false;
            // 
            // button1_help
            // 
            this.button1_help.Location = new System.Drawing.Point(12, 163);
            this.button1_help.Name = "button1_help";
            this.button1_help.Size = new System.Drawing.Size(85, 23);
            this.button1_help.TabIndex = 2;
            this.button1_help.Text = "?";
            this.button1_help.UseVisualStyleBackColor = true;
            this.button1_help.Click += new System.EventHandler(this.button1_help_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 292);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 23);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 335);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button1_help);
            this.Controls.Add(this.pictureBox_mapa);
            this.Controls.Add(this.groupBox_panstwa);
            this.Name = "Form1";
            this.Text = "Państwa";
            this.groupBox_panstwa.ResumeLayout(false);
            this.groupBox_panstwa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_panstwa;
        private System.Windows.Forms.RadioButton radioButton_panstwa_usa;
        private System.Windows.Forms.RadioButton radioButton_panstwa_anglia;
        private System.Windows.Forms.RadioButton radioButton_panstwa_francja;
        private System.Windows.Forms.RadioButton radioButton_panstwa_norwegia;
        private System.Windows.Forms.RadioButton radioButton_panstwa_polska;
        private System.Windows.Forms.PictureBox pictureBox_mapa;
        private System.Windows.Forms.Button button1_help;
        private System.Windows.Forms.Button button_exit;
    }
}

