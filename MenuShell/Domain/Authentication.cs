using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    //interface IAuthenticationSevice
    //{
    //    User Autenticate(string username, string password);
    //}

    class AuthenticationService //: IAuthenticationSevice
    {
        private readonly GetUsers UserLoader;

        public AuthenticationService()
        {
            UserLoader = new GetUsers();
        }

        public User Autenticate(string username, string password)
        {
            // var userLoader = new UserLoader();
            var users = UserLoader.LoadUsers();
            
            return users.FirstOrDefault(x => x.Username == username && x.PassWord == password);
        }
    }
}
