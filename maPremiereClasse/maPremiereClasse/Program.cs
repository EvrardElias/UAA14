namespace Chien 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("première méthode");
            Chien chien1 = new Chien("Nelson", 10, "Golden Rotriever", false, false, "Male", false, "Doré", "Belgique", "Romane Grootaers", false);
            Chien chien2 = new Chien("James", 7, "Cavalier King Charles", false, false, "Male", false, "Brun", "Belgique", "Romane Grootaers", false);
            Chien chien3 = new Chien("Djo", 12, "Berger Allemand", false, false, "Male", false, "Brun", "Belgique", "Elias Evrard", false);

            Console.WriteLine(chien1.AfficherCaracteristique());
            Console.WriteLine(chien2.AfficherCaracteristique());
            Console.WriteLine(chien3.AfficherCaracteristique());
        }
    }
}