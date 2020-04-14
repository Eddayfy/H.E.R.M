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
            Console.WriteLine("Hello Jbiri!");

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

            Data.Add_Client_To_File(c0);
            Data.Add_Client_To_File(c1);
            Data.Add_Client_To_File(c2);
            Data.Add_Client_To_File(c3);
            Data.Add_Client_To_File(c4);

            //Data.Add_Clients_To_File();

            Client.Afficher_client();

            //Data.CreatFolder();
        }
    }
}
