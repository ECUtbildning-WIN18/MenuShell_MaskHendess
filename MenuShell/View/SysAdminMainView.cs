using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class SySAdminMainView : ConsoleView
    {
        public override string Display()
        {
            bool LoopisFinished = false;
            while (LoopisFinished == false)
            {
                base.Display(); // Consloe.Clear() 
                Console.WriteLine("== System Admin Menu ==");
                Console.WriteLine("\n1. Add User" +
                                  "\n2. Delete User" +
                                  "\n3.List Users" +
                                  " \n4. Log Out");
                Console.Write("\nSelect Action:");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1: // Register new Patient
                    RegisterNewUser NewUserMenu = new RegisterNewUser();
                        NewUserMenu.Display();
                    break;
                    case ConsoleKey.D2:

                        break;
                    case ConsoleKey.D3:
                        LoopisFinished = true;
                        break;
                    default:
                        Console.WriteLine("Selection Error");
                        return "Default";
                }
            }
            return "Default";
        }
    }
}
