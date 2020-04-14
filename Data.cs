using System.Collections.Generic;
using System.IO;

namespace H.E.R.M
{
    public class Data
    {
        static public List<Client> clients = new List<Client>();

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
    }
}