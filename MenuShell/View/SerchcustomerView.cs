using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class SerchcustomerView : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            ListCustomers Customers = new ListCustomers();
            Customers.Display();
            string UserName = Customers.ShowDetails();
            DeleateCustomer delete = new DeleateCustomer();

            return "Customer Removed";
        }
    }
}
