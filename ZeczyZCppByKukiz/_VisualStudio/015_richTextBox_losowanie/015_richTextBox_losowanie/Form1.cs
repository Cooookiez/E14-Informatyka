using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_richTextBox_losowanie
{
    public partial class Form1 : Form
    {
        public void losujPowtarzaj()
        {
            rtb_cout.AppendText("\n==========\n");
            Random rnd = new Random();
            int min = Convert.ToInt32(numUD_od.Value);
            int max = Convert.ToInt32(numUD_do.Value);
            int ile = Convert.ToInt32(numUD_ile.Value);
            int los = 0;
            for (int i = 0; i < ile; i++)
            {
                if (i > 0) rtb_cout.AppendText(", ");
                los = rnd.Next(min, (max + 1));
                rtb_cout.AppendText(los.ToString());
            }
        }
        public void losujNiePowtarzaj()
        {
            rtb_cout.AppendText("\n==========\n");
            Random rnd = new Random();
            int min = Convert.ToInt32(numUD_od.Value);
            int max = Convert.ToInt32(numUD_do.Value);
            int ile = Convert.ToInt32(numUD_ile.Value);
            int los = 0;
            int[] numers = new int[ile];
            for (int i = 0; i < ile; i++)
            {
                numers[i] = -10000000;
            }

            for (int i = 0; i < ile; i++)
            {
                do
                {
                    los = rnd.Next(min, (max + 1));
                } while (numers.Contains(los));
                numers[i] = los;
            }
            Array.Sort(numers);
            for (int i = 0; i < ile; i++)
            {
                if (i > 0) rtb_cout.AppendText(", ");
                rtb_cout.AppendText(numers[i].ToString());
            }
        }

        public void czyMozeBycBezPowturzen()
        {
            int min = Convert.ToInt32(numUD_od.Value);
            int max = Convert.ToInt32(numUD_do.Value);
            int ile = Convert.ToInt32(numUD_ile.Value);
            if((max-min+1) >= ile)
            {
                chB_powtarzaj.Enabled = true;
            }
            else
            {
                chB_powtarzaj.Checked = true;
                chB_powtarzaj.Enabled = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            /* (chB_powtarzaj.Checked)
            {
                losujPowtarzaj();
            }
            else
            {
                losujNiePowtarzaj();
            }*/
            rtb_cout.AppendText("==========\n");
            Random rnd = new Random();
            int min = Convert.ToInt32(numUD_od.Value);
            int max = Convert.ToInt32(numUD_do.Value);
            int ile = Convert.ToInt32(numUD_ile.Value);

            bool powtarzaj = chB_powtarzaj.Checked;
            bool sortuj = chB_sort.Checked;

            int los = 0;
            int[] numers = new int[ile];


            //wybełnia duza ujemna liczba
            for (int i = 0; i < ile; i++)
            {
                numers[i] = -10000000;
            }

            //losuje
            for (int i = 0; i < ile; i++)
            {
                if (powtarzaj)
                {
                    los = rnd.Next(min, (max + 1));
                }
                else
                {
                    do
                    {
                        los = rnd.Next(min, (max + 1));
                    } while (numers.Contains(los));
                }
                numers[i] = los;
            }

            //sortuje
            if (sortuj)
            {
                Array.Sort(numers);
            }

            //wypisuje
            for (int i = 0; i < ile; i++)
            {
                if (i > 0) rtb_cout.AppendText(", ");
                rtb_cout.AppendText(numers[i].ToString());
            }

            rtb_cout.AppendText("\n");
        }

        private void numUD_od_ValueChanged(object sender, EventArgs e)
        {
            numUD_do.Minimum = numUD_od.Value;
            czyMozeBycBezPowturzen();
        }

        private void numUD_do_ValueChanged(object sender, EventArgs e)
        {
            numUD_od.Maximum = numUD_do.Value;
            czyMozeBycBezPowturzen();
        }

        private void numUD_ile_ValueChanged(object sender, EventArgs e)
        {
            czyMozeBycBezPowturzen();
        }
    }
}
