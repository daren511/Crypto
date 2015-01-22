using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographie
{
    abstract public class wrapper
    {
        public bool init {get;private set;}

        public wrapper()
        {
            this.init = false;
        }
        public abstract string Chiffrer(string valeur) ;
        public abstract string Dechiffrer(string valeur);
        public void initialiser()
        {
            this.init = true;
        }
    }
}
