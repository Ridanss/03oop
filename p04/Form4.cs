using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno1 = Convert.ToString(textBox1.Text);
            string jmeno2 = Convert.ToString(textBox3.Text);
            DateTime narozen1 = Convert.ToDateTime(textBox2.Text);
            DateTime narozen2 = Convert.ToDateTime(textBox4.Text);

            Clovek pepa = new Clovek(jmeno1, narozen1);
            Clovek karel = new Clovek(jmeno2, narozen2);

            MessageBox.Show(pepa.ToString());
            pepa.NastavJmeno("Pepíno");
            MessageBox.Show(pepa.ToString());

            MessageBox.Show(karel.Starsi(pepa));
        }
    }
}
