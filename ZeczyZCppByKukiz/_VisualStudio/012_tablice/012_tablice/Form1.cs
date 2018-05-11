using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_tablice
{
    public partial class Form1 : Form
    {

        public int max_length = 9;
        public int min_length = 0;
        public float[] numbers = new float[10];

        public Form1()
        {
            InitializeComponent();
        }

        public int getIndex()
        {
            string s_n = label_liczba.Text;
            int i_n = int.Parse(s_n);
            return i_n;
        }

        public void showNumber(int index = 0)
        {
            textBox_liczba.Text = numbers[index].ToString();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            int index = getIndex() + 1;
            if (index > max_length) index = max_length;
            if(index >= max_length) button_next.Enabled = false;
            button_prev.Enabled = true;
            showNumber(index);
            label_liczba.Text = index.ToString();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            int index = getIndex() - 1;
            if (index < min_length) index = min_length;
            if (index <= min_length) button_prev.Enabled = false;
            button_next.Enabled = true;
            showNumber(index);
            label_liczba.Text = index.ToString();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach(int val in numbers)
            {
                message += val + "\n";
            }
            MessageBox.Show(message, "Zapisane liczby", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int index = getIndex();
            string s_n = textBox_liczba.Text;
            float f_n;
            if (float.TryParse(s_n, out f_n))
            {
                numbers[index] = f_n;
                MessageBox.Show("Zapisano liczbe to tablicy!", "Zapisano!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("To nie liczba", "Błąd", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            float rt = numbers.Sum();
            MessageBox.Show(rt.ToString(), "Suma", MessageBoxButtons.OK);
        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            float rt = numbers.Average();
            MessageBox.Show(rt.ToString(), "Średnia", MessageBoxButtons.OK);
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            float rt = numbers.Min();
            MessageBox.Show(rt.ToString(), "Min", MessageBoxButtons.OK);
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            float rt = numbers.Max();
            MessageBox.Show(rt.ToString(), "Max", MessageBoxButtons.OK);
        }
    }
}
