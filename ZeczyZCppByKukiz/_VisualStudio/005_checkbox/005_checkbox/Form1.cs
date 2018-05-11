using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sprawdz_Click(object sender, EventArgs e)
        {
            string odp1, odp2, odp3, k, m;

            if (checkBox_odp_1.Checked) odp1 = "on";
            else odp1 = "off";

            if (checkBox_odp_2.Checked) odp2 = "on";
            else odp2 = "off";

            if (checkBox_odp_3.Checked) odp3 = "on";
            else odp3 = "off";

            if (radioButton_kobieta.Checked) k = "on";
            else k = "off";

            if (radioButton_mezcyzna.Checked) m = "on";
            else m = "off";

            MessageBox.Show(
                "odp1:\t" + odp1 + "\nodp2:\t" + odp2 + "\nodp3:\t" + odp3 + "\nm:\t" + m + "\nk:\t" + k,
                "Zaznaczone Żaczy",
                MessageBoxButtons.OK
            );
        }
    }
}
