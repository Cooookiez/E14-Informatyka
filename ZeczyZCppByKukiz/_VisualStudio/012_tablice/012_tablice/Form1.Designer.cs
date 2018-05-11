namespace _012_tablice
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
            this.textBox_liczba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_liczba = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.button_avg = new System.Windows.Forms.Button();
            this.button_sum = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_max = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_liczba
            // 
            this.textBox_liczba.Location = new System.Drawing.Point(91, 69);
            this.textBox_liczba.Name = "textBox_liczba";
            this.textBox_liczba.Size = new System.Drawing.Size(100, 20);
            this.textBox_liczba.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba nr:";
            // 
            // label_liczba
            // 
            this.label_liczba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_liczba.Location = new System.Drawing.Point(142, 35);
            this.label_liczba.Name = "label_liczba";
            this.label_liczba.Size = new System.Drawing.Size(49, 31);
            this.label_liczba.TabIndex = 2;
            this.label_liczba.Text = "0";
            this.label_liczba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(197, 69);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(20, 20);
            this.button_next.TabIndex = 4;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.Enabled = false;
            this.button_prev.Location = new System.Drawing.Point(65, 69);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(20, 20);
            this.button_prev.TabIndex = 4;
            this.button_prev.Text = "<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(65, 96);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(152, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Zapamiętaj";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(65, 146);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(149, 23);
            this.button_show.TabIndex = 7;
            this.button_show.Text = "Poka zwszystko";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_avg
            // 
            this.button_avg.Location = new System.Drawing.Point(142, 175);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(72, 23);
            this.button_avg.TabIndex = 9;
            this.button_avg.Text = "Średnia";
            this.button_avg.UseVisualStyleBackColor = true;
            this.button_avg.Click += new System.EventHandler(this.button_avg_Click);
            // 
            // button_sum
            // 
            this.button_sum.Location = new System.Drawing.Point(65, 175);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(72, 23);
            this.button_sum.TabIndex = 10;
            this.button_sum.Text = "Suma";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(65, 204);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(72, 23);
            this.button_min.TabIndex = 12;
            this.button_min.Text = "Min";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(142, 204);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(72, 23);
            this.button_max.TabIndex = 11;
            this.button_max.Text = "Max";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 281);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_liczba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_liczba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_liczba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_liczba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_avg;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_max;
    }
}

