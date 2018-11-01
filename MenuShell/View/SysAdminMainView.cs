using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.View
{
    class SySAdminMainView : ConsoleView
    {
        public override string Display()
        {
            Console.Title = "System Admin Menu";

            bool LoopisFinished = false;
            while (LoopisFinished == false) // Stop loop to go back to Main
            {
                base.Display(); // Consloe.Clear() 
                Console.WriteLine("== System Admin Menu ==");
                Console.WriteLine("\n1. Add User" +
                                  "\n2. List Users" + 
                                  " \n3. Log Out");
                Console.Write("\nSelect Action:");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1: // Add New User
                    RegisterNewUser NewUserMenu = new RegisterNewUser();
                    NewUserMenu.Display();
                    break;

                    case ConsoleKey.D2: // List Users => Show Details => Delete User
                        var RemoveUserMenu = new RemoveUserView();
                        RemoveUserMenu.Display();
                        break;

                    case ConsoleKey.D3: // Log Out
                    LoopisFinished = true;
                    break;

                    default:
                    Console.WriteLine("Selection Error");
                    break;
                }
            }
            return "Default";
        }
    }
}
