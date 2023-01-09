using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelVysl.Text = "výsledek:\n";
            Retez veta = new Retez(textBox1.Text, int.Parse(textBox2.Text));
            MessageBox.Show(veta.ToString());
            Retez veta2 = new Retez(textBox1.Text);
            veta2.Zkrat();
            MessageBox.Show(veta2.ToString());
            veta.Zkrat();
            labelVysl.Text += veta.ToString();

            
        }
    }
}
