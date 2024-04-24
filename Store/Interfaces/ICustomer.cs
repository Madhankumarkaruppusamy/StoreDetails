﻿using Store.Models;

namespace Store.Interfaces
{
    public interface ICustomer
    {

        public Customer ReadCustomerById(int id);
        public List<Customer> ReadCustomer();
        public void InsertCustomer(Customer detail);
        public void UpdateCustomer(int id, Customer detail);
        public void DeleteCustomer(int id);
        
    }
}
