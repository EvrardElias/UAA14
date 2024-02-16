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

namespace _6TTI_Damiers_Evrard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Damier();
        }
         public void Damier()
        {
            ColumnDefinition[] colonne = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                colonne[i] = new ColumnDefinition();
            }

            for (int i = 0; i < 10; i++)
            {
                damier.ColumnDefinitions.Add(colonne[i]);
            }

            RowDefinition[] ligne = new RowDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                ligne[i] = new RowDefinition();
            }

            for (int i = 0; i < 10; i++)
            {
                damier.RowDefinitions.Add(ligne[i]);
            }

            Button[,] btn = new Button[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int m = 0; m < 10; m++)
                {
                    btn[i, m] = new Button();
                    Grid.SetColumn(btn[i, m], m);
                    Grid.SetRow(btn[i, m], i);
                    btn[i, m].Height = 65;
                    btn[i, m].Width = 65;
                    int nombreCase = i*10 + m+1;
                    btn[i, m].Content = nombreCase.ToString();
                    if (i %2 == 0)
                    {
                        if (nombreCase %2 == 0)
                        {
                            btn[i,m].Background = Brushes.Black;
                        }
                        else
                        {
                            btn[i,m].Background= Brushes.White;
                        }
                    }
                    else
                    {
                        if (nombreCase % 2 == 0)
                        {
                            btn[i, m].Background = Brushes.White;
                        }
                        else
                        {
                            btn[i, m].Background = Brushes.Black;
                        }
                    }

                    btn[i,m].FontWeight = FontWeights.Bold;
                    btn[i,m].Foreground = Brushes.Red;
                    damier.Children.Add(btn[i, m]);
                }
            }
        }
    }
}
