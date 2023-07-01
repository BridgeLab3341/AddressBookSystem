using System;
using System.Collections.Generic;
using System.Data;
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
                Console.WriteLine("Enter State Name");
                contacts.State = Console.ReadLine();
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
                Console.WriteLine("First Name = "+data.First_Name+"  "+"Last Name = "+data.Last_Name+"  "+"Address = "+data.Address+"  "+"City = "+data.City+"  "+"  "+"State = "+data.State+"  "+"Zip" +data.Zip+"  "+"Phone Number = "+data.Phone_number+"  "+"Email = "+data.Email);
            }
        }
        public void EditContacts(string name)
        {
            foreach(var data in addressList)
            {
                if(data.First_Name == name)
                {
                    Console.WriteLine("Choose Option to Edit Deatils\n1.Last Name\n2.Addresss\n3.City\n4.State\n5.Zip\n6.Phone Number\n7.Email");
                    int option=Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            Console.WriteLine("Enter Last Name");
                            data.Last_Name = Console.ReadLine();
                            break;
                            case 2:
                            Console.WriteLine("Enter Last Name");
                            data.Address = Console.ReadLine();
                            break;
                            case 3:
                            Console.WriteLine("Enter Last Name");
                            data.City = Console.ReadLine();
                            break;
                            case 4:
                            Console.WriteLine("Enter Last Name");
                            data.State = Console.ReadLine();
                            break;
                            case 5:
                            Console.WriteLine("Enter Last Name");
                            data.Zip = Console.ReadLine();
                            break;
                            case 6:
                            Console.WriteLine("Enter Last Name");
                            data.Phone_number = Console.ReadLine();
                            break;
                            case 7:
                            Console.WriteLine("Enter Last Name");
                            data.Email = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("First Name not Matching .........");
                }
            }
        }
    }
}
