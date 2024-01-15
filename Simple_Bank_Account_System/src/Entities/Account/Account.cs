using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account_System.src.Entities.Account
{
    internal abstract class Account
    {
        User user;
        protected double Tax { get; set; }
        public int Agency { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        protected Account(string name, string password, int cpf)
        {
            Random rnd = new Random();

            Balance = 0;
            Tax = 0;
            Agency = rnd.Next(0, 20);
            AccountNumber = rnd.Next(100, 999);
            User user = new User(name, password, cpf);
            Console.WriteLine($"Parabéns na criação de sua conta");
            Console.WriteLine($"Usuário: {user.Name}");
            Console.WriteLine($"Agencia: {Agency}");
            Console.WriteLine($"Número da conta: {AccountNumber}");
            Console.WriteLine($"Saldo inicial: {Balance}");
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Você depositou: {amount}$");
            Console.WriteLine($"Saldo total: {Balance}$");
        }

        public virtual void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Você não tem saldo o suficiente");
                return;
            }
            Balance -= (amount + this.Tax);
            Console.WriteLine($"Novo saldo: {Balance}");
        }
    }
}
