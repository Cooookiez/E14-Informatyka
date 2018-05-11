using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulamki
{

    public partial class Form1 : Form
    {

        public void exit()
        {
            var result = MessageBox.Show(
                "Jesteś pewien?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void WynikVal_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float wynik = 3.14f;
            int ulamek = Int32.Parse(textBox1.Text);
            int mianownik = Int32.Parse(textBox2.Text);
            wynik = (float)ulamek / mianownik;

            WynikVal.Text = wynik.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mianownikVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
