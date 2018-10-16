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
            LoadCustomers customers = new LoadCustomers();
            customers.ListCustomers();
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            return "Defalut";
        }
    }
}
