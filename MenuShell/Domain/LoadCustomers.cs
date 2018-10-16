using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class LoadCustomers
    {
        List<Customer> customers = new List<Customer>();

        public List<Customer> LoadCustomersList()
        {
            var DOC = XDocument.Load("Customers.xml"); // This is the xml file we load from

            var ROOT = DOC.Root;

            foreach (var element in ROOT.Elements())
            {
                var firstname = element.Attribute("firstname").Value;
                var lastname = element.Attribute("lastname").Value;
                var socialsecuritynumber = element.Attribute("SSN").Value;
                var petname = element.Attribute("petname").Value;
                var petspecies = element.Attribute("petspecies").Value;
                var appointement = element.Attribute("appointment").Value;
                DateTime appointmentDate = Convert.ToDateTime(appointement);
                customers.Add(new Customer(firstname, lastname, socialsecuritynumber, petname, petspecies, appointmentDate));
            }

            return customers;
        }

        public void Addelement(string FirstName, string LastName, string SSN, string PetName, string Species)
        {
            var DOC = XDocument.Load("Customers.xml"); // This is the xml file we load from
            XElement NewCustomer = new XElement("Customer",
                new XAttribute("firstname", FirstName),
                new XAttribute("lastname", LastName),
                new XAttribute("SSN", SSN),
                new XAttribute("petname", PetName),
                new XAttribute("petspecies", Species),
                new XAttribute("appointment", DateTime.Now));
            DOC.Root.Add(NewCustomer);
            DOC.Save("Customers.xml");

        }

        public void ListCustomers()
        {
            var customerlist = new LoadCustomers();
            var customers = customerlist.LoadCustomersList();
            Console.WriteLine("Customers:\n");
            
            foreach (var element in customers)
            {

                Console.WriteLine(element.FirstName + " " + element.LastName + ", SSN: " + element.SSN +
                                    " Patient: " + element.PetName + " Species: " + element.Petspecies);
            }
        }
    }
}
