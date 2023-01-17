using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p07
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        NakladniAuto auto1;

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string spz = textBoxSpz.Text;
            double nosnost = double.Parse(textBoxNosnost.Text);

            auto1 = new NakladniAuto(spz, nosnost);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto1.ToString());
        }

        private void buttonVylNal_Click(object sender, EventArgs e)
        {
            double naklad = double.Parse(textBox1.Text);
            if (radioButtonNalozit.Checked)
            {
                auto1.NalozNaklad(naklad);
            }
            else
            {
                auto1.VylozNaklad(naklad);
            }
        }
    }
}
