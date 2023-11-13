using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TT_EvrardElias_ACT3_Elephants
{
    class Elephant
    {
        private string _nom;
        private uint _tailleOreilles;

        public Elephant(string nom, uint tailleOreille)
        {
            _nom = nom;
            _tailleOreilles = tailleOreille;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public uint TailleOreilles
        {
            get { return _tailleOreilles; }
            set { _tailleOreilles = value; }
        }

        public string AfficheQuiJeSuis ()
        {
            string chaine = "Je m'appelle " + _nom + ".\nMes oreilles mesurent " + _tailleOreilles + "cm.";
            return chaine;
        }

        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message\n" + quiDit._nom + " a dit : " + message);
        }

        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }
    }
}
