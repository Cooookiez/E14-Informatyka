using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_funkcjaZerowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void pokazFunkcje(string s_a = "", string s_b = "", string s_c = "")
        {
            //a
            if (s_a.Length == 0)
            {
                float f_a;
                if (!float.TryParse(s_a, out f_a))
                {
                    s_a = "a";
                }
            }
            else
            {
                s_a = "a";
            }
            //b
            if (s_b.Length == 0)
            {
                float f_b;
                if (!float.TryParse(s_b, out f_b))
                {
                    s_b = "b";
                }
            }
            else
            {
                s_b = "b";
            }
            //c
            if (s_c.Length == 0)
            {
                float f_c;
                if (!float.TryParse(s_c, out f_c))
                {
                    s_c = "a";
                }
            }
            else
            {
                s_c = "c";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pokazFunkcje();
        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            string str_a = text_podaj_a.Text;
            string str_b = text_podaj_b.Text;
            string str_c = text_podaj_c.Text;

            float flt_a = 0;
            float flt_b = 0;
            float flt_c = 0;


            bool error = false;

            if (str_a.Length != 0)
            {
                //czy jest jakas liczba
                if (!float.TryParse(str_a, out flt_a))
                {
                    error = true;
                    MessageBox.Show("To nie jest liczba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error = true;
                MessageBox.Show("Nic nie wprowadono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (str_b.Length != 0)
            {
                //czy jest jakas liczba
                if (!float.TryParse(str_b, out flt_b))
                {
                    error = true;
                    MessageBox.Show("To nie jest liczba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error = true;
                MessageBox.Show("Nic nie wprowadono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (str_c.Length != 0)
            {
                //czy jest jakas liczba
                if (!float.TryParse(str_c, out flt_c))
                {
                    error = true;
                    MessageBox.Show("To nie jest liczba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error = true;
                MessageBox.Show("Nic nie wprowadono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (error == false)
            {
                float delta = (flt_b * flt_b) - (4 * flt_a * flt_c);
                MessageBox.Show(delta.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (delta > 0)
                {
                    double delta_p = Math.Sqrt(delta);
                    double x1 = ((flt_b) * (-1) - delta_p) / (2 * flt_a);
                    double x2 = ((flt_b) * (-1) + delta_p) / (2 * flt_a);
                    miejscaZerowe.Text = "Delta: " + delta + "x1: " + x1.ToString() + "\nx2: " + x2.ToString();
                }
                else if(delta == 0)
                {
                    double delta_p = Math.Sqrt(delta);
                    double x0 = ((flt_b) * (-1)) / (2 * flt_a);
                    miejscaZerowe.Text = "x0: " + x0.ToString();

                }
                else
                {
                    miejscaZerowe.Text = "Brak";
                }
            }

        }
    }
}
