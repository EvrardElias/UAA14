namespace CeUAA14Partie2_dec23_EvrardElias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint nombreBalles = 30;
            uint chargeur = 0;
            PaintBallGun ball = new PaintBallGun(nombreBalles, chargeur);
            string option = "";
            bool continuer = true;

            Console.WriteLine("Bienvenue dans ce jeu de tir . . . Vous démarrez avec 30 balles\n===============================================================");
            do
            {
                Console.WriteLine("Vous avez un total de " + ball.NombreBalles + " dans votre poche et " + ball.Chargeur + " balles dans le chargeur");
                if (ball.Chargeur == 0)
                {
                    Console.WriteLine("Attention votre chargeur est vide");
                }
                Console.WriteLine("[Espace] pour tirer,\n[r] pour recharger,\n[+] pour reprendre des munitions,\n[q] pour quitter");
                option = Console.ReadLine();
                if (option == " ")
                {
                    Console.WriteLine(ball.Tirer());
                    continuer = true;
                }
                else if (option == "r")
                {
                    Console.WriteLine(ball.Recharger());
                    continuer = true;
                }
                else if (option == "+")
                {
                    Console.WriteLine(ball.NouvelleMunition());
                    continuer = true;
                }
                else if (option == "q")
                {
                    Console.WriteLine("Au revoir soldat !");
                    continuer = false;
                }
            } while (continuer == true);
            
        }
    }
}