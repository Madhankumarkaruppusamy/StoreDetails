using Store.Models;

namespace Store.Interfaces
{
    public interface IItem
    {
        public Item ReadItemById(int id);
        public List<Item> ReadItem();
        public void InsertItem(Item detail);
        public void UpdateItem(int id, Item detail);
        public void DeleteItem(int id);
    }
}
