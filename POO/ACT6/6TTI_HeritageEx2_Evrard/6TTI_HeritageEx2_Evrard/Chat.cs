using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx2_Evrard
{
    internal class Chat : Animal
    {
        public Chat(string nom, DateTime naissance, uint puce, uint taille, bool concours) : base(nom, naissance, puce, taille, concours)
        {
        }

        public string Miauler()
        {
            string miaulement = "Miaou";
            return miaulement;
        }

    }
}
