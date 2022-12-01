using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03
{
    internal class Retez
    {
        private string veta;

        public Retez(string veta)
        {
            this.veta = veta;
        }

        public int PocetSlov()
        {
            bool slovo = false;
            int pocetSlov = 0;

            for (int i = 0; i < veta.Length; i++)
            {
                if (char.IsLetter(veta[i]) || char.IsDigit(veta[i]))
                {
                    slovo = true;
                }
                else if (veta[i] == ' ' && veta[i++] == ' ') slovo = false;

            }
            return pocetSlov;
        }

        public string Vypis()
        {
            return veta;
        }

        public void Smaz(char target)
        {
            veta.Replace(target, char.MinValue);
        }
    }
}
