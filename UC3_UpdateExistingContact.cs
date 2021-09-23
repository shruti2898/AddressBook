using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookOOPS
{
    class UC3_UpdateExistingContact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }

        //method for updating details
        public static void UpdateContactDetails(UC3_UpdateExistingContact updateInfo, List<String> addressBook)
        {
            Console.Write("\nFirst Name:   ");
            updateInfo.firstName = Console.ReadLine();
            UC6_UniqueNameInAddressBook.checkUniqueName(updateInfo.firstName, addressBook);
            Console.Write("Last Name:   ");
            updateInfo.lastName = Console.ReadLine();
            Console.Write("Address:   ");
            updateInfo.address = Console.ReadLine();
            Console.Write("City:   ");
            updateInfo.city = Console.ReadLine();
            Console.Write("State:   ");
            updateInfo.state = Console.ReadLine();
            Console.Write("Zip:   ");
            updateInfo.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email:   ");
            updateInfo.email = Console.ReadLine();
            Console.Write("Phone Number:   ");
            updateInfo.phoneNumber = Convert.ToInt64(Console.ReadLine());
        }
    }
}
