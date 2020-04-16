using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Articl
    {
        string Nom_Articl;
        int ID_Articl;
        double Prix_Articl;
        int Quantite_Articl;
        public int Choix_I;
        public int Choix_Q;
        public Articl()
        { }
        public Articl(string nom, int id, double prix, int quantite)
        {
            this.Nom_Articl = nom;
            this.ID_Articl = id;
            this.Prix_Articl = prix;
            this.Quantite_Articl = quantite;
        }
        public string Nom_Articl_
        {
            get { return Nom_Articl; }
            set { Nom_Articl = value; }
        }
        public int ID_Articl_
        {
            get { return ID_Articl; }
            set { ID_Articl = value; }
        }

        public double Prix_Articl_
        {
            get { return Prix_Articl; }
            set { Prix_Articl = value; }
        }
        public int Quantite_Articl_
        {
            get { return Quantite_Articl; }
            set { Quantite_Articl = value; }
        }
        public void afficher_Pneu()
        {
            List<Articl> Pneu_ = new List<Articl>();
            Pneu_.Add(new Articl { Nom_Articl = "Pneu Run", ID_Articl = 347501, Prix_Articl = 150.00, Quantite_Articl = 100000 });
            Pneu_.Add(new Articl { Nom_Articl = "Pneu Flat", ID_Articl = 354020, Prix_Articl = 100.00, Quantite_Articl = 100000 });
            Pneu_.Add(new Articl { Nom_Articl = "Pneu Pasc", ID_Articl = 401275, Prix_Articl = 170.00, Quantite_Articl = 100000 });
            Pneu_.Add(new Articl { Nom_Articl = "Pneu Hiver", ID_Articl = 164020, Prix_Articl = 220.00, Quantite_Articl = 100000 });
            Pneu_.Add(new Articl { Nom_Articl = "Pneu Eté", ID_Articl = 701540, Prix_Articl = 250.00, Quantite_Articl = 100000 });
            Console.WriteLine("Voilà Les Pneu Que Vous Vendons");
            for (int i = 0; i < Pneu_.Count; i++)
            {

                Console.WriteLine("\n\t\t" + (i + 1) + " - " + Pneu_[i].Nom_Articl + " Numéro " + Pneu_[i].ID_Articl + " à partir de " + Pneu_[i].Prix_Articl + ".00 DH ");

            }
            int a;
            do
            {
                Console.Write("\nDonnez numéro  d'Articl Que Vous Achèterez : ");
                a = int.Parse(Console.ReadLine());
                if (a == 1) { Choix_I = 347501; Choix_Q = 100000; }
                else if (a == 2) { Choix_I = 354020; Choix_Q = 100000; }
                else if (a == 3) { Choix_I = 401275; Choix_Q = 100000; }
                else if (a == 4) { Choix_I = 164020; Choix_Q = 100000; }
                else if (a == 5) { Choix_I = 701540; Choix_Q = 100000; }
            } while (a != 1 && a != 2 && a != 3 && a != 4 && a != 5);
        }
        public void afficher_Moteur()
        {
            List<Articl> Moteur_ = new List<Articl>();
            Moteur_.Add(new Articl { Nom_Articl = "Moteur VR", ID_Articl = 347502, Prix_Articl = 6000.00, Quantite_Articl = 100000 });
            Moteur_.Add(new Articl { Nom_Articl = "Moteur TDI", ID_Articl = 354021, Prix_Articl = 8000.00, Quantite_Articl = 100000 });
            Moteur_.Add(new Articl { Nom_Articl = "Moteur DCI", ID_Articl = 401276, Prix_Articl = 8500.00, Quantite_Articl = 100000 });
            Moteur_.Add(new Articl { Nom_Articl = "Moteur TSI", ID_Articl = 164021, Prix_Articl = 6500.00, Quantite_Articl = 100000 });
            Console.WriteLine("Voilà Les Moteur Que Vous Vendons");
            for (int i = 0; i < Moteur_.Count; i++)
            {
                Console.WriteLine("\n\t\t" + (i + 1) + " - " + Moteur_[i].Nom_Articl + " Numéro " + Moteur_[i].ID_Articl + " à partir de " + Moteur_[i].Prix_Articl + ".00 DH ");
            }
            int a;
            do
            {
                Console.Write("\nDonnez numéro  d'Articl Que Vous Achèterez : ");
                a = int.Parse(Console.ReadLine());
                if (a == 1) { Choix_I = 347502; Choix_Q = 100000; }
                else if (a == 2) { Choix_I = 354021; Choix_Q = 100000; }
                else if (a == 3) { Choix_I = 401276; Choix_Q = 100000; }
                else if (a == 4) { Choix_I = 164021; Choix_Q = 100000; }
            } while (a != 1 && a != 2 && a != 3 && a != 4 );
        }
        public void afficher_Huile()
        {
            List<Articl> Huile_ = new List<Articl>();
            Huile_.Add(new Articl { Nom_Articl = "Fleet Master", ID_Articl = 347503, Prix_Articl = 100, Quantite_Articl = 100000 });
            Huile_.Add(new Articl { Nom_Articl = "Ultras7", ID_Articl = 384022, Prix_Articl = 70, Quantite_Articl = 100000 });
            Huile_.Add(new Articl { Nom_Articl = "GerBox", ID_Articl = 461277, Prix_Articl = 150, Quantite_Articl = 100000 });
            Huile_.Add(new Articl { Nom_Articl = "HD3", ID_Articl = 164222, Prix_Articl = 100, Quantite_Articl = 100000 });
            Huile_.Add(new Articl { Nom_Articl = "Deux Ton", ID_Articl = 164422, Prix_Articl = 100, Quantite_Articl = 100000 });
            Console.WriteLine("Voilà Les Huile Que Vous Vendons");
            for (int i = 0; i < Huile_.Count; i++)
            {
                Console.WriteLine("\n\t\t" + (i + 1) + " - " + Huile_[i].Nom_Articl + " Numéro " + Huile_[i].ID_Articl + " à partir de " + Huile_[i].Prix_Articl + ".00 DH ");            
            }
              int a;
            do
            {
                Console.Write("\nDonnez numéro  d'Articl Que Vous Achèterez : ");
                 a = int.Parse(Console.ReadLine());
                if (a == 1) { Choix_I = 347503; Choix_Q = 100000; }
                else if (a == 2) { Choix_I = 384022; Choix_Q = 100000; }
                else if (a == 3) { Choix_I = 461277; Choix_Q = 100000; }
                else if (a == 4) { Choix_I = 164222; Choix_Q = 100000; }
                else if (a == 5) { Choix_I = 164222; Choix_Q = 100000; }
            } while (a != 1 && a != 2 && a != 3 && a != 4 && a != 5 );
        }
        public void Choix()
        {
            Console.WriteLine("Voilà Les Produit Que Vous Vendons");
            Console.WriteLine("\n\t\t  1 - Moteur ");
            Console.WriteLine("\n\t\t  2 - Pneu ");
            Console.WriteLine("\n\t\t  3 - Huile ");
            int a;
            do
            {
                Console.Write("\nDonnez Le Produit Que Vous Achèterez : ");
                a = int.Parse(Console.ReadLine());

                if (a == 1) { Console.WriteLine("\n") ; afficher_Moteur(); }
                else if (a == 2) { Console.WriteLine("\n"); afficher_Pneu(); }
                else if (a == 3) { Console.WriteLine("\n"); afficher_Huile(); }

            } while (a !=1 && a != 2 && a != 3);
        }



    }
}