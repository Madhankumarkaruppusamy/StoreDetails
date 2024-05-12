using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store1.DBContext;
using Store1.Entity;
using Store1.IRepository;

namespace Store1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly StoreDBContext _db;
        private readonly ICustomerRepository _customer;
        
        public CustomerController(ICustomerRepository customer)
        {
            _customer= customer;
        }

        [HttpPost]
        [Route("AddCustomerDetail")]
        public dynamic AddCustomerDetail(CustomerInput input)
        {
            _customer.AddCustomer(input);
            return Ok(input);
        }
    }
}
