using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataStore = new ContactsDataStore();
            var contactManager = new ContactManager(dataStore);

            ShowMenu(contactManager);
        }
        public static void ShowMenu(ContactManager contactManager)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Contact Management System");
            Console.WriteLine("=========================");

            Console.WriteLine("1. Create Contact");
            Console.WriteLine("2. Find Contact");
            Console.WriteLine("3. Get All Contacts");
            Console.WriteLine("4. Modify Contacts");
            Console.WriteLine("5. Exit");


            Console.Write("Your Choice: ");
            var userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                contactManager.CreateContact();
                ReturnToMenu();
                Console.Clear();
                ShowMenu(contactManager);

            }
            else if (userChoice == "2")
            {
                contactManager.FindContact();
                ReturnToMenu();
                Console.Clear();
                ShowMenu(contactManager);
            }
            else if (userChoice == "3")
            {
                contactManager.GetAllContacts();
                ReturnToMenu();
                Console.Clear();
                ShowMenu(contactManager);
            }
            else if (userChoice == "4")
            {
                contactManager.ModifyContact();
                ReturnToMenu();
                Console.Clear();
                ShowMenu(contactManager);
            }
            else
            {
                Environment.Exit(1);
            }

            static void ReturnToMenu()
            {
                Console.WriteLine("Press any key to return to the menu");
                Console.ReadLine();
            }

        }
    }
}
