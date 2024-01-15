using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account_System.src.Entities
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int CPF { get; set; }

        public User(string name, string password, int cpf)
        {
            Name = name;
            Password = password;
            CPF = cpf;
        }
    }
}
