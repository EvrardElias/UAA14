using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace _6TTI_Act4CreationDynamiqueObjet_Evrard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreerGrille();
        }

        public void CreerGrille()
        {
            ColumnDefinition[] colonne = new ColumnDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                colonne[i] = new ColumnDefinition();
            }

            for (int i = 0; i < 3; i++)
            {
                grd.ColumnDefinitions.Add(colonne[i]);
            }

            RowDefinition[] ligne = new RowDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                ligne[i] = new RowDefinition();
            }

            for (int i = 0; i < 3; i++)
            {
                grd.RowDefinitions.Add(ligne[i]);
            }

            TextBlock txtBlock = new TextBlock();
            Grid.SetRow(txtBlock, 0);
            Grid.SetColumnSpan(txtBlock, 2);
            txtBlock.Text = "TextBlock créé dynamiquement";
            txtBlock.FontFamily = new FontFamily("Georgia");
            txtBlock.Foreground = Brushes.Red;
            txtBlock.FontSize = 18;
            txtBlock.Height = 50;
            txtBlock.Background = Brushes.Yellow;
            grd.Children.Add(txtBlock);

            Button[] btn = new Button[3];
            for (int i = 0; i < 3; i++)
            {
                btn[i] = new Button();
                Grid.SetRow(btn[i], 1);
                Grid.SetColumn(btn[i], i);
                btn[i].Content = "Bouton" + i;
                btn[i].Height = 150;
                btn[i].Width = 150;
                grd.Children.Add(btn[i]);
               
            }

            StackPanel stackP = new StackPanel();
            Grid.SetRow(stackP, 3);
            Grid.SetColumnSpan(stackP, 2);
            TextBlock texteB = new TextBlock();
            texteB.Text = "Bonjour le monde";
            texteB.Background = Brushes.Yellow;
            texteB.Height = 50;
            stackP.Children.Add(texteB);
            TextBox zoneT = new TextBox();
            stackP.Children.Add(zoneT);
            grd.Children.Add(stackP);

            ComboBox comboB = new ComboBox();
            comboB.Items.Add("Bonjour");
            comboB.Items.Add("Au revoir");
            comboB.Height = 50;
            comboB.Width = 150;
            Grid.SetRow(comboB, 2);
            Grid.SetColumn(comboB, 2);
            grd.Children.Add(comboB);
        }
    }
}
