using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    public class Articl
    {
        string Nom_Articl;
        int ID_Articl;
        double Prix_Articl;
        int Quantite_Articl;
        string Type_Articl;
        public Articl()
        { }
        public Articl(string nom, int id, double prix, int quantite, string type)
        {
            this.Nom_Articl = nom;
            this.ID_Articl = id;
            this.Prix_Articl = prix;
            this.Quantite_Articl = quantite;
            this.Type_Articl = type;
        }
        public string Nom_Articl_
        {
            get { return Nom_Articl; }
            set { Nom_Articl = value; }
        }
        public string Type_Articl_
        {
            get { return Type_Articl; }
            set { Type_Articl = value; }
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

        public void Afficher_Articl()
        {
            Console.WriteLine("\t\t" + "- " + Type_Articl + ": " + Nom_Articl + ", Numéro " + ID_Articl + ", à partir de " + Prix_Articl + " DH.\n");
        }
        static public void Afficher_Articls()
        {
            Console.Clear();
            Console.WriteLine("Voila les Article que nous avon vendu: ");
            Console.WriteLine("\t1 - Pneu.");
            Console.WriteLine("\t2 - Moteur.");
            Console.WriteLine("\t3 - Huile.");
            Console.Write("Votre choix: "); articlechoix:
            int articleChoix = int.Parse(Console.ReadLine());
            if (articleChoix == 1)
            {
                Console.Clear();
                Afficher_Pneu();
            }
            else if (articleChoix == 2)
            {
                Console.Clear();
                Afficher_Moteur();
            }
            else if (articleChoix == 3)
            {
                Console.Clear();
                Afficher_Huile();
            }
            else
            {
                Console.Write("incorecte choix, rentrer votre choix: ");
                goto articlechoix;
            }
        }
        static public void Afficher_Pneu()
        {
            foreach (var item in Data.Articls)
            {
                if (item.Type_Articl_ == "Pneu")
                {
                    item.Afficher_Articl();
                }
            }
        }
        static public void Afficher_Moteur()
        {
            foreach (var item in Data.Articls)
            {
                if (item.Type_Articl_ == "Moteur")
                {
                    item.Afficher_Articl();
                }
            }
        }
        static public void Afficher_Huile()
        {
            foreach (var item in Data.Articls)
            {
                if (item.Type_Articl_ == "Huile")
                {
                    item.Afficher_Articl();
                }
            }
        }
        static public int checkArticl(int id)
        {
            bool check = false;
            foreach (var item in Data.Articls)
            {
                if (item.ID_Articl_ == id)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }




    }
}