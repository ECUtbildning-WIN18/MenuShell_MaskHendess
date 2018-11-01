using MenuShell.Domain;
using System;
using System.Xml.Linq;

namespace MenuShell.View
{
    class RegisterNewCoustomer : ConsoleView
    {
        bool NewCoustomerSucesfullyAdded = false;
        public override string Display()
        {

            while (NewCoustomerSucesfullyAdded == false)
            {
                base.Display();
                AddCoustomer();
            }
            return "Default";
        }

        private void AddCoustomer()
        {
            
            Console.Write("Enter Owners First Name:");
            string FirstName = Console.ReadLine();

            Console.Write("Enter Owners Last Name:");
            string LastName = Console.ReadLine();

            Console.Write("Enter SSN:");
            string SSN = Console.ReadLine();

            Console.Write("Enter Patient Name:");
            string PetName = Console.ReadLine();

            Console.Write("Enter Pet Species:");
            string Species = Console.ReadLine();

            Console.Write("Is this Correct (Y)es/(N)o");
            var consoleKeyInfo = Console.ReadKey();
            if(consoleKeyInfo.Key == ConsoleKey.Y)
            {
                LoadCustomers NewCustomer = new LoadCustomers();
                NewCustomer.Addelement(FirstName, LastName, SSN, PetName, Species);
                
                XDocument doc = XDocument.Load("Customers.xml");
                doc.Root.Add(NewCustomer);
                NewCoustomerSucesfullyAdded = true;

                //XDocument doc = XDocument.Load("Users.xml");
                //XElement NewUser = new XElement("User",
                //         new XAttribute("username", Username),
                //         new XAttribute("password", Password),
                //         new XAttribute("role", Role));

                //doc.Root.Add(NewUser);
                //doc.Save("Users.xml");
            }
            else
            {
                NewCoustomerSucesfullyAdded = false;
            }
        }
    }
}
