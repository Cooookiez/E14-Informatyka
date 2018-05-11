using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_ktura_liczba_wieksza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sparwdz_Click(object sender, EventArgs e)
        {
            porownaj();
        }

        private void textBox_nr1_TextChanged(object sender, EventArgs e)
        {
            porownaj();
        }

        private void porownaj()
        {
            string s_nr1 = textBox_nr1.Text;
            string s_nr2 = textBox_nr2.Text;
            float f_nr1;
            float f_nr2;
            if (!float.TryParse(s_nr1, out f_nr1) || !float.TryParse(s_nr2, out f_nr2))
            {
                label_znak.Text = "!";
            }
            else
            {
                if (f_nr1 > f_nr2)
                {
                    label_znak.Text = ">";
                }
                else if (f_nr1 < f_nr2)
                {
                    label_znak.Text = "<";
                }
                else
                {
                    label_znak.Text = "=";
                }
            }
        }

        private void textBox_nr2_TextChanged(object sender, EventArgs e)
        {
            porownaj();
        }
    }
}
