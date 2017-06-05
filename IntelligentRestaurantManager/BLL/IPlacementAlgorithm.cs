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
        void flood_fill(List<Table> ptables, Table tb, HashSet<int> visited, List<int> partition);
        int n_flood_fill(List<Table> ptables, Table curr_table, HashSet<int> prev_visited, HashSet<int> new_visited);
        bool is_still_connected(List<Table> ptables, HashSet<int> visited);
        void Place_customer(List<Table> ptables, Table curr_table, int curr_occupied, int n_people, HashSet<int> visited);
        List<Table> Get_opt_seat();

        void PlaceTabletoCustomer(List<Table> ptables, Customer pcustomer);
    }
}
