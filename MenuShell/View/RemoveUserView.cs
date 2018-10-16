using MenuShell.Domain;
using System;

namespace MenuShell.View
{
    class RemoveUserView : ConsoleView
    {
        bool SuccessfulyRemovedUser = false;
        public override string Display()
        {

            while (SuccessfulyRemovedUser == false)
            {
                base.Display();
                RemoveUser();
            }
            return "User Removed";
        }

        private void RemoveUser()
        {
            GetUsers users = new GetUsers();
           var userslist = users.LoadUsers();
            users.ListUsers();
            Console.Write("Enter a Username:");
            var input = "username=\"" + Console.ReadLine() +"\"";
            
            Console.Write("Do you wish to Delete selected User? (Y)es/(N)o");
            var consoleKeyInfo = Console.ReadKey();
            if(consoleKeyInfo.Key == ConsoleKey.Y)
            {
                DeleateUser SelectedUser = new DeleateUser();
                SelectedUser.GoodByeForever(input);
                SuccessfulyRemovedUser = true;
            }
            else
            {
                SuccessfulyRemovedUser = false;
            }
        }
    }
}
