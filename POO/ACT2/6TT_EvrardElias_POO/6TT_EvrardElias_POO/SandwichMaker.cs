using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TT_EvrardElias_POO
{
    class SandwichMaker
    {
        private string[] _proteine = {"Jambon", "Fromage", "Roast beef", "Salami"};
        private string[] _condiment = {"Moutarde", "Guacamole", "Mayo", "Ketchup"};
        private string[] _pain = {"Pain complet", "Pain blanc", "Pain gris", "Pain demi-gris"};
        private string[] _crudites = {"Salade", "Tomate", "Oeuf", "Oignon"};

        public SandwichMaker()
        {
           
        }

        public string[] Proteine
        {
            get { return _proteine; }
        }

        public string[] Condiment
        {
            get { return _condiment; }
        }

        public string[] Pain
        {
            get { return _pain; }
        }

        public string[] Crudites
        {
            get { return _crudites; }
        }

        public string ComposeSandwich()
        {
            Random alea = new Random();
            int choix = alea.Next(0,4);
            string sandwich = _pain[choix] + ", " + _proteine[choix] + ", " + _crudites[choix] + ", " + _condiment[choix];
            return sandwich;
        }
    }
}
