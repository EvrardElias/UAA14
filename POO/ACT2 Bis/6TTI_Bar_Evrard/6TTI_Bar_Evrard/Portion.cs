using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Portion
    {
        private Liquide _contenu;
        private double _quantite;

        public Portion(Liquide contenu, double quantite)
        {
            _contenu = contenu;
            _quantite = quantite;
        }

        public Liquide Contenu
        {
            get { return _contenu; }
        }

        public double Quantite
        {
            get { return _quantite; }
        }

        //Regarder dans la bouteille si assez de liquide et si assez de place dans le shaker
        public bool TesterPortion(Shaker shaker, Bouteille bouteille)
        {
            bool ok = false;
            if (shaker.ContenanceMax >= (shaker.CalculQuantiteContenu() + this.Quantite * 0.2) && this.Quantite * 0.2 <= bouteille.Contenance)
            {
                ok = true;
            }
            return ok;
        }
    }
}
