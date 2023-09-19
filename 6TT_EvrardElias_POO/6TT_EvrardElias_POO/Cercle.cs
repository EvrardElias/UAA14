using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TT_EvrardElias_POO
{
    class Cercle
    {
        private float _rayon;

        public Cercle(float rayon)
        {
            _rayon = rayon;
        }

        public float Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        public float CalculePerimetre()
        {
            float perimetre = (float)(2 * Math.PI * Rayon);
            return perimetre;
        }

        public float CalculeAire()
        {
            float aire = (float)(Math.PI * (Rayon * Rayon));
            return aire;
        }

        public string AfficherCalcul()
        {
            string chaine = "Le cercle de rayon " + Rayon + " a un périmètre de " + CalculePerimetre() + " et une aire de " + CalculeAire() + ".";
            return chaine;
        }
    }
}
