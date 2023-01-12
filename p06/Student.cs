using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p06
{
    internal class Student
    {
        public string Jmeno { get; }

        public string Prijmeni { get; set; }

        public Student(string name, string surname, DateTime birth, int grade)
        {
            Jmeno = name;
            Prijmeni = surname;
            DatumNarozeni = birth;
            Znamka = grade;
        }

        private DateTime narozeni;
        public DateTime DatumNarozeni
        {
            get
            {
                return narozeni;
            }
            set
            {
                narozeni = value;
                if (narozeni > DateTime.Today)
                {
                    MessageBox.Show("Budoucí datum");
                }
            }
        }

        private int znamka;

        public int Znamka
        {
            get
            {
                if (znamka == 0) MessageBox.Show("Neproběhla klasifikace");
                return znamka;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    znamka = 0;
                }
                else znamka = value;
            }
        }

        public int Vek()
        {
            int vek;
            DateTime today = DateTime.Today;
            vek = today.Year - DatumNarozeni.Year;

            if (DatumNarozeni.AddYears(vek) > today) vek--;
            return vek;
        }

        public bool Sleva()
        {
            if (Vek() < 26) return false;
            return true;
        }

        public override string ToString()
        {
            return string.Format($"{Jmeno} {Prijmeni}, {DatumNarozeni.ToString("d")}");
        }
    }
}
