using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using System.Data.SqlClient;
using System.Data;

namespace IntelligentRestaurantManager.DAL
{
    class ItemService
    {
        public int AddNew(Item item)
        {
            return SQLHelper.ExecuteNonQuery("insert into T_ItemInfo([ItemId],[Name],[Price],[AverageTimeCost],[Description] ,[ItemStatus]) values(@ItemId,@Name,@Price,@AverageTimeCost,@Description,@ItemStatus)",
                new SqlParameter("ItemId", item.ItemId),
                new SqlParameter("Name", item.Name),
                new SqlParameter("Price", item.Price),
                new SqlParameter("AverageTimeCost", item.AverageTimeCost),
                new SqlParameter("Description", item.Description),
                new SqlParameter("ItemStatus", item.ItemStatus)
                );
        }

        public int DeleteByItemId(int itemId)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_ItemInfo where [ItemId]=@ItemId", new SqlParameter("ItemId", itemId));
        }

        public int DeleteByName(string name)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_ItemInfo where [Name]=@Name", new SqlParameter("Name", name));
        }

        public int DeleteAll()
        {
            return SQLHelper.ExecuteNonQuery("delete from T_ItemInfo");
        }

        public int Update(Item item)
        {
            return SQLHelper.ExecuteNonQuery("update T_ItemInfo set [Name]=@Name,[Price]=@Price,[AverageTimeCost]=@AverageTimeCost,[Description]=@Description,[ItemStatus]=@ItemStatus where [ItemId]=@ItemId",
                new SqlParameter("ItemId", item.ItemId),
                new SqlParameter("Name", item.Name),
                new SqlParameter("Price", item.Price),
                new SqlParameter("AverageTimeCost", item.AverageTimeCost),
                new SqlParameter("Description", item.Description),
                new SqlParameter("ItemStatus", item.ItemStatus)
                );
        }

        public IEnumerable<Item> GetAll()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_ItemInfo order by [ItemId]");
            List<Item> list = new List<Item>();
            foreach (DataRow row in dt.Rows)
            {
                Item item = new Item();
                item.ItemId = (int)row["ItemId"];
                item.Name = (string)row["Name"];
                item.Price = (decimal)row["Price"];
                item.AverageTimeCost = (int)row["AverageTimeCost"];
                item.Description = (string)row["Description"];
                item.ItemStatus = (ItemStatus)row["ItemStatus"];
                list.Add(item);
            }
            return list;
        }

        public IEnumerable<Item> GetByItemStatus(ItemStatus itemStatus)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_ItemInfo where [ItemStatus]=@ItemStatus", new SqlParameter("ItemStatus", (int)itemStatus));
            List<Item> list = new List<Item>();
            foreach (DataRow row in dt.Rows)
            {
                Item item = new Item();
                item.ItemId = (int)row["ItemId"];
                item.Name = (string)row["Name"];
                item.Price = (decimal)row["Price"];
                item.AverageTimeCost = (int)row["AverageTimeCost"];
                item.Description = (string)row["Description"];
                item.ItemStatus = (ItemStatus)row["ItemStatus"];
                list.Add(item);
            }
            return list;
        }

        public Item GetByItemId(int itemId)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_ItemInfo where [ItemId]=@ItemId", new SqlParameter("ItemId", itemId));
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Item item = new Item();
                item.ItemId = (int)row["ItemId"];
                item.Name = (string)row["Name"];
                item.Price = (decimal)row["Price"];
                item.AverageTimeCost = (int)row["AverageTimeCost"];
                item.Description = (string)row["Description"];
                item.ItemStatus = (ItemStatus)row["ItemStatus"];
                return item;
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception(string.Format("Error! ItemId {0} is not unique!", itemId));
            }
            else
            {
                return null;
            }
        }


        public IEnumerable<Item> GetByItemIdArray(int [] itemIdArray)
        {
            List<Item> list = new List<Item>();
            foreach (int itemId in itemIdArray)
            {
                Item item = new Item();
                item = GetByItemId(itemId);
                list.Add(item);
            }
            return list;
        }
        //get item list by item id array, and set item status according to itemStatusArray
        public IEnumerable<Item> GetByItemIdArray(int[] itemIdArray, int[] itemStatusArray)
        {
            List<Item> list = new List<Item>();
            for (int i = 0; i < itemIdArray.Length; i++)
            {
                Item item = new Item();
                item = GetByItemId(itemIdArray[i]);
                item.ItemStatus = (ItemStatus)itemStatusArray[i];
                list.Add(item);
            }
            return list;
        }

        public int GetCount()
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_ItemInfo");
        }
    }
}
