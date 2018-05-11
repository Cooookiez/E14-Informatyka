using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_konwerterLiczb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_bin_CheckedChanged(object sender, EventArgs e)
        {
            string typ = label_multi.Text;
            string s_liczba = textBox_multi.Text;
            int i_liczba;
            switch (typ)
            {
                case "BIN": i_liczba = Convert.ToInt32(s_liczba, 2); break;
                case "OCT": i_liczba = Convert.ToInt32(s_liczba, 8); break;
                case "DEC": i_liczba = Convert.ToInt32(s_liczba, 10); break;
                case "HEX": i_liczba = Convert.ToInt32(s_liczba, 16); break;
                default: i_liczba = 0; break;
            }
            textBox_multi.Text = Convert.ToString(i_liczba, 2);
            label_multi.Text = "BIN";
        }

        private void radioButton_oct_CheckedChanged(object sender, EventArgs e)
        {
            string typ = label_multi.Text;
            string s_liczba = textBox_multi.Text;
            int i_liczba;
            switch (typ)
            {
                case "BIN": i_liczba = Convert.ToInt32(s_liczba, 2); break;
                case "OCT": i_liczba = Convert.ToInt32(s_liczba, 8); break;
                case "DEC": i_liczba = Convert.ToInt32(s_liczba, 10); break;
                case "HEX": i_liczba = Convert.ToInt32(s_liczba, 16); break;
                default: i_liczba = 0; break;
            }
            textBox_multi.Text = Convert.ToString(i_liczba, 8);
            label_multi.Text = "OCT";
        }

        private void radioButton_dec_CheckedChanged(object sender, EventArgs e)
        {
            string typ = label_multi.Text;
            string s_liczba = textBox_multi.Text;
            int i_liczba;
            switch (typ)
            {
                case "BIN": i_liczba = Convert.ToInt32(s_liczba, 2); break;
                case "OCT": i_liczba = Convert.ToInt32(s_liczba, 8); break;
                case "DEC": i_liczba = Convert.ToInt32(s_liczba, 10); break;
                case "HEX": i_liczba = Convert.ToInt32(s_liczba, 16); break;
                default: i_liczba = 0; break;
            }
            textBox_multi.Text = Convert.ToString(i_liczba, 10);
            label_multi.Text = "DEC";
        }

        private void radioButton_hex_CheckedChanged(object sender, EventArgs e)
        {
            string typ = label_multi.Text;
            string s_liczba = textBox_multi.Text;
            int i_liczba;
            switch (typ)
            {
                case "BIN": i_liczba = Convert.ToInt32(s_liczba, 2); break;
                case "OCT": i_liczba = Convert.ToInt32(s_liczba, 8); break;
                case "DEC": i_liczba = Convert.ToInt32(s_liczba, 10); break;
                case "HEX": i_liczba = Convert.ToInt32(s_liczba, 16); break;
                default: i_liczba = 0; break;
            }
            textBox_multi.Text = Convert.ToString(i_liczba, 16);
            label_multi.Text = "HEX";
        }
        
    }
}
