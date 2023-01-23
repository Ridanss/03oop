using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auto auto;

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            auto = new Auto(Convert.ToString(textBox1.Text), double.Parse(textBox2.Text));
        }

        private void buttonJed_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
        }

        private void buttonZast_Click(object sender, EventArgs e)
        {
            auto.Zastav(double.Parse(textBox3.Text));
        }

        private void buttonState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto.ToString());
        }
    }
}
