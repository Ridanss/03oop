using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05
{
    internal class Retez
    {

        private string veta;

        private int cislo;

        public Retez(string veta)
        {
            this.veta = veta;
            cislo = 1;
        }

        public Retez(string veta, int cislo)
        {
            this.veta = veta;
            this.cislo = cislo;
        }

        public override string ToString()
        {
            return veta;
        }

        public void Zkrat()
        {
            bool slovo = true;
            int pocetSlov = 0;
            string chain = string.Empty;

            for (int i = 0; i < veta.Length; i++)
            {

                if (char.IsLetter(veta[i]) || char.IsDigit(veta[i]))
                {
                    if (slovo)
                    {
                        pocetSlov++;
                        if (pocetSlov <= cislo)
                        {
                            
                        }
                        slovo = false;
                    }
                }

                else if (veta[i] == ' ')
                {
                    slovo = true;
                }

            }
            
        }

    }
}
