// See https://aka.ms/new-console-template for more information
using _6TT_EvrardElias_POO;

Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
Console.WriteLine("Tapez un rayon pour votre cercle.");
float rayon = float.Parse(Console.ReadLine());

Cercle monCercle = new Cercle(rayon);
Console.WriteLine(monCercle.AfficherCalcul());