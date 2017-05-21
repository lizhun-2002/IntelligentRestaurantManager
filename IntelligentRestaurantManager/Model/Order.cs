using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Model
{
    public enum OrderStatus
    {
        Start, Cancel, Finish
    }

    public class Order
    {
        public Order()
        {
            FinishTime = DateTime.MinValue;
        }
        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        private int numberofPeople;

        public int NumberofPeople
        {
            get { return numberofPeople; }
            set { numberofPeople = value; }
        }
        private int [] tableIds;

        public int [] TableIds
        {
            get { return tableIds; }
            set { tableIds = value; }
        }
        private OrderStatus orderStatus;

        internal OrderStatus OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }
        private DateTime finishTime;

        public DateTime FinishTime
        {
            get { return finishTime; }
            set { finishTime = value; }
        }
        public List<Item> Items = new List<Item>();
    }
}
