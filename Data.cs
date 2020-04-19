using System;
using System.Collections.Generic;
using System.IO;

namespace H.E.R.M
{
    public class Data
    {
        static public List<Client> clients = new List<Client>();
        static public List<Articl> Articls = new List<Articl>();
        static public List<Facture> Factures = new List<Facture>();
        static public List<Commande> Commandes = new List<Commande>();

        static public void CreatFolder()
        {
            if (!(Directory.Exists("./DataFile")))
            {
                DirectoryInfo Folder = Directory.CreateDirectory("./DataFile");
            }
        }
        static public void Add_Client_To_File(Client C)
        {
            CreatFolder();

            FileStream file = new FileStream("./DataFile/Clients.txt", FileMode.Append);
            StreamWriter index = new StreamWriter(file);
            index.WriteLine(C.Nom + "/" + C.Prenom + "/" + C.Type + "/" + C.Id);
            index.Close();
        }
        static public void Add_Clients_To_File()
        {
            CreatFolder();

            StreamWriter index = new StreamWriter("./DataFile/Clients.txt");
            foreach (var item in Data.clients)
            {
                index.WriteLine(item.Nom + "/" + item.Prenom + "/" + item.Type + "/" + item.Id);
            }
            index.Close();
        }
        static public void Read_Clients_From_File()
        {
            CreatFolder();

            List<Client> cls = new List<Client>();
        FileBack:
            if (File.Exists("./DataFile/Clients.txt"))
            {
                StreamReader index = new StreamReader("./DataFile/Clients.txt");
                string str = "";
                while (index.Peek() != -1)
                {
                    str = index.ReadLine();
                    string[] edd = str.Split('/');
                    Client Cl = new Client(edd[0], edd[1], edd[2], int.Parse(edd[3]));

                    cls.Add(Cl);
                }
            }
            else
            {
                StreamWriter creatit = new StreamWriter("./DataFile/Clients.txt");
                goto FileBack;
            }

            foreach (var item in cls)
            {
                Data.clients.Add(item);
            }
        }

        static public void Add_Articl_To_File(Articl A)
        {
            CreatFolder();

            FileStream file = new FileStream("./DataFile/Articls.txt", FileMode.Append);
            StreamWriter index = new StreamWriter(file);
            index.WriteLine(A.Nom_Articl_ + "/" + A.ID_Articl_ + "/" + A.Prix_Articl_ + "/" + A.Quantite_Articl_ + "/" + A.Type_Articl_);
            index.Close();
        }
        static public void Add_Articls_To_File()
        {
            CreatFolder();

            StreamWriter index = new StreamWriter("./DataFile/Articls.txt");
            foreach (var item in Data.Articls)
            {
                index.WriteLine(item.Nom_Articl_ + "/" + item.ID_Articl_ + "/" + item.Prix_Articl_ + "/" + item.Quantite_Articl_ + "/" + item.Type_Articl_);
            }
            index.Close();
        }
        static public void Read_Articls_From_File()
        {
            CreatFolder();

            List<Articl> Arts = new List<Articl>();
        FileBack:
            if (File.Exists("./DataFile/Articls.txt"))
            {
                StreamReader index = new StreamReader("./DataFile/Articls.txt");
                string str = "";
                while (index.Peek() != -1)
                {
                    str = index.ReadLine();
                    string[] edd = str.Split('/');
                    Articl Ar = new Articl(edd[0], int.Parse(edd[1]), double.Parse(edd[2]), int.Parse(edd[3]), edd[4]);

                    Arts.Add(Ar);
                }
            }
            else
            {
                StreamWriter creatit = new StreamWriter("./DataFile/Articls.txt");
                goto FileBack;
            }

            foreach (var item in Arts)
            {
                Data.Articls.Add(item);
            }
        }

        static public void Add_Facture_To_File(Facture F)
        {
            CreatFolder();

            FileStream file = new FileStream("./DataFile/Factures.txt", FileMode.Append);
            StreamWriter index = new StreamWriter(file);
            index.WriteLine(F.id + "/" + F.Nom_complet + "/" + F.date + "/" + F.Telephone);
            index.Close();
        }
        static public void Add_Factures_To_File()
        {
            CreatFolder();

            StreamWriter index = new StreamWriter("./DataFile/Factures.txt");
            foreach (var item in Data.Factures)
            {
                index.WriteLine(item.id + "/" + item.Nom_complet + "/" + item.date + "/" + item.Telephone);
            }
            index.Close();
        }
        static public void Read_Factures_From_File()
        {
            CreatFolder();

            List<Facture> Facts = new List<Facture>();
        FileBack:
            if (File.Exists("./DataFile/Factures.txt"))
            {
                StreamReader index = new StreamReader("./DataFile/Factures.txt");
                string str = "";
                while (index.Peek() != -1)
                {
                    str = index.ReadLine();
                    string[] edd = str.Split('/');
                    Facture Ar = new Facture(edd[0], DateTime.Parse(edd[1]), int.Parse(edd[2]), int.Parse(edd[3]));

                    Facts.Add(Ar);
                }
            }
            else
            {
                StreamWriter creatit = new StreamWriter("./DataFile/Factures.txt");
                goto FileBack;
            }

            foreach (var item in Facts)
            {
                Data.Factures.Add(item);
            }
        }

        static public void Add_Commande_To_File(Commande C)
        {
            CreatFolder();

            FileStream file = new FileStream("./DataFile/Commandes.txt", FileMode.Append);
            StreamWriter index = new StreamWriter(file);
            index.WriteLine(C.ID + "/" + C.Date + "/" + C.Prix);
            index.Close();
        }
        static public void Add_Commandes_To_File()
        {
            CreatFolder();

            StreamWriter index = new StreamWriter("./DataFile/Commandes.txt");
            foreach (var item in Data.Commandes)
            {
                index.WriteLine(item.ID + "/" + item.Date + "/" + item.Prix);
            }
            index.Close();
        }
        static public void Read_Commandes_From_File()
        {
            CreatFolder();

            List<Commande> Facts = new List<Commande>();
        FileBack:
            if (File.Exists("./DataFile/Commandes.txt"))
            {
                StreamReader index = new StreamReader("./DataFile/Commandes.txt");
                string str = "";
                while (index.Peek() != -1)
                {
                    str = index.ReadLine();
                    string[] edd = str.Split('/');
                    Commande Ar = new Commande(int.Parse(edd[0]), DateTime.Parse(edd[1]), double.Parse(edd[2]));

                    Facts.Add(Ar);
                }
            }
            else
            {
                StreamWriter creatit = new StreamWriter("./DataFile/Commandes.txt");
                goto FileBack;
            }

            foreach (var item in Facts)
            {
                Data.Commandes.Add(item);
            }
        }

    }
}