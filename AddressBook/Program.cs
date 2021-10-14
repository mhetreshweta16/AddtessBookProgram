using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
           

            AddressBookClass bookClass = new AddressBookClass(); // creating object of class

            bookClass.GetContactDetails();   //through object accessing method 
            bookClass.putDetails();




        }
    }
}
