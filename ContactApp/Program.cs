using System;

namespace ContactApp
{
    class Program
    {
        public static void Main()
        {
            var phoneBook = new PhoneBook();
            while (true)
            {

                ShowContactsOptions();

                var input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Add new Contact\n\n");

                        Console.Write("Insert name: ");
                        var newName = Console.ReadLine();
                        Console.Write("Insert number: ");
                        var newNumber = int.Parse(Console.ReadLine());

                        var newContact = new Contact(newName, newNumber);

                        phoneBook.AddContact(newContact);
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Find contact by number\n\n");
                        var number = int.Parse(Console.ReadLine());

                        phoneBook.FindContactByNumber(number);
                        WaintUntillGetKey();
                        break;

                    case 3:
                        Console.WriteLine("DisplayAllNumbers\n\n");
                        phoneBook.ShowAllContacts();
                        WaintUntillGetKey();
                        break;

                    case 4:
                        Console.WriteLine("Find contact by name\n\n");
                        var name = Console.ReadLine();

                        phoneBook.FindContactByName(name);
                        WaintUntillGetKey();
                        break;

                    default:
                        throw new ArgumentException($"Not supported argument: {input}");
                }
            }
        }

        private static void ShowContactsOptions()
        {
            Console.WriteLine("1. Add new Contact");
            Console.WriteLine("2. Find contact by number");
            Console.WriteLine("3. Wyswietlic wszystkie kontakty");
            Console.WriteLine("4. Find contact by name");
        }

        private static void WaintUntillGetKey()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}