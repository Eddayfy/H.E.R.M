using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M
{
    class Commande
    {
        int Num_Comd;
        DateTime Date_Comd;
        public Commande()
        {
        }
        public Commande(int numcomd, DateTime datecomd)
        {
            this.Num_Comd = numcomd;
            this.Date_Comd = datecomd;
        }
        public int Num_Comd_
        {
            get {return this.Num_Comd; }
            set {this.Num_Comd=value; }
        }
        public DateTime Date_Comd_
        {
            get {return this.Date_Comd; }
            set {this.Date_Comd=value; }
        }
    }


}
