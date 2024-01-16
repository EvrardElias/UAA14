// See https://aka.ms/new-console-template for more information
using I2P623_Evrard;

FeuxDeSignalisation feux = new FeuxDeSignalisation();

Console.WriteLine("Etat des feux :\n---------------");
Console.WriteLine(feux.AfficheEtat());

Console.WriteLine("Changement d'état :\n---------------");
Console.WriteLine(feux.AfficheEtat());

Console.WriteLine("Faire passer le 007 à l'orange :\n---------------");
Console.WriteLine(feux.AfficheEtat());

Console.WriteLine("Feu clignotant :\n---------------");
Console.WriteLine(feux.Clignote);