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
            txtA.PreviewTextInput += new
            TextCompositionEventHandler(VerifTextInput);

            private bool EstEntier(string texteUser)
            {
                bool entier = true;
                entier = bool.TryParse(Console.ReadLine());
                return entier;
            }
        }
    }
}
