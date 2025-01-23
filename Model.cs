using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grossbuchstaben_MVVM
{
    internal class Model
    {
        public Model() { }


        public string NachGross(string klein)
        {
            string gross = null;

            gross = klein.ToUpper();
            return gross;
        }
        public string NachKlein(string gross)
        {
            string klein = null;

            klein = gross.ToLower();
            return klein;
        }

    }
}
