using Store.Models;

namespace Store.Interfaces
{
    public interface ICustomer
    {
        
            public void InsertCustomer(Customer detail);
            public List<Customer> ReadCustomer();
            public void UpdateCustomer(int id, Customer detail);
            public void DeleteCustomer(int id);
        
    }
}
