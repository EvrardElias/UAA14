using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MatchingGame_Evrard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock derniereTBClique;
        bool trouvePaire = false;
        DispatcherTimer timer = new DispatcherTimer();
        int tempsEcoule = 0;
        int nbPaireTrouvees = 0;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += new EventHandler(Timer_Tick);
            SetUpGame();
        }

        private void SetUpGame()
        {
            tempsEcoule = 0;
            nbPaireTrouvees = 0;
            timer.Start();


            List<string> animalEmoji = new List<string>()
                {
                    "🦄","🦄",
                    "🦁","🦁",
                    "🐵","🐵",
                    "🐭","🐭",
                    "🐶","🐶",
                    "🐺","🐺",
                    "🐱","🐱",
                    "🐷","🐷",
                };

            foreach (TextBlock textblock in grdMain.Children.OfType<TextBlock>())
            {
                int index;
                textblock.Visibility = Visibility.Visible;
                Random nbAlea = new Random();
                string nextEmoji;
                if (textblock.Name != "txtTemps")
                {
                    index = nbAlea.Next(animalEmoji.Count);
                    nextEmoji = animalEmoji[index];
                    textblock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index); //On retire un animal de la liste pour ne pas l'attribuer à nouveau
                }
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            if (!trouvePaire)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                derniereTBClique = textBlockActif;
                trouvePaire = true;
            }
            else if (textBlockActif.Text == derniereTBClique.Text)
            {
                nbPaireTrouvees++;
                textBlockActif.Visibility = Visibility.Hidden;
                trouvePaire = false;
            }
            else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouvePaire = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempsEcoule++;
            txtTemps.Text = (tempsEcoule / 10F).ToString("0.0s");
            if (nbPaireTrouvees == 8)
            {
                timer.Stop();
                txtTemps.Text = txtTemps.Text + " - Rejouer ? ";
            }
        }

        private void txtTemps_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (nbPaireTrouvees == 8)
            {
                SetUpGame();
            }
        }

    }
}
