using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p08
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        Atlet atlet;

        private void button1_Click(object sender, EventArgs e)
        {
            atlet = new Atlet(textBox1.Text);
        }

        private void buttonRealShit_Click(object sender, EventArgs e)
        {
            atlet.Behej(1);
        }

        private void buttonISleep_Click(object sender, EventArgs e)
        {
            atlet.Spi(1);
        }

        private void buttonKowalskiAnalysis_Click(object sender, EventArgs e)
        {
            atlet.ZjistitUnavu();
        }
    }
}
