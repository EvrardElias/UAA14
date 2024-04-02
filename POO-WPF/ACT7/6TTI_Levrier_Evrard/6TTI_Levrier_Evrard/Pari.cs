using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace _6TTI_Levrier_Evrard
{
    class Pari
    {
        private int _montant;
        private int _numChien;

        public Pari (int montant, int numChien)
        {
            _montant = montant;
            _numChien = numChien;
        }

        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }
        }

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }
    }
}
