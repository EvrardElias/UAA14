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
        public int Commander(string menu, int nbRecette)
        {
            Console.WriteLine("Bonjour, quel cocktail souhaitez-vous ?\n" + menu);
            do
            {

            }
            while (TryParse = true);
            nbRecette = Console.ReadLine();

        }

        //Chercher les ingredient,... pour faire le cocktail
        public bool Fabriquer(Cocktail cocktail, Shaker shaker, Bar monBar)
        {

        }

        //Sert dans le verre (fabriquer le message)
        public string Servir(Cocktail cocktail, bool fabricationOk, ref Shaker shaker)
        {

        }
    }
}
