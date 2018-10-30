using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class ListUsers
    {
        private GetUsers userslist = new GetUsers();
       private List<User> users = new List<User>();
        
        public void Display()
        {
            Console.Clear();
            users = userslist.LoadUsers();
            Console.WriteLine("Users:\n");
            foreach (var element in users)
            {
                Console.WriteLine(element.Username);
            }
        }
        
        public string ShowDetails()
        {
            string UserName = "";
            Console.WriteLine("(V)iew Details (B)ack");
            var Input = Console.ReadKey();
            if (Input.Key == ConsoleKey.V)
            {
                Console.WriteLine("Enter User Name:");
                UserName = Console.ReadLine();
                FetchDetails(UserName);

            }

            return UserName;
        }

        private void FetchDetails(string userName)
        {
            int i = 0;
            users = userslist.LoadUsers();
            foreach (User user in users)
            {
                if (user.Username == userName)
                {
                    Console.Clear();
                    Console.WriteLine("Username: " + user.Username + "\nPassword: " + user.PassWord + "\nRole: " + user.Role);
                    i = 1;
                    DeleteUserReview(userName);
                }
            }

            if (i == 0)
            {
                Console.WriteLine("User Not Found.");
                Console.WriteLine("Press Any key to Continue");
                Console.ReadKey();
            }
        }

        private void DeleteUserReview(string userName)
        {
            Console.WriteLine("Delete User? (Y)es/(N)o");
            var input = Console.ReadKey();
            userName = "username=\"" + userName + "\""; // userName == userName in the xml document
            if (input.Key == ConsoleKey.Y)
            {
                DeleateUser SelectedUser = new DeleateUser();
                SelectedUser.GoodByeForever(userName);
            }
        }

    }
}

