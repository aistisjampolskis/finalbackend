namespace ContactsAPI.Models
{
    public static class UpdateContactRequestDTOConverter
    {
        public static UpdateContactRequest ToUpdateContactRequest(this UpdateContactRequestDTO dto)
        {
            var imageByte = Convert.FromBase64String(dto.ProfileImage);
            return new UpdateContactRequest()
            {
                Name = dto.Name,
                Surname = dto.Surname,
                PersonId = dto.PersonId,
                Telephone = dto.Telephone,
                Email = dto.Email,
                ProfileImage = imageByte
            };
        }
    }
}
