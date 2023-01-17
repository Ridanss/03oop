using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p08
{
    internal class Atlet
    {

        private int unava = 0;

        private string jmeno;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    jmeno = value;
                   
                    
                }
                else jmeno = value;
            }
        }

        public Atlet(string name)
        {
            Jmeno = name;
        }

        public void Behej(int km)
        {
            for (int i = 0; i < km; i++)
            {
                if (unava <= 190) unava += 10;
                else
                {
                    MessageBox.Show("Atlet je příliš unavený");
                    continue;
                }
            }
        }

        public void Spi(int hodin)
        {
            for (int i = 0; i < hodin; i++)
            {
                if (unava >= 100) unava -= 100;
                else if (unava < 100 && unava > 0) unava = 0;
                else continue;
            }
        }

        public void ZjistitUnavu()
        {
            MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
        }

    }
}
