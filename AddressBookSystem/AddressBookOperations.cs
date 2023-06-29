using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookOperations
    {
       // List<Contacts> addressList = new List<Contacts>();
        Contacts contacts = new Contacts();
        public void AddContacts()
        {
            {
                Console.WriteLine("Enter First Name");
                contacts.First_Name = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                contacts.Last_Name = Console.ReadLine();
                Console.WriteLine("Enter Address");
                contacts.Address = Console.ReadLine();
                Console.WriteLine("Enter City Name");
                contacts.City = Console.ReadLine();
                Console.WriteLine("Enter Zip Code");
                contacts.Zip = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                contacts.Phone_number = Console.ReadLine();
                Console.WriteLine("Enter Email");
                contacts.Email = Console.ReadLine();
            }
        }
        public void Display()
        {
            {
                Console.WriteLine("1.First Name: {0}\n2.Last Name: {1}\n3.Address: {2}\n4.City: {3},\n5.Zip: {4}\n6.Phone Number: {5}\n7.Email: {6}",contacts.First_Name,contacts.Last_Name,contacts.Address,contacts.City,contacts.Zip,contacts.Phone_number,contacts.Email);
            }
        }
    }
}
