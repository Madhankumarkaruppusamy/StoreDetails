using Store.Models;

namespace Store.Interfaces
{
    public interface ICounter
    {

        public Counter ReadCounterById(int id);
        public List<Counter> ReadCounter();
        public void InsertCustomer(Customer detail);
        public void UpdateCustomer(int id, Customer detail);
        public void DeleteCustomer(int id);
    }
}
