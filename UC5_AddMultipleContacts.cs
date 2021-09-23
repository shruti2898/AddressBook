using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookOOPS 
{
    class UC5_AddMultipleContacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }

        public static void AddMultipleContacts(UC5_AddMultipleContacts multipleContacts , List<String> addressBook ,int i)
        {
            Console.Write("\nEnter Contact-{0} Details:  \nFirst Name:   ", i+1);
            multipleContacts.firstName = Console.ReadLine();
            UC6_UniqueNameInAddressBook.checkUniqueName(multipleContacts.firstName, addressBook);
            Console.Write("Last Name:   ");
            multipleContacts.lastName = Console.ReadLine();
            Console.Write("Address:   ");
            multipleContacts.address = Console.ReadLine();
            Console.Write("City:   ");
            multipleContacts.city = Console.ReadLine();
            Console.Write("State:   ");
            multipleContacts.state = Console.ReadLine();
            Console.Write("Zip:   ");
            multipleContacts.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email:   ");
            multipleContacts.email = Console.ReadLine();
            Console.Write("Phone Number:   ");
            multipleContacts.phoneNumber = Convert.ToInt64(Console.ReadLine());

            string newContact = multipleContacts.firstName + " " + multipleContacts.lastName + " " + multipleContacts.phoneNumber.ToString() + " " + multipleContacts.email + " " + multipleContacts.address + " " + multipleContacts.city + " " + multipleContacts.state + " " + multipleContacts.zip.ToString();
            addressBook.Add(newContact);
        }
    }
}
