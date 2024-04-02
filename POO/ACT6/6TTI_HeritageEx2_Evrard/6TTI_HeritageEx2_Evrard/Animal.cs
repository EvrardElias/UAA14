using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx2_Evrard
{
    class Animal
    {
		private string _nom;
		private DateTime _naissance;
		private uint _puce;
		private uint _taille;
		private bool _concours;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		public DateTime Naissance
		{
			get { return _naissance; }
		}

		public uint Puce
		{
			get { return _puce; }
			set { _puce = value; }
		}

		public uint Taille
		{
			get { return _taille; }
			set { _taille = value; }
		}

		public bool Concours
		{
			get { return _concours; }
			set { _concours = value; }
		}

		public Animal(string nom, DateTime naissance, uint puce, uint taille, bool concours)
		{
			_nom = nom;
			_naissance = naissance;
			_puce = puce;
			_taille = taille;
			_concours = concours;
		}

		public virtual string AfficherInfo()
		{
			string info = "Nom: " + Nom + "\nDate de naissance: " + Naissance + "\nNumero de la puce: " + Puce + "\nTaille: " + Taille + "\nConcour t-il ?" + Concours;
			return info;
		}

		public string Manger()
		{
			string mange = _nom + " mange quelque chose de bon...Enfin je suppose.";
			return mange;
		}

		public string Dormir()
		{
			string dormir = _nom + " fait de très beau rêve.";
			return dormir;
		}
	}
}
