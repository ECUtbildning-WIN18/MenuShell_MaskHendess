using MenuShell.Domain;
using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml;

namespace MenuShell
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
        
            var Login = new LoginView();
            var ReceptionistMainMenu = new ReceptionistMainView();
            var RegisterNewCoustomer = new RegisterNewCoustomer();
            var SerchCoustomerView = new ListCoustomerView(); 

            var SysAdminMainMenu = new SySAdminMainView();

            var VetMainMenu = new VeterinaryMainView();
            while (true)
            {

                var result = Login.Display();
                if(result == "receptionist")
                {
                ReceptionistMainMenu.Display();
                }else if(result == "veterinary")
                {
                VetMainMenu.Display();
                }else if (result == "sysadmin")
                {
                SysAdminMainMenu.Display();
                }
            }
        }
    }
}
