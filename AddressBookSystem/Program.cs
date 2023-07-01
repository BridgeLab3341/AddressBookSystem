using AddressBookSystem;

namespace AddressBookSysytem
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose the Option to Perform the Opearation\n1.Add Contact to the List\n2.Edit Contact List\n3.Delete Contact\n4.Search By City\n5.Search By State\n6.Count By City and State\n7.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                AddressBookOperations address = new AddressBookOperations();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number of contacts to add");
                        int n=Convert.ToInt32(Console.ReadLine());
                        for(int i=0; i<n; i++)
                        {
                            address.AddContacts();
                        }
                        address.Display();
                        break;
                        case 2:
                        Console.WriteLine("Enter First Name");
                        address.EditContacts(Console.ReadLine());
                        address.Display();
                        break;
                        case 3:
                        Console.WriteLine("Enter First Name to Delete");
                        address.DeleteContact(Console.ReadLine());
                        address.Display();
                        break;
                        case 4:
                        Console.WriteLine("Enter City Name to Search");
                        string city=Console.ReadLine();
                        address.SearchByCity(city);
                        break;
                        case 5:
                        Console.WriteLine("Enter State Name to Search");
                        string state=Console.ReadLine();
                        address.SearchByState(state);
                        break;
                        case 6:
                        Console.WriteLine("Enter City Name");
                        string cit=Console.ReadLine();
                        address.ByCity(cit);
                        Console.WriteLine("Enter City Name");
                        string stat = Console.ReadLine();
                        address.ByState(stat);
                        break;
                        case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
