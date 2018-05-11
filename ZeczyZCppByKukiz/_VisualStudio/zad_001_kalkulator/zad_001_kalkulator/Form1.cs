using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_001_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char gl_c_symbol = '+'; 
        float gl_f_last_result = 0;
        float gl_f_result = 0;

        public float Sumowanie()
        {
            float wynik = 0;
            switch (gl_c_symbol)
            {
                case '+': wynik = gl_f_last_result + gl_f_result; break;
                case '-': wynik = gl_f_last_result - gl_f_result; break;
                case '*': wynik = gl_f_last_result * gl_f_result; break;
                case '/': wynik = gl_f_last_result / gl_f_result; break;
            }
            return wynik;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_key_ce_Click(object sender, EventArgs e)
        {
            label_result.Text = "";
            label_last_result.Text = "";
            gl_c_symbol = '+';
            gl_f_last_result = 0;
            gl_f_result = 0;
        }

        private void button_key_c_Click(object sender, EventArgs e)
        {
            label_result.Text = "";
        }

        private void button_key_backspace_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            string s_wynik = "";
            int dl = s_liczba.Length;
            for (int i = 0; i < dl - 1; i++) s_wynik += s_liczba[i];
            label_result.Text = s_wynik;
        }

        private void button_key_perCent_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                float wynik = gl_f_last_result / 100 * f_liczba;
                label_result.Text = wynik.ToString();
            }
        }

        private void button_key_divide_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                gl_f_result = f_liczba;
                float wynik = Sumowanie();

                gl_f_last_result = wynik;
                label_last_result.Text = wynik + " /";
                label_result.Text = "";

                gl_c_symbol = '/';
            }
        }

        private void button_key_times_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                gl_f_result = f_liczba;
                float wynik = Sumowanie();

                gl_f_last_result = wynik;
                label_last_result.Text = wynik + " *";
                label_result.Text = "";

                gl_c_symbol = '*';
            }
        }

        private void button_key_minus_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                gl_f_result = f_liczba;
                float wynik = Sumowanie();

                gl_f_last_result = wynik;
                label_last_result.Text = wynik + " -";
                label_result.Text = "";

                gl_c_symbol = '-';
            }
        }

        private void button_key_plus_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                gl_f_result = f_liczba;
                float wynik = Sumowanie();

                gl_f_last_result = wynik;
                label_last_result.Text = wynik + " +";
                label_result.Text = "";

                gl_c_symbol = '+';
            }
        }

        private void button_key_equal_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                gl_f_result = f_liczba;
                float wynik = Sumowanie();

                gl_f_last_result = 0;
                gl_f_result = wynik;
                label_last_result.Text = "";
                label_result.Text = wynik.ToString();

                gl_c_symbol = '+';
            }
        }

        private void button_key_x_1_2_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                label_result.Text = Math.Pow(f_liczba, 0.5).ToString();
            }
        }

        private void button_key_x_2_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if (float.TryParse(s_liczba, out f_liczba))
            {
                label_result.Text = Math.Pow(f_liczba, 2).ToString();
            }
        }

        private void button_key_1_x_Click(object sender, EventArgs e)
        {
            string s_liczba = label_result.Text;
            float f_liczba;
            if(float.TryParse(s_liczba, out f_liczba))
            {
                f_liczba = 1 / f_liczba;
                label_result.Text = f_liczba.ToString();
            }
        }

        private void button_key_plus_minus_Click(object sender, EventArgs e)
        {
            string s_result = label_result.Text;
            float f_result;
            if (float.TryParse(s_result, out f_result))
            {
                f_result *= -1;
                label_result.Text = f_result.ToString();
            }
        }

        private void button_key_dot_Click(object sender, EventArgs e)
        {
            if (!label_result.Text.Contains(','))
            {
                label_result.Text += ",";
            }
        }

        private void buttons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label_result.Text += btn.Text; //I<3Todzio
        }

        private void pkd(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0: label_result.Text += "0"; break;
                case Keys.NumPad1: label_result.Text += "1"; break;
                case Keys.NumPad2: label_result.Text += "2"; break;
                case Keys.NumPad3: label_result.Text += "3"; break;
                case Keys.NumPad4: label_result.Text += "4"; break;
                case Keys.NumPad5: label_result.Text += "5"; break;
                case Keys.NumPad6: label_result.Text += "6"; break;
                case Keys.NumPad7: label_result.Text += "7"; break;
                case Keys.NumPad8: label_result.Text += "8"; break;
                case Keys.NumPad9: label_result.Text += "9"; break;
                case Keys.Add: button_key_plus_Click(sender, e); break;
                case Keys.Subtract: button_key_minus_Click(sender, e); break;
                case Keys.Multiply: button_key_times_Click(sender, e); break;
                case Keys.Divide: button_key_divide_Click(sender, e); break;
                case Keys.OemPeriod: button_key_dot_Click(sender, e); break;
                case Keys.Back: button_key_backspace_Click(sender, e);  break;
                case Keys.Enter: button_key_equal_Click(sender, e); break;
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sprubuj nacisnąć kturyś guzik, lub klawisz na klawiaturze numerycznej", "pomoc", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno chcesz wyjść?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
