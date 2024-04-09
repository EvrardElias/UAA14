using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Bar
    {
        private List<Bouteille> _bouteilles;

        public Bar(List<Bouteille> bouteilles)
        {
            _bouteilles = bouteilles;
        }

        public List<Bouteille> Bouteilles
        {
            get { return _bouteilles; }
            set { _bouteilles = value;}
        }

        //Sur base du liquide regarder le numero de la bouteille
        public bool PrendreBouteille(Liquide liquide, out int placeBouteille)
        {

        }

        //Si bouteille vide remettre une nouvelle
        public bool AjouterBouteille(Bouteille bouteille)
        {

        }

        //Parcourir la liste des bouteille
        public string AfficheInventaireBar()
        {

        }
    }
}
