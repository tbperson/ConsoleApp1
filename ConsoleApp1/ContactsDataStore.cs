using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class ContactsDataStore
    {
        public List<Contact> Contacts;

        public ContactsDataStore()
        {
            Contacts = new List<Contact> {
                new Contact
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Address = "123 Everlong Road",
                    City = "London",
                    PhoneNumber = "123412341234",
                    Postcode = "ST75RT"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Email = "jane.doe@example.com",
                    Address = "124 Everlong Road",
                    City = "London",
                    PhoneNumber = "432143214321",
                    Postcode = "ST75RI"
                },
                new Contact
                {
                    Id = 3,
                    Name = "Test",
                    Email = "test@test.com",
                    Address = "123 test road",
                    City = "TestCity",
                    Postcode = "T35TGG"
                }
            }
        }

        public bool AddContact(Contact contact)
        {
            Contacts.Add(contact);

            return true;
        }
        public bool RemoveContact(Contact contact)
        {
            var existingContact = Contacts.FirstOrDefault(c => c.Id == contact.Id);

            if (existingContact != null)
            {
                Contacts.Remove(existingContact);
                return true;
            }

            return false;
        }
        public Contact FindContact(int id)
        {
            var existingContact = Contacts.FirstOrDefault(c => c.Id == id);
            if (existingContact != null)
            {
                return existingContact;
            }

            return null;

        }
        public List<Contact> GetContacts()
        {
            return Contacts;
        }
    }
}

