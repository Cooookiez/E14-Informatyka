using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_LosowanieLiczb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_losuj_Click(object sender, EventArgs e)
        {
            int i_nOd = Convert.ToInt32(numeric_od.Value);
            int i_nDo = Convert.ToInt32(numeric_do.Value);
            //validacja
            if(i_nOd > i_nDo)
            {
                MessageBox.Show("Liczba \"Od\" nie może być większa od \"Do\"","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int i_nIle = Convert.ToInt32(numeric_ile.Value);
                int wynikTmp = 0;
                string wynik = "";
                string parzyste = "";
                string nieParzyste = "";
                Random rnd = new Random();
                //losowanie
                for (int i = 0; i < i_nIle; i++)
                {
                    wynikTmp = rnd.Next(i_nOd, (i_nDo + 1));
                    wynik += wynikTmp + ", ";
                    if (wynikTmp % 2 == 0) parzyste += wynikTmp + ", ";
                    else nieParzyste += wynikTmp + ", ";
                }
                //usuwanie ostatniego rzecinka
                if (wynik.Length > 0) wynik = wynik.Remove(wynik.Length - 2);
                if (parzyste.Length > 0) parzyste = parzyste.Remove(parzyste.Length - 2);
                if (nieParzyste.Length > 0) nieParzyste = nieParzyste.Remove(nieParzyste.Length - 2);
                MessageBox.Show("Wszystko:\n" + wynik + "\n\nParzyste:\n" + parzyste + "\n\nNie parzyste:\n" + nieParzyste, "Wynik", MessageBoxButtons.OK);
            }
        }
    }
}
