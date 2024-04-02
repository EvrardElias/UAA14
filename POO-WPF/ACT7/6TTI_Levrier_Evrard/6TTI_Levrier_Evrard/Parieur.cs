using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _6TTI_Levrier_Evrard
{
    class Parieur
    {
        private string _nom;
        private Pari _monPari;
        private int _cash;
        private TextBlock _textBlockEtatPari;

        public Parieur (string nom, Pari monPari, int cash, TextBlock textBlockEtatpari)
        {
            _nom = nom;
            _monPari = monPari;
            _cash = cash;
            _textBlockEtatPari = textBlockEtatpari;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public TextBlock TextBlockEtatpari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }
    }
}
