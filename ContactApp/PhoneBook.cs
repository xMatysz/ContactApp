using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contacts)
        {
            Contacts.Add(contacts);
        }

        public void ShowAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }

        public void FindContactByNumber(int number)
        {
            var contact = Contacts.Find(x => x.Number == number);

            if (contact != null)
                DisplayContactDetails(contact);

            else
                Console.WriteLine("Contant not found");
        }

        public void FindContactByName(string name)
        {
            var matchingContacts = Contacts.FindAll(x => x.Name == name);

            if (matchingContacts.Count != 0)
                DisplayContactsDetails(matchingContacts);

            else
                Console.WriteLine("Contacts not found");
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name} {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contactsList)
        {
            foreach (var contact in contactsList)
            {
                DisplayContactDetails(contact);
            }
        }
    }
}
