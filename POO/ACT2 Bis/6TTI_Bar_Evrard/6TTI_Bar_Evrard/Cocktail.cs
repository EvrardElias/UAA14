using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Cocktail
    {
        private string _nom;
        private Recette _recetteCocktail;

        public Cocktail(string nom, Recette recetteCocktail) 
        {
            _nom = nom;
            _recetteCocktail = recetteCocktail;

        }

        public string Nom
        {
            get { return _nom; }
        }

        public Recette RecetteCocktail
        {
            get { return _recetteCocktail;}
        }

        //Concatener la recette
        public string AfficherRecette()
        {
            string chaine = "Recette du " + Nom + "\n";
            for (int i = 0; i < RecetteCocktail.Ingredients.Count -1; i++)
            {
                chaine += RecetteCocktail.Ingredients[i].Quantite + " de " + RecetteCocktail.Ingredients[i].Contenu.Nom + "\n";
            }
            return chaine;
        }
    }
}
