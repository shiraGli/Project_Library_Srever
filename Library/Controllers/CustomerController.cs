using AutoMapper;
using Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Servise;
using Solid.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>

        private readonly ICustomerServise _customerServise;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerServise customerServise, IMapper mapper)
        {
            _customerServise = customerServise;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<Customer> Get()
        {
            var list = _customerServise.GetCustomer();
            var listDto = _mapper.Map<IEnumerable<CustomerDto>>(list);
            return Ok(listDto);
        }

        [HttpGet("{password}+{name}")]
        public bool GetCustomerPassword(string password, string name)
        {
            return _customerServise.GetCustomerPassword(password, name);
        }


        [HttpGet("{id}")]
        public ActionResult<CustomerDto> Get(int id)
        {
            var customer = _customerServise.GetIdCustomer(id);
            var customerDto = _mapper.Map<CustomerDto>(customer);
            if (customer != null)
                return customerDto;
            return NotFound();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Customer Post([FromBody] CustomerPostModel c)
        {
            var customer = _mapper.Map<Customer>(c);
            _customerServise.AddCustomer(customer);
            return customer;
        }
        
        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            _customerServise.DeleteCustomer(id);
            return id;
        }
    }
}

