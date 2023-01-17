using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxBirth.Clear();
            List<Student> person = new List<Student>();
            person.Add(new Student("Karel", "Pavloň", DateTime.Parse("3.4.2004"), 1));
            person.Add(new Student("Daniel", "Nováček", DateTime.Parse("23.1.2005"), 5));
            person.Add(new Student("Šimon", "Dočkal", DateTime.Parse("10.10.2004"), 6));
            person.Add(new Student("Vojtěch", "Dolák", DateTime.Parse("1.4.2005"), 2));
            person.Add(new Student("Weedeg", "Novotný", DateTime.Parse("4.1.2004"), 0));
            person.Add(new Student("Radim", "Pokorný", DateTime.Parse("25.4.2004"), 1));

            int count = 0;
            double sum = 0;
            double average;
            foreach(Student student in person)
            {
                if (student.Vek() >= 18) listBox1.Items.Add(student.ToString());

                if (student.znamka != 0) count++;
                sum += student.znamka;
            }
            average = sum / count;
            MessageBox.Show("Průměr klasifikovaných studentů je " + average.ToString());
        }
    }
}
