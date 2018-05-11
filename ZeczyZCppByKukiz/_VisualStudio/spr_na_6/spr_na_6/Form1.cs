using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spr_na_6
{
    public partial class Form1 : Form
    {
        private int min = 0;
        private int max = 255;
        private int ile = 20;
        private int[] losy = new int[20];
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            var msgb = MessageBox.Show("Czy napewno chcesz zamknąć?", "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgb == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btt_autor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Krzysztof Kukiz IV i", "Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btt_clear_Click(object sender, EventArgs e)
        {
            rtb_consola.Text = "";
        }

        private void btt_losuj_Click(object sender, EventArgs e)
        {
            int tmpLos;
            for(int i = 0; i < ile; i++)
            {
                tmpLos = rnd.Next(max - min + 1) + min;
                if(cB_tylkoParzyste.Checked == true && tmpLos % 2 != 0)
                {
                    i--;
                    continue;
                }
                else
                {
                    losy[i] = tmpLos;
                }
            }
        }

        private void btt_sprawdz_Click(object sender, EventArgs e)
        {
            int przDo = Convert.ToInt32(nUD_pokazDo.Value);
            for (int i = 0; i < ile; i++)
            {
                if(losy[i] <= przDo)
                {
                    rtb_consola.AppendText(losy[i]+", ");
                }
            }
        }
    }
}
