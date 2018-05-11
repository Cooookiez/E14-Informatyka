using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_Mapka_kraju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_panstwa_polska_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_mapa.Image = Image.FromFile(@"F:\Jacki\_VisualStudio\010_Mapka kraju\img\pl.png");
        }

        private void radioButton_panstwa_norwegia_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_mapa.Image = Image.FromFile(@"F:\Jacki\_VisualStudio\010_Mapka kraju\img\norwegia.jpg");
        }

        private void groupBox_panstwa_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_panstwa_francja_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_mapa.Image = Image.FromFile(@"F:\Jacki\_VisualStudio\010_Mapka kraju\img\fr.jpg");
        }

        private void radioButton_panstwa_anglia_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_mapa.Image = Image.FromFile(@"F:\Jacki\_VisualStudio\010_Mapka kraju\img\uk.jpg");
        }

        private void radioButton_panstwa_usa_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_mapa.Image = Image.FromFile(@"F:\Jacki\_VisualStudio\010_Mapka kraju\img\usa.jpg");
        }

        private void button1_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("?", "?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Czy napewno chcesz wyjść z programu?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(msg == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
