﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_HeritageEx1_Evrard
{
    class Vehicule
    {
        protected string _marque;
        protected string _modele;
        protected string _couleur;
        protected decimal _prix;

        public string Marque
        {
            get
            {
                return _marque;
            }
        }

        public string Modele
        {
            get
            {
                return _modele;
            }
            set
            {
                _modele = value;
            }
        }

        public string Couleur
        {
            get 
            { 
                return _couleur;
            }
            set 
            { 
                _couleur = value;
            }
        }

        public decimal Prix
        {
            get 
            { 
                return _prix; 
            }
            set 
            { 
                _prix = value; 
            }
        }
        public Vehicule(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }

        public virtual string Afficher()
        {
            string info = "Votre vehicule est de marque et modèle " + Marque + " " + Modele + " de couleur " + Couleur + " qui vaut " + Prix + " euro";
            return info;
        }
    }
}