using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class Cook: Staff
    {
        /// <summary>
        /// Change the item's status
        /// </summary>
        /// <param name="item"></param>
        /// <returns>If changed sucessfully, return true; else return false</returns>
        public bool StartItem(Item item)
        {
            if (item.ItemStatus == ItemStatus.Wait)
            {
                item.ItemStatus = ItemStatus.Start;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AbandonItem(Item item)
        {
            if (item.ItemStatus == ItemStatus.Start)
            {
                item.ItemStatus = ItemStatus.Wait;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FinishItem(Item item)
        {
            if (item.ItemStatus == ItemStatus.Start)
            {
                item.ItemStatus = ItemStatus.Finish;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
