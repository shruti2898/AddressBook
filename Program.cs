using System;
using System.Collections.Generic;

namespace AddressBookOOPS
{
    class Program
    {
        public static List<String> addressBook = new List<String>();
        public static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("===================================Welcome to Address Book Management System===========================================");

            //Use Case 1:  creating new contact using object creation of class UC1_CreateContact and parsing this newly created object into class method.
            //UC1_CreateContact createContact = new UC1_CreateContact();
            //UC1_CreateContact.Contact(createContact);


            // Method for a switch-case base menu of remaining use cases from use case 2 to use case 6
            MainMenu();

            Console.ReadKey();
        }

        public static void MainMenu()
        {
            Console.WriteLine("\n\nSelect an option: \n1. Create Contact \n2. Update Contact \n3. Delete Contact \n4. Add Multiple Contacts \n5. Display Contacts\n0. Exit\n");
            Console.Write("Option:   ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {   // Use Case 2: Creating a new contact into address book also checking if entered name is unique or not using UC6 class.
                        char ch;
                        do
                        {
                            UC2_AddNewContact person = new UC2_AddNewContact();
                            UC2_AddNewContact.AddContact(person, addressBook);
                            count++;
                            Console.WriteLine("\nDo you want to add more contacts? (y/n)");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        Console.WriteLine("\n\n{0} Contact Created\n", count);
                        DisplayAddressBook(addressBook);
                        toContinue();
                    }
                    break;
                case 2:
                    {   // Use Case 2: updating an existing ontact into address book after checking whether address book is empty or not
                        if (addressBook.Count == 0)
                        {
                            Console.Write("\nAddress Book is empty. \n\n");
                            toContinue();
                        }
                        else
                        {
                            Console.Write("\nEnter contact name that you want to update:  ");
                            String name = Console.ReadLine();
                            for (int i = 0; i < addressBook.Count; i++)
                            {
                                String[] contactArray = addressBook[i].Split(" ");
                                for (int j = 0; j < contactArray.Length; j++)
                                {
                                    if (name == contactArray[0])
                                    {
                                        Console.WriteLine("\nPlease update contact details:  \n");
                                        UC3_UpdateExistingContact updateInfo = new UC3_UpdateExistingContact();
                                        UC3_UpdateExistingContact.UpdateContactDetails(updateInfo, addressBook);
                                        String updatedContact = updateInfo.firstName + " " + updateInfo.lastName + " " + updateInfo.phoneNumber.ToString() + " " + updateInfo.email + " " + updateInfo.address + " " + updateInfo.city + " " + updateInfo.state + " " + updateInfo.zip.ToString();
                                        addressBook[i] = updatedContact;
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("\n\nContact Updated\n");
                        }
                        DisplayAddressBook(addressBook);
                        toContinue();
                    }
                    break;
                case 3:
                    {    // Use Case 3: deleting contact from address book after checking whether address book is empty or not 
                        if (addressBook.Count == 0)
                        {
                            Console.Write("\nAddress Book is empty. \n\n");
                            toContinue();
                        }
                        else
                        {
                            UC4_DeleteContact deleteContact = new UC4_DeleteContact();
                            UC4_DeleteContact.DeleteContactDetails(deleteContact, addressBook);
                        }
                        DisplayAddressBook(addressBook);
                        toContinue();
                    }
                    break;
                case 4:
                    {   // Use Case 4: adding multiple contacts into address book and also checking if entered name is unique or not using UC6 class.
                        Console.Write("\nEnter number of contacts that you want to add into address book: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < number; i++)
                        {
                            UC5_AddMultipleContacts multipleContacts = new UC5_AddMultipleContacts();
                            UC5_AddMultipleContacts.AddMultipleContacts(multipleContacts, addressBook, i);
                        }
                        Console.WriteLine("\n\n{0} Contact Created\n", number);
                        DisplayAddressBook(addressBook);
                        toContinue();
                    }
                    break;
                case 5:
                    {   // Displaying Contact list from address book
                        if (addressBook.Count == 0)
                        {
                            Console.Write("\nAddress Book is empty. \n\n");
                            toContinue();
                        }
                        else
                        {
                            DisplayAddressBook(addressBook);
                            toContinue();
                        }
                    }
                    break;
                case 0:
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("\nInvalid Option");
                    break;
            }
        }

        private static void DisplayAddressBook(List<string> addressBook)
        {
            UC6_UniqueNameInAddressBook.SortAddressBook(addressBook);
            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i + 1, addressBook[i]);
              
            }
        }
       
        public static void toContinue()
        {
            char ch;
            Console.WriteLine("\n\nDo you want to continue? (y/n)");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch == 'y')
            {
                MainMenu();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}

    

