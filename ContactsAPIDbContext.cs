using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AddContactRequestDTO> Contacts { get; set; }
        public DbSet<LivingPlace> LivingPlaces { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }


    }
}
