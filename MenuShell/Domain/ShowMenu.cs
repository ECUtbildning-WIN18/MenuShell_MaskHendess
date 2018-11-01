using System;

namespace MenuShell.View
{
    class ShowMenu
    {
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var Login = new LoginView();

            var ReceptionistMainMenu = new ReceptionistMainView();
            var SysAdminMainMenu = new SySAdminMainView();
            var VetMainMenu = new VeterinaryMainView();
            // Got muh Menus!

            bool theDream = true;
            while (theDream == true)
            {
                var result = Login.Display();// Goes through the Login Menu, returns a user role

                if (result == "receptionist") // checks result and then takes you to the right menu 
                {
                    ReceptionistMainMenu.Display();
                }
                else if (result == "veterinary")
                {
                    VetMainMenu.Display();
                }
                else if (result == "sysadmin")
                {
                    SysAdminMainMenu.Display();
                }
            }
        }
    }
}
