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

namespace _6TTI_ACT4CreationDynamiqueObjetEx2_Evrard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MatchingGame();
        }

        public void MatchingGame()
        {
            ColumnDefinition[] colonne = new ColumnDefinition[4];
            for (int i = 0; i < 4; i++)
            {
                colonne[i] = new ColumnDefinition();
            }

            for (int i = 0; i < 4; i++)
            {
                grd.ColumnDefinitions.Add(colonne[i]);
            }

            RowDefinition[] ligne = new RowDefinition[4];
            for (int i = 0; i < 4; i++)
            {
                ligne[i] = new RowDefinition();
            }

            for (int i = 0; i < 4; i++)
            {
                grd.RowDefinitions.Add(ligne[i]);
            }

            TextBlock[,] txtBlock = new TextBlock[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int m = 0; m < 4; m++)
                {
                    txtBlock[i,m] = new TextBlock();
                    Grid.SetColumn(txtBlock[i,m], m);
                    Grid.SetRow(txtBlock[i, m], i);
                    txtBlock[i, m].Text = "?";
                    grd.Children.Add(txtBlock[i, m]);
                }
            }
        }

    }
}
