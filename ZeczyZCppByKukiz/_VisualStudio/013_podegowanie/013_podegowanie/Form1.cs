using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_podegowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_pok_wynik_Click(object sender, EventArgs e)
        {
            double podstawa = Convert.ToDouble(numericUpDown_podstawa.Value);
            double podenga = Convert.ToDouble(numericUpDown_podega.Value);

            double wyn = Math.Pow(podstawa, podenga);

            label_wynik.Text = wyn.ToString();
        }
    }
}
