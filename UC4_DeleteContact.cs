using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookOOPS
{
    class UC4_DeleteContact
    {
        public string name { get; set; }

        public static void DeleteContactDetails(UC4_DeleteContact deleteContact, List<String> addressBook)
        {
            Console.Write("\nEnter contact name that you want to delete:  ");
            deleteContact.name = Console.ReadLine();
            for (int i = 0; i < addressBook.Count; i++)
            {
                String[] contactArray = addressBook[i].Split(" ");
               
                if (deleteContact.name == contactArray[0])
                {
                        addressBook.RemoveAt(i);
                        break;
                }
                
            }
            Console.WriteLine("\n\nContact Deleted\n");

        }
    }
}
