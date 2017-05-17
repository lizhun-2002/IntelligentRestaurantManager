using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class OrderManager
    {
        private OrderService orderService = new OrderService();

        //check if given ID is already used
        public bool CheckExists(int id)
        {
            Order order = orderService.GetByOrderId(id);
            if (order == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int AddNew(Order order)
        {
            if (this.CheckExists(order.OrderId))
            {
                return 0;
            }
            else
            {
                return orderService.AddNew(order);
            }

        }

        public int DeleteByOrderId(int orderId)
        {
            return orderService.DeleteByOrderId(orderId);
        }

        public int DeleteAll()
        {
            return orderService.DeleteAll();
        }

        public int Update(Order order)
        {
            return orderService.Update(order);
        }

        public IEnumerable<Order> GetAll()
        {
            return orderService.GetAll();
        }

        public IEnumerable<Order> GetByOrderStatus(OrderStatus orderStatus)
        {
            return orderService.GetByOrderStatus(orderStatus);
        }

        public Order GetByOrderId(int orderId)
        {
            return orderService.GetByOrderId(orderId);
        }

        public IEnumerable<Order> GetByOrderDate(DateTime date)
        {
            return orderService.GetByOrderDate(date);
        }

        public int GetCount()
        {
            return orderService.GetCount();
        }

        public int GetCountByDate(DateTime date)
        {
            return orderService.GetCountByDate(date);
        }
    }
}
