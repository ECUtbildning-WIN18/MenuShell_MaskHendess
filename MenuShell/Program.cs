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
            Console.Title = "Login Menu";


            var Login = new LoginView();
            var ReceptionistMainMenu = new ReceptionistMainView();
            var RegisterNewCoustomer = new RegisterNewCoustomer();
            var SerchCoustomerView = new SerchCoustomerView(); 

            var result = Login.Display();
            if(result == "receptionist")
            {
            ReceptionistMainMenu.Display();
            }else if(result == "veterinary")
            {
                // vet menu go
            }else if (result == "sysadmin")
            {
                // admin menu go
            }
            //var result = ReceptionistMainMenu.Display();
            //if(result == "1")
            //{
            //    RegisterNewCoustomer.Display();
            //}else if(result == "2")
            //{
            //    SerchCoustomerView.Display();
            //}else if(result == "3")
            //{
            //    GitNuke();   
            //}
            ReceptionistMainMenu.Display();
        }
        
        public static void GitNuke()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
                Thread.Sleep(1);
            }
            Environment.Exit(0);
        }
    }
}
