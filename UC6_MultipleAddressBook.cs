using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC6_MultipleAddressBook
    {
        
        public static List<String> Family = new List<String>();
        public static List<String> Friends = new List<String>();
        public static List<String> Colleagues = new List<String>();


        public static Dictionary<int, List<string>> addressBook = new Dictionary<int, List<string>>();
        
       
        static String firstName;
        static String lastName;
        static long phoneNumber;
        static String email;
        static String address;
        static String city;
        static String state;
        static int zipCode;
        
        public static void multipleAddressBook()
        {
            Console.WriteLine("Select an option: ");
            Console.Write("1. Create Contact \n2. Display Contacts \n0. Exit\nOption:  ");
            int option = Convert.ToInt32(Console.ReadLine());

            addressBook[1] = Family;
            addressBook[2] = Friends;
            addressBook[3] = Colleagues;

            switch (option)
            {
                case 1:
                    CreateContact(addressBook);
                    break;
                case 2:
                    DisplayContacts(addressBook);
                    break;
                case 0:
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    toContinue();
                    break;

            }
        }

        public static void CreateContact(Dictionary<int, List<string>> addressBook)
        {
            Console.WriteLine("\n\nSelect group: ");
            Console.Write("1. Family \n2. Friends \n3. Colleagues\n0. Exit\nOption:  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddContact(addressBook[1]);
                    break;
                case 2:
                    AddContact(addressBook[2]);
                    break;
                case 3:
                    AddContact(addressBook[3]);
                    break;
                case 0:
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }

        public static void DisplayContacts(Dictionary<int, List<string>> addressBook)
        {
            int number = 0;
            Console.WriteLine("\nContacts: ");
            foreach (int key in addressBook.Keys)
            {
                foreach (var contacts in addressBook[key])
                {
                    number++;
                    Console.WriteLine("{0}. {1}",number,contacts);
                  
                   
                }
            }
        }

        public static void AddContact(List<string> group)
        {
            int count = 0;

            string contact;
            char ch;
            do
            {
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nPlease Enter Contact Details: \n");
                ContactDeatils();
                Console.WriteLine("\nContact Created.\n");

                contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                group.Add(contact);
                count++;

                Console.WriteLine("Do you want to add more contacts: y/n");
                ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            }
            while (ch == 'y');

            Console.WriteLine("\n{0} new contact created.\n", count);
            toContinue();
        }

        public static void ContactDeatils()
        {

            Console.Write("First Name : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            lastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            email = Console.ReadLine(); ;
            Console.Write("Address : ");
            address = Console.ReadLine();
            Console.Write("City : ");
            city = Console.ReadLine();
            Console.Write("State : ");
            state = Console.ReadLine();
            Console.Write("Zip : ");
            zipCode = Convert.ToInt32(Console.ReadLine());
        }

        public static void toContinue()
        {
            char ch;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nDo you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            if (ch == 'y')
            {
                multipleAddressBook();
            }
            else
            {
                Environment.Exit(-1);
            }
        }

       

    }
}
