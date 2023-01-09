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
                veta = value;
                if (veta != null)
                {
                    veta = veta.Substring(0, 1).ToUpper() + veta.Substring(1);
                    if (veta[veta.Length - 1] != '.') veta += '.';
                }
            }
        }

        public Retez(string veta)
        {
            this.Veta = veta;
            cislo = 1;
        }

        public Retez(string veta, int cislo)
        {
            this.Veta = veta;
            this.cislo = cislo;
        }

        public override string ToString()
        {
            return Veta;
        }

        public string Zkrat()
        {
            string[] pole = Veta.Split(' ');
            pole = pole.Take(cislo).ToArray();

            Veta = string.Join(" ", pole);
            return Veta;
            
        }

    }
}
