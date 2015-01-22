using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptographie;

namespace TestDeCryptage
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulaire rot = new Circulaire(3);
            Rotation cirque = new Rotation(10);
            string phraseAFrancis = "Allo mon ami, Francis Côté, je mets des accents genre comme test faque ton nom était super approprié!, je peux même mettre des chevrons < < > > ^_^b";
            rot.initialiser();
            cirque.initialiser();

            //Console.WriteLine(rot.Chiffrer(phraseAFrancis));
            //Console.WriteLine(rot.Dechiffrer(rot.Chiffrer(phraseAFrancis)));
            Console.WriteLine(cirque.Chiffrer("ZoOMApHoReJhzjUEwAAAAAAAdeeeeemMaMOMan"));
            Console.WriteLine(cirque.Dechiffrer(cirque.Chiffrer("ZoOMApHoReJhzjUEwAAAAAAAdeeeeemMaMOMan")));
            //Console.WriteLine(cirque.Chiffrer(phraseAFrancis));
           // Console.WriteLine(cirque.Dechiffrer(cirque.Chiffrer(phraseAFrancis)));

            Console.ReadLine();
        }
    }
}
