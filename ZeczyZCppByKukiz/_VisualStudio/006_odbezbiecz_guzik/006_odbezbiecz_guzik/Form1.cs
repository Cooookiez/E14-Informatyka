using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_odbezbiecz_guzik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_odbezbiecz_Click(object sender, EventArgs e)
        {
            bool wl_exit = button_wlacz_zamknij.Enabled;
            if (wl_exit)
            {
                button_odbezbiecz.Text = "Odbezbiecz";
                button_wlacz_zamknij.Enabled = false;
            }
            else
            {
                button_odbezbiecz.Text = "Zabezbiecz";
                button_wlacz_zamknij.Enabled = true;
            }
        }

        private void button_wlacz_zamknij_Click(object sender, EventArgs e)
        {
            bool wl_exit = button_exit.Enabled;
            if (wl_exit)
            {
                button_wlacz_zamknij.Text = "Włącz guzik \"Wyjdź\"";
                button_exit.Enabled = false;
            }
            else
            {
                button_wlacz_zamknij.Text = "Wyłącz guzik \"Wyjdź\"";
                button_exit.Enabled = true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_exit2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox_gura_odbezbieczona_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_gura_odbezbieczona.Checked) checkBox_onoff_exit2.Enabled = true;
            else checkBox_onoff_exit2.Enabled = false;
        }

        private void checkBox_onoff_exit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_onoff_exit2.Checked) button_exit2.Enabled = true;
            else button_exit2.Enabled = false;
        }
    }
}
