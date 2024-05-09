using Microsoft.EntityFrameworkCore;
using Store.Context;
using Store.Data;
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
                var result = _contxt.Customers.ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer ReadCustomerById(int id)
        {
            try
            {
                var result = _contxt.Customers.Where(x => x.CustomerId == id);
                return result.ToList().FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertCustomer(CustomerInput input)
        {
            try
            {
                var customer = new Customer
                {
                    CustomerName = input.CustomerName,
                };

                var address = new Address
                {
                    City = input.City,
                    PostalCode = input.PostalCode
                };

                var contact = new Contact
                {
                    Phone = input.ContactNumber
                };
                customer.Addresses.Add(address);
                customer.Contacts.Add(contact);

                _contxt.Customers.Add(customer);
                _contxt.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCustomer(int id, Customer detail)
        {
            try
            {

                _contxt.Customers.Update(detail);
                _contxt.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteCustomer(int id)
        {
            try
            {
                var book = _contxt.Customers.Find(id);
                if (book != null)
                {
                    _contxt.Customers.Remove(book);
                    _contxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
