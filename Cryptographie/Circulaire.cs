using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographie
{
    public class Circulaire : wrapper
    {
        public int rotation{get; private set;}
        public Circulaire(int rotation = 1)
        {
            this.rotation = rotation;
        }
        public override string Chiffrer(string valeur)
        {
            string mot;
            mot = valeur.Substring(0, rotation);
            valeur += mot;
            return valeur.Substring(rotation, valeur.Length - rotation);
        }
        public override string Dechiffrer(string valeur)
        {
            string debut, fin;
            fin = valeur.Substring(0, valeur.Length - rotation);
            debut = valeur.Substring(valeur.Length - rotation, rotation);
            return debut+fin;

        }
    }
}
