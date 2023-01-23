using ContactsAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsAPI.Models
{
    public class UserInfo : IUserInfo
    {
        private readonly ContactsAPIDbContext _dbContext;

        public UserInfo()
        {
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }




        public UserInfo AddContact(UserInfo account)
        {
            throw new NotImplementedException();
        }

        // public UserInfo GetContacts(Guid id)
        public UserInfo GetContacts(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string username, string pasword, string role)
        {
            throw new NotImplementedException();
        }
    }
}
