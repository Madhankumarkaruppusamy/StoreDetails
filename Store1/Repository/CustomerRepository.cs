using Microsoft.AspNetCore.Http.HttpResults;
using Store1.DBContext;
using Store1.Entity;
using Store1.IRepository;
using Store1.Model;

namespace Store1.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly StoreDBContext _db;
        public CustomerRepository(StoreDBContext db)
        {
            _db = db;   
        }

        public dynamic AddCustomer(CustomerInput input)
        {
            try
            {
                var customer = new Customer
                {
                    CustomerName = input.CustomerName,
                    DOB = input.DOB,
                    Email = input.Email,
                };

                var details = new CustomerDetail
                {
                    FatherName = input.FatherName,
                    PhoneNumber = input.PhoneNumber,
                };

                var additionalDetail = new CustomerAdditionalDetail
                {
                    City=input.City,
                    Country=input.Country,
                };

                customer.Details = details;
                customer.AdditionalDetails=additionalDetail;

                _db.Customer.Add(customer);
                _db.SaveChanges();
                return 200;
            }
            catch (Exception ex) 
            {
                return ex;
            }
        }


        public dynamic UpdateCustomer(long customerId, CustomerInput input)
        {
            try
            {

                var customerToUpdate = _db.Customer. Include(c => c.Details).Include(c => c.AdditionalDetails).FirstOrDefault(c => c.CustomerId == customerId);

                if (customerToUpdate != null)
                {

                    customerToUpdate.CustomerName = input.CustomerName;
                    customerToUpdate.DOB = input.DOB;
                    customerToUpdate.Email = input.Email;

                    
                    if (customerToUpdate.Details == null)
                    {
                        customerToUpdate.Details = new CustomerDetail();
                    }
                    customerToUpdate.Details.FatherName = input.FatherName;
                    customerToUpdate.Details.PhoneNumber = input.PhoneNumber;

                    
                    if (customerToUpdate.AdditionalDetails == null)
                    {
                        customerToUpdate.AdditionalDetails = new CustomerAdditionalDetail();
                    }
                    customerToUpdate.AdditionalDetails.City = input.City;
                    customerToUpdate.AdditionalDetails.Country = input.Country;

                    
                    _db.SaveChanges();

                    return 200;
                }
                else
                {
                    return 404;
                }
            }
            catch (Exception ex)
            {
                return ex; // Return exception details
            }
        }

    }
}
