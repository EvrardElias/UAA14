using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_Evrard
{
    internal class FeuxDeSignalisation
    {
        private int _couleur = 0;
        private string _identifiant = "1001";

        public FeuxDeSignalisation(int couleur, string identifiant)
        {
            _couleur = couleur;
            _identifiant = identifiant;
        }
        public int Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public string Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }

        public int Change()
        {
            int couleur;
            if (_couleur == 0)
            {
                couleur = 1;
            }
            else if (_couleur == 1)
            {
                couleur = 2;
            }
            else
            {
                couleur = 0;
            }
            return couleur;
        }

        public string AfficheEtat()
        {
            string etat = "Le feu de signalisation " + _identifiant + "est" + Change() + ".";
            return etat;
        }

        public void Clignote(int frequence)
        {
            for (int i = 0; i < frequence; i++)
            {

            }
        }
    }
}
