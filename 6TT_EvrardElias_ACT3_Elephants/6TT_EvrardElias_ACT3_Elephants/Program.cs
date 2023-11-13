// See https://aka.ms/new-console-template for more information
using _6TT_EvrardElias_ACT3_Elephants;

Elephant elephant1 = new Elephant("Titi", 100);

Elephant elephant2 = new Elephant("Zazou", 82);

Elephant elephantX;

Console.WriteLine("Bienvenue dans cet échange d'éléphants");
Console.WriteLine("Tapez :\n1 : Pour afficher les informations de Zazou\n2 : Pour afficher les informations de Titi\n3 : Pour échanger les informations\n4 : Pour voir le transfert d'un message de Zazou à Titi\n5 : Pour réviser la notion de tableaux et l'appliquer à des objets");
int choixMenu = int.Parse(Console.ReadLine());

if (choixMenu == 1)
{
    Console.WriteLine(elephant2.AfficheQuiJeSuis());
}
else  if (choixMenu == 2)
{
    Console.WriteLine(elephant1.AfficheQuiJeSuis());
}
else if (choixMenu == 3)
{
    elephantX = elephant1;
    elephant1 = elephant2;
    elephant2 = elephantX;
    Console.WriteLine(elephant1.AfficheQuiJeSuis());
    Console.WriteLine(elephant2.AfficheQuiJeSuis());
}
else if (choixMenu == 4)
{
    elephant1.EcouteMessage("Coucou Titi", elephant2);
}
else if (choixMenu == 5)
{
    
}