using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class CustomerManager
    {
        private CustomerService customerService = new CustomerService();

        //check if given waitingNumber is already used
        public bool CheckExists(int waitingNumber)
        {
            Customer customer = customerService.GetByWaitingNumber(waitingNumber);
            if (customer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int AddNew(Customer customer)
        {
            if (this.CheckExists(customer.WaitingNumber))
            {
                return 0;
            }
            else
            {
                return customerService.AddNew(customer);
            }

        }

        public int DeleteByWaitingNumber(int waitingNumber)
        {
            return customerService.DeleteByWaitingNumber(waitingNumber);
        }

        public int DeleteAll()
        {
            return customerService.DeleteAll();
        }

        public int Update(Customer customer)
        {
            return customerService.Update(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customerService.GetAll();
        }

        public IEnumerable<Customer> GetByNumberofPeople(int numberofPeople)
        {
            return customerService.GetByNumberofPeople(numberofPeople);
        }

        public Customer GetByWaitingNumber(int waitingNumber)
        {
            return customerService.GetByWaitingNumber(waitingNumber);
        }

        public int GetCount()
        {
            return this.customerService.GetCount();
        }
    }
}
