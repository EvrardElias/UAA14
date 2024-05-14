using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Barman
    {
        private string _prenom;

        public Barman(string prenom)
        {
            _prenom = prenom;
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        //Demander le numero de la recette à l'utilisateur
        public int Commander(string menu, int nbRecettes)
        {
            string choixUser;
            int numeroCocktail;
            do
            {
                do
                {
                    Console.WriteLine(menu);
                    choixUser = Console.ReadLine();
                } while (!int.TryParse(choixUser, out numeroCocktail));
            } while (numeroCocktail < 1 || numeroCocktail > nbRecettes);
            return numeroCocktail;

        }

        //Chercher les ingredients pour faire le cocktail
        public bool Fabriquer(Cocktail cocktail, Shaker shaker, Bar monBar)
        {
            bool ok = true;
            int numeroBouteille;
            Liquide ingredient;
            
            foreach (Portion portion in cocktail.RecetteCocktail.Ingredients)
            {
                ingredient = portion.Contenu;
                if (monBar.PrendreBouteille(ingredient, out numeroBouteille))
                {
                    if (portion.TesterPortion(shaker, monBar.Bouteilles[numeroBouteille]))
                    {
                        monBar.Bouteilles[numeroBouteille].Verser(portion);
                        shaker.AjouterPortion(portion);
                    }
                    else
                    {
                        Console.WriteLine(monBar.Bouteilles[numeroBouteille].Jeter(monBar.Bouteilles[numeroBouteille]));
                        ok = false;
                    }
                }
                else
                {
                    ok = false;
                }
            }
            return ok;
        }

        //Sert dans le verre (fabriquer le message)
        public string Servir(Cocktail cocktail, bool fabricationOk, ref Shaker shaker)
        {
            string chaine = "";
            if (fabricationOk)
            {
                chaine = "Voici votre cocktail !";
            }
            else
            {
                chaine = "Nous avons rencontré un problème lors de la fabrication de votre cocktail";
            }
            return chaine;
        }
    }
}
