using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_EvrardElias
{
    class PaintBallGun
    {
        private uint _nombreBalles;
        private uint _chargeur;

        public PaintBallGun(uint nombreBalles, uint chargeur)
        {
            _chargeur = chargeur;
            _nombreBalles = nombreBalles;
        }

        public uint NombreBalles
        {
            get { return _nombreBalles; }
            set { _nombreBalles = value;}
        }

        public uint Chargeur
        {
            get { return _chargeur; }
            set { _chargeur = value;}
        }

        public string Tirer()
        {
            string chaine;
            if (Chargeur == 0)
            {
                chaine = "Vous essayez de tirer mais rien ne se passe. Peut-être faut-il recharger l'arme avant de tirer ?";
            }
            else
            {
                Chargeur = Chargeur - 1;
                chaine = "BAM! Vous avez réussi à tirer!";
            }
            return chaine;
        }

        public string Recharger()
        {
            string chaine;
            int balleDonne = 0;
            if (NombreBalles == 0)
            {
                chaine = "STUPEFACTION! Vous vous rendez compte que vous avez oubliez de prendre des munitions.";
            }
            else if (Chargeur == 16 )
            {
                chaine = "Malgré que le chargeur soit plein vous essayez quand même de mettre une balle. Vous n'y arriver pas et vous abandonnez";
            }
            else
            {
                do
                {
                    Chargeur = Chargeur + 1;
                    NombreBalles = NombreBalles - 1;
                    balleDonne = balleDonne + 1; 
                } while (Chargeur < 16 && NombreBalles > 0);
                chaine = "Recharge de " + balleDonne + " dans le chargeur effectuée";
            }
            return chaine;
        }

        public string NouvelleMunition()
        {
            string chaine;
            NombreBalles = NombreBalles + 30;
            chaine = "Vous venez de faire l'acquisition de 30 magnifiques munition que vous garder précieusement dans votre poche";
            return chaine;
        }
    }
}
