using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.Models
{

    public class AddContactRequestDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonId { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int LivingPlaceId { get; set; }
        public string ProfileImage { get; set; }
    }

}
