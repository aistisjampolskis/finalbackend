namespace ContactsAPI.Models
{
    public class UpdateContactRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonId { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public byte[] ProfileImage { get; set; }
    }
}
