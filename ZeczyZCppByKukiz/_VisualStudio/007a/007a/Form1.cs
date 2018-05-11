using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_oblicz_Click(object sender, EventArgs e)
        {
            string s_co = textBox_co.Text;
            string s_przez_co = textBox_przez_co.Text;
            int i_co = 0;
            int i_przez_co = 0;

            if (!Int32.TryParse(s_co, out i_co))
            {
                MessageBox.Show(
                    "Wpisz Poprawną liczbe (licznik)",
                    "Błędna wartość",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if(!Int32.TryParse(s_przez_co, out i_przez_co))
            {
                MessageBox.Show(
                    "Wpisz Poprawną liczbe (mianownik)",
                    "Błędna wartość",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if (i_przez_co == 0)
            {
                MessageBox.Show(
                    "Nie dzieli się przez zero!",
                    "Błędna wartość",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                float f_wynik = (float)i_co / i_przez_co;
                label_wynik.Text = f_wynik.ToString();
            }
        }

        private void checkBox_odblokuj_exit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_odblokuj_exit.Checked)
            {
                button_exit.Enabled = true;
            }
            else
            {
                button_exit.Enabled = false;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var msb = MessageBox.Show(
                "Czy napewno chcesz zamknąć program?",
                "Czy Napewno?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if(msb == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
