using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    public class Commande
    {
        private int id;
        static private int nmbridcommande = 0;
        private DateTime date;
        private double prix;

        struct Article { public string Nom,Type; public int ID,Quantite; public double Prix; }
        Client client = new Client();
        List<Article> articl = new List<Article>();

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
        public Commande(int ID, DateTime Date, double Prix)
        {
            this.ID = ID;
            this.Date = Date;
            this.Prix = Prix;
        }
        public void AfficherCommande()
        {
            Console.Clear();
            Console.WriteLine("Commande N: " + id + ", Date: " + date + ".");
            Console.WriteLine("Client: " + client.Nom + " " + client.Prenom);
            
            int x = 1;
            foreach (var item in articl)
            {
                Console.WriteLine("Articl N: " + x + ", " + item.Type + " " + item.Nom + ", Quantite: " + item.Quantite + ", Prix: " + (item.Quantite * item.Prix) + ".");
                x++;
            }

        }

        public void CreeCommande()
        {
            Console.Write("vous avez a neveau client[y/n]: ");
            char clientype = char.Parse(Console.ReadLine());
        clientInput:
            if (clientype == 'y' || clientype == 'Y')
            {

                Console.Write("Votre Nom: ");
                client.Nom = Console.ReadLine();
                Console.Write("Votre Prenom: ");
                client.Prenom = Console.ReadLine();
                do
                {
                    Console.Write("Votre Id: ");
                    client.Id = int.Parse(Console.ReadLine());
                } while (Client.checkClient(client.Id) != -1);
            }
            else if (clientype == 'n' || clientype == 'N')
            {
            idInput:
                Console.Write("Donner votre Id: ");
                int clientIdTemp = int.Parse(Console.ReadLine());
                while (Client.checkClient(clientIdTemp) == -1)
                {
                    Console.WriteLine("Had ID li dakhalti makaynch fi lbase donner.");
                    Console.WriteLine("kteb [1] ila bghiti t3awd dakhle l'ID dyalak.");
                    Console.WriteLine("kteb [2] ila knti Client jdid.");
                    Console.WriteLine("kteb ay ra9m akher ila bghiti dir bna9ss ka3.");
                    Console.Write("votr choix: ");
                    int darijaChoix = int.Parse(Console.ReadLine());
                    if (darijaChoix == 1)
                    {
                        goto idInput;
                    }
                    else if (darijaChoix == 2)
                    {
                        clientype = 'y';
                        goto clientInput;
                    }
                }
            }
            char loop;
            do
            {
                Console.Clear();
                Articl.Afficher_Articls();
                Console.Write("Donner ID de votre Articl pour acheter: ");
                int articlID = int.Parse(Console.ReadLine());
                while (Articl.checkArticl(articlID) == -1)
                {
                    Console.Write("le ID que vous enter est incorect, rentrer l'ID: ");
                    articlID = int.Parse(Console.ReadLine());
                }
                Console.Write("Donner la Quantite: ");
                int ArticlQuantite = int.Parse(Console.ReadLine());
                Article a;
                foreach (var item in Data.Articls)
                {
                    if (item.ID_Articl_ == articlID)
                    {
                        a.Nom = item.Nom_Articl_;
                        a.ID = item.ID_Articl_;
                        a.Prix = item.Prix_Articl_;
                        a.Quantite = ArticlQuantite;
                        a.Type = item.Type_Articl_;
                        articl.Add(a);
                        break;
                    }
                }
                Console.Write("Vous les vous choise un autre articl [y/n]: ");
                loop = char.Parse(Console.ReadLine());
            } while (loop == 'y' || loop == 'Y');
        }
    
    }


}
