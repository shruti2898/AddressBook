using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookOOPS
{
    class UC1_CreateContact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }
        public static void Contact(UC1_CreateContact person)
        {
            Console.Write("\nEnter Contact Details:  \nFirst Name:   ");
            person.firstName = Console.ReadLine();
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
            Console.WriteLine("\n\nContact Created\n\n{0}",newContact);            
        }       
    }
}
