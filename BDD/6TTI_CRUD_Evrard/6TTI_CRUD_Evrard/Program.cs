using System.Data;

namespace _6TTI_CRUD_Evrard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] donnees = new string[8];
            DataSet immoBiens;
            methodemodele monModele = new methodemodele();
            Console.WriteLine("Liste des utilisateurs");
            Console.WriteLine("----------------------");
            if (monModele.ChercherBiens(out immoBiens))
            {
                string listeBien = monModele.AfficheDataBiens(immoBiens);
                Console.WriteLine(listeBien);
            }
            else
            {
                Console.WriteLine("Pb lors de la lecture des données");
            }
            Console.WriteLine("Ajout d'un bien :");
            Console.WriteLine("------------------------");
            Console.WriteLine("Nom ? ");
            donnees[0] = Console.ReadLine();
            Console.WriteLine("Taille ? ");
            donnees[1] = Console.ReadLine();
            Console.WriteLine("Prix ? ");
            donnees[2] = Console.ReadLine();
            Console.WriteLine("Ville ? ");
            donnees[3] = Console.ReadLine();
            Console.WriteLine("User Id ? ");
            donnees[4] = Console.ReadLine();
            Console.WriteLine("Description ? ");
            donnees[5] = Console.ReadLine();
            Console.WriteLine("Chambres ? ");
            donnees[6] = Console.ReadLine();
            Console.WriteLine("Image bien ? ");
            donnees[7] = Console.ReadLine();

            if (monModele.AjouterBien(donnees))
            {
                Console.WriteLine("Bien ajouté !");
            }
            else
            {
                Console.WriteLine("Problème lors de l'ajout !");
            }
            Console.ReadLine();
        }
    }
}