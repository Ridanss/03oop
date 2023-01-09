using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05
{
    internal class Retez
    {

        private string veta;

        private int cislo;

        public string Veta
        {
            get
            {
                return veta;
            }
            set
            {
                string chain = veta.Substring(1, veta.Length - 1);
                char first = char.ToUpper(veta[0]);
                veta = first.ToString() + chain;
            }
        }

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
            return Veta;
        }

        public void Zkrat()
        {
            bool slovo = true;
            int pocetSlov = 0;
            string chain = string.Empty;

            for (int i = 0; i < veta.Length; i++)
            {

                if (char.IsLetter(Veta[i]) || char.IsDigit(Veta[i]))
                {
                    if (slovo)
                    {
                        if (pocetSlov <= cislo)
                        {
                            
                        }
                        slovo = false;
                    }
                }

                else if (Veta[i] == ' ')
                {
                    slovo = true;
                }

            }
            
        }

    }
}
