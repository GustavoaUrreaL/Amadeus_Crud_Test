using crud_test.api.Data;
using crud_test.api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_test.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomRepository _customerRepository;

        public CustomerController(ICustomRepository customerRespository)
        {
            _customerRepository = customerRespository;
        }



        [HttpGet("customers")]
        public async Task<IActionResult> Getcustomers()
        {
            return Ok(await _customerRepository.GetAllCustomers());
        }
    

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerID(int id)
        {
            return Ok(await _customerRepository.GetCustomerID(id));
        }



        // POST api/values
        [HttpPost("addcustomer")]
        public async Task<IActionResult> PostCustome([FromBody] CustomerViewModel customer)
        {
            if (customer == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var created = await _customerRepository.PostCustome(customer);
            return Created("Created",created);
        }

        [HttpPut("updatecustomer")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerViewModel customer)
        {
            if (customer == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _customerRepository.UpdateCustomer(customer);
            return NoContent();
        }



        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuser(int id)
        {
            await _customerRepository.DeleteCustomer(new CustomerViewModel { id= id});
            return NoContent();
        }
    }
}
