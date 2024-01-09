using System.Globalization;

namespace _6TTI_HeritageEx1_Evrard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Vehicule monVehicule = new Vehicule("Megan", "Renault", "Gris", 5000);
            string info = monVehicule.Afficher();
            Console.WriteLine(info);

            Vélo monVelo = new Vélo("VTT", false, "BMC", "Tandem", "Rouge", 300);
            info = monVelo.Afficher();
            Console.WriteLine(info);

            Voiture maVoiture = new Voiture("Diesel", false, "206", "Peugeot", "Jaune", 3000);
            info = maVoiture.Afficher();
            Console.WriteLine(info);
        }
    }
}