using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Shaker
    {
        private double _contenanceMax;
        private List<Portion> _contenu;
        private bool _propre;

        public Shaker(double contenanceMax, bool propre) 
        {
            _contenanceMax = contenanceMax;
            _contenu = new List<Portion>();
            _propre = propre;
        }

        public double ContenanceMax
        {
            get { return _contenanceMax; }
        }

        public List<Portion> Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public bool Propre
        {
            get { return _propre; }
            set { _propre = value; }
        }

        //Combien il y a dans le shaker
        public double CalculQuantiteContenu()
        {
            double quantite = 0;
            foreach (Portion contenu in Contenu)
            {
                quantite += quantite + contenu.Quantite * 0.2;
            }
            return quantite;
        }

        //Ajouter dans le shaker une portion
        public void AjouterPortion(Portion portion)
        {
            _contenu.Add(portion);
            _propre = false;
        }

        //Ajouter un message
        public string MelangerContenu()
        {
            return "Shaker secoué => Contenu mélanger";
        }

        //Remise à zero du shaker et fini sale
        public void Vider()
        {
            
            _contenu = new List<Portion>();
        }

        //Laver le shaker apres utilisation
        public string Laver()
        {
            _propre = true;
            return "Shaker lavé => Shaker réutilisable";
        }
    }
}
