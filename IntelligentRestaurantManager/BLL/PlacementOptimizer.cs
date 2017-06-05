using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class PlacementOptimizer : IPlacementAlgorithm
    {
        int occupied;
        List<Table> final_seat;
        List<int> curr_partition;

        public void flood_fill(List<Table> ptables, Table tb, HashSet<int> visited, List<int> partition)
        {
            if (visited.Contains(tb.TableId) || tb.TableStatus != TableStatus.Active)
                return;
            visited.Add(tb.TableId);
            partition.Add(tb.TableId);

            if (tb.LinkableTableId1 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId1), visited, partition);
            if (tb.LinkableTableId2 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId2), visited, partition);
            if (tb.LinkableTableId3 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId3), visited, partition);
            if (tb.LinkableTableId4 != 0)
                flood_fill(ptables, ptables.Find(o => o.TableId == tb.LinkableTableId4), visited, partition);

            return;
        }

        public int n_flood_fill(List<Table> ptables, Table curr_table, HashSet<int> prev_visited, HashSet<int> new_visited)
        {
            int n = 1;

            if (!(curr_partition.Contains(curr_table.TableId)) || prev_visited.Contains(curr_table.TableId) || new_visited.Contains(curr_table.TableId))
                return 0;
            new_visited.Add(curr_table.TableId);
            if (curr_table.LinkableTableId1 != 0)
                n += n_flood_fill(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId1), prev_visited, new_visited);
            if (curr_table.LinkableTableId2 != 0)
                n += n_flood_fill(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId2), prev_visited, new_visited);
            if (curr_table.LinkableTableId3 != 0)
                n += n_flood_fill(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId3), prev_visited, new_visited);
            if (curr_table.LinkableTableId4 != 0)
                n += n_flood_fill(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId4), prev_visited, new_visited);

            return n;
        }

        public bool is_still_connected(List<Table> ptables, HashSet<int> visited)
        {
            int t, n_new_partition = 0;
            HashSet<int> new_visited = new HashSet<int>();

            foreach (var i in curr_partition)
            {
                t = n_flood_fill(ptables, ptables.Find(x => x.TableId == i), visited, new_visited);
                if (t > 0)
                    n_new_partition++;
            }

            if (n_new_partition <= 1)
                return true;
            return false;
        }

        public void Place_customer(List<Table> ptables, Table curr_table, int curr_occupied, int n_people, HashSet<int> visited)
        {
            if (visited.Contains(curr_table.TableId) || (curr_table.TableStatus != TableStatus.Active))
                return;

            visited.Add(curr_table.TableId);
            curr_occupied += curr_table.Capacity;

            if (occupied <= curr_occupied)
            {
                visited.Remove(curr_table.TableId);
                return;
            }
            if (n_people <= curr_occupied)
            {
                if (is_still_connected(ptables, visited))
                {
                    final_seat.Clear();

                    foreach (var i in visited)
                        final_seat.Add(ptables.Find(x => x.TableId == i));
                    occupied = curr_occupied;
                }
                visited.Remove(curr_table.TableId);
                return;
            }

            if (curr_table.LinkableTableId1 != 0)
                Place_customer(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId1), curr_occupied, n_people, visited);
            if (curr_table.LinkableTableId2 != 0)
                Place_customer(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId2), curr_occupied, n_people, visited);
            if (curr_table.LinkableTableId3 != 0)
                Place_customer(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId3), curr_occupied, n_people, visited);
            if (curr_table.LinkableTableId4 != 0)
                Place_customer(ptables, ptables.Find(o => o.TableId == curr_table.LinkableTableId4), curr_occupied, n_people, visited);

            visited.Remove(curr_table.TableId);
        }

        public void PlaceTabletoCustomer(List<Table> ptables, Customer pcustomer)
        {
            HashSet<int> visited = new HashSet<int>();
            List<List<int>> partition = new List<List<int>>();
            final_seat = new List<Table>();
            int n_partition = 0;

            foreach (var i in ptables)
            {
                if (!(visited.Contains(i.TableId)))
                {
                    n_partition++;
                    partition.Add(new List<int>());
                    flood_fill(ptables, i, visited, partition.Last());
                }
            }
            partition.Sort((List<int> p1, List<int> p2) => (p1.Sum(x => ptables.Find(o => o.TableId == x).Capacity).CompareTo(p2.Sum(x => ptables.Find(o => o.TableId == x).Capacity))));


            foreach (var i in partition)
            {
                if (i.Sum(x => ptables.Find(o => o.TableId == x).Capacity) < pcustomer.NumberofPeople)
                    continue;
                curr_partition = i;
                occupied = i.Sum(x => ptables.Find(o => o.TableId == x).Capacity) + 1;
                foreach (var j in i)
                {
                    visited.Clear();
                    Place_customer(ptables, ptables.Find(x => x.TableId == j), 0, pcustomer.NumberofPeople, visited);
                }
                if (occupied < i.Sum(x => ptables.Find(o => o.TableId == x).Capacity) + 1)
                    break;
            }
        }

        public List<Table> Get_opt_seat()
        {
            return final_seat;
        }
    }
}
