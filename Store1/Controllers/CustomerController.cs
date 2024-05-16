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
        [HttpPost]
        [Route("ReadCustomerDetail")]
        public dynamic ReadCustomerDetail(CustomerInput input)
        {
            var result=_customer.ReadCustomer(input);
            return result;
        }
        [HttpPut]
        [Route("UpdateCustomerDetail")]
        public dynamic UpdateCustomerDetail(CustomerInput input)
        {
            var result = _customer.UpdateCustomer(input);
            return result;
        }

        /*        [HttpDelete]
                [Route("DeleteCustomerDetail")]
                public dynamic DeleteCustomerDetail(long ID)
                {
                    var result = _customer.DeleteCustomer(ID);
                    return result;
                }*/
        [HttpPost]
        [Route("AddNewCustomerDetail")]
        public dynamic AddNewCustomerDetail(CustomerInput input)
        {
            _customer.AddNewCustomer(input);
            return Ok(input);
        }
    }
}
