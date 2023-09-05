using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            MethodesDuProjet MesOutils = new MethodesDuProjet();
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                lireDouble(1);
                lireDouble(2);
                lireDouble(3);
                MesOutils.OrdonneCotes(ref c1, ref c2, ref c3);

                // série de test (voir consignes)
                if (MesOutils.Triangle(c1, c2, c3))
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    MesOutils.Affiche(ok, "triangle", out rep);
                    Console.WriteLine(rep);

                    // vérification équilatéral
                    if (MesOutils.Equi(c1, c2, c3))
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        MesOutils.Affiche(ok, "equilateral", out rep);
                        Console.WriteLine(rep);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (MesOutils.TriangleRectangle(c1, c2, c3))
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            MesOutils.Affiche(ok, "rectangle", out rep);
                            Console.WriteLine(rep);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            MesOutils.Affiche(ok, "rectangle", out rep);
                            Console.WriteLine(rep);
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        MesOutils.Isocele(c1, c2, c3, ok);
                        if (ok == true)
                        {
                            MesOutils.Affiche(ok, "isocele", out rep);
                            Console.WriteLine(rep);
                        }
                       
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    MesOutils.Affiche(ok, "triangle", out rep);
                    Console.WriteLine(rep);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
