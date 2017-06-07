using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;
using IntelligentRestaurantManager.Common;

namespace IntelligentRestaurantManager.BLL
{
    class WaitingTimePredictor : IPredictionAlgorithm
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
                        tmp_tables.Find(x => x.TableId == j.TableId).TableStatus = TableStatus.Ordering;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tables"></param>diningArea.tables
        /// <param name="customers"></param>diningArea.customers
        /// <param name="orders"></param>diningArea.orders
        /// <param name="finishedOrders"></param>training data
        /// <param name="allItem"></param>
        //make sure the itemId is continuous
        public void PredictWaitingTimeReg(List<Table> tables, List<Customer> customers, List<Order> orders, List<Order> finishedOrders, List<Item> allItem)
        {
            //HashSet<Item> hs = new HashSet<Item>(allItem);//去重

            int nAttributes = allItem.Count + 1;
            int nSamples = finishedOrders.Count;
            double[,] tsData = new double[nSamples, nAttributes];
            double[] resultData = new double[nSamples];

            for (int i = 0; i < nSamples; i++)
            {
                for (int j = 0; j < nAttributes; j++)
                {
                    tsData[i, j] = 0;
                }
                tsData[i, 0] = finishedOrders[i].NumberofPeople;
                foreach (var item in finishedOrders[i].Items)
                {
                    tsData[i, item.ItemId] = item.ItemAmount;
                }
                TimeSpan ts = finishedOrders[i].FinishTime - finishedOrders[i].StartTime;
                resultData[i] = ts.TotalMinutes;
            }

            double[] weights = null;
            int fitResult = 0;
            alglib.lsfit.lsfitreport rep = new alglib.lsfit.lsfitreport();
            alglib.lsfit.lsfitlinear(resultData, tsData, nSamples, nAttributes, ref fitResult, ref weights, rep);

            //about weight: weights[0] -> NumberofPeople,weights[1-allItem.Count]->ItemId,weights[allItem.Count+1 - nAttributes]->ItemAmount
            foreach (var t in tables)
            {
                if (t.TableStatus == TableStatus.Active)
                {
                    t.CountDown = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
                }
                else if (t.TableStatus == TableStatus.Cleaning)
                {
                    //t.CountDown = DateTime.Now.AddMinutes(5);
                    //this operation will be done when set tablestatus to cleaning.
                }
                else if (t.TableStatus == TableStatus.Reserved || t.TableStatus == TableStatus.Breakdown)
                {
                    t.CountDown = System.Data.SqlTypes.SqlDateTime.MaxValue.Value;
                }
                else if (fitResult == 1 && t.OrderId > 0)//solved
                {
                    Order currentOrder = orders.Find(x => x.OrderId == t.OrderId);
                    double waitTime = weights[0] * currentOrder.NumberofPeople;
                    foreach (var item in currentOrder.Items)
                    {
                        waitTime += weights[item.ItemId] * item.ItemAmount;
                    }

                    t.CountDown = currentOrder.StartTime.AddMinutes(waitTime);
                }
            }


            //Dictionary<int, double> labelsAndWeights = new Dictionary<int, double>();
            //labelsAndWeights.Add(0, weights[0]);
            //labelsAndWeights.Add(1, weights[1]);
            //labelsAndWeights.Add(2, weights[2]);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="tables"></param>diningArea.tables
        ///// <param name="customers"></param>diningArea.customers
        ///// <param name="orders"></param>diningArea.orders
        ///// <param name="finishedOrders"></param>training data
        ///// <param name="allItem"></param>
        ////make sure the itemId is continuous
        //public void PredictWaitingTimeReg(List<Table> tables, List<Customer> customers, List<Order> orders, List<Order> finishedOrders, List<Item> allItem)
        //{
        //    //HashSet<Item> hs = new HashSet<Item>(allItem);//去重

        //    int nAttributes = allItem.Count * 2 + 1;
        //    int nSamples = finishedOrders.Count;
        //    double[,] tsData = new double[nSamples, nAttributes];
        //    double[] resultData = new double[nSamples];

        //    for (int i = 0; i < nSamples; i++)
        //    {
        //        for (int j = 0; j < nAttributes; j++)
        //        {
        //            tsData[i, j] = 0;
        //        }
        //        tsData[i, 0] = finishedOrders[i].NumberofPeople;
        //        foreach (var item in finishedOrders[i].Items)
        //        {
        //            tsData[i, item.ItemId] = 1;
        //            tsData[i, item.ItemId + allItem.Count] = item.ItemAmount;

        //        }
        //        TimeSpan ts = finishedOrders[i].FinishTime - finishedOrders[i].StartTime;
        //        resultData[i] = ts.Seconds;
        //    }

        //    double[] weights = null;
        //    int fitResult = 0;
        //    alglib.lsfit.lsfitreport rep = new alglib.lsfit.lsfitreport();
        //    alglib.lsfit.lsfitlinear(resultData, tsData, nSamples, nAttributes, ref fitResult, ref weights, rep);

        //    //about weight: weights[0] -> NumberofPeople,weights[1-allItem.Count]->ItemId,weights[allItem.Count+1 - nAttributes]->ItemAmount
        //    foreach (var t in tables)
        //    {
        //        if (t.TableStatus == TableStatus.Active)
        //        {
        //            t.CountDown = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
        //        }
        //        else if (t.TableStatus == TableStatus.Cleaning)
        //        {
        //            t.CountDown = DateTime.Now.AddMinutes(5);
        //        }
        //        else if (t.TableStatus == TableStatus.Reserved || t.TableStatus == TableStatus.Breakdown)
        //        {
        //            t.CountDown = System.Data.SqlTypes.SqlDateTime.MaxValue.Value;
        //        }
        //        else if (fitResult == 1 && t.OrderId > 0)//solved
        //        {
        //            Order currentOrder = orders.Find(x => x.OrderId == t.OrderId);
        //            double waitTime = weights[0] * currentOrder.NumberofPeople;
        //            foreach (var item in currentOrder.Items)
        //            {
        //                waitTime += weights[item.ItemId] * 1 + weights[item.ItemId + allItem.Count] * item.ItemAmount;
        //            }

        //            t.CountDown = DateTime.Now.AddSeconds(waitTime);
        //        }
        //    }


        //    //Dictionary<int, double> labelsAndWeights = new Dictionary<int, double>();
        //    //labelsAndWeights.Add(0, weights[0]);
        //    //labelsAndWeights.Add(1, weights[1]);
        //    //labelsAndWeights.Add(2, weights[2]);
        //}
    }
}
