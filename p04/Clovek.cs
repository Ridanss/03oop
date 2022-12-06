using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p04
{
    internal class Clovek
    {

        private string jmeno;

        private DateTime narozen;

        public Clovek(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }

        public void NastavJmeno(string noveJmeno)
        {
            jmeno = noveJmeno;
        }

        public string VypisJmeno()
        {
            return jmeno;
        }

        public int Vek()
        {
            int vek;
            DateTime today = DateTime.Today;
            vek = today.Year - narozen.Year;

            if (today.DayOfYear < narozen.DayOfYear) vek--;
            return vek;
        }

        public bool Plnolety()
        {
            if (Vek() >= 18) return true;
            return false;
        }

        public string Starsi(Clovek druhyClovek)
        {
            if (druhyClovek.narozen < narozen)
            {
                return druhyClovek.jmeno + " je starší než " + jmeno + ".";
            }
            else return jmeno + " je starší než " + druhyClovek.jmeno + ".";
        }

        public override string ToString()
        {
            return string.Format($"{jmeno} má {Vek()} let a {(Plnolety() ? "je" : "není")} plnoletý");
        }


    }
}
