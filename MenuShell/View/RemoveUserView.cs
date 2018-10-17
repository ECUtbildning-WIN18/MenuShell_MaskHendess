using MenuShell.Domain;
using System;

namespace MenuShell.View
{
    class RemoveUserView : ConsoleView // this class might be obsolite?
    {
        bool SuccessfulyRemovedUser = false;
        public override string Display()
        {
                base.Display();
                ListUsers users = new ListUsers();
                users.Display();
                string UserName = users.ShowDetails();
            
            return "User Removed";
        }

        
    }
}
