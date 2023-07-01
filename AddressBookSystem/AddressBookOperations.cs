using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookOperations
    {
        List<Contacts> addressList = new List<Contacts>();
        public void AddContacts()
        {
            Contacts contacts = new Contacts();
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
            addressList.Add(contacts);
        }
        public void Display()
        {
            foreach(var data in  addressList)
            {
                Console.WriteLine("First Name = "+data.First_Name+"  "+"Last Name = "+data.Last_Name+"  "+"Address = "+data.Address+"  "+"City = "+data.City+"  "+"Zip" +data.Zip+"  "+"Phone Number = "+data.Phone_number+"  "+"Email = "+data.Email);
            }
        }
    }
}
