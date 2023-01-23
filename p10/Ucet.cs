using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10
{
    internal class Ucet
    {

        public static int cisloUctu;

        public string jmeno { get; set; }

        public int castka;

        public enum BankaEnum
        {
            Aktivni,
            Zablokovany,
            Zruseny
        }

        public Ucet(string jmeno, int castka)
        {
            this.jmeno = jmeno;

            this.castka = 1000;
        }
    }
}
