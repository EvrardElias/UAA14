namespace _6TTI_Bar_Evrard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barman barman = new Barman("jayson");
            Shaker shaker = new Shaker(25, true);

            List<Liquide> liquides = new List<Liquide>()
            {
                new Liquide("Coca", "Soft"), //0
                new Liquide("Sprite", "Soft"), //1
                new Liquide("Fanta", "Soft"), //2
                new Liquide("Red Bull", "Soft"), //3
                new Liquide("Vodka", "Spiritueux"), //4
                new Liquide("Rhum Blanc", "Spiritueux"), //5
                new Liquide("Rhum Brun", "Spiritueux"), //6
                new Liquide("Rhum Ambré", "Spiritueux"), //7
                new Liquide("Whiskey", "Spiritueux"), //8
                new Liquide("Gin", "Spiritueux"), //9
                new Liquide("Tequila", "Spiritueux"), //10
                new Liquide("Pisang", "Liqueur"), //11
                new Liquide("Amaretto", "Liqueur"), //12
                new Liquide("Baileys", "Liqueur"), //13
                new Liquide("Cointreau", "Liqueur"), //14
                new Liquide("Curaçao bleu", "Liqueur"), //15
                new Liquide("Kahlùa", "Liqueur"), //16
                new Liquide("Limoncello", "Liqueur"), //17
                new Liquide("Malibu", "Liqueur"), //18
                new Liquide("Röteli", "Liqueur"), //19
                new Liquide("Aperol", "Liqueur"), //20
                new Liquide("Campari", "Liqueur"), //21
                new Liquide("Ramazotti", "Liqueur"), //22
                new Liquide("Jus d'ananas", "Soft"), //23
                new Liquide("Lait de coco", "Soft"), //24
                new Liquide("Jus de citron vert", "Soft"), //25
                new Liquide("Triple sec", "Liqueur"), //26
                new Liquide("Jus de Cranberry", "Soft"), //27
                new Liquide("Eau Gazeuse", "Soft"), //28
                new Liquide("Jus de citron", "Soft"), //29
                new Liquide("Jus de pamplemousse", "Soft"), //30
            };

            List<Bouteille> bouteilles = new List<Bouteille>();
            for (int i = 0; i < liquides.Count; i++)
            {
                bouteilles.Add(new Bouteille(liquides[i], 75));
            }

            Bar bar = new Bar(bouteilles);

            List<Portion> portionsPinaColada = new List<Portion>()
            {
                new Portion(liquides[5], 4),
                new Portion(liquides[7], 2),
                new Portion(liquides[23], 12),
                new Portion(liquides[24], 4),
            };
            Recette pinaColada = new Recette(portionsPinaColada);

            List<Portion> portionsMargarita = new List<Portion>()
            {
                new Portion(liquides[10], 5),
                new Portion(liquides[26], 3),
                new Portion(liquides[25], 2),
            };
            Recette margarita = new Recette(portionsMargarita);

            List<Portion> portionsCosmopolitain = new List<Portion>()
            {
                new Portion(liquides[4], 4),
                new Portion(liquides[26], 2),
                new Portion(liquides[27], 2),
                new Portion(liquides[25], 1),
            };
            Recette cosmopolitain = new Recette(portionsCosmopolitain);

            List<Portion> portionsLimeRickey = new List<Portion>()
            {
                new Portion(liquides[9], 3),
                new Portion(liquides[4], 3),
                new Portion(liquides[28], 11),
                new Portion(liquides[25], 3),
            };
            Recette limeRickey = new Recette(portionsLimeRickey);

            List<Portion> portionsTropicalStar = new List<Portion>()
            {
                new Portion(liquides[29], 2),
                new Portion(liquides[30], 2),
                new Portion(liquides[26], 1),
                new Portion(liquides[15], 0.5),
            };
            Recette tropicalStar = new Recette(portionsTropicalStar);

            List<Cocktail> cocktails = new List<Cocktail>()
            {
                new Cocktail("Piña Colada", pinaColada),
                new Cocktail("Margarita", margarita),
                new Cocktail("Cosmopolitain", cosmopolitain),
                new Cocktail("Lime Rickey", limeRickey),
                new Cocktail("Tropical Star", tropicalStar),
            };

            Console.WriteLine("Bonjour, je m'appelle " + barman.Prenom + " et je serais votre serveur aujourd'hui.");
            Console.WriteLine("Que souhaitez-vous commander ?");

            string recettes = "";

            for (int i = 0; i < cocktails.Count; i++)
            {
                recettes += cocktails[i].AfficherRecette();
            }
            int commande = barman.Commander(recettes, cocktails.Count);

            bool fabrication = barman.Fabriquer(cocktails[commande - 1], shaker, bar);
            string servir = barman.Servir(cocktails[commande - 1], fabrication, ref shaker);
            Console.WriteLine(servir);
        }
    }
}