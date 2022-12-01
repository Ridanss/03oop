using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string[] vyrobek;
            listBox1.Items.Clear();

            for(int i = 0; i < textBox1.Lines.Count(); i++)
            {
                vyrobek = textBox1.Lines[i].Split(';');
                Zbozi zbozi = new Zbozi(vyrobek[0], double.Parse(vyrobek[1]), DateTime.Parse(vyrobek[2]), int.Parse(vyrobek[3]));
                listBox1.Items.Add(zbozi.Vypis());

            }
        }
    }
}
