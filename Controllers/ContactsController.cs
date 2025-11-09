using Microsoft.AspNetCore.Mvc;
using TravelBliss.Models;

namespace TravelBliss.Controllers
{
    public class ContactsController : Controller
    {
        // In-memory storage for demo purposes
        private static List<Contact> _contacts = new List<Contact>
        {
            new Contact
            {
                Id = 1,
                FirstName = "Travis",
                LastName = "Diamond",
                PrimaryEmail = "tdiamond01@protonmail.com",
                TripCount = 1,
                IsActive = true,
                IsArchived = false
            }
        };

        public IActionResult Index()
        {
            var activeContacts = _contacts.Where(c => !c.IsArchived).ToList();
            return View(activeContacts);
        }

        [HttpGet]
        public IActionResult GetContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return PartialView("_ContactDetail", contact);
        }

        [HttpPost]
        public IActionResult SaveContact([FromBody] Contact contact)
        {
            if (contact.Id == 0)
            {
                // New contact
                contact.Id = _contacts.Any() ? _contacts.Max(c => c.Id) + 1 : 1;
                contact.CreatedDate = DateTime.Now;
                _contacts.Add(contact);
            }
            else
            {
                // Update existing contact
                var existingContact = _contacts.FirstOrDefault(c => c.Id == contact.Id);
                if (existingContact != null)
                {
                    existingContact.FirstName = contact.FirstName;
                    existingContact.MiddleName = contact.MiddleName;
                    existingContact.LastName = contact.LastName;
                    existingContact.PrimaryEmail = contact.PrimaryEmail;
                    existingContact.PhoneNumber = contact.PhoneNumber;
                    existingContact.Address1 = contact.Address1;
                    existingContact.Address2 = contact.Address2;
                    existingContact.City = contact.City;
                    existingContact.State = contact.State;
                    existingContact.Zip = contact.Zip;
                    existingContact.Country = contact.Country;
                    existingContact.Tags = contact.Tags;
                }
            }
            return Json(new { success = true, contact = contact });
        }

        [HttpPost]
        public IActionResult ArchiveContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contact.IsArchived = true;
            }
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult DeleteContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _contacts.Remove(contact);
            }
            return Json(new { success = true });
        }
    }
}
