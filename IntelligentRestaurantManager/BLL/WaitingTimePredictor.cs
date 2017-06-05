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
        public void PredictWaitingTime(List<Table> ptables, List<Customer> pcustomers)
        {
            List<Table> tmp_tables = new List<Table>(ptables);
            List<Table> opt_seat;
            CustomerManager cus = new CustomerManager();
            PlacementOptimizer opt_pl = new PlacementOptimizer();

            foreach (var i in pcustomers)
            {

                opt_pl.PlaceTabletoCustomer(tmp_tables, i);
                opt_seat = opt_pl.Get_opt_seat();
                if (opt_seat.Count > 0)
                {
                    i.EstimatedWaitingTime = 0;
                    cus.Update(i);

                    foreach (var j in opt_seat)
                        tmp_tables.Find(x=>x.TableId == j.TableId).TableStatus = TableStatus.Ordering;
                }
            }

            foreach (var i in tmp_tables)
            {
                if (i.TableStatus == TableStatus.Cleaning)
                    i.TableStatus = TableStatus.Active;
            }

            foreach (var i in pcustomers)
            {
                if (i.EstimatedWaitingTime == 0)
                    continue;
                else if (i.EstimatedWaitingTime > 0)
                {
                    i.EstimatedWaitingTime = i.EstimatedWaitingTime - 1;
                    cus.Update(i);
                    continue;
                }
                opt_pl.PlaceTabletoCustomer(tmp_tables, i);
                opt_seat = opt_pl.Get_opt_seat();
                if (opt_seat.Count > 0)
                {
                    i.EstimatedWaitingTime = 300;
                    cus.Update(i);

                    foreach (var j in opt_seat)
                        tmp_tables.Find(x => x.TableId == j.TableId).TableStatus = TableStatus.Ordering;
                }
            }
        }
    }
}
