using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class PlacementOptimizer: IPlacementAlgorithm
    {
        HashSet<int> is_visit, picked_customers, Occupied;
        HashSet<Table> CurrentTables;
        List<Customer> PickedList;

        public int n_Active_Set(List<Table> tables, int currID)
        {
            int n;
            Table currTable = tables.Find(x => x.TableId == currID);

            if (is_visit.Contains(currID) || currTable.TableStatus != TableStatus.Active)
                return 0;
            CurrentTables.Add(currTable);
            is_visit.Add(currID);
            n = currTable.Capacity;

            if (currTable.LinkableTableId1 != 0)
            {
                n += n_Active_Set(tables, currTable.LinkableTableId1);
            }
            if (currTable.LinkableTableId2 != 0)
            {
                n += n_Active_Set(tables, currTable.LinkableTableId2);
            }
            if (currTable.LinkableTableId3 != 0)
            {
                n += n_Active_Set(tables, currTable.LinkableTableId3);
            }
            if (currTable.LinkableTableId4 != 0)
            {
                n += n_Active_Set(tables, currTable.LinkableTableId4);
            }

            return n;
        }

        public int Pick_customers(int upper_bnd, List<Customer> pcustomers)
        {
            List<Customer> SortedList = pcustomers.OrderByDescending(o => o.NumberofPeople).ToList();
            List<Customer> tmpList = new List<Customer>();

            PickedList.Clear();

            foreach (var i in SortedList)
            {
                if (upper_bnd - i.NumberofPeople >= 0)
                {
                    tmpList.Add(i);
                    upper_bnd -= i.NumberofPeople;
                }
            }

            PickedList = tmpList.OrderBy(o => o.NumberofPeople).ToList();

            return upper_bnd;
        }

        public void flood_fill(List<Table> ptables, Table tb, HashSet<int> visited)
        {
            if (visited.Contains(tb.TableId) || Occupied.Contains(tb.TableId) || !(CurrentTables.Contains(tb)))
                return;
            visited.Add(tb.TableId);

            if (tb.LinkableTableId1 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId1), visited);
            if (tb.LinkableTableId2 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId2), visited);
            if (tb.LinkableTableId3 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId3), visited);
            if (tb.LinkableTableId4 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId4), visited);
        }

        public bool Check_Division(List<Table> ptables)
        {
            int n_partition = 0;
            HashSet<int> visited = new HashSet<int>();

            foreach (var i in CurrentTables)
            {
                if (!(visited.Contains(i.TableId)) && !(Occupied.Contains(i.TableId)))
                {
                    n_partition++;
                    flood_fill(ptables, i,visited);
                }
            }

            if(n_partition <= 1)
                return true;
            return false;
        }

        public bool Place_one_Party(List<Table> ptables, Table tb,int num)
        {
            int next_num;

            if(num == 0)
                return true;
            if(!(CurrentTables.Contains(tb)) || Occupied.Contains(tb.TableId))
                return false;

            next_num = num - tb.Capacity;
            Occupied.Add(tb.TableId);

            if (next_num <= 0)
            {
                if (Check_Division(ptables))
                    return true;
                else
                {
                    Occupied.Remove(tb.TableId);
                    return false;
                }
            }

            if (tb.LinkableTableId1 != 0)
            {
                if(Place_one_Party(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId1), next_num))
                    return true;
            }
            if (tb.LinkableTableId2 != 0)
            {
                if (Place_one_Party(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId2), next_num))
                    return true;
            }
            if (tb.LinkableTableId3 != 0)
            {
                if (Place_one_Party(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId3), next_num))
                    return true;
            }
            if (tb.LinkableTableId4 != 0)
            {
                if (Place_one_Party(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId4), next_num))
                    return true;
            }
            Occupied.Remove(tb.TableId);
            return false;
        }

        public bool PlacementSuccess(List<Table> ptables)
        {
            bool flag;

            foreach (var i in PickedList)
            {
                flag = false;
                foreach (var y in CurrentTables)
                {
                    if (Place_one_Party(ptables, y, i.NumberofPeople))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    return false;
            }

            return true;
        }

        public void PlaceTabletoCustomer(List<Table> ptables, List<Customer> pcustomers)
        {
            int n_avail,tmp;
            
            is_visit = new HashSet<int>();
            picked_customers = new HashSet<int>();
            
            CurrentTables = new HashSet<Table>();
            Occupied = new HashSet<int>();

            foreach (var i in ptables)
            {
                CurrentTables.Clear();
                Occupied.Clear();
                n_avail = n_Active_Set(ptables, i.TableId);
                if (n_avail == 0)
                    continue;
                tmp = Pick_customers(n_avail, pcustomers);

                while (!PlacementSuccess(ptables))
                {
                    n_avail = n_avail - tmp - 1;
                    tmp = Pick_customers(n_avail, pcustomers);
                }

            }
        }
    }
}
