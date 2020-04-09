using System;
using System.Collections.Generic;
using System.Text;

namespace H.E.R.M_App22
{
    class Matiere_premier
    {
        private int Id;
        private string libell;
        private double Quntite;

        public int id
        {
            get => id;
            set => id = value;
        }
        public string Libell
        {
            get => libell;
            set => libell = value;
        }
        public double quntite
        {
            get => Quntite;
            set => Quntite = value;
        }
        public Matiere_premier(int Id,string libell,double Quntite)
        {
            this.Id = id;
            this.libell = Libell;
            this.Quntite = quntite;
        }
    }
}
