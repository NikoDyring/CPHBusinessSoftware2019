using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient
{
    class Account
    {
        public Account(string accountNo)
        {
            AccountNo = accountNo;
        }

        public string AccountNo { get; set; }
    }
}
