using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<FetchCustomerDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public dynamic ReadCustomer()
        {
                try
                {
                //var customer = _db.Customer.Include(c => c.Details).Include(c => c.AdditionalDetails).ToList();
                //var customer = (from c in _db.Customer
                //                join cd in _db.CustomerDetail on c.ID equals cd.ID
                //                join cad in _db.CustomerAdditionalDetail on c.ID equals cad.ID
                //                select new { c.CustomerName, c.DOB, c.Email, cd.FatherName,cd.PhoneNumber,cad.Country,cad.City }).ToList();    
                
                return 0;
                }
                catch (Exception ex)
                {
                return ex;
                }
        }


    }
}

