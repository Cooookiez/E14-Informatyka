namespace _003_czyIntCzyString
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
            this.podajText = new System.Windows.Forms.Label();
            this.podajLiczbe = new System.Windows.Forms.Label();
            this.jakisText = new System.Windows.Forms.TextBox();
            this.jakasLiczba = new System.Windows.Forms.TextBox();
            this.pokazText = new System.Windows.Forms.Button();
            this.razyTrzy = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // podajText
            // 
            this.podajText.AutoSize = true;
            this.podajText.Location = new System.Drawing.Point(12, 9);
            this.podajText.Name = "podajText";
            this.podajText.Size = new System.Drawing.Size(78, 13);
            this.podajText.TabIndex = 0;
            this.podajText.Text = "Podaj jakiś text";
            // 
            // podajLiczbe
            // 
            this.podajLiczbe.AutoSize = true;
            this.podajLiczbe.Location = new System.Drawing.Point(12, 97);
            this.podajLiczbe.Name = "podajLiczbe";
            this.podajLiczbe.Size = new System.Drawing.Size(92, 13);
            this.podajLiczbe.TabIndex = 1;
            this.podajLiczbe.Text = "Podaj jakąś liczbe";
            // 
            // jakisText
            // 
            this.jakisText.Location = new System.Drawing.Point(15, 25);
            this.jakisText.Name = "jakisText";
            this.jakisText.Size = new System.Drawing.Size(100, 20);
            this.jakisText.TabIndex = 2;
            // 
            // jakasLiczba
            // 
            this.jakasLiczba.Location = new System.Drawing.Point(15, 113);
            this.jakasLiczba.Name = "jakasLiczba";
            this.jakasLiczba.Size = new System.Drawing.Size(100, 20);
            this.jakasLiczba.TabIndex = 3;
            // 
            // pokazText
            // 
            this.pokazText.Location = new System.Drawing.Point(15, 51);
            this.pokazText.Name = "pokazText";
            this.pokazText.Size = new System.Drawing.Size(100, 23);
            this.pokazText.TabIndex = 4;
            this.pokazText.Text = "Pokaż text";
            this.pokazText.UseVisualStyleBackColor = true;
            this.pokazText.Click += new System.EventHandler(this.pokazText_Click);
            // 
            // razyTrzy
            // 
            this.razyTrzy.Location = new System.Drawing.Point(15, 139);
            this.razyTrzy.Name = "razyTrzy";
            this.razyTrzy.Size = new System.Drawing.Size(100, 23);
            this.razyTrzy.TabIndex = 5;
            this.razyTrzy.Text = "x3";
            this.razyTrzy.UseVisualStyleBackColor = true;
            this.razyTrzy.Click += new System.EventHandler(this.razyTrzy_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(15, 188);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 23);
            this.Close.TabIndex = 6;
            this.Close.Text = "Wyjdź";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 223);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.razyTrzy);
            this.Controls.Add(this.pokazText);
            this.Controls.Add(this.jakasLiczba);
            this.Controls.Add(this.jakisText);
            this.Controls.Add(this.podajLiczbe);
            this.Controls.Add(this.podajText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(144, 262);
            this.MinimumSize = new System.Drawing.Size(144, 262);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label podajText;
        private System.Windows.Forms.Label podajLiczbe;
        private System.Windows.Forms.TextBox jakisText;
        private System.Windows.Forms.TextBox jakasLiczba;
        private System.Windows.Forms.Button pokazText;
        private System.Windows.Forms.Button razyTrzy;
        private new System.Windows.Forms.Button Close;
    }
}

