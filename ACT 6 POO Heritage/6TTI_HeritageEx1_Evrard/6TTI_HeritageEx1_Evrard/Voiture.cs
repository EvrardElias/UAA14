using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx1_Evrard
{
    class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }

        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(marque, modele, couleur, prix)
        {
            _gps = gps;
            _motorisation = motorisation;
        }

        public override string Afficher()
        {
            string info = "Votre voiture est une " + Marque + " " + Modele + " de couleur " + Couleur + " avec une motorisation de type " + Motorisation + " qui vaut " + Prix + " euro";
            return info;
        }
    }
}
