using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class Waiter : Staff
    {
        /// <summary>
        /// Add new customer to waiting list, update database
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="customer"></param>
        /// <returns>No. of customer added, i.e. 0 or 1</returns>
        public int AddCustomer(List<Customer> customers, Customer customer)
        {
            int result = new CustomerManager().AddNew(customer);
            if (result == 1)
            {
                customers.Add(customer);
            }
            return result;
        }

        public int DeleteCustomer(List<Customer> customers, Customer customer)
        {
            int result = new CustomerManager().DeleteByWaitingNumber(customer.WaitingNumber);
            if (result == 1)
            {
                customers.Remove(customer);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="customer"></param>
        /// <param name="waiter"></param>
        /// <returns>No. of table updated</returns>
        public int AllocateTableWaiter(Table table, Customer customer, Waiter waiter)
        {
            if (table.TableStatus == TableStatus.Active)
            {
                table.TableStatus = TableStatus.Ordering;
                table.CustomerId = customer.WaitingNumber;
                table.WaiterName = waiter.Name;
                return new TableManager().Update(table);
            }
            return 0;
        }

        public bool SetTableStatus(Table table, TableStatus tableStatus)
        {
            bool result = false;
            switch (tableStatus)
            {
                case TableStatus.Active:
                    table.TableStatus = TableStatus.Active;
                    result = true;
                    break;
                case TableStatus.Ordering:
                case TableStatus.Reserved:
                case TableStatus.Breakdown:
                    if (table.TableStatus == TableStatus.Active)
                    {
                        table.TableStatus = tableStatus;
                        result = true;
                    }
                    break;
                case TableStatus.Cleaning:
                    if (table.TableStatus == TableStatus.Ordering)
                    {
                        table.TableStatus = tableStatus;
                        result = true;
                    }
                    break;
            }
            return result;
        }

        public int CreateOrder(List<Order> orders, Table table, List<Item> items, int numberofPeople)
        {
            if (table.CustomerId == null) return 0;
            List<Table> tables = (List<Table>)new TableManager().GetByTableCustomerId(table.CustomerId);
            Order order = new Order();
            order.OrderId = new OrderManager().GetMaxOrderId() + 1;
            order.StartTime = DateTime.Now;
            order.NumberofPeople = numberofPeople;
            int[] tableIdArray = new int[tables.Count];
            for (int i = 0; i < tables.Count; i++)
            {
                tableIdArray[i] = tables[i].TableId;
            }
            order.TableIds = tableIdArray;
            order.OrderStatus = OrderStatus.Start;
            order.Items = items;
            order.FinishTime = DateTime.MinValue;
            int result = new OrderManager().AddNew(order);
            if (result == 1)
            {
                orders.Add(order);
            }
            return result;
        }

        public int UpdateOrder(List<Order> orders, Order order)
        {
            int result = new OrderManager().Update(order);
            if (result == 1)
            {
                orders.Add(order);
            }
            return result;
        }
    }
}
