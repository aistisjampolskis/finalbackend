using ContactsAPI.Data;
using ContactsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;

        public ContactsController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbContext.UserInfos.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetContact([FromRoute] int id)
        {
            var contact1 = await dbContext.UserInfos.FindAsync(id);

            if (contact1 != null)
            {
                return Ok(contact1);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(UserInfo account)
        {
            var userInfo = new UserInfo()
            {

                Username = account.Username,
                Password = account.Password,
                Role = account.Role

            };
            await dbContext.UserInfos.AddAsync(userInfo);
            await dbContext.SaveChangesAsync();

            return Ok(userInfo);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateContact([FromRoute] int id, UserInfo updating)
        {
            var contact1 = await dbContext.UserInfos.FindAsync(id);

            if (contact1 != null)
            {
                contact1.Username = updating.Username;
                contact1.Password = updating.Password;
                contact1.Role = updating.Role;

                // contact.ProfileImage = updating.ProfileImage;

                await dbContext.SaveChangesAsync();

                return Ok(contact1);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] int id)
        {
            var contact1 = await dbContext.UserInfos.FindAsync(id);

            if (contact1 != null)
            {
                dbContext.Remove(contact1);
                await dbContext.SaveChangesAsync();
                return Ok(contact1);
            }

            return NotFound();
        }

    }
}
