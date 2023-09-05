using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien
{
    class Chien
    {
        private string _nom;
        private uint _age;
        private string _race;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private string _genre;
        private bool _sterilise;
        private string _poils;
        private string _paysOrigine;
        private string _proprietaire;
        private bool _dresse;

        public Chien (string nom, uint age, string race,  bool enOrdreDeVaccin, bool puce, string genre, bool sterilise, string poils, string paysOrigine, string proprietaire, bool dresse)
        {
            _nom = nom;
            _age = age;
            _race = race;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _genre = genre;
            _sterilise = sterilise;
            _poils = poils;
            _paysOrigine = paysOrigine;
            _proprietaire = proprietaire;
            _dresse = dresse;
        }

        public string AfficherCaracteristique ()
        {
            string chaine = "Nom : " + _nom + " - Age : " + _age + " - Race : " + _race + " - En ordre de vaccin : " + _enOrdreDeVaccin + " - Puce : " + _puce + " - Genre : " + _genre + " - Sterilise : " + _sterilise + " - Poils : " + _poils + " - Pays d'origine : " + _paysOrigine + " - Proprietaire : " + _proprietaire + " - Dresser : " + _dresse + ".";
            return chaine;
        }
    }
}
