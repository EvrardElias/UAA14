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

        public Shaker(double contenanceMax, List<Portion> contenu, bool propre) 
        {
            _contenanceMax = contenanceMax;
            _contenu = contenu;
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

        }

        //Ajouter dans le shaker une portion
        public void AjouterPortion(Portion portion)
        {

        }

        //Ajouter un message
        public string MelangerContenu()
        {

        }

        //Remise à zero du shaker et fini sale
        public void Vider()
        {

        }

        //Laver le shaker apres utilisation
        public string Laver()
        {

        }
    }
}
