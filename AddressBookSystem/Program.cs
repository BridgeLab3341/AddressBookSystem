using AddressBookSystem;

namespace AddressBookSysytem
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBookOperations address=new AddressBookOperations();
            address.AddContacts();
            address.Display();
        }
    }
}
