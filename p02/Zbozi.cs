using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace p02
{
    internal class Zbozi
    {
        private string nazev;
        private double cena;
        private DateTime datumVyroby;
        private int dniTrvanlivosti;

        public Zbozi(string nazev, double cena, DateTime datumVyroby, int dniTrvanlivosti)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumVyroby = datumVyroby;
            this.dniTrvanlivosti = dniTrvanlivosti;
        }

        public int MinTrvanlivostDny()
        {
            DateTime today = DateTime.Today;

            TimeSpan left = (datumVyroby.AddDays(dniTrvanlivosti)) - today;

            return left.Days;
        }

        public void NovaCena()
        {

            double price = cena;
            int timeleft = MinTrvanlivostDny();
            if (timeleft < -10) price = 0;
            else if (timeleft < 0) price *= 0.5;
            else if (timeleft <= 3)price *= 0.25;
            this.cena = price;
        }

        public string Vypis()
        {

            string chain = nazev + "; ";
            if (cena == 0) chain += "neprodejné; ";
            else chain += cena + "; ";
            chain += datumVyroby.ToString("d") + "; " + dniTrvanlivosti + "; " + MinTrvanlivostDny().ToString();
            return chain;
        }
    }
}
