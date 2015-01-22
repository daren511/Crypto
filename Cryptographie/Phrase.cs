using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographie
{
    public class Phrase : wrapper
    {
        int increment;

        public Phrase(int inc = 2)
        {
            increment = inc;
        }
        public override string Chiffrer(string valeur)
        {
            string mot = "";

            for (int i = 0; i < valeur.Length; ++i)
            {
                mot += Char.ConvertFromUtf32(valeur[i] + increment);
            }
            return mot;
        }
        public override string Dechiffrer(string valeur)
        {
            string mot = "";

            for (int i = 0; i < valeur.Length; ++i)
            {
                mot += Char.ConvertFromUtf32(valeur[i] - increment);
            }
            return mot;
        }
    }
}
