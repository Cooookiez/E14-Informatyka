using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_LosowanieDoPukiWiększeNiż
{

    public partial class Form1 : Form
    {
        private int losGranica = 500;
        private int losMin = 0;
        private int losMax = 1000;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            losGranica = Convert.ToInt32(numGranica.Value);
            int tmpNum;
            do
            {
                tmpNum = rnd.Next(losMax - losMin + 1) + losMin;
                if (cB_Par.Checked && tmpNum % 2 == 0) rtb_losy.AppendText(tmpNum + ", ");
                if (cB_NPar.Checked && tmpNum % 2 == 1) rtb_losy.AppendText(tmpNum + ", ");
            } while (tmpNum < losGranica);
            rtb_losy.AppendText("\n - - - - - - - - - -\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb_losy.Clear();
        }
    }
}
