using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class DiningArea
    {
        public Staff CurrentStaff { get; set; }
        public List<Table> Tables { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Waiter> Waiters { get; set; }
        IPlacementAlgorithm PlacementOptimizer { get; set; }
        IPredictionAlgorithm WaitingTimePredictor { get; set; }

        public DiningArea(Staff staff)
        {
            InitDiningArea(staff);
        }

        void InitDiningArea(Staff staff)
        {
            throw new System.NotImplementedException();
        }

        void CloseDiningArea()
        {
            throw new System.NotImplementedException();
        }
    }
}
