using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    
    class UC3_UpdateExistingContact
    {
        static String firstName;
        static String lastName ;
        static long phoneNumber;
        static String email;
        static String address ;
        static String city ;
        static String state;
        static int zipCode;
        public static List<String> addressBook = new List<String>();
       
        public static void UpdateContact()
        {
            Console.WriteLine("Select an option: ");
            Console.Write("1. Create Contact \n2. Update Contact \n0. Exit\nOption:  ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    
                    CreateContact(addressBook);
                    break;
                case 2:
                   UpdateExistingContact(addressBook);
                    break;
                default:
                    Environment.Exit(-1);
                    break;
            }

        }


        // method for updating an existing contact searching by contact name
        public static void UpdateExistingContact(List<string> addressBook)
        {
            if(addressBook.Count == 0){
                Console.Write("\nAddress Book is empty. \n\n");
                toContinue();
            }
            else
            {
                Console.Write("\nEnter contact name that you want to update:  ");
                String name = Console.ReadLine();
                for (int i= 0; i <  addressBook.Count; i++)
                {
                    String[] contactArray = addressBook[i].Split(" ");

                    for (int j = 0; j < contactArray.Length; j++)
                    {
                        if(name == contactArray[0])
                        {
                            Console.WriteLine("\nPlease update contact details:  \n");
                            ContactDeatils();
                           String updatedContact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                           addressBook[i] = updatedContact;
                           break;
                         }
                    }
                }

                Console.WriteLine("\n\nContact Updated.\n");

                for (int i = 0; i < addressBook.Count; i++)
                {
                    Console.WriteLine("{0}.  {1}", i+1, addressBook[i]);
                }
                toContinue();

            }   
        }

        // method for creating new contact in address book
        public static void CreateContact(List<string> addressBook)
        {
            int count = 0;
            string contact;
            char ch;
            do
            {
                Console.WriteLine("\nPlease Enter Contact Details: \n");
                ContactDeatils();
                Console.WriteLine("\nContact Created.\n");

                contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                addressBook.Add(contact);
                count++;

                Console.WriteLine("Do you want to continue: y/n");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'y');


            Console.WriteLine("\n{0} contacts\n", count);

            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i, addressBook[i]);
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
        public static void toContinue() {
            char ch;
            Console.WriteLine("Do you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n\n");
            if (ch == 'y')
            {
                UpdateContact();
            }
            else
            {
                Environment.Exit(-1);
            }
        }    
    }
}
