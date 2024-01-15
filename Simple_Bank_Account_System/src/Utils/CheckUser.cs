using Simple_Bank_Account_System.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account_System.src.Utils
{
    internal class CheckUser
    {
        public bool CheckUserList(User newUser, List<User> userList)
        {
            if (userList.Count >= 1)
            {
                foreach (User user in userList)
                {
                    if (newUser.CPF == user.CPF)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
