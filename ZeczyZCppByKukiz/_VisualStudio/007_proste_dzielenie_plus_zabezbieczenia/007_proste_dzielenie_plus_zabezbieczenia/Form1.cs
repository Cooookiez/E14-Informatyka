using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_proste_dzielenie_plus_zabezbieczenia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_dzielenie_co_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pokaz_exit.Checked)
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
            Close();
        }

        private void button_oblicz_Click(object sender, EventArgs e)
        {
            string s_przez_co = textBox_dzielenie_przez_co.Text;
            string s_co = textBox_dzielenie_przez_co.Text;

            int i_co = 0;
            int i_przez_co = 0;

            if (!Int32.TryParse(s_co, out i_co))
            {
                MessageBox.Show("To musi być cyfra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!Int32.TryParse(s_przez_co, out i_przez_co))
            {
                MessageBox.Show("To musi być cyfra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (i_przez_co == 0)
            {
                MessageBox.Show("Nie dzielimy rzez zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            float wynik = 3.14f;
            wynik = (float)i_co / (float)i_przez_co;
            MessageBox.Show("co:\t" + i_co + "\nPrzez co:\t" + i_przez_co + "\nWynik:\t" + ((float)i_co / i_przez_co) , "w");
            label_wynik.Text = wynik.ToString();
        }
    }
}
