using Microsoft.AspNetCore.Mvc;
using Store.Context;
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
        private readonly DatabaseContext _contxt;
        public CustomerController(DatabaseContext contxt)
        {
            _contxt = contxt;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        [Route("Customerlist")]
        public List<Customer> GetCustomer()
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

        // GET: api/<AddressController>
        [HttpGet]
        [Route("Addresslist")]
        public List<Address> GetAddress()
        {
            try
            {
                var result = _contxt.Addresses.ToList();
                    return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: api/<ContactController>
        [HttpGet]
        [Route("Contactlist")]
        public List<Contact> GetContact()
        {
            try
            {
                var result = _contxt.Contacts.ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: api/<OrderController>
        [HttpGet]
        [Route("Orderlist")]
        public List<Order> GetOrder()
        {
            try
            {
                var result = _contxt.Orders.ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
