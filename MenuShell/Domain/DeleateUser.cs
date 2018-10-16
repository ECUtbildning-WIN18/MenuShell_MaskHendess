using System;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class DeleateUser
    {
        public void GoodByeForever(string input)
        {
            XDocument doc = XDocument.Load("Users.xml");
            var root = doc.Root;

            foreach (XElement element in root.Elements())
            {
                var elmentusername = Convert.ToString(element.Attribute("username"));
                if (input == elmentusername)
                {
                    element.RemoveAll();
                    element.Remove();
                    Console.WriteLine("Element Removed");
                    doc.Save("Users.xml");
                }
            }
        }
    }
}
