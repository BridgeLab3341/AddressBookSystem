using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookOperations
    {
        List<Contacts> addressList = new List<Contacts>();
        Contacts Contacts=new Contacts();
        Dictionary<string, List<Contacts>> dict = new Dictionary<string, List<Contacts>>();
        public void AddContacts()
        {
            Contacts contacts = new Contacts();
            {
                Console.WriteLine("Enter First Name");
                contacts.First_Name = Console.ReadLine();
                int a=CheckUnique(contacts.First_Name);
                if (a == 0)
                {
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
            }
            addressList.Add(contacts);
        }
        public void Display()
        {
            foreach(var data in  addressList)
            {
                Console.WriteLine("\nFirst Name = "+data.First_Name+"  "+"\nLast Name = "+data.Last_Name+"  "+"\nAddress = "+data.Address+"  "+"\nCity = "+data.City+"  "+"  "+"\nState = "+data.State+"  "+"\nZip" +data.Zip+"  "+"\nPhone Number = "+data.Phone_number+"  "+"\nEmail = "+data.Email);
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
                            Display();
                            break;
                            case 2:
                            Console.WriteLine("Enter Last Name");
                            data.Address = Console.ReadLine();
                            Display();
                            break;
                            case 3:
                            Console.WriteLine("Enter Last Name");
                            data.City = Console.ReadLine();
                            Display();
                            break;
                            case 4:
                            Console.WriteLine("Enter Last Name");
                            data.State = Console.ReadLine();
                            Display();
                            break;
                            case 5:
                            Console.WriteLine("Enter Last Name");
                            data.Zip = Console.ReadLine();
                            Display();
                            break;
                            case 6:
                            Console.WriteLine("Enter Last Name");
                            data.Phone_number = Console.ReadLine();
                            Display();
                            break;
                            case 7:
                            Console.WriteLine("Enter Last Name");
                            data.Email = Console.ReadLine();
                            Display();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("First Name not Matching .........");
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contacts contacts = new Contacts();
            foreach(var data in addressList)
            {
                if(data.First_Name == name)
                {
                    contacts=data;
                }
                if(data.First_Name == null)
                {
                    Console.WriteLine("No Contact Exits With Respect to First Namw");
                }
                else
                {
                    Console.WriteLine(contacts);
                }
            }
        }
        public int CheckUnique(string name)
        {
            int flag = 0;
            if (dict.Count != 0)
            {
                foreach (var data in dict)
                {
                    foreach (var item in data.Value)
                    {
                        if (data.Key.Equals(name))
                        {
                            Console.WriteLine("The Name You have given is Already Present");
                            flag = 1;
                            break;
                        }
                    }
                }
            }
            return flag;
        }
    }
}
