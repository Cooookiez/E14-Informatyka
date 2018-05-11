using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_zdarzenia
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            lbl_info.Text = "Najechano na groupbo";
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            lbl_info.Text = "Zmieniono rozmiar";
            MessageBox.Show("NIe ma takiej Hakerki !!!", "NIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Size = new Size(240, 240);
        }
    }
}
