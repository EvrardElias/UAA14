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
            bool trouve = false;
            placeBouteille = -1;
            int i = 0;
            while (i < Bouteilles.Count && !trouve)
            {
                if (Bouteilles[i].Contenu == liquide)
                {
                    trouve = true;
                    placeBouteille = i;
                }
                i++;
            }
            return trouve;

        }

        //Si bouteille vide remettre une nouvelle
        public bool AjouterBouteille(Bouteille bouteille)
        {
            _bouteilles.Add(bouteille);
            return true;
        }

        //Parcourir la liste des bouteille
        public void AfficheInventaireBar()
        {
            for (int i = 0; i < _bouteilles.Count; i++)
            {
                Console.WriteLine(_bouteilles[i].Contenu.Nom);
            }
        }
    }
}
