using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class RegisterNewCoustomer : ConsoleView
    {
        bool NewCoustomerSucesfullyAdded = false;
        public override string Display()
        {
            
            do
            {
                base.Display();
                AddCoustomer();
            } while (NewCoustomerSucesfullyAdded == false);
            return "Fail";
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
                NewCoustomerSucesfullyAdded = true;
            }
            else
            {
                NewCoustomerSucesfullyAdded = false;
            }
        }
    }
}
