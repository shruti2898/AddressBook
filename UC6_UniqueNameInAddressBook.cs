using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookOOPS
{
    class SortingAddressBook : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            // CompareTo() method
            return x.CompareTo(y);

        }
    }
    class UC6_UniqueNameInAddressBook
    {   // USe case 6: maintaining uniqueness of firstname in addressbook and sorting contact list in alphabetical order.
        public static void checkUniqueName(String firstName, List<String> addressBook)
        {          
                if (addressBook.Count != 0)
                {
                     for (int i = 0; i < addressBook.Count; i++)
                     {
                         String[] contactArray = addressBook[i].Split(" ");
                         do
                         {
                              if (firstName == contactArray[0])
                              {
                                     Console.WriteLine("\nPlease Enter Unique Name Again: ");
                                     firstName = Console.ReadLine();
                                     
                              }
                         }while (firstName == contactArray[0]);
                         contactArray[0] = firstName;
                     }
                }           
        } 
        
        public static void SortAddressBook(List<String> addressBook)
        {
            SortingAddressBook sortContacts= new SortingAddressBook();
            addressBook.Sort(sortContacts);
        }
    }
}
