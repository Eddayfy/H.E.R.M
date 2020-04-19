using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.E.R.M
{
    public class Client
    {
        private string prenom;
        private string nom;
        private string type;
        private int id;

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }
        public Client()
        {
            Type = "normal";
        }
        public Client(string prenom, string nom, string type, int id)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Type = type;
            this.Id = id;
        }
        public Client(string prenom, string nom, int id)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Type = "normal";
            this.Id = id;
        }
        public void Afficher_client()
        {
            Console.WriteLine("\t " + Nom + " " + Prenom + " ," + Type + " Client ,Id: " + Id + "\n");
        }
        static public void Afficher_clients()
        {
            Console.WriteLine("Voila nos Clients");
            foreach (var item in Data.clients)
            {
                item.Afficher_client();
            }
        }
        static public int checkClient(int id)
        {
            bool check = false;
            foreach (var item in Data.clients)
            {
                if (item.Id == id)
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