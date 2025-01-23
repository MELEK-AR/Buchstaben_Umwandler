using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grossbuchstaben_MVVM
{
    class ViewModel: BindableBase
    {
        private string kleinwort;
        private string grosswort;
        private Model model;

        public string Kleinwort { get { return kleinwort; } set { SetProperty(ref kleinwort, value); } } 
        public string Grosswort { get {return grosswort; } set { SetProperty(ref grosswort, value); } }

        public ViewModel()
        {
            model = new Model();
        }

        public void Umwandeln()
        {
            if (!string.IsNullOrEmpty(kleinwort))
            {
                Grosswort = model.NachGross(kleinwort);
            }
            else if(!string.IsNullOrEmpty(grosswort)){ 
                Kleinwort = model.NachKlein(grosswort);
            }
        }

        public void Reset()
        {
            Grosswort = "";
            Kleinwort = "";
        }
    }
}
