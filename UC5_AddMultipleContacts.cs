using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC5_AddMultipleContacts
    {
        static int num;
        static String firstName;
        static String lastName;
        static long phoneNumber;
        static String email;
        static String address;
        static String city;
        static String state;
        static int zipCode;
        public static List<String> addressBook = new List<String>();
        static int count = 0;
        public static void AddMultipleContacts()
        {
            Console.Write("How many contacts you want to add into address book:   ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i< num; i++)
            {
                CreateContact(addressBook,i);
            }

            Console.WriteLine("\n{0} contacts\n", count);

            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i+1, addressBook[i]);
            }
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");

            toContinue();
        }

        public static void CreateContact(List<string> addressBook,int i)
        {
           
            string contact;
            
            Console.WriteLine("\nContact number-{0} details :  \n",i+1);
           
            ContactDeatils();
            
            Console.WriteLine("\nContact Created.\n");
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");

            contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
            addressBook.Add(contact);
            count++;

            
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
            Console.WriteLine("Do you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n\n");
            if (ch == 'y')
            {
                AddMultipleContacts();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
