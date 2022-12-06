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
            bool slovo = true;
            int pocetSlov = 0;

            for (int i = 0; i < veta.Length; i++)
            {

                if (char.IsLetter(veta[i]) || char.IsDigit(veta[i]))
                {
                    if (slovo)
                    {
                        pocetSlov++;
                        slovo = false;
                    }
                }

                else if (veta[i] == ' ')
                {
                    slovo = true;
                }

            }
            return pocetSlov;
        }

        public string Vypis()
        {
            return veta;
        }

        public void Smaz(char target)
        {
            int i = 0;
            while (i < veta.Length)
            {
                if (veta[i] == target)
                {
                    veta = veta.Remove(i, 1);
                }
                else i++;
            }
        }
    }
}
