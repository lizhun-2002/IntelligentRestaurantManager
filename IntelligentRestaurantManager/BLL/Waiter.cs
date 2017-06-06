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

        public int AllocateTableWaiter(List<Table> tables, Table table, int waitingNumber, string waiterName)
        {
            if (table.TableStatus == TableStatus.Active)
            {
                table.TableStatus = TableStatus.Ordering;
                table.CustomerId = waitingNumber;
                table.WaiterName = waiterName;

                for (int i = 0; i < tables.Count; i++)
                {
                    if (tables[i].TableId == table.TableId)
                    {
                        tables[i] = table;
                    }
                }

                return new TableManager().Update(table);
            }
            return 0;
        }

        public int AllocateTableWaiter(List<Table> tables, int tableId, int waitingNumber, int noOfPeople, string waiterName)
        {
            Table table = new TableManager().GetByTableId(tableId);
            if (table != null && table.TableStatus == TableStatus.Active)
            {
                table.TableStatus = TableStatus.Ordering;
                table.CustomerId = waitingNumber;
                table.WaiterName = waiterName;
                table.OrderId = -noOfPeople;//not good. (save number of people in orderId before create order)

                for (int i = 0; i < tables.Count; i++)
                {
                    if (tables[i].TableId == table.TableId)
                    {
                        tables[i] = table;
                    }
                }

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

        public int CreateOrder(List<Order> orders, int customerId, List<Item> items, int numberofPeople, List<Table> tables)
        {
            if (customerId <= 0)
            {
                return 0;
            }
            List<Table> linkedTables = (List<Table>)new TableManager().GetByTableCustomerId(customerId);
            Order order = new Order();
            if (new OrderManager().GetCount() < 1)
            {
                order.OrderId = 1;
            }
            else
            {
                order.OrderId = new OrderManager().GetMaxOrderId() + 1;
            }
            order.StartTime = DateTime.Now;
            order.NumberofPeople = numberofPeople;
            int[] tableIdArray = new int[linkedTables.Count];
            for (int i = 0; i < linkedTables.Count; i++)
            {
                tableIdArray[i] = linkedTables[i].TableId;
            }
            order.TableIds = tableIdArray;
            order.OrderStatus = OrderStatus.Start;
            order.Items = items;
            int result = new OrderManager().AddNew(order);
            if (result == 1)
            {
                orders.Add(order);
                for (int i = 0; i < tables.Count; i++)
                {
                    foreach (Table t in linkedTables)
                    {
                        if(t.TableId==tables[i].TableId) tables[i].OrderId = order.OrderId;
                        new TableManager().Update(tables[i]);
                    }
                }
            }
            return result;
        }

        public int UpdateOrder(List<Order> orders, int orderId, int customerId, List<Item> items, int numberofPeople, OrderStatus orderStatus)
        {
            if (customerId <= 0)
            {
                return 0;
            }
            List<Table> tables = (List<Table>)new TableManager().GetByTableCustomerId(customerId);
            Order order = new OrderManager().GetByOrderId(orderId);
            order.NumberofPeople = numberofPeople;
            int[] tableIdArray = new int[tables.Count];
            for (int i = 0; i < tables.Count; i++)
            {
                tableIdArray[i] = tables[i].TableId;
            }
            order.TableIds = tableIdArray;
            order.OrderStatus = orderStatus;
            order.Items = items;
            if (orderStatus == OrderStatus.Finish) order.FinishTime = DateTime.Now;
            int result = UpdateOrder(orders, order);
            return result;
        }

        public int UpdateOrder(List<Order> orders, Order order)
        {
            int result = new OrderManager().Update(order);
            if (result == 1)
            {
                orders.Add(order);
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orders[i].OrderId == order.OrderId)
                    {
                        orders[i] = order;
                    }
                }
            }
            return result;
        }

        public int UpdateTable(List<Table> tables, Table table)
        {
            int result = new TableManager().Update(table);
            if (result == 1)
            {
                for (int i = 0; i < tables.Count; i++)
                {
                    if (tables[i].TableId == table.TableId)
                    {
                        tables[i] = table;
                    }
                }
            }
            return result;
        }
    }
}
