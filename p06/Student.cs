using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06
{
    internal class Student
    {
        public string Jmeno { get; }

        public string Prijmeni { get; set; }

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

                }
            }
        }
    }
}
