using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx1_Evrard
{
    class Vélo : Vehicule
    {
        private string _type;
        private bool _electrique;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool Electrique
        {
            get { return _electrique; }
            set { _electrique = value; }
        }

        public Vélo(string type, bool electrique, string marque, string modele, string couleur, decimal prix) : base (marque, modele, couleur, prix)
        {
            _type = type;
            _electrique = electrique;
        }

        public override string Afficher()
        {
            string info = "Votre vélo est un " + Marque + " " + Modele + " de couleur " + Couleur + " de type " + Type + " qui vaut " + Prix + " euro";
            return info;
        }
    }
}
