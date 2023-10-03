// See https://aka.ms/new-console-template for more information
using _6TT_EvrardElias_POO;
using System.Runtime.CompilerServices;

bool recommencer;
do
{
    Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
    Console.WriteLine("Tapez un rayon pour votre cercle.");
    float rayon = float.Parse(Console.ReadLine());

    Cercle monCercle = new Cercle(rayon);
    Console.WriteLine(monCercle.AfficherCalcul());

    Console.WriteLine("Avec un cercle de rayon diminué de moitié :\n-------------------------------");
    monCercle = new Cercle(rayon/2);
    Console.WriteLine(monCercle.AfficherCalcul());
    Console.WriteLine("Voulez-vous recommencer avec les cercles ? (V/F)");
    string reponse = Console.ReadLine();
    if (reponse == "V")
    {
        recommencer = true;
    }
    else
    {
        recommencer = false;
    }
} while (recommencer == true);
do
{
    Console.WriteLine("Bienvenue dans ce programme sur les complexes !");

    Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
    double reele = double.Parse(Console.ReadLine());
    Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
    double imaginaire = double.Parse(Console.ReadLine());
    Complexe monComplexe = new Complexe(reele, imaginaire);
    Console.WriteLine("Le premier complexe : " + monComplexe.AfficheComplexe() + " a pour module : " + monComplexe.CalculeModule());

    Console.WriteLine("Encodez un second nombre complexe :");

    Console.WriteLine("Que vaut la partie réelle du second complexe ?");
    reele = double.Parse(Console.ReadLine());
    Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
    imaginaire = double.Parse(Console.ReadLine());
    monComplexe = new Complexe(reele, imaginaire);
    Console.WriteLine("Le second complexe est : " + monComplexe.AfficheComplexe());
    Console.WriteLine("Le premier complexe devient : " + )

    Console.WriteLine("Voulez-vous recommencer avec les complexes ? (V/F)");
    string reponse = Console.ReadLine();
    if (reponse == "V")
    {
        recommencer = true;
    }
    else
    {
        recommencer = false;
    }
} while (recommencer == true);

