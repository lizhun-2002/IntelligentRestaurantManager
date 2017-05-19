using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class Manager: Staff
    {
        /// <summary>
        /// Add data
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>No. of lines affected</returns>
        public int Add(Staff staff)
        {
            StaffManager staffManager = new StaffManager();
            return staffManager.AddNew(staff);
        }

        public int Add(Item item)
        {
            ItemManager itemManager = new ItemManager();
            return itemManager.AddNew(item);
        }

        public int Add(Table table)
        {
            TableManager tableManager = new TableManager();
            return tableManager.AddNew(table);
        }

        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>No. of lines affected</returns>
        public int Update(Staff staff)
        {
            StaffManager staffManager = new StaffManager();
            return staffManager.Update(staff);
        }

        public int Update(Item item)
        {
            ItemManager itemManager = new ItemManager();
            return itemManager.Update(item);
        }

        public int Update(Table table)
        {
            TableManager tableManager = new TableManager();
            return tableManager.Update(table);
        }

        /// <summary>
        /// Delete data
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>No. of lines affected</returns>
        public int Delete(Staff staff)
        {
            StaffManager staffManager = new StaffManager();
            return staffManager.DeleteByName(staff.Name);
        }

        public int Delete(Item item)
        {
            ItemManager itemManager = new ItemManager();
            return itemManager.DeleteByItemId(item.ItemId);
        }

        public int Delete(Table table)
        {
            TableManager tableManager = new TableManager();
            return tableManager.DeleteByTableId(table.TableId);
        }
    }
}
