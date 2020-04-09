using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.E.R.M
{
    class Personne
    {
        private int Id;
        private string Nom_Complet;
     
        public int id
        {
            get => id;
            set => id = value; 
        }
        public string nom_Complet
        {
            get => nom_Complet;
            set => nom_Complet = value;
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
