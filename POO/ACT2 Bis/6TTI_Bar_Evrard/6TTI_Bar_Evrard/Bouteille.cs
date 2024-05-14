using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Bouteille
    {
        private Liquide _contenu;
        private double _contenance;

        public Bouteille(Liquide contenu, double contenance) 
        {
            _contenu = contenu;
            _contenance = contenance;
        }

        public Liquide Contenu
        { 
            get { return _contenu; }
            set { _contenu = value; }
        }

        public double Contenance
        {
            get { return _contenance; }
            set { _contenance = value; }
        }

        //Decompter une portion dans la bouteille
        public void Verser(Portion portion)
        {
            _contenance = _contenance - 1;
        }

        //Detruire la bouteille si vide
        public string Jeter(Bouteille bouteille)
        {
            string chaine = "Votre bouteille de " + _contenu.Nom + " à bien fini à la poubelle.";
            return chaine;
        }
    }
}
