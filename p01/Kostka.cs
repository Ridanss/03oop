using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    internal class Kostka
    {
        /// <summary>
        /// generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// počet stěn kostky
        /// </summary>
        private int pocetSten;

        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }

        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }

        public int VratPocetSten()
        {
            return pocetSten;
        }

        public override string ToString()
        {
            return "kostka s " + pocetSten + " stěnami";
        }

        public int Hod()
        {
            return random.Next(1, pocetSten + 1);
        }
    }
}
