using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_losyRozdzielnoeNaParzysteINieParzyste
{
    public partial class Form1 : Form
    {
        private int liczbaMin= -20;
        private int liczbaMax = 20;
        private int liczbaIle = 20;

        private int countPar = 0;
        private int countNPar = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int lTmp;
            for(int i = 0; i < liczbaIle; i++)
            {
                lTmp = rnd.Next(liczbaMax-liczbaMin+1) + liczbaMin ;
                if (lTmp % 2 == 0)
                {
                    countPar++;
                    rtb_parzyste.AppendText(lTmp + ", ");
                    lb_ParCount.Text = "(" + countPar + ")";
                }
                else
                {
                    countNPar++;
                    rtb_nieParzyste.AppendText(lTmp + ", ");
                    lb_NParCount.Text = "("+ countNPar + ")";
                }
            }
            rtb_nieParzyste.Text += "\n";
            rtb_parzyste.Text += "\n";
        }

        private void btt_czyscPar_Click(object sender, EventArgs e)
        {
            rtb_parzyste.Clear();
            countPar = 0;
            lb_ParCount.Text = "(" + countPar + ")";
        }

        private void btt_czyscNPar_Click(object sender, EventArgs e)
        {
            rtb_nieParzyste.Clear();
            countNPar = 0;
            lb_ParCount.Text = "(" + countNPar + ")";
        }
    }
}
