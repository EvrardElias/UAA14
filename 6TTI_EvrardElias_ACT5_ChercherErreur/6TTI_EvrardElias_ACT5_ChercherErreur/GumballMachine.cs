using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_EvrardElias_ACT5_ChercherErreur
{
    class GumballMachine
    {
        private int _gumballs;
        private int _price;

        public int Price
        {
            get
            {
                return _price;
            }
        }

        public GumballMachine(int gumballs, int price)
        {
            this._gumballs = gumballs;
            _price = price;
        }

        public string DispenseOneGumball(int coinsInserted)
        {
                if (coinsInserted >= _price)
                {
                    _gumballs -= 1;
                    return "Voici votre gomme !";
                }
                else
                {
                    return "Pas assez de pièces !";
                }
        }
    }
}
