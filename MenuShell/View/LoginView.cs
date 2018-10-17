using MenuShell.Domain;
using System;
using System.Threading;

namespace MenuShell.View
{
    class LoginView : ConsoleView
    {
        public override string Display()
        {
            Console.Title = "Login Menu";

            bool LoopisFinished = false;
            while (LoopisFinished == false) { 
                base.Display();
                Console.WriteLine("Please Log In\n\n");

                Console.Write("UserName:");
                string username = Console.ReadLine();

                Console.Write("PassWord:");
                string password = WritePassword();

                Console.Write("\nIs this correct (Y)es/(N)o:");
                var input = Console.ReadKey();

                if(input.Key == ConsoleKey.Y)
                {
                    var SystemCheck = new AuthenticationService();

                    var user = SystemCheck.Autenticate(username, password);
                    if (user != null)
                    {
                        Console.WriteLine("\nLogin Sucessfull");
                        Console.WriteLine(user.Role);
                        LoopisFinished = true ;
                        return user.Role;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied!");
                    }
                }
                else if ( input.Key == ConsoleKey.N) {

                } else{
                Console.WriteLine("\nInvalid Username or Password.");
                    
                }
                Thread.Sleep(2000);
            }
            return "Default";
        }

        private string WritePassword()
        {
            string Password = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    Password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && Password.Length > 0)
                    {
                        Password = Password.Substring(0, (Password.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            return Password;
        }
    }
}
