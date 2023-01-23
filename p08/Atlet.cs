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

        private int unava;

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
                    jmeno = char.ToUpper(value[0]).ToString();
                    jmeno += value.Substring(1);
                   
                    
                }
                else jmeno = value;
            }
        }

        public Atlet(string name)
        {
            Jmeno = name;
            unava = 0;
        }

        public void Behej(int km)
        {
            if (km * 10 < (200 - unava))
            {
                unava += km * 10;
                MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
            }
            else if (km != 0)
            {
                unava = 200;
                MessageBox.Show("Atlet je příliš unavený");
            }
        }

        public void Spi(int hodin)
        {
            if (hodin == 1 && unava >= 100)
            {
                unava -= 100;
                MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
            }
            else if (hodin != 0)
            {
                unava = 0;
                MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
            }
                
        }

        public void ZjistitUnavu()
        {
            MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
        }

    }
}
