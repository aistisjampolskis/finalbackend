namespace ContactsAPI.Models
{
    public class AddContactRequestService
    {
        public AddContactRequest ConvertToModel(AddContactRequestDTO dto)
        {
            return new AddContactRequest
            {
                Name = dto.Name,
                Surname = dto.Surname,
                PersonId = dto.PersonId,
                Telephone = dto.Telephone,
                Email = dto.Email,
                LivingPlaceId = dto.LivingPlaceId,
                ProfileImage = Convert.FromBase64String(dto.ProfileImage)
            };
        }
    }

}
