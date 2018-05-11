using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_richTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_koniec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            rtb_box.AppendText("Start\n");
            for(int i = 0; i < 10; i++)
            {
                rtb_box.AppendText(i + "\n");
            }
            rtb_box.AppendText("Koniec\n\n");
        }

        private void bt_czysc_Click(object sender, EventArgs e)
        {
            rtb_box.Clear();
        }
    }
}
