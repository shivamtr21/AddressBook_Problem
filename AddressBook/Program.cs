﻿namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            Console.ReadLine();

        }
    }
}