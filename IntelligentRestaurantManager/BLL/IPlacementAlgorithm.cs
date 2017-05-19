using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    interface IPlacementAlgorithm
    {
        void PlaceTabletoCustomer(List<Table> tables, List<Customer> customers);
    }
}
