using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ContactManager
    {
        public ContactsDataStore ContactsDataStore;
        public ContactManager(ContactsDataStore contactsDataStore)
        {
            ContactsDataStore = contactsDataStore;
        }

        public void CreateContact()
        {
            Console.Clear();
     
                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Phone Number: ");
                var phoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                var email = Console.ReadLine();

                Console.Write("Address: ");
                var address = Console.ReadLine();

                Console.Write("City: ");
                var city = Console.ReadLine();

                Console.Write("Postcode: ");
                var postcode = Console.ReadLine();
            

            var previousContact = ContactsDataStore.Contacts.Last();

            Contact newContact = new Contact()
            {
                Id = previousContact.Id + 1,
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address,
                City = city,
                Postcode = postcode
            };

            ContactsDataStore.AddContact(newContact);

            if (ContactsDataStore.FindContact(newContact.Id) != null)
            {
                Console.WriteLine($"Contact for {newContact.Name} has been successfuly created");
            }
            else
            {
                Console.WriteLine("Contact could not be created");
            }
        }
        public void FindContact()
        {
            Console.Clear();
            Console.Write("User ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var existingContact = ContactsDataStore.FindContact(id);


            if (existingContact != null)
            {
                Console.WriteLine($"Contact with Id {id} found");
                ShowContactInfo(existingContact);
            }
            else
            {
                Console.WriteLine("Contact could not be found");
            }

        }
        public static void ShowContactInfo(Contact contact)
        {
            Console.WriteLine("Name: " + contact.Name);
            Console.WriteLine("Phone Number: " + contact.PhoneNumber);
            Console.WriteLine("Email: " + contact.Email);
            Console.WriteLine("Address: " + contact.Address);
            Console.WriteLine("City: " + contact.City);
            Console.WriteLine("Postcode" + contact.Postcode);
        }

        public void GetAllContacts()
        {
            Console.Clear();
            var previousContact = ContactsDataStore.Contacts.Last();

            for (int i = 0; i < ContactsDataStore.Contacts.Count; i++)
            {
            ShowContactInfo(ContactsDataStore.Contacts[i]);
            Console.WriteLine();
            }
        }

        public void ModifyContact()
        {
            Console.Clear();    
            Console.Write("Input ID to modify the contact: ");
            int SearchId = Convert.ToInt32(Console.ReadLine());
            var existingContact = ContactsDataStore.FindContact(SearchId);

            if (existingContact != null)
            {
                Console.WriteLine("Data will be shown below, input a change or leave blank");

                Console.WriteLine(existingContact.Name);
                string Change = Console.ReadLine();
                if (Change.Trim() == "")
                {
                    Console.WriteLine("No changes made");
                }
                else
                {
                    existingContact.Name = Change;
                }

                Console.WriteLine(existingContact.PhoneNumber);
                Change = Console.ReadLine();
                if (Change.Trim() == "")
                {
                    Console.WriteLine("No changes made");
                }
                else
                {
                    existingContact.PhoneNumber = Change;
                }

                Console.WriteLine(existingContact.Email);
                Change = Console.ReadLine();
                if (Change.Trim() == "")
                {
                    Console.WriteLine("No changes made");
                }
                else
                {
                    existingContact.Email = Change;
                }

                Console.WriteLine(existingContact.Address);
                Change = Console.ReadLine();
                if (Change.Trim() == "")
                {
                    Console.WriteLine("No changes made");
                }
                else
                {
                    existingContact.Address = Change;
                }

                Console.WriteLine(existingContact.City);
                Change = Console.ReadLine();
                if (Change.Trim() == "")
                {
                    Console.WriteLine("No changes made");
                }
                else
                {
                    existingContact.City = Change;
                }
                
                Console.WriteLine(existingContact.Postcode);
                Change = Console.ReadLine();
                if (Change.Trim() == "")
                {
                    Console.WriteLine("No changes made");
                }
                else
                {
                    if (Change.Length == 6)
                    {
                        existingContact.Postcode = Change;
                    }
                    else
                    {
                        Console.WriteLine("Invalid postcode");
                    }
                }
            }
            else
            { 
                Console.WriteLine("Contact not found");
            }
        }
    }
}


 