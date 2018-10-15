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
            while (LoopisFinished == false)
            {
                base.Display(); // Consloe.Clear() 
                Console.WriteLine("== System Admin Menu ==");
                Console.WriteLine("\n1. Add User" +
                                  "\n2. Delete User" +
                                  "\n3. List Users" +
                                  " \n4. Log Out");
                Console.Write("\nSelect Action:");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1: // New User
                    RegisterNewUser NewUserMenu = new RegisterNewUser();
                        NewUserMenu.Display();
                    break;
                    case ConsoleKey.D2: // Delete
                    RemoveUserView RemoveUserMenu = new RemoveUserView();
                    RemoveUserMenu.Display();
                        break;
                    case ConsoleKey.D3: // List Users
                        base.Display();
                        GetUsers users = new GetUsers();
                        users.ListUsers();
                        Console.WriteLine("Press any key to Continue");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
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
