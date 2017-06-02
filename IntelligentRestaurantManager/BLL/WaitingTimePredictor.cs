using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class WaitingTimePredictor: IPredictionAlgorithm
    {
        HashSet<int> is_visit;

        public int Max_Active_Seat(List<Table> tables, int currID)
        {
            int n;
            Table currTable = tables.Find(x => x.TableId == currID);

            if (is_visit.Contains(currID) || currTable.TableStatus != TableStatus.Active)
                return 0;
            is_visit.Add(currID);
            n = currTable.Capacity;

            if (currTable.LinkableTableId1 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId1);
            }
            if (currTable.LinkableTableId2 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId2);
            }
            if (currTable.LinkableTableId3 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId3);
            }
            if (currTable.LinkableTableId4 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId4);
            }

            return n;
        }

        public int Max_Active_Cleaning_Seat(List<Table> tables, int currID)
        {
            int n;
            Table currTable = tables.Find(x => x.TableId == currID);

            if (is_visit.Contains(currID) || (currTable.TableStatus != TableStatus.Active && currTable.TableStatus != TableStatus.Cleaning))
                return 0;
            is_visit.Add(currID);
            n = currTable.Capacity;

            if (currTable.LinkableTableId1 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId1);
            }
            if (currTable.LinkableTableId2 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId2);
            }
            if (currTable.LinkableTableId3 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId3);
            }
            if (currTable.LinkableTableId4 != 0)
            {
                n += Max_Active_Seat(tables, currTable.LinkableTableId4);
            }

            return n;
        }

        public void PredictWaitingTime(List<Table> ptables, List<Customer> pcustomers)
        {
            int n_avail;

            is_visit = new HashSet<int>();

            n_avail = 0;
            is_visit.Clear();

            foreach (var i in ptables)
            {
                n_avail = Math.Max(n_avail, Max_Active_Seat(ptables, i.TableId));
            }
            //if there is the available placement, then set estimated time to 0.
            if (pcustomers.Count > 0 && n_avail >= pcustomers[0].NumberofPeople)
            {
                pcustomers[0].EstimatedWaitingTime = 0;
                return;
            }

            n_avail = 0;
            is_visit.Clear();

            foreach (var i in ptables)
            {
                n_avail = Math.Max(n_avail, Max_Active_Cleaning_Seat(ptables, i.TableId));
            }
            //if there is the available placement containing cleaning seat, then set estimated time to 5 min.
            if (pcustomers.Count > 0 && n_avail >= pcustomers[0].NumberofPeople)
            {
                pcustomers[0].EstimatedWaitingTime = 300;
                return;
            }

        }
    }
}
