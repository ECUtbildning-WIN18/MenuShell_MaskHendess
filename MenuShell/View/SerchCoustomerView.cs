using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class SerchCoustomerView : ConsoleView
    {
        public override string Display()
        {
            Console.WriteLine("Serch kustomer. . . There are none");
            return base.Display();
        }
    }
}
