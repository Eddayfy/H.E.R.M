using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Commande
    {
        private int CommandeID_;
        private DateTime CommandeDate_;

        public int CommandeID
        {
            get { return this.CommandeID_; }
            set { this.CommandeID_ = value; }
        }
        public DateTime CommandeDate
        {
            get { return this.CommandeDate_; }
            set { this.CommandeDate_ = value; }
        }
        public Commande() { }
        public Commande(int ID, DateTime Date)
        {
            this.CommandeID = ID;
            this.CommandeDate = Date;
        }

        public int calculerPrix()
        {
            //int Prix_Total;
            //int Prix_Sous_Total;
            //int Contiter;
            //
            return 1;
        }

        public void afficherCommande()
        {
            //
            System.Console.WriteLine("Commande ID: ");
            System.Console.WriteLine("Commande Date: ");
            System.Console.WriteLine("Commande Prix: ");
        }
    }


}
