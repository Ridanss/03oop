using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p07
{
    internal class NakladniAuto
    {

        private string spz;

        private int nosnost; //v tunach

        public int HmotnostNakladu { get; private set; } //v tunach

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
            HmotnostNakladu = 0;
        }

        public int NalozNaklad(int naklad)
        {
            if (naklad < nosnost - HmotnostNakladu) HmotnostNakladu += naklad;
            else
            {
                int rozdil = nosnost - HmotnostNakladu;
                naklad -= rozdil;
                HmotnostNakladu += naklad;
                MessageBox.Show(String.Format($"{rozdil} tun nebylo naloženo"));
            }
        }

        public int VylozNaklad()
        {

        }

        public override string ToString()
        {
            return string.Format($"Nákladní auto {spz} má nosnost {nosnost}t a má naloženo {HmotnostNakladu}t");
        }
    }
}
