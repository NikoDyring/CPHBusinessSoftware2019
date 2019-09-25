using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BankServer
{
    class Program
    {



        static void Main(string[] args)
        {
            CustomerJournal.Accounts = new Dictionary<int, double>();

            CustomerJournal.Accounts.Add(14578932, 5590);
            CustomerJournal.Accounts.Add(65987412, 3268);
            CustomerJournal.Accounts.Add(48759321, 9874);
            CustomerJournal.Accounts.Add(96587412, 32141);
            CustomerJournal.Accounts.Add(36987412, 7489);
            CustomerJournal.Accounts.Add(36987120, 329);



            IPAddress ip = IPAddress.Parse("127.0.0.1");

            TcpListener serverSocket = new TcpListener(ip, 6789);
            serverSocket.Start();

            Console.WriteLine("Server started");

            TcpClient connectionSocket = serverSocket.AcceptTcpClient();
            //Socket connectionSocket = serverSocket.AcceptSocket();
            Console.WriteLine("Connection between client and server established");

            Stream ns = connectionSocket.GetStream();
            // Stream ns = new NetworkStream(connectionSocket);

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            string message;
            message = "";
            message = sr.ReadLine();
            string answer = "";
            while (true)
            {

                Console.WriteLine("Client: " + message);
                if (message != null)
                {
                    if (message == "stop")
                    {
                        break;
                    }

                    string[] splitmessage = message.Split(' ');
                    string accountNoInput = splitmessage[0];
                    int accountNo = Int32.Parse(accountNoInput);
                    string totalValueInput = splitmessage[1];
                    double totalValue = double.Parse(totalValueInput);

                    if (CustomerJournal.Accounts.ContainsKey(accountNo))
                    {
                        CustomerJournal.Accounts[accountNo] += totalValue;
                        answer = CustomerJournal.Accounts[accountNo].ToString();


                        sw.WriteLine(answer);
                    }
                    else
                    {
                        sw.WriteLine("Account not found");
                    }


                }

                message = sr.ReadLine();
            }
        }
    }
}
