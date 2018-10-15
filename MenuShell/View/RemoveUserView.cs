using MenuShell.Domain;
using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MenuShell.View
{
    class RemoveUserView : ConsoleView
    {
        bool SuccessfulyRemovedUser = false;
        public override string Display()
        {

            while (SuccessfulyRemovedUser == false)
            {
                base.Display();
                RemoveUser();
            }
            return "User Removed";
        }

        private void RemoveUser()
        {
            GetUsers users = new GetUsers();
           var userslist = users.LoadUsers();
            users.ListUsers();
            Console.Write("Enter a Username:");
            var input = "username=\"" + Console.ReadLine() +"\"";
            
            Console.Write("Do you wish to Delete selected User? (Y)es/(N)o");
            var consoleKeyInfo = Console.ReadKey();
            if(consoleKeyInfo.Key == ConsoleKey.Y)
            {
                XDocument doc = XDocument.Load("Users.xml");
                var root = doc.Root;

                foreach (XElement element in root.Elements())
                {
                    var elmentusername = Convert.ToString(element.Attribute("username"));
                    if (input == elmentusername)
                    {
                        element.RemoveAll();
                        element.Remove();
                        Console.WriteLine("Element Removed");
                        doc.Save("Users.xml");
                    }
                }
                SuccessfulyRemovedUser = true;
            }
            else
            {
                SuccessfulyRemovedUser = false;
            }
        }
    }
}
