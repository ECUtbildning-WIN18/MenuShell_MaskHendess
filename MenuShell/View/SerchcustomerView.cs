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
            Console.WriteLine("Enter Customer Firstname:");
            string input = Console.ReadLine();
            var customers = new LoadCustomers();
            var customerlist = customers.LoadCustomersList();
            foreach (var customer in customerlist)
            {
                if(customer.FirstName == input)
                {
                    Console.WriteLine(customer.FirstName);
                }
            }
            Console.ReadKey();
            Console.WriteLine("1. Set Appointment");
            return "Woah";
        }
    }
}
