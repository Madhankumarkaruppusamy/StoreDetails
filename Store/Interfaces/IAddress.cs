using Store.Models;

namespace Store.Interfaces
{
    public interface IAddress
    {
        public void InsertAddress(Address detail);
        public List<Address> ReadAddress();
        public void UpdateAddress(int id, Address detail);
        public void DeleteAddress(int id);
    }
}
