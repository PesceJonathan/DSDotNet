using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSJonathanPesce.Models
{
    public class Produit
    {
        private String nom;
        private int type;
        private double prix;

        public Produit(String n, int t, double p)
        {
            nom = n;
            type = t;
            prix = p;
        }

        public String LeNom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int LeType
        {
            get { return type; }
            set { type = value; }
        }
        public double LePrix
        {
            get { return prix; }
            set { prix = value; }
        }
        public String toString()
        {
            String info;
            switch (type)
            {
                case 1:
                    info = " le jeu ";
                    break;
                case 2:
                    info = " la figurine ";
                    break;
                case 3:
                    info = " le poster ";
                    break;
                default:
                    info = " type inconnu ";
                    break;
            }
            return info + nom + " coute " + prix + " euros";
        }
    }
}