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

namespace _6TTI_DamiersEx3_Evrard
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
            for (int i = 0; i < 8; i++)
            {
                colonne[i] = new ColumnDefinition();
            }

            for (int i = 0; i < 8; i++)
            {
                damier.ColumnDefinitions.Add(colonne[i]);
            }

            RowDefinition[] ligne = new RowDefinition[10];
            for (int i = 0; i < 8; i++)
            {
                ligne[i] = new RowDefinition();
            }

            for (int i = 0; i < 8; i++)
            {
                damier.RowDefinitions.Add(ligne[i]);
            }

            Button[,] btn = new Button[10, 10];
            for (int i = 0; i < 8; i++)
            {
                for (int m = 0; m < 8; m++)
                {
                    btn[i, m] = new Button();
                    Grid.SetColumn(btn[i, m], m);
                    Grid.SetRow(btn[i, m], i);
                    btn[i, m].Height = 85;
                    btn[i, m].Width = 85;
                    int nombreCase = i * 10 + m + 1;

                    if ((i == 0 && m == 3) || (i == 7 && m == 3))
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/k.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        btn[i, m].Content = imBouton;
                    }
                    else if ((i == 0 && m == 2) || (i == 7 && m == 2) || (i == 0 && m == 5) || (i == 7 && m == 5))
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/b.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        btn[i, m].Content = imBouton;
                    }
                    else if ((i == 0 && m == 0) || (i == 7 && m == 0) || (i == 0 && m == 7) || (i == 7 && m == 7))
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/t.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        btn[i, m].Content = imBouton;
                    }
                    else if ((i == 0 && m == 1) || (i == 7 && m == 1) || (i == 0 && m == 6) || (i == 7 && m == 6))
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        btn[i, m].Content = imBouton;
                    }
                    else if ((i == 0 && m == 4) || (i == 7 && m == 4))
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/q.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        btn[i, m].Content = imBouton;
                    }
                    else if (i == 1 || i == 6)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/p.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        btn[i, m].Content = imBouton;
                    }

                    if (i % 2 == 0)
                    {
                        if (nombreCase % 2 == 0)
                        {
                            btn[i, m].Background = Brushes.Black;
                        }
                        else
                        {
                            btn[i, m].Background = Brushes.White;
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
                    damier.Children.Add(btn[i, m]);
                }
            }
        }
    }
}
