using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account_System.src.Entities.Account
{
    internal class CommonAccount : Account
    {

        public CommonAccount(string name, string password, int cpf) : base(name, password, cpf)
        {
            Tax = 10;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }
    }
}
