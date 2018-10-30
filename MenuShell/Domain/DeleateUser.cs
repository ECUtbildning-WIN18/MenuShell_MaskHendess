using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class DeleateUser
    {
        public void GoodByeForever(string input)
        {
            Console.Clear();

            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            //QUEEERRRY
            
                string queryString = $"DELETE FROM Users WHERE Username ='{input}'";
            
            using (var connection = new SqlConnection(connectionString))
            {
                var sqlcommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var reader = sqlcommand.ExecuteReader();

                    while (reader.Read())
                    {
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            //XDocument doc = XDocument.Load("Users.xml");
            //var root = doc.Root;

            //foreach (XElement element in root.Elements())
            //{
            //    var elmentusername = Convert.ToString(element.Attribute("username"));
            //    if (input == elmentusername)
            //    {
            //        element.RemoveAll();
            //        element.Remove();
            //        Console.WriteLine("User Sucessfully Deleted");
            //        Console.WriteLine("Press Any Key To Continue");
            //        Console.ReadKey();
            //        doc.Save("Users.xml");
            //    }
            //}
        }
    }
}
