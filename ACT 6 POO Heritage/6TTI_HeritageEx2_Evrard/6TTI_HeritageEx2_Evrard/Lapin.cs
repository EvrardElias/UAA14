using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx2_Evrard
{
    class Lapin : Animal
    {
        private uint _tailleOreille;

		public uint TailleOreille
		{
			get { return _tailleOreille; }
			set { _tailleOreille = value; }
		}

		public Lapin(uint tailleOreille, string nom, DateTime naissance, uint puce, uint taille, bool concours) : base(nom, naissance, puce, taille, concours)
		{
			_tailleOreille = tailleOreille;
		}

		public override string AfficherInfo()
		{
            string info = "Nom: " + Nom + "\nDate de naissance: " + Naissance + "\nNumero de la puce: " + Puce + "\nTaille: " + Taille + "\nConcour t-il ?" + Concours + "\nTaille des oreilles:" + TailleOreille;
			return info;
        }

		public string Bondir()
		{
			string bond = "Boing";
			return bond;
		}
    }
}
