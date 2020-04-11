using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.E.R.M
{
    class Client
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
        public void Afficher_client()
        {
            List<string> Nclient = new List<string>() { "Benjeloun", "Tazi", "Berrada", "Rehal", "Bennis", "Qebaj" };
            List<string> Pclient = new List<string>() { "Ahmed", "Karim", "Samir", "Rayan", "Simo", "Aziz" };
            List<string> Tclient = new List<string>() { "vrai client", "client normal", "vrai client", "vrai client", "vrai client", "client normal" };
            List<int> idclient = new List<int>() { 1550, 1551, 1552, 1553, 1554, 1555 };
            Console.WriteLine("Voila nos Clients");
            for (int i=0;i<Nclient.Count;i++)
            {
                Console.WriteLine("\n \t  \t " + (i + 1) + " - " + Nclient[i] + "  " + Pclient[i] + "  " + Tclient[i] + "  " + idclient[i]);
            }  
   
        }
    }

}