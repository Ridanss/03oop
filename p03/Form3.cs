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
            labelVypis.Text = "výpis: ";
            labelWordCount.Text = "počet slov: ";
            Retez chain = new Retez(textBox1.Text);
            labelVypis.Text += chain.Vypis();
            labelWordCount.Text += chain.PocetSlov().ToString();

        }
    }
}
