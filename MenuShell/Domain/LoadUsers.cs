using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    //interface ILoadUsers
    //{
    //    List<User> LoadUsers();
    //}

    class GetUsers /*: /*ILoadUsers*/
    {
        public List<User> LoadUsers()
        {
            var users = new List<User>();

            var DOC = XDocument.Load("Users.xml");

            var ROOT = DOC.Root;

            foreach (var element in ROOT.Elements())
            {
                var username = element.Attribute("username").Value;
                var PassWord = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;
                users.Add(new User(username, PassWord, role));
            }

            return users;
        }
        
    }
}
