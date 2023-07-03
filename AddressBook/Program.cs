﻿namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Edit Contact \n5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;
                    case 2:
                        addressBook.AddContact();
                        break;
                    case 3:
                        addressBook.DisplayContact();
                        break;
                    case 4:
                        Console.WriteLine("Enter the name of the contact to edit:");

                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        // addressBook.EditContact();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }

}