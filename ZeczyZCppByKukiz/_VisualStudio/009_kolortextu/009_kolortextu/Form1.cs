using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_kolortextu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_red_CheckedChanged(object sender, EventArgs e)
        {
            label_szkola.ForeColor = Color.Red;
        }

        private void radioButton_green_CheckedChanged(object sender, EventArgs e)
        {
            label_szkola.ForeColor = Color.Green;
        }

        private void radioButton_blue_CheckedChanged(object sender, EventArgs e)
        {
            label_szkola.ForeColor = Color.Blue;
        }

        private void radioButton_yellow_CheckedChanged(object sender, EventArgs e)
        {
            label_szkola.ForeColor = Color.Yellow;
        }
    }
}
