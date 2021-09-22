using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC4_DeleteContact
    {
        static String firstName;
        static String lastName;
        static long phoneNumber;
        static String email;
        static String address;
        static String city;
        static String state;
        static int zipCode;
        public static List<String> addressBook = new List<String>();

        public static void ContactDelete()
        {
            Console.WriteLine("Select an option: ");
            Console.Write("1. Create Contact \n2. Delete Contact \n0. Exit\nOption:  ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    CreateContact(addressBook);
                    break;
                case 2:
                    DeleteExistingContact(addressBook);
                    break;
                default:
                    Environment.Exit(-1);
                    break;
            }

        }

        // method for deleting an existing contact
        public static void DeleteExistingContact(List<string> addressBook)
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            if (addressBook.Count == 0)
            {
                Console.Write("\nAddress Book is empty. \n\n");
                toContinue();
            }
            else
            {
                Console.Write("\nEnter contact name that you want to delete:  ");
                String name = Console.ReadLine();
                for (int i = 0; i < addressBook.Count; i++)
                {
                    String[] contactArray = addressBook[i].Split(" ");

                    for (int j = 0; j < contactArray.Length; j++)
                    {
                        if (name == contactArray[0])
                        {
                            addressBook.RemoveAt(i);
                            break;
                        }
                    }
                }


                Console.WriteLine("\n\nContact Deleted.\n");

                for (int i = 0; i < addressBook.Count; i++)
                {
                    Console.WriteLine("{0}.  {1}", i+1, addressBook[i]);
                }
                toContinue();
            }
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
        }

      
        // method for creating contact
        public static void CreateContact(List<string> addressBook)
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
                addressBook.Add(contact);
                count++;

                Console.WriteLine("Do you want to continue: y/n");
                ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            }
            while (ch == 'y');


            Console.WriteLine("\n{0} contacts\n", count);

            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i+1, addressBook[i]);
            }
            toContinue();
        }

        // method for taking user input from console for creating or updating a contact
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

        // method for asking user to continue
        public static void toContinue()
        {
            char ch;
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nDo you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            if (ch == 'y')
            {
                ContactDelete();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}