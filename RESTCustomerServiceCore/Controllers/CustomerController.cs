using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTCustomerServiceCore.Models;

namespace RESTCustomerServiceCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static int nextId = 0;
        private static List<Customer> cList = new List<Customer>()
        {
            new Customer("Anna", "Moeller", 1980),
            new Customer("Peter", "Plys", 1960),
            new Customer("Peter", "Pedal", 1920)
        };

        // GET: api/Customer
        [HttpGet]
        public List<Customer> Get()
        {
            return cList;
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return cList.FirstOrDefault(c => c.ID == id);
        }

        // POST: api/Customer
        [HttpPost]
        public Customer InsertCustomer(Customer customer)
        {
            cList.Add(customer);
            return customer;
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public Customer UpdateCustomer(int id, Customer customer)
        {
            Customer c = Get(id);
            if (c == null) return null;
            c.FirstName = customer.FirstName;
            c.LastName = customer.LastName;
            c.YearOfReg = customer.YearOfReg;
            return Get(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Customer DeleteCustomer(int id)
        {
            Customer c = Get(id);
            if (c == null) return null;
            cList.Remove(c);
            return c;
        }


    }
}
