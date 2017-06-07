using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    public class DiningArea
    {
        public Staff CurrentStaff { get; set; }
        public List<Table> Tables { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Staff> Waiters { get; set; }
        public IPlacementAlgorithm APlacementOptimizer { get; set; }
        public IPredictionAlgorithm AWaitingTimePredictor { get; set; }

        public DiningArea(Staff staff)
        {
            InitDiningArea(staff);
        }

        public void InitDiningArea(Staff staff)
        {
            CurrentStaff = staff;
            Tables = (List<Table>)new TableManager().GetAll();
            Orders = (List<Order>)new OrderManager().GetByOrderStatus(OrderStatus.Start);
            Customers = (List<Customer>)new CustomerManager().GetAll();
            Waiters = (List<Staff>)new StaffManager().GetByRole(StaffRole.Waiter);
            APlacementOptimizer = new PlacementOptimizer();
            AWaitingTimePredictor = new WaitingTimePredictor();
        }

        public void CloseDiningArea()
        {
            //only waiter can close dining area
            if (!(CurrentStaff is Waiter)) return;

            foreach (Table table in Tables)
            {
                //reset countDown time
                table.CountDown = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
                //activate table
                if (table.TableStatus != TableStatus.Breakdown)
                {
                    table.TableStatus = TableStatus.Active;
                }
                table.ReservationInfo = "";
                table.CustomerId = -1;
                table.WaiterName = "";
                table.OrderId = -1;
                new TableManager().Update(table);
            }

            foreach (Order order in Orders)
            {
                if (order.OrderStatus == OrderStatus.Start)
                {
                    order.OrderStatus = OrderStatus.Finish;
                    order.FinishTime = DateTime.Now;
                    new OrderManager().Update(order);
                }
            }

            //clear waiting list
            Customers.Clear();
            new CustomerManager().DeleteAll();

        }
    }
}
