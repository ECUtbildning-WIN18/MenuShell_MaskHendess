using System;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class DeleateCustomer
    {
        public void GoodByeForever(string input)
        {
            Console.Clear();
            XDocument doc = XDocument.Load("Customers.xml");
            var root = doc.Root;

            foreach (XElement element in root.Elements())
            {
                var elmentusername = Convert.ToString(element.Attribute("firstname"));
                if (input == elmentusername)
                {
                    element.RemoveAll();
                    element.Remove();
                    Console.WriteLine("Customer Sucessfully Deleted");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                    doc.Save("Customers.xml");
                }
            }
        }
    }
}
