﻿using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookClass bookClass = new AddressBookClass(); // creating object of class
            string yes = "y";
            string y;

            do
            {
                
                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1.AddNewContact\n2.ShowContact\n3.EditContact\n4.RmoveContact");
                Console.WriteLine("\nEnter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {

                    case 1:
                        Console.WriteLine("how many contact you want to add:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            bookClass.GetContactDetails();
                        }
                        break;
                    case 2:
                        bookClass.ContactDetails();
                        break;

                    case 3:
                        bookClass.editContact();
                        break;

                    case 4:
                        bookClass.removeContact();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\ndo you want to continue? press...y/n");
                y = Console.ReadLine();

            
            } while (yes == y);
            Console.ReadLine();


        }
    }
}
