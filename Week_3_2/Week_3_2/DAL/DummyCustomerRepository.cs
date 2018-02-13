using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week_3_2.Models;

namespace Week_3_2.DAL
{
    public class DummyCustomerRepository : ICustomerRepository
    {
        public DummyCustomerRepository()
        {

        }

        public void Dispose()
        {

        }

        public Customer GetCustomerByID(int id)
        {
            return new Customer()
            {
                CustomerID = "cust01",
                ContactName = "Fake Name",
                Country = "Ireland"
            };
        }
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                     CustomerID = "cust01",
                    ContactName = "Fake Name",
                    Country = "Ireland"
                }
            };
        }
    }
}