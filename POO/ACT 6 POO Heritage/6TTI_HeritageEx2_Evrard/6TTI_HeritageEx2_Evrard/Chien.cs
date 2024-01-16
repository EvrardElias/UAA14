using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx2_Evrard
{
    class Chien : Animal
    {
        public Chien(string nom, DateTime naissance, uint puce, uint taille, bool concours) : base(nom, naissance, puce, taille, concours)
        {
        }

        public string Aboyer()
        {
            string aboyement = "Woaf";
            return aboyement;
        }
    }
}
