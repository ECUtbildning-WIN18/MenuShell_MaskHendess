using System;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class DeleateUser
    {
        public void GoodByeForever(string input)
        {
            Console.Clear();
            XDocument doc = XDocument.Load("Users.xml");
            var root = doc.Root;

            foreach (XElement element in root.Elements())
            {
                var elmentusername = Convert.ToString(element.Attribute("username"));
                if (input == elmentusername)
                {
                    element.RemoveAll();
                    element.Remove();
                    Console.WriteLine("User Sucessfully Deleted");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                    doc.Save("Users.xml");
                }
            }
        }
    }
}
