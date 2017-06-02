using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class TableManager
    {
        private TableService tableService = new TableService();

        //check if given ID is already used
        public bool CheckExists(int id)
        {
            Table table = tableService.GetByTableId(id);
            if (table == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int AddNew(Table table)
        {
            if (this.CheckExists(table.TableId))
            {
                return 0;
            }
            else
            {
                return tableService.AddNew(table);
            }

        }

        public int DeleteByTableId(int tableId)
        {
            return tableService.DeleteByTableId(tableId);
        }

        public int DeleteAll()
        {
            return tableService.DeleteAll();
        }

        public int Update(Table table)
        {
            return tableService.Update(table);
        }

        public IEnumerable<Table> GetAll()
        {
            return tableService.GetAll();
        }

        public IEnumerable<Table> GetByTableStatus(TableStatus tableStatus)
        {
            return tableService.GetByTableStatus(tableStatus);
        }

        public IEnumerable<Table> GetByTableCustomerId(int customerId)
        {
            return tableService.GetByTableCustomerId(customerId);
        }

        public Table GetByTableId(int tableId)
        {
            try
            {
                return tableService.GetByTableId(tableId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Table> GetByCapacity(int capacity)
        {
            return tableService.GetByCapacity(capacity);
        }

        public int GetCount()
        {
            return this.tableService.GetCount();
        }
    }
}
