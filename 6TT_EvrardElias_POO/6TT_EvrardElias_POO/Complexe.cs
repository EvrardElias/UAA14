using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TT_EvrardElias_POO
{
    class Complexe
    {
        private double _reele;
        private double _imaginaire;
        public Complexe(double reele, double imaginaire)
        {
            _reele = reele;
            _imaginaire = imaginaire;
        }

        public double Reele
        {
            get { return _reele; }
            set { _reele = value; }
        }

        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }

        public double CalculeModule()
        {
            double module = Math.Sqrt(Reele*Reele + Imaginaire*Imaginaire);
            return module;
        }

        public double Ajoute(Complexe nbAAjouter)
        {
            _reele = _reele + nbAAjouter._reele;
            _imaginaire = _imaginaire + nbAAjouter._imaginaire;
            return _reele;
            return _imaginaire;
        }

        public string AfficheComplexe()
        {
            string complexe = "( " + Reele + " , " + Imaginaire + " ) ";
            return complexe;
        }
    }
}
