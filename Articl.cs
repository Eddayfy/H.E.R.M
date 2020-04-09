using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Articl
    {
        int ID_Articl;
        string Nom_Articl;
        double Prix_Articl;
        int Quantite_Articl;
        public Articl()
        { }
        public Articl(int id,string nom,double prix,int quantite)
        {
            this.ID_Articl = id;
            this.Nom_Articl = nom;
            this.Prix_Articl = prix;
            this.Quantite_Articl = quantite;
        }
        public int ID_Articl_
        {
            get {return ID_Articl ;}
            set { ID_Articl=value;}
        }
        public string Nom_Articl_
        {
            get {return Nom_Articl;}
            set {Nom_Articl=value;}
        }
        public double Prix_Articl_
        {
            get {return Prix_Articl;}
            set {Prix_Articl=value;}
        }
        public int Quantite_Articl_
        {
            get {return Quantite_Articl;}
            set {Quantite_Articl=value;}
        }

            
    }
}
