using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; }
        public string PetName { get; set; }
        public string Petspecies { get; set; }
        DateTime Appointment { get; set; }

        public Customer(string firstName, string lastName, string sSN, string petName, string petspecies, DateTime appointment)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = sSN;
            PetName = petName;
            Petspecies = petspecies;
            Appointment = appointment;
        }

        public override string ToString()
        {
            return FirstName + "\t" + LastName +"\t" + SSN;
        }
    }
}
