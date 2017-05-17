using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Model
{
    class Customer
    {
        private int waitingNumber;

        public int WaitingNumber
        {
            get { return waitingNumber; }
            set { waitingNumber = value; }
        }
        private int numberofPeople;

        public int NumberofPeople
        {
            get { return numberofPeople; }
            set { numberofPeople = value; }
        }
        private DateTime arriveTime;

        public DateTime ArriveTime
        {
            get { return arriveTime; }
            set { arriveTime = value; }
        }
        private int recommendedTableId;

        public int RecommendedTableId
        {
            get { return recommendedTableId; }
            set { recommendedTableId = value; }
        }
        private int estimatedWaitingTime;

        public int EstimatedWaitingTime
        {
            get { return estimatedWaitingTime; }
            set { estimatedWaitingTime = value; }
        }
    }
}
