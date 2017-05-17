using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class ItemManager
    {
        private ItemService itemService = new ItemService();

        //check if given ID is already used
        public bool CheckExists(int id)
        {
            Item item = itemService.GetByItemId(id);
            if (item == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int AddNew(Item item)
        {
            if (this.CheckExists(item.ItemId))
            {
                return 0;
            }
            else
            {
                return itemService.AddNew(item);
            }

        }

        public int DeleteByItemId(int itemId)
        {
            return itemService.DeleteByItemId(itemId);
        }

        public int DeleteByName(string name)
        {
            return itemService.DeleteByName(name);
        }

        public int DeleteAll()
        {
            return itemService.DeleteAll();
        }

        public int Update(Item item)
        {
            return itemService.Update(item);
        }

        public IEnumerable<Item> GetAll()
        {
            return itemService.GetAll();
        }

        public IEnumerable<Item> GetByItemStatus(ItemStatus itemStatus)
        {
            return itemService.GetByItemStatus(itemStatus);
        }

        public Item GetByItemId(int itemId)
        {
            return itemService.GetByItemId(itemId);
        }

        public IEnumerable<Item> GetByItemIdArray(int [] itemIdArray)
        {
            return itemService.GetByItemIdArray(itemIdArray);
        }

        //get item list by item id array, and set item status according to itemStatusArray
        public IEnumerable<Item> GetByItemIdArray(int[] itemIdArray, int[] itemStatusArray)
        {
            return itemService.GetByItemIdArray(itemIdArray, itemStatusArray);
        }

        public int GetCount()
        {
            return this.itemService.GetCount();
        }
    }
}
