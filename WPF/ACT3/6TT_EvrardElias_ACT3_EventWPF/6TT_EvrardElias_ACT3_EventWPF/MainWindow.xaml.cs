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

namespace _6TT_EvrardElias_ACT3_EventWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            BtnCalculer.MouseEnter += new MouseEventHandler(BtnCalculer_MouseEnter);
            BtnCalculer.MouseLeave += new MouseEventHandler(BtnCalculer_MouseLeave);
            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);
        }

        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            double c;
            double x1 = 0;
            double x2 = 0;
            char type;
            string message;
            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
            {
                MehodeDuProjet mesOutils = new MehodeDuProjet();
                mesOutils.ResoudTrinome(a, b, c, ref x1, ref x2, out type);
                if (type == '2')
                {
                    message = $"Il y a deux solutions : {x1} et {x2}.";
                }
                else if (type == '1')
                {
                    message = $"Il y a deux solutions : {x1}.";
                }
                else
                {
                    message = $"Il n'y a aucune solution réelle.";
                }
            }
        }

        private void BtnCalculer_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Hidden;
        }

        private void BtnCalculer_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Visible;
            BtnV.Background = Brushes.Red;
        }

        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
            {
                e.Handled = true;
            }
        }

        private bool EstEntier(string texteUser)
        {
            bool entier = false;
            if (int.TryParse(texteUser, out int chiffre))
            {
                entier = true;
            }
            return entier;
        }
    }
}
