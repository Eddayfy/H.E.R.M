using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Commande
    {
        private int id;
        static private int nmbridcommande = 0;
        private DateTime date;
        private double prix;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }
        public Commande()
        {
            ID += (nmbridcommande + 1);
            Date = DateTime.Now;
        }
        public Commande(int ID, DateTime Date)
        {
            this.ID = ID;
            this.Date = Date;
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
            System.Console.WriteLine("Commande ID: " + ID);
            System.Console.WriteLine("Commande Date: " + Date);
            //System.Console.WriteLine("Commande Prix: " + Co);
        }

        public void DemmandeCommande()
        {
            Articl Ar = new Articl();
            Console.WriteLine("Voilà Les Article Que Nous avons Vende ici:");
            Console.WriteLine("1 - Pneu.");
            Console.WriteLine("2 - Moteur.");
            Console.WriteLine("3 - Huile.");
            Console.Write("Votre Choix: ");
            int choix = int.Parse(Console.ReadLine());

        menu:
            if (choix == 1)
            {
                Ar.afficher_Pneu();
            }
            else if (choix == 2)
            {
                Ar.afficher_Moteur();
            }
            else if (choix == 3)
            {
                Ar.afficher_Huile();
            }
            else
            {
                System.Console.WriteLine("Votre choix est incorecte.");
                System.Console.Write("Votre choix: ");
                choix = int.Parse(Console.ReadLine());
                goto menu;
            }

        }
    }


}
