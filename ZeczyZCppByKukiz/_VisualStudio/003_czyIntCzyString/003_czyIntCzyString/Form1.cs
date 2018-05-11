using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_czyIntCzyString
{
    public partial class Form1 : Form
    {
        public void CloseProgram()
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

        private void Close_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }

        private void pokazText_Click(object sender, EventArgs e)
        {
            string strJakisText = jakisText.Text;
            var result = MessageBox.Show(
                "Czy \"" + strJakisText + "\" to Twój text?",
                "Ale czy napewno?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                podajText.Text = "Wee, udało się!";
            }
            else
            {
                podajText.Text = "Jakiś error :/";
            }
        }

        private void razyTrzy_Click(object sender, EventArgs e)
        {
            string strJakasLiczba = jakasLiczba.Text;
            //czy jest cokolwiek
            if (strJakasLiczba.Length != 0)
            {
                float floatJakasLiczba;
                //czy jest jakas liczba
                if (float.TryParse(strJakasLiczba, out floatJakasLiczba))
                {
                    floatJakasLiczba *= 3;
                    jakasLiczba.Text = floatJakasLiczba.ToString();
                }
                else
                {
                    MessageBox.Show("To nie jest liczba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nic nie wprowadono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
