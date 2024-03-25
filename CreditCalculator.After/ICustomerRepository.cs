using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator.After
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();

        public void AddCustomer(Customer customer);
    }
}
