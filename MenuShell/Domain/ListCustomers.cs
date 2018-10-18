using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class ListCustomers
    {
            private LoadCustomers Customerslist = new LoadCustomers();
            private List<Customer> customers = new List<Customer>();

            public void Display()
            {
                Console.Clear();
                customers = Customerslist.LoadCustomersList();
                Console.WriteLine("Customers:\n");
                foreach (var element in customers)
                {
                    Console.WriteLine(element.FirstName + " " + element.PetName);
                }
            }

            public string ShowDetails()
            {
                string CustomerName = "";
                Console.WriteLine("(V)iew Details (B)ack");
                var Input = Console.ReadKey();
                if (Input.Key == ConsoleKey.V)
                {
                    Console.WriteLine("Enter Customers Name");
                    CustomerName = Console.ReadLine();
                    FetchDetails(CustomerName);

                }

                return CustomerName;
            }

            private void FetchDetails(string customerName)
            {
                int i = 0;
                customers = Customerslist.LoadCustomersList();
                foreach (Customer customer in customers)
                {
                    if (customer.FirstName == customerName)
                    {
                        Console.Clear();
                    Console.WriteLine("Firstname: " + customer.FirstName + " " +
                            "\nLastname:" + customer.LastName +
                            "\nSSN: " + customer.SSN +
                            "\nPetName: " + customer.PetName +
                            "\nSpecies:" + customer.Petspecies);
                            i = 1;
                        DeleteCustomerReview(customerName);
                    }
                }

                if (i == 0)
                {
                    Console.WriteLine("User Not Found.");
                    Console.WriteLine("Press Any key to Continue");
                    Console.ReadKey();
                }
            }

            private void DeleteCustomerReview(string userName)
            {
                Console.WriteLine("Delete Customer? (Y)es/(N)o");
                var input = Console.ReadKey();
                userName = "firstname=\"" + userName + "\""; // userName == userName in the xml document
                
                if (input.Key == ConsoleKey.Y)
                {
                    DeleateCustomer SelectedCustomer = new DeleateCustomer();
                    SelectedCustomer.GoodByeForever(userName);
                }
            }

        }
    }


