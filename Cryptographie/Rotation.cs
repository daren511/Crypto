using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographie
{
    public class Rotation : wrapper
    {
        int increment;
        List<char> tableau = new List<char>();
        public Rotation(int inc = 2)
        {
            increment = inc;
          

            for (int i = 0; i < 26 ; ++i)
            {
                tableau.Add(Char.ConvertFromUtf32('A' + i)[0]);
            }

            int valeurInterne = 0;
            for (int i = tableau.Count; i < 52; ++i)
            {
                tableau.Add(Char.ConvertFromUtf32('a' + valeurInterne)[0]);
                valeurInterne++;
            }
        }
        public override string Chiffrer(string valeur)
        {
            string mot = "";
            char lettre;
            for (int i = 0; i < valeur.Length; ++i)
            {
                lettre = valeur[i];

                if(tableau.IndexOf(lettre) < 26)
                {
                    mot += tableau[((lettre - 65 + increment) % 26)];
                }
                else
                    mot += tableau[(lettre - 97 + increment) % 26 + 26];
            }
            return mot;
        }
        public override string Dechiffrer(string valeur)
        {
            string mot = "";
            char lettre;

            for (int i = 0; i < valeur.Length; ++i)
            {
                lettre = valeur[i];

                if (tableau.IndexOf(lettre) < 26)
                {
                    mot += tableau[((lettre + 65 - increment) % 26)];
                }
                else
                {
                    if(lettre - 97 - increment >= 0)
                    {
                        mot += tableau[(lettre - 97 - increment) % 26 + 26];
                    }
                    else
                    {
                        mot += tableau[52 - Math.Abs(lettre - 97 - increment)];
                    }
                }
            }
            return mot;
        }
    }
}
