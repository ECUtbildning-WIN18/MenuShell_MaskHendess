using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //QUEEERRRY
            string queryString = "SELECT * FROM Users"; // Select all from users 

            using (var connection = new SqlConnection(connectionString))
            {
                var sqlcommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var reader = sqlcommand.ExecuteReader();

                    while (reader.Read())
                    {
                        users.Add(new User(Convert.ToString(reader[0]), Convert.ToString(reader[1]),
                                                                    Convert.ToString( reader[2])));
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            //var DOC = XDocument.Load("Users.xml");

            //var ROOT = DOC.Root;

            //foreach (var element in ROOT.Elements())
            //{
            //    var username = element.Attribute("username").Value;
            //    var PassWord = element.Attribute("password").Value;
            //    var role = element.Attribute("role").Value;
            //    users.Add(new User(username, PassWord, role));
            //}

            return users;
        }
        
    }
}
