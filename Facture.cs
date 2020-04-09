using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M_App22
{
    class Facture
    {
        private int Id;
        private string nom_complet;
        private DateTime Date;
        private int telephone;

        public int id
        {
            get => Id;
            set => Id = value;
        }
        public string Nom_complet
        {
            get => nom_complet;
            set => nom_complet = value;
        }
        public DateTime date
        {
            get => date;
            set => date = value;
        }

        public int Telephone
        {
            get => telephone;
            set => telephone = value;
        }

        public Facture(string nom_complet,DateTime date,int telephone)
        {
            this.Id = id;
            this.nom_complet = nom_complet;
            this.Date = date;
            this.telephone = telephone;
        } 

    }
}
