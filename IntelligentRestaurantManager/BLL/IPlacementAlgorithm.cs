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
        int n_Active_Set(List<Table> tables, int currID);
        int Pick_customers(int upper_bnd, List<Customer> pcustomers);
        void flood_fill(List<Table> ptables, Table tb, HashSet<int> visited);
        bool Check_Division(List<Table> ptables);
        bool Place_one_Party(List<Table> ptables, Table tb, int num);
        bool PlacementSuccess(List<Table> ptables);

        void PlaceTabletoCustomer(List<Table> tables, List<Customer> customers);
    }
}
