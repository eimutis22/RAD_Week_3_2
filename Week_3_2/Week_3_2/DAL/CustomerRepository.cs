using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3_2.Models;

namespace Week_3_2.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleDBEntities context;

        public CustomerRepository(SampleDBEntities context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Customer GetCustomerByID(int id)
        {
            return context.Customers.Find(id);
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}
