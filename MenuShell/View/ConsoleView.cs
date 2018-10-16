using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.View
{
    class ConsoleView
    {
        public virtual string Display()
        {
            Console.Clear();
           
            return "Return Me";
        }
    }
}
