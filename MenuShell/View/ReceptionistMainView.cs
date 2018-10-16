using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class ReceptionistMainView : ConsoleView
    {
        public override string Display()
        {
            Console.Title = "Receptionist Menu";

            bool LoopisFinished = false;
            while (LoopisFinished == false)
            {
                base.Display(); // Consloe.Clear() 
                Console.WriteLine("== Reception Menu ==");
                Console.WriteLine("\n1. Register new Customer" +
                                  "\n2. List existing Customers" +
                                  "\n3. Serch Customer" +
                                  "\n4. Log Out");
                Console.Write("\nSelect Action:");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                        case ConsoleKey.D1: // Register new Patient
                        RegisterNewCoustomer NewCustomer = new RegisterNewCoustomer();
                        NewCustomer.Display();
                        break;
                        case ConsoleKey.D2:
                        ListCoustomerView NewList = new ListCoustomerView();
                            NewList.Display();
                        break;
                        case ConsoleKey.D3:
                        SerchcustomerView SerchCustomerMenu = new SerchcustomerView();
                        SerchCustomerMenu.Display();
                        break;
                        case ConsoleKey.D4:
                        LoopisFinished = true;
                        break; ;
                        default:
                        Console.WriteLine("Selection Error");
                            break;
                }
            }
            return "Default";
        }
    }
}
