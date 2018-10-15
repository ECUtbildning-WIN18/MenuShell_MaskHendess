using MenuShell.Domain;
using System;
using System.Xml;
using System.Xml.Linq;

namespace MenuShell.View
{
    class RegisterNewUser : ConsoleView
    {
        bool NewUserAdded = false;
        public override string Display()
        {

            while (NewUserAdded == false)
            {
                base.Display();
                AddUser();
            }
            return "New User Added!";
        }

        private void AddUser()
        {
            string Username = "";
            string Password = "";
            string Role = "";
            bool NewUserHasValidRole = false;
            Console.WriteLine("Enter new UserName:\n");
            Username = Console.ReadLine();
            Console.WriteLine("Enter new Password:\n");
            Password = Console.ReadLine();
            while (NewUserHasValidRole == false) // Must Select a Valid role for the User
            {
                Role = SelectUserRole(Role);

                if (Role == "receptionist"|| Role == "veterinary" || Role == "sysadmin")
                {
                    NewUserHasValidRole = true;
                }
                else
                {
                    NewUserHasValidRole = false;
                }
            }

            Console.Write("\nIs this correct (Y)es/(N)o:");
            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                XDocument doc = XDocument.Load("Users.xml");
                XElement NewUser = new XElement("User",
                         new XAttribute("username", Username),
                         new XAttribute("password", Password),
                         new XAttribute("role", Role));
              
                doc.Root.Add(NewUser);
                doc.Save("Users.xml");
                NewUserAdded = true;
            }
            else
            {
             NewUserAdded = false;
            }
        }
        
        private string SelectUserRole(string role)
        {
           // string role = "I need a valid role";
            Console.WriteLine("Select User Role");
            Console.WriteLine("1. Receptionist\n2.Vetrenarian\n3.System Admin");
            role = Console.ReadLine();
            switch (role)
            {
                case "1":
                    role = "receptionist"; // these must match the roles in the xml document
                    break;
                case "2":
                    role = "veterinary";
                    break;
                case "3":
                    role = "sysadmin";
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            return role;
        }
    }
}
