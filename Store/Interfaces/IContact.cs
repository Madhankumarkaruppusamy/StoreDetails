using Store.Models;

namespace Store.Interfaces
{
    public interface IContact
    {
        public void InsertContact(Contact detail);
        public List<Contact> ReadContact();
        public void UpdateContact(int id, Contact detail);
        public void DeleteContact(int id);
    }
}
