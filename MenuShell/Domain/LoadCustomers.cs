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
                customers.Add(new Customer(firstname, lastname, socialsecuritynumber, petname, petspecies));
            }

            return customers;
        }

        public void Addelement(string FirstName, string LastName, string SSN, string PetName, string Species)
        {
            var DOC = XDocument.Load("Customers.xml"); // This is the xml file we load from
            var NewDude = new Customer(FirstName, LastName, SSN, PetName, Species);
            DOC.Root.Add(NewDude);

        }
    }
}
