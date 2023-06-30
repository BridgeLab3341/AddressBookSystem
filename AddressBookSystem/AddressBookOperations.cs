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
                Console.WriteLine("1.First Name=" + contacts.First_Name + "\n2.Last Name=" + contacts.Last_Name + "\n3.Address=" + contacts.Address + "\n4.City=" + contacts.City + "\n5.Zip=" + contacts.Zip + "\n6.Phone Number=" + contacts.Phone_number + "\n7.Email=" + contacts.Email);
            }
        }
        public void EditContacts()
        {
            Console.WriteLine("\nChoose option to edit contact\n1.First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.ZIP\n7.Phone number\n8.E-Mail");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                        Console.WriteLine(contacts.First_Name);
                    break;
                case 2:
                    contacts.Last_Name = Console.ReadLine();
                    break;
                case 3:
                    contacts.Address = Console.ReadLine();
                    break;
                case 4:
                    contacts.City = Console.ReadLine();
                    break;
                case 5:
                    contacts.State = Console.ReadLine();
                    break;
                case 6:
                    contacts.Zip = Console.ReadLine();
                    break;
                case 7:
                    contacts.Phone_number = Console.ReadLine();
                    break;
                case 8:
                    contacts.Email = Console.ReadLine();
                    break;
            }
        }
    }
}
