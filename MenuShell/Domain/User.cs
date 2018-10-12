using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class User
    {
        public string Username { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }

        public User(string username, string passWord, string role)
        {
            Username = username;
            PassWord = passWord;
            Role = role;
        }
    }
}
