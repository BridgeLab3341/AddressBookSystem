using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
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
        public Dictionary<string, List<Contacts>> city = new Dictionary<string, List<Contacts>>();
        public Dictionary<string, List<Contacts>> state = new Dictionary<string, List<Contacts>>();
        public Dictionary<string, List<Contacts>> zipCode = new Dictionary<string, List<Contacts>>();
        public void AddContacts()
        {
            Contacts contacts = new Contacts();
            {
                Console.WriteLine("Enter First Name");
                contacts.First_Name = Console.ReadLine();
                //int a=CheckUnique(contacts.First_Name);
                //if (a == 0)
                int b = CheckDuplicate(Contacts.First_Name);
                if (b == 0)
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
            WriteToFile(@"D:\ReMapBridgeLabs\AddressBookSystem\AddressBookSystem\TextFile.txt");
            WriteFileCSV(@"D:\ReMapBridgeLabs\AddressBookSystem\AddressBookSystem\CSVData.csv");
            ReadJson(@"D:\ReMapBridgeLabs\AddressBookSystem\AddressBookSystem\JsonFile.json");
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
        public int CheckDuplicate(string name)
        {
            int sum = 0;
            if (dict.Count != 0)
            {
                foreach (var data in dict)
                {
                    foreach (var item in data.Value)
                    {
                        Console.WriteLine(data.Key.Any(x => x.Equals(name)));
                        if (data.Key.Any(x => x.Equals(name)))
                        {
                            Console.WriteLine("Duplicate is present");
                            sum = 1;
                            break;
                        }
                    }
                }

            }
            return sum;
        }
        public void SearchByCity(string city)
        {
            foreach(var data in dict)
            {
                foreach(var item in data.Value)
                {
                    if(item.City.Equals(city))
                    {
                        Console.WriteLine("\nFirst Name = " + item.First_Name + "  " + "\nLast Name = " + item.Last_Name + "  " + "\nAddress = " + item.Address + "  " + "\nCity = " + item.City + "  " + "  " + "\nState = " + item.State + "  " + "\nZip" + item.Zip + "  " + "\nPhone Number = " + item.Phone_number + "  " + "\nEmail = " + item.Email);
                    }
                }
            }
        }
        public void SearchByState(string state)
        {
            foreach (var data in dict)
            {
                foreach (var item in data.Value)
                {
                    if (item.State.Equals(state))
                    {
                        Console.WriteLine("\nFirst Name = " + item.First_Name + "  " + "\nLast Name = " + item.Last_Name + "  " + "\nAddress = " + item.Address + "  " + "\nCity = " + item.City + "  " + "  " + "\nState = " + item.State + "  " + "\nZip" + item.Zip + "  " + "\nPhone Number = " + item.Phone_number + "  " + "\nEmail = " + item.Email);
                    }
                }
            }
        }
        public void ByCity(string cityname)
        {
           var result=city.Keys.Where(x=>x.Equals(cityname)).ToList();
            Console.WriteLine("City Count = "+result.Count);
        }
        public void ByState(string statename)
        {
            var result = state.Keys.Where(x => x.Equals(statename)).ToList();
            Console.WriteLine("No of Contact ------------>" + result.Count);
        }
        public void Sort()
        {
            List<Contacts>list= new List<Contacts>();
            foreach(var data in dict)
            {
                foreach(var item in data.Value)
                {
                    list=data.Value.OrderBy(x=>x.First_Name).ToList();
                    Console.WriteLine(list);
                }
            }
        }
        public void SortByCity()
        {
            city = city.OrderBy(key => key.Key).ToDictionary(key => key.Key, key => key.Value);
            Console.WriteLine(city);
        }
        public void SortState()
        {
            state = state.OrderBy(key => key.Key).ToDictionary(key => key.Key, key => key.Value);
            Console.WriteLine(state);
        }
        public void SortZip()
        {
            zipCode = zipCode.OrderBy(key => key.Key).ToDictionary(key => key.Key, key => key.Value);
            Console.WriteLine(zipCode);
        }
        public void WriteToFile(string filePath)
        {
            using (StreamWriter sr = new StreamWriter(filePath))
            {
                foreach (var data in dict)
                {
                    sr.WriteLine("Key------------>" + data.Key);
                    foreach (var item in data.Value)
                    {
                        sr.WriteLine("First Name :" + item.First_Name + "\n" + "Last Name :" + item.Last_Name + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.Zip + "\n" + "Phone Number :" + item.Phone_number + "\n" + "Mail Id :" + item.Email);
                    }
                }
            }
        }
        public void ReadFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.ReadLine() != null)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
        public void WriteFileCSV(string filePath)
        {
            using(var writer=new StreamWriter(filePath))
                using(var csvwriter=new CsvWriter(writer,CultureInfo.InvariantCulture))
            {

            }
        }
        public void ReadCSV(string filePath)
        {
            List<Contacts> contacts = new List<Contacts>();
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                contacts = csv.GetRecords<Contacts>().ToList();
                foreach (var item in contacts)
                {
                    Console.WriteLine("First Name :" + item.First_Name + "\n" + "Last Name :" + item.Last_Name + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.Zip + "\n" + "Phone Number :" + item.Phone_number + "\n" + "Mail Id :" + item.Email);
                }
            }
        }
        public void ReadJson(string filePath)
        {
            Dictionary<string, List<Contacts>> records = JsonConvert.DeserializeObject<Dictionary<string, List<Contacts>>>(File.ReadAllText(filePath));
            foreach (var data in records)
            {
                foreach (var item in data.Value)
                {
                    Console.WriteLine("First Name :" + item.First_Name + "\n" + "Last Name :" + item.Last_Name + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.Zip + "\n" + "Phone Number :" + item.Phone_number + "\n" + "Mail Id :" + item.Email);
                }
            }
        }
    }
}
