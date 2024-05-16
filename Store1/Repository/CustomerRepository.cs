using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Store1.DBContext;
using Store1.Entity;
using Store1.IRepository;
using Store1.Model;
using System.Transactions;

namespace Store1.Repository
{
    public class CustomerRepository : ICustomerRepository
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
                    DOB = DateTime.Parse(input.DOB),
                    Email = input.Email,
                };

                var details = new CustomerDetail
                {
                    FatherName = input.FatherName,
                    PhoneNumber = (long)input.PhoneNumber,
                };

                var additionalDetail = new CustomerAdditionalDetail
                {
                    City = input.City,
                    Country = input.Country,
                };

                customer.Details = details;
                customer.AdditionalDetails = additionalDetail;

                _db.Customer.Add(customer);
                _db.SaveChanges();
                return 200;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public dynamic DeleteCustomer(CustomerInput input)
        {
            throw new NotImplementedException();
        }

        public dynamic ReadCustomer(CustomerInput input)
        {
            try
            {
                //input.PageNumber++;
                //var customer = _db.Customer.Include(c => c.Details).Include(c => c.AdditionalDetails).ToList();   //var customer = (from c in _db.Customer  join cd in _db.CustomerDetail on c.ID equals cd.ID   join cad in _db.CustomerAdditionalDetail on c.ID equals cad.ID     select new { c.CustomerName, c.DOB, c.Email, cd.FatherName,cd.PhoneNumber,cad.Country,cad.City }).ToList();    ////   var customer=_db.vw_getallcustomerdetail.ToList();////customer = customer.Where(w => w.CustomerName == "hari").ToList();


                IQueryable<FetchCustomerDetail> customer = _db.vw_getallcustomerdetail;
                if (!string.IsNullOrWhiteSpace(input.CustomerName))
                    customer = customer.Where(w => w.CustomerName.Equals(input.CustomerName, StringComparison.OrdinalIgnoreCase));

                var pagesizecalculate = ((input.PageNumber - 1) * input.PageSize);
                var paginatedResult = customer.Skip((input.PageNumber - 1) * input.PageSize)
                                     .Take(input.PageSize)
                                     .ToList();
                var totalcount = customer.Count();

                return new { Data = paginatedResult, TotalCount = totalcount };

            }
            catch (Exception ex)
            {
                return ex;
            }
        }
        public dynamic UpdateCustomer(CustomerInput input)
        {
            try
            {
                /*var customer = _db.vw_getallcustomerdetail.FirstOrDefault(c => c.ID == input.ID);
                if (!string.IsNullOrWhiteSpace(input.CustomerName))
                {
                    customer.CustomerName= input.CustomerName;
                }
                _db.vw_getallcustomerdetail.Update(customer);
                _db.SaveChanges();
                return 200;*/

                var result = _db.Customer.Where(w => w.ID == input.ID).FirstOrDefault();
                result.CustomerName = input.CustomerName;
                result.Email = input.Email;
                result.DOB = DateTime.Parse(input.DOB);


                _db.Customer.Update(result);
                _db.SaveChanges();
                return 200;

            }
            catch (Exception ex)
            {
                return ex;
            }


        }
        public dynamic AddNewCustomer(CustomerInput add)
        {
            try
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        var customer = new Customer
                        {
                            CustomerName = add.CustomerName,
                            DOB = DateTime.Parse(add.DOB),
                            Email = add.Email
                        };

                        _db.Customer.Add(customer);
                        _db.SaveChanges();

                        var customerId = customer.ID; // Assuming ID is auto-generated

                        
                            var customerDetail = new CustomerDetail
                            {
                                CustomerID = 0,
                                FatherName = add.FatherName
                            };
                            _db.CustomerDetail.Add(customerDetail);
                            _db.SaveChanges();
                    
                        transaction.Commit();
                        return 200; // Success
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Log the exception for debugging
                        return 500; // Internal Server Error
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                return 500; // Internal Server Error
            }
        }

    }
}


    

