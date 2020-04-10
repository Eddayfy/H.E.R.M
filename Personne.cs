using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Personne
    {
        private int Id;
        private string Nom_Complet;
     
        public int id
        {
            get => Id;
            set => Id = value; 
        }
        public string nom_Complet
        {
            get => Nom_Complet;
            set => Nom_Complet = value;
        }
       
        public Personne (int Id,string Nom_complet)
        {
            this.id = Id;
            this.nom_Complet = Nom_complet;
           

        }
        public string afficher()
        {
            return this.id + "  " + this.nom_Complet ;
        }
    }
}
