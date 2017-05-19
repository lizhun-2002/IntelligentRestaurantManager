using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class Waiter: Staff
    {
        /// <summary>
        /// Add new customer to waiting list, update database
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="customer"></param>
        /// <returns>No. of customers added, i.e. 0 or 1</returns>
        public int AddCustomer(List<Customer> customers, Customer customer)
        {
            customers.Add(customer);
            return new CustomerManager().AddNew(customer);
        }
    }
}
