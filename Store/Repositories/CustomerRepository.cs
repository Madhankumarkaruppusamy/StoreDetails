using Microsoft.EntityFrameworkCore;
using Store.Context;
using Store.Interfaces;
using Store.Models;

namespace Store.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private readonly DatabaseContext _contxt;
        public CustomerRepository(DatabaseContext contxt)
        {
            _contxt = contxt;
        }
        public List<Customer> ReadCustomer()
        {
            try
            {
                var result=_contxt.Customers.Include(x=>x.CustomerId).ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer ReadCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(Customer detail)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, Customer detail)
        {
            throw new NotImplementedException();
        }
        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
