using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Client : Personne
    {
        public string type;
        public Client (int Id,string Nom_complet,string type)
            : base(Id,Nom_complet)
        {
            this.type = type;
        }
    }
}
