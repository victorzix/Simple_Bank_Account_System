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
        public string Password { get; set;}
        public int Agency { get; set; }
        public double Balance { get; set; }

        public User(string name, string password, int agency)
        {
            Name = name;
            Password = password;
            Agency = agency;
            Balance = 0;
        }

        public static User CreateUser(string name, string password, int agency, List<User> usersList)
        {
            if (UserIsValid(usersList, new User(name, password, agency))) {
                User newUser = new User(name, password, agency);
                usersList.Add(newUser);
                Console.WriteLine($"Usuário cadastrado com sucesso");
                Console.WriteLine($"Nome: {newUser.Name}");
                Console.WriteLine($"Agencia: {newUser.Agency}");
                Console.WriteLine($"Saldo: {newUser.Balance}");

                return newUser;
            }
            Console.WriteLine("Usuário já cadastrado");
            return null;
        }

        private static bool UserIsValid(List<User> usersList, User data)
        {
            if (usersList.Count > 0)
            {
                foreach (var user in usersList)
                {
                    if (data.Agency == user.Agency)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}
