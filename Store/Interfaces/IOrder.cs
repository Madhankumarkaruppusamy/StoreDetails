using Store.Models;

namespace Store.Interfaces
{
    public interface IOrder
    {
        public Order ReadOrderById();
        public void InsertOrder(Order detail);
        public List<Order> ReadOrder();
        public void UpdateOrder(int id, Order detail);
        public void DeleteOrder(int id);
    }
}
