using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTCustomerServiceCore.Controllers;

namespace RESTCustomerServiceCore.Models
{
    public class Customer
    {
        private static int nextId;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfReg { get; set; }

        public Customer(string first, string last, int year)
        {
            ID = nextId++;
            FirstName = first;
            LastName = last;
            YearOfReg = year;
        }

        public Customer(){}
    }
}
