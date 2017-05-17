using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Model
{
    enum ItemStatus
    {
        Wait,Start,Cancel,Finish
    }

    class Item
    {
        private int itemId;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        private int averageTimeCost;//minutes

        public int AverageTimeCost
        {
            get { return averageTimeCost; }
            set { averageTimeCost = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ItemStatus itemStatus;

        public ItemStatus ItemStatus
        {
            get { return itemStatus; }
            set { itemStatus = value; }
        }

    }
}
