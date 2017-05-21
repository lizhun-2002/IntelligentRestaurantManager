using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Model
{
    public enum TableStatus
    {
        Active,Ordering,Cleaning,Reserved,Breakdown
    }

    public class Table
    {
        public Table()
        {
            CountDown = DateTime.MinValue;
            ReservationInfo = "";
            CustomerId = -1;
            WaiterName = "";
            OrderId = -1;
        }
        private int tableId;

        public int TableId
        {
            get { return tableId; }
            set { tableId = value; }
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private int linkableTableId1;

        public int LinkableTableId1
        {
            get { return linkableTableId1; }
            set { linkableTableId1 = value; }
        }
        private int linkableTableId2;

        public int LinkableTableId2
        {
            get { return linkableTableId2; }
            set { linkableTableId2 = value; }
        }
        private int linkableTableId3;

        public int LinkableTableId3
        {
            get { return linkableTableId3; }
            set { linkableTableId3 = value; }
        }
        private int linkableTableId4;

        public int LinkableTableId4
        {
            get { return linkableTableId4; }
            set { linkableTableId4 = value; }
        }
        private DateTime countDown;

        public DateTime CountDown
        {
            get { return countDown; }
            set { countDown = value; }
        }
        private TableStatus tableStatus;

        public TableStatus TableStatus
        {
            get { return tableStatus; }
            set { tableStatus = value; }
        }
        private string reservationInfo;

        public string ReservationInfo
        {
            get { return reservationInfo; }
            set { reservationInfo = value; }
        }
        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string waiterName;

        public string WaiterName
        {
            get { return waiterName; }
            set { waiterName = value; }
        }
        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
    }
}
