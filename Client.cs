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
        { }
        public Client(string prenom, string nom, string type, int id)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Type = type;
            this.Id = id;
        }
        static public void Afficher_client()
        {
            Console.WriteLine("Voila nos Clients");
            for (int i = 0; i < Data.clients.Count; i++)
            {
                Console.WriteLine("\n \t  \t " + (i + 1) + " - " + Data.clients[i].Nom + "  " + Data.clients[i].Prenom + "  " + Data.clients[i].Type + "  " + Data.clients[i].Id);
            }
        }
    }

}