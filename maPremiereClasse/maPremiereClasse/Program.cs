namespace Chien 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("première méthode");

            Console.WriteLine("Combien de chiens voulez-vous enregister ?");
            int nbrChiens = int.Parse(Console.ReadLine());
            Chien[] mesChiens = new Chien[nbrChiens];

            for (int i = 0; i < nbrChiens - 1; i++)
            {

            Console.WriteLine("Quel est le nom du chien ?");
            string nom = Console.ReadLine();

            Console.WriteLine("Quel est l'âge du chien ?");
            uint age = uint.Parse(Console.ReadLine());

            Console.WriteLine("Quel est la race du chien ?");
            string race = Console.ReadLine();

            bool enOrdreDeVaccin;
            Console.WriteLine("Es ce que le chien est en ordre du vaccin ? (O/N)");
            string reponse = Console.ReadLine();
            if (reponse == "O")
            {
                enOrdreDeVaccin = true;
            }
            else
            {
                enOrdreDeVaccin = false;
            }

            bool puce;
            Console.WriteLine("Es ce que le chien a une puce ? (O/N)");
            reponse = Console.ReadLine();
            if (reponse == "O")
            {
                puce = true;
            }
            else
            {
                puce = false;
            }

            Console.WriteLine("Quel est le genre du chien ?");
            string genre = Console.ReadLine();

            bool sterilise;
            Console.WriteLine("Es ce que le chien est sterilisé ? (O/N)");
            reponse= Console.ReadLine();
            if (reponse == "O")
            {
                sterilise = true;
            }
            else
            {
                sterilise = false;
            }

            Console.WriteLine("Quel est la couleur du chien ?");
            string poil = Console.ReadLine();

            Console.WriteLine("Quel est le pays d'origine du chien ?");
            string paysOrigine = Console.ReadLine();

            Console.WriteLine("Qui est le propriétaire du chien ?");
            string proprietaire = Console.ReadLine();

            bool dresse;
            Console.WriteLine("Es ce que le chien est dressé ?");
            reponse = Console.ReadLine();
            if (reponse == "O")
            {
                dresse = true;
            }
            else
            {
                dresse = false;
            }

                mesChiens [i] = new Chien(nom, age, race, enOrdreDeVaccin, puce, genre, sterilise, poil, paysOrigine, proprietaire, dresse);
                Console.WriteLine(mesChiens[i].AfficherCaracteristique());
            }
        }
    }
}