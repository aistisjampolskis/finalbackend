using ContactsAPI.Data;
using ContactsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace ContactsAPI.Controllers
{


    [ApiController]
    [Route("api[controller]")]
    public class UserControler : Controller
    {

        private readonly ContactsAPIDbContext dbContext;

        public UserControler(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]

        public async Task<IActionResult> GetContact()
        {
            var contact = await dbContext.Contacts.ToListAsync();

            return Ok(contact);
        }

        [HttpPost]
        public async Task<IActionResult> AddContact([FromBody] AddContactRequestDTO ad)
        {
            var contact = new AddContactRequest()
            {
                Name = ad.Name,
                Surname = ad.Surname,
                PersonId = ad.PersonId,
                Telephone = ad.Telephone,
                Email = ad.Email,
                LivingPlaceId = ad.LivingPlaceId,
                ProfileImage = Encoding.ASCII.GetBytes(ad.ProfileImage)
            };


            await dbContext.AddAsync(contact);
            await dbContext.SaveChangesAsync();

            return Ok(contact);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateContact([FromRoute] int id, UpdateContactRequestDTO updating)
        {
            var contact = await dbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                var updatedContactRequest = updating.ToUpdateContactRequest();
                contact.Name = updatedContactRequest.Name;
                contact.Surname = updatedContactRequest.Surname;
                contact.PersonId = updatedContactRequest.PersonId;
                contact.Telephone = updatedContactRequest.Telephone;
                contact.Email = updatedContactRequest.Email;
                contact.ProfileImage = Encoding.ASCII.GetString(updatedContactRequest.ProfileImage);

                await dbContext.SaveChangesAsync();

                return Ok(contact);
            }

            return NotFound();
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] int id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);

            if (contact != null)
            {
                dbContext.Remove(contact);
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }

            return NotFound();
        }


    }

}



