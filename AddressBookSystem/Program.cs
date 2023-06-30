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
                Console.WriteLine("Choose the Option to Perform the Opearation\n1.Add Contact to the List\n2.Edit Contact List\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                AddressBookOperations address = new AddressBookOperations();
                switch (option)
                {
                    case 1:
                        address.AddContacts();
                        address.Display();
                        break;
                        case 2:
                        address.EditContacts();
                        //address.Display();
                        break;
                        case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
