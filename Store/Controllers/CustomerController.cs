using Microsoft.AspNetCore.Mvc;
using Store.Interfaces;
using Store.Models;
using Store.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _obj;
        public CustomerController(ICustomer obj)
        {
            _obj = obj;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public List<Customer> Get()
        {
            return _obj.ReadCustomer();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _obj.ReadCustomerById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer detail)
        {
            _obj.InsertCustomer(detail);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer detail)

        {
            _obj.UpdateCustomer(id,detail);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _obj.DeleteCustomer(id);
        }
    }
}
