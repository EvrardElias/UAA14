namespace _6TTI_HeritageEx2_Evrard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes animaux !");

            Animal[] mesAnimaux = new Animal[5];

            mesAnimaux[0] = new Chat("Aïko", DateTime.Parse("10/06/2020"), 178569, 30, false);
            mesAnimaux[1] = new Chat("Vodka", DateTime.Parse("05/08/2017"), 850417, 38, false);
            mesAnimaux[2] = new Lapin(35, "Bugs", DateTime.Parse("27/07/1940"), 071940, 142, true);
            mesAnimaux[3] = new Chien("Milou", DateTime.Parse("10/01/1929"), 011929, 45, true);
            mesAnimaux[4] = new Chien("Djo", DateTime.Parse("21/07/2005"), 456879, 65, false);

            for (int i = 0; i < mesAnimaux.Length; i++)
            {
                Console.WriteLine(mesAnimaux[i].AfficherInfo());
                Console.WriteLine(mesAnimaux[i].Manger());

                if (mesAnimaux[i] is Chat chat)
                {
                    Console.WriteLine(chat.Miauler());
                }
                else if (mesAnimaux[i] is Lapin lapin)
                {
                    Console.WriteLine(lapin.Bondir());
                }
                else if (mesAnimaux[i] is Chien chien)
                {
                    Console.WriteLine(chien.Aboyer());
                }
            }
        }
    }
}