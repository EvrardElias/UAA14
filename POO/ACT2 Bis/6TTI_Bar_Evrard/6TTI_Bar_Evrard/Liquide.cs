using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Liquide
    {
        private string _nom;
        private string _type;

        public Liquide(string nom, string type)
        {
            _nom = nom;
            _type = type;
        }

        public string Nom
        {
            get { return _nom; }
        }

        public string Type
        {
            get { return _type; }
        }
    }
}
