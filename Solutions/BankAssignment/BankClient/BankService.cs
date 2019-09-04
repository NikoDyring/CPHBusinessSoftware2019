using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BankClient
{
    class BankService
    {

        private TcpClient client = new TcpClient("localhost", 6789);
        private StreamReader sr;
        private StreamWriter sw;

        public BankService()
        {
            Stream networkstream = client.GetStream();
            sr = new StreamReader(networkstream);
            sw = new StreamWriter(networkstream);
            sw.AutoFlush = true;
        }

        #region Calculations for accounts.
        
        // Needs use of DRY principle. A lot of code is repeated. Could make it into 1 method, with the same functionality. 

        public string CheckBalance(string accountNo, double value)
        {
            if(!client.Connected)
            {
                TcpClient a = new TcpClient("localhost", 6789);
            }
            if (accountNo == "")
            {
                accountNo = "404";
            }

            var message = $"{accountNo} {value}";
            sw.WriteLine(message);

            var serverAnswer = sr.ReadLine();
            if(serverAnswer != null)
            {
                
                return serverAnswer;
            }
            client.Close();
            return "Unable to find account with given account number.";
        }

        public string AddFunds(string accountNo, string value)
        {
            if (!client.Connected)
            {
                TcpClient a = new TcpClient("localhost", 6789);
            }
            if (accountNo == "")
            {
                accountNo = "404";
            }

            var message = $"{accountNo} {value}";
            sw.WriteLine(message);

            var serverAnswer = sr.ReadLine();
            if (serverAnswer != null)
            {

                return serverAnswer;
            }
            client.Close();
            return "Unable to deposit funds from given account number.";
        }

        public string WithdrawFunds(string accountNo, string value)
        {
            if (!client.Connected)
            {
                TcpClient a = new TcpClient("localhost", 6789);
            }

            if (accountNo == "")
            {
                accountNo = "404";
            }

            var message = $"{accountNo} -{value}";
            sw.WriteLine(message);

            var serverAnswer = sr.ReadLine();
            if (serverAnswer != null)
            {

                return serverAnswer;
            }
            client.Close();
            return "Unable to withraw funds from given account number.";
        }

        #endregion

    }
}
