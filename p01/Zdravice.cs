using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    internal class Zdravice
    {

        public string text;

        /// <summary>
        /// Pozdraví uživatele textem pozdravu a jeho jménem
        /// </summary>
        /// <param name="jmeno">jméno uživatele</param>
        /// <returns></returns> 
        public string Pozdrav(string jmeno)
        {
            return String.Format($"{text} {jmeno}");    

        }

        
    }
}
