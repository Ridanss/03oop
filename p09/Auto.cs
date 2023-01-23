using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace p09
{
    internal class Auto
    {

        private string znacka;

        private double spotreba;

        private double ujetoCelkem;

        private DateTime okamzikRozjezdu;

        private TimeSpan dobaJizdyCelkem;

        public bool Jede { get; private set; }

        public Auto(string znacka, double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            ujetoCelkem = 0;
            dobaJizdyCelkem = TimeSpan.Zero;
            Jede = false;
        }

        public double VratUjetKm()
        {
            return ujetoCelkem;
        }

        public void Rozjed()
        {
            okamzikRozjezdu = DateTime.Now;
            Jede = true;
        }

        public void Zastav(double km)
        {
            if (Jede)
            {
                Jede = false;
                dobaJizdyCelkem += DateTime.Now - okamzikRozjezdu;
                ujetoCelkem += km;
            }
        }

        public double CelkovaSpotreba()
        {
            return ujetoCelkem / 100 * spotreba;
        }

        public override string ToString()
        {
            return string.Format($"Detaily auta:\nznačka: {znacka}\nnajeto: {ujetoCelkem}\nčas jízdy: {dobaJizdyCelkem.ToString(@"hh\:mm\:ss")}\nspotřeba: {spotreba}\n" +
                $"auto spotřebovalo {CelkovaSpotreba()} litrů paliva\nauto momentálně {(Jede ? "jede" : "nejede")}");
        }

    }
}
