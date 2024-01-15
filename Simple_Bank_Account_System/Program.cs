using Simple_Bank_Account_System.src.Entities;
using Simple_Bank_Account_System.src.Entities.Account;
using Simple_Bank_Account_System.src.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simple_Bank_Account_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new CommonAccount("1", "2", 3);
            Account acc2 = new PlatinumAccount("2", "2", 3);
            acc1.Deposit(300);
            acc1.Withdraw(100);
            acc2.Deposit(300);
            acc2.Withdraw(100);
        }
    }
}
