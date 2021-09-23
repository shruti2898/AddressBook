using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookOOPS
{
    class UC2_AddNewContact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }
        
        // method for creating contact in addressBook
        public static void AddContact(UC2_AddNewContact person, List<String> addressBook)
        {
            Console.Write("\nEnter Contact Details:  \nFirst Name:   ");
            person.firstName = Console.ReadLine();
            UC6_UniqueNameInAddressBook.checkUniqueName(person.firstName, addressBook);
            Console.Write("Last Name:   ");
            person.lastName = Console.ReadLine();
            Console.Write("Address:   ");
            person.address = Console.ReadLine();
            Console.Write("City:   ");
            person.city = Console.ReadLine();
            Console.Write("State:   ");
            person.state = Console.ReadLine();
            Console.Write("Zip:   ");
            person.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email:   ");
            person.email = Console.ReadLine();
            Console.Write("Phone Number:   ");
            person.phoneNumber = Convert.ToInt64(Console.ReadLine());
          
            string newContact = person.firstName + " " + person.lastName + " " + person.phoneNumber.ToString() + " " + person.email + " " + person.address + " " + person.city + " " + person.state + " " + person.zip.ToString();
            addressBook.Add(newContact);
        }
    }
}
