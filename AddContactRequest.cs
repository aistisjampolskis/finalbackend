using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsAPI.Models
{
    public class AddContactRequest : IAddContactRequest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonId { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int LivingPlaceId { get; set; }
        public byte[] ProfileImage { get; set; }


        public AddContactRequest AddContact(AddContactRequest account)
        {
            throw new NotImplementedException();
        }


        public AddContactRequest GetContacts(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string name, string surname, int personId, int telephone, string email)
        {
            throw new NotImplementedException();
        }


    }
}
