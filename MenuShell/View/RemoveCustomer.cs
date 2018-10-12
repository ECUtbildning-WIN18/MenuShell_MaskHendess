using MenuShell.Domain;
using System;
using System.Xml.Linq;

namespace MenuShell.View
{
    class RemoveCustomer : ConsoleView
    {
        bool CustomerRemoved = false;
        public override string Display()
        {
            
            do
            {
                base.Display();
                AddCoustomer();
            } while (CustomerRemoved == false);
            return "Fail";
        }

        private void AddCoustomer()
        {
            
            Console.Write("Enter Owners First Name:");
            string FirstName = Console.ReadLine();

           // Check Database  if customer is there
            // if true, do stuff else say dude not here

            Console.Write("Is this Correct (Y)es/(N)o");
            var consoleKeyInfo = Console.ReadKey();
            if(consoleKeyInfo.Key == ConsoleKey.Y)
            {
                // Remove from list chosen customer
                CustomerRemoved = true;
            }
            else
            {
                CustomerRemoved = false;
            }
        }
    }
}
