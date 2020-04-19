using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace H.E.R.M
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Console.WriteLine("Hello Jbiri!");

            //Clients
            Data.Read_Clients_From_File();
            Client c0 = new Client("Ahmed", "Benjeloun", "vrai", 1550);
            Client c1 = new Client("Karim", "Tazi", "normal", 1551);
            Client c2 = new Client("Samir", "Berrada", "vrai", 1552);
            Client c3 = new Client("Rayan", "Rehal", "vrai", 1553);
            Client c4 = new Client("Simo", "Bennis", "vrai", 1554);
            Client c5 = new Client("Aziz", "Qebaj", "normal", 1555);
            Data.clients.Add(c0);
            Data.clients.Add(c1);
            Data.clients.Add(c2);
            Data.clients.Add(c3);
            Data.clients.Add(c4);
            Data.clients.Add(c5);

            //Articls
            Data.Read_Articls_From_File();
            Articl A0 = new Articl("Run", 347501, 150.00, 100000, "Pneu");
            Articl A1 = new Articl("Flat", 354020, 100.00, 100000, "Pneu");
            Articl A2 = new Articl("Pasc", 401275, 170.00, 100000, "Pneu");
            Articl A3 = new Articl("Hiver", 164020, 220.00, 100000, "Pneu");
            Articl A4 = new Articl("Eté", 701540, 250.00, 100000, "Pneu");
            Data.Articls.Add(A0);
            Data.Articls.Add(A1);
            Data.Articls.Add(A2);
            Data.Articls.Add(A3);
            Data.Articls.Add(A4);

            Articl A5 = new Articl("Run", 47501, 50.00, 00000, "Pneu");
            Articl A6 = new Articl("Flat", 354020, 100.00, 100000, "Pneu");
            Articl A7 = new Articl("Pasc", 401275, 170.00, 100000, "Pneu");
            Articl A8 = new Articl("Hiver", 164020, 220.00, 100000, "Pneu");
            Articl A9 = new Articl("Eté", 01540, 50.00, 100000, "Pneu");
            Data.Articls.Add(A5);
            Data.Articls.Add(A6);
            Data.Articls.Add(A7);
            Data.Articls.Add(A8);
            Data.Articls.Add(A9);

            Articl A10 = new Articl("VR", 347502, 6000.00, 100000, "Moteur");
            Articl A11 = new Articl("TDI", 354021, 8000.00, 100000, "Moteur");
            Articl A12 = new Articl("DCI", 401276, 8500.00, 100000, "Moteur");
            Articl A13 = new Articl("TSI", 164021, 6500.00, 100000, "Moteur");
            Data.Articls.Add(A10);
            Data.Articls.Add(A11);
            Data.Articls.Add(A12);
            Data.Articls.Add(A13);

            Articl A14 = new Articl("Fleet Master", 347503, 100, 100000, "Huile");
            Articl A15 = new Articl("Ultras7", 384022, 70, 100000, "Huile");
            Articl A16 = new Articl("GerBox", 461277, 150, 100000, "Huile");
            Articl A17 = new Articl("HD3", 164222, 100, 100000, "Huile");
            Articl A18 = new Articl("Deux Ton", 164422, 100, 100000, "Huile");
            Data.Articls.Add(A14);
            Data.Articls.Add(A15);
            Data.Articls.Add(A16);
            Data.Articls.Add(A17);
            Data.Articls.Add(A18);




            //Start
        menu:
            Console.Clear();
            Console.WriteLine("1 - Afficher nos Articls.");
            Console.WriteLine("2 - Afficher nos Clients.");
            Console.WriteLine("3 - Gerer un Commande.");
            Console.WriteLine("9 - Quitter.");
            Console.Write("Votre choix: "); choix:
            int choix = int.Parse(Console.ReadLine());
            Commande commande = new Commande();

            if (choix == 1)
            {
                Articl.Afficher_Articls();
                Console.ReadKey();
                goto menu;
            }
            else if (choix == 2)
            {
                Console.Clear();
                Client.Afficher_clients();
                Console.ReadKey();
                goto menu;
            }
            else if (choix == 3)
            {
                Console.Clear();
                
                Console.WriteLine("1 - Cree un Commande.");
                Console.WriteLine("2 - Afficher ma Commande.");
                Console.Write("Votre choix: ");
                int commandchoix = int.Parse(Console.ReadLine());
                if (commandchoix == 1)
                {
                    Console.Clear();
                    commande.CreeCommande();
                }
                else if (commandchoix == 2)
                {
                    Console.Clear();
                    commande.AfficherCommande();
                }
                Console.ReadKey();
                goto menu;
            }
            else if (choix == 9)
            {
                Console.WriteLine("Merci.");
            }
            else
            {
                Console.Write("incorecte choix, rentrer votre choix: ");
                goto choix;
            }
        }
    }
}
