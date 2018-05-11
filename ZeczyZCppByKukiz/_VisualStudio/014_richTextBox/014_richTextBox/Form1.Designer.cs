namespace _014_richTextBox
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
            this.rtb_box = new System.Windows.Forms.RichTextBox();
            this.bt_koniec = new System.Windows.Forms.Button();
            this.bt_czysc = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_box
            // 
            this.rtb_box.Location = new System.Drawing.Point(12, 12);
            this.rtb_box.Name = "rtb_box";
            this.rtb_box.Size = new System.Drawing.Size(179, 237);
            this.rtb_box.TabIndex = 0;
            this.rtb_box.Text = "";
            // 
            // bt_koniec
            // 
            this.bt_koniec.Location = new System.Drawing.Point(197, 226);
            this.bt_koniec.Name = "bt_koniec";
            this.bt_koniec.Size = new System.Drawing.Size(75, 23);
            this.bt_koniec.TabIndex = 1;
            this.bt_koniec.Text = "Koniec";
            this.bt_koniec.UseVisualStyleBackColor = true;
            this.bt_koniec.Click += new System.EventHandler(this.bt_koniec_Click);
            // 
            // bt_czysc
            // 
            this.bt_czysc.Location = new System.Drawing.Point(197, 197);
            this.bt_czysc.Name = "bt_czysc";
            this.bt_czysc.Size = new System.Drawing.Size(75, 23);
            this.bt_czysc.TabIndex = 2;
            this.bt_czysc.Text = "Czyść";
            this.bt_czysc.UseVisualStyleBackColor = true;
            this.bt_czysc.Click += new System.EventHandler(this.bt_czysc_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(197, 168);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_czysc);
            this.Controls.Add(this.bt_koniec);
            this.Controls.Add(this.rtb_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_box;
        private System.Windows.Forms.Button bt_koniec;
        private System.Windows.Forms.Button bt_czysc;
        private System.Windows.Forms.Button bt_start;
    }
}

