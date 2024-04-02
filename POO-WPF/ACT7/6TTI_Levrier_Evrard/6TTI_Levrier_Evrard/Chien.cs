using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _6TTI_Levrier_Evrard
{
    class Chien
    {
        private int _longueurPiste;
        private int _numChien;
        private Image _imageChien;
        private int[] _positionCourante;
        private bool _gagne;

        public Chien (int longueurPiste, int numChien, Image imageChien, int[] positionCourante, bool gagne)
        {
            _longueurPiste = longueurPiste;
            _numChien = numChien;
            _imageChien = imageChien;
            _positionCourante = positionCourante;
            _gagne = gagne;
        }

        public int LongueurPiste
        {
            get { return _longueurPiste; }
            set { _longueurPiste = value; }
        }

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        public Image ImageChien
        {
            get { return _imageChien; }
            set { _imageChien = value; }
        }

        public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }

        public bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }
    }
}
