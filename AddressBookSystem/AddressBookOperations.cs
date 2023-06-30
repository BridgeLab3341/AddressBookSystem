using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookOperations
    {
        Contacts contacts = new Contacts();
        List<Contacts> addressList = new List<Contacts>();
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
        public void EditContacts(string name)
        {
            foreach(var data in addressList)
            {

                if (data.First_Name.Equals(name.ToLower()))
                {
                    Console.WriteLine("\nChoose option to edit contact\n1.Last Name\n2.Address\n3.City\n4.State\n5.ZIP\n6.Phone number\n7.E-Mail");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            data.Last_Name = Console.ReadLine();
                            break;
                        case 2:
                            data.Address = Console.ReadLine();
                            break;
                        case 3:
                            data.City = Console.ReadLine();
                            break;
                        case 4:
                            data.State = Console.ReadLine();
                            break;
                        case 5:
                            data.Zip = Console.ReadLine();
                            break;
                        case 6:
                            data.Phone_number = Console.ReadLine();
                            break;
                        case 7:
                            data.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
