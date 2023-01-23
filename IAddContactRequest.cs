namespace ContactsAPI.Models
{
    public interface IAddContactRequest
    {
        AddContactRequest AddContact(AddContactRequest account);
        AddContactRequest GetContacts(int id);
        void Update(int id, string name, string surname, int personId, int telephone, string email);
    }

    public interface IUserInfo
    {
        UserInfo AddContact(UserInfo account);
        UserInfo GetContacts(int id);
        void Update(int id, string username, string password, string role);

    }
}
