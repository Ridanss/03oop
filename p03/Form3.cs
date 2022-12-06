using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelVypis1.Text = "1. výpis: ";
            labelVypis2.Text = "2. výpis: ";
            labelWordCount.Text = "počet slov: ";
            Retez chain = new Retez(textBox1.Text);
            labelVypis1.Text += chain.Vypis();
            labelWordCount.Text += chain.PocetSlov().ToString();
            if (char.TryParse(textBox2.Text, out char smaz))
            {
                chain.Smaz(smaz);
                labelVypis2.Text += chain.Vypis();
            }
        }
    }
}
