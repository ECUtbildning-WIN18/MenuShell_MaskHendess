using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MenuShell.Domain;

namespace MenuShell.View
{
    class ListCoustomerView : ConsoleView
    {
        public override string Display()
        {
          base.Display();
            Console.WriteLine("Listing Customers");
            //XDocument doc = XDocument.Load("Customers.xml");

            //foreach (var customer in doc)
            //{
            //    Console.WriteLine(customer.FirstName);
            //}
            //Console.ReadLine();
            return "Defalut";
        }
    }
}
