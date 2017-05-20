using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using IntelligentRestaurantManager.Model;

namespace IntelligentRestaurantManager.DAL
{
    class TableService
    {
        public int AddNew(Table table)
        {
            return SQLHelper.ExecuteNonQuery("insert into T_TableInfo([TableId],[Capacity],[LinkableTableId1],[LinkableTableId2],[LinkableTableId3],[LinkableTableId4],[CountDown],[TableStatus],[ReservationInfo],[CustomerId],[WaiterName] ,[OrderId]) "
                + "values(@TableId,@Capacity,@LinkableTableId1,@LinkableTableId2,@LinkableTableId3,@LinkableTableId4,@CountDown,@TableStatus,@ReservationInfo,@CustomerId,@WaiterName,@OrderId)",
                new SqlParameter("TableId", table.TableId),
                new SqlParameter("Capacity", table.Capacity),
                new SqlParameter("LinkableTableId1", table.LinkableTableId1),
                new SqlParameter("LinkableTableId2", table.LinkableTableId2),
                new SqlParameter("LinkableTableId3", table.LinkableTableId3),
                new SqlParameter("LinkableTableId4", table.LinkableTableId4),
                new SqlParameter("CountDown", table.CountDown),
                new SqlParameter("TableStatus", table.TableStatus),
                new SqlParameter("ReservationInfo", table.ReservationInfo),
                new SqlParameter("CustomerId", table.CustomerId),
                new SqlParameter("WaiterName", table.WaiterName),
                new SqlParameter("OrderId", table.OrderId)
                );
        }

        public int DeleteByTableId(int tableId)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_TableInfo where [TableId]=@TableId", new SqlParameter("TableId", tableId));
        }

        public int DeleteAll()
        {
            return SQLHelper.ExecuteNonQuery("delete from T_TableInfo");
        }

        public int Update(Table table)
        {
            return SQLHelper.ExecuteNonQuery("update T_TableInfo set [Capacity]=@Capacity,[LinkableTableId1]=@LinkableTableId1,[LinkableTableId2]=@LinkableTableId2,[LinkableTableId3]=@LinkableTableId3,[LinkableTableId4]=@LinkableTableId4, "
                + "[CountDown]=@CountDown,[TableStatus]=@TableStatus,[ReservationInfo]=@ReservationInfo,[CustomerId]=@CustomerId,[WaiterName]=@WaiterName,[OrderId]=@OrderId"
                +" where [TableId]=@TableId",
                new SqlParameter("TableId", table.TableId),
                new SqlParameter("Capacity", table.Capacity),
                new SqlParameter("LinkableTableId1", table.LinkableTableId1),
                new SqlParameter("LinkableTableId2", table.LinkableTableId2),
                new SqlParameter("LinkableTableId3", table.LinkableTableId3),
                new SqlParameter("LinkableTableId4", table.LinkableTableId4),
                new SqlParameter("CountDown", table.CountDown),
                new SqlParameter("TableStatus", table.TableStatus),
                new SqlParameter("ReservationInfo", table.ReservationInfo),
                new SqlParameter("CustomerId", table.CustomerId),
                new SqlParameter("WaiterName", table.WaiterName),
                new SqlParameter("OrderId", table.OrderId)
                );
        }

        public IEnumerable<Table> GetAll()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_TableInfo order by [TableId]");
            List<Table> list = new List<Table>();
            foreach (DataRow row in dt.Rows)
            {
                Table table = new Table();
                table.TableId = (int)row["TableId"];
                table.Capacity = (int)row["Capacity"];
                table.LinkableTableId1 = (int)row["LinkableTableId1"];
                table.LinkableTableId2 = (int)row["LinkableTableId2"];
                table.LinkableTableId3 = (int)row["LinkableTableId3"];
                table.LinkableTableId4 = (int)row["LinkableTableId4"];
                table.CountDown = (DateTime)row["CountDown"];
                table.TableStatus = (TableStatus)row["TableStatus"];
                table.ReservationInfo = (string)row["ReservationInfo"];
                table.CustomerId = (int)row["CustomerId"];
                table.WaiterName = (string)row["WaiterName"];
                table.OrderId = (int)row["OrderId"];
                list.Add(table);
            }
            return list;
        }

        public IEnumerable<Table> GetByCapacity(int capacity)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_TableInfo where [Capacity]=@Capacity", new SqlParameter("Capacity", capacity));
            List<Table> list = new List<Table>();
            foreach (DataRow row in dt.Rows)
            {
                Table table = new Table();
                table.TableId = (int)row["TableId"];
                table.Capacity = (int)row["Capacity"];
                table.LinkableTableId1 = (int)row["LinkableTableId1"];
                table.LinkableTableId2 = (int)row["LinkableTableId2"];
                table.LinkableTableId3 = (int)row["LinkableTableId3"];
                table.LinkableTableId4 = (int)row["LinkableTableId4"];
                table.CountDown = (DateTime)row["CountDown"];
                table.TableStatus = (TableStatus)row["TableStatus"];
                table.ReservationInfo = (string)row["ReservationInfo"];
                table.CustomerId = (int)row["CustomerId"];
                table.WaiterName = (string)row["WaiterName"];
                table.OrderId = (int)row["OrderId"];
                list.Add(table);
            }
            return list;
        }

        public IEnumerable<Table> GetByTableStatus(TableStatus tableStatus)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_TableInfo where [TableStatus]=@TableStatus", new SqlParameter("TableStatus", (int)tableStatus));
            List<Table> list = new List<Table>();
            foreach (DataRow row in dt.Rows)
            {
                Table table = new Table();
                table.TableId = (int)row["TableId"];
                table.Capacity = (int)row["Capacity"];
                table.LinkableTableId1 = (int)row["LinkableTableId1"];
                table.LinkableTableId2 = (int)row["LinkableTableId2"];
                table.LinkableTableId3 = (int)row["LinkableTableId3"];
                table.LinkableTableId4 = (int)row["LinkableTableId4"];
                table.CountDown = (DateTime)row["CountDown"];
                table.TableStatus = (TableStatus)row["TableStatus"];
                table.ReservationInfo = (string)row["ReservationInfo"];
                table.CustomerId = (int)row["CustomerId"];
                table.WaiterName = (string)row["WaiterName"];
                table.OrderId = (int)row["OrderId"];
                list.Add(table);
            }
            return list;
        }

        public IEnumerable<Table> GetByTableCustomerId(int customerId)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_TableInfo where [CustomerId]=@CustomerId", new SqlParameter("CustomerId", customerId));
            List<Table> list = new List<Table>();
            foreach (DataRow row in dt.Rows)
            {
                Table table = new Table();
                table.TableId = (int)row["TableId"];
                table.Capacity = (int)row["Capacity"];
                table.LinkableTableId1 = (int)row["LinkableTableId1"];
                table.LinkableTableId2 = (int)row["LinkableTableId2"];
                table.LinkableTableId3 = (int)row["LinkableTableId3"];
                table.LinkableTableId4 = (int)row["LinkableTableId4"];
                table.CountDown = (DateTime)row["CountDown"];
                table.TableStatus = (TableStatus)row["TableStatus"];
                table.ReservationInfo = (string)row["ReservationInfo"];
                table.CustomerId = (int)row["CustomerId"];
                table.WaiterName = (string)row["WaiterName"];
                table.OrderId = (int)row["OrderId"];
                list.Add(table);
            }
            return list;
        }

        public Table GetByTableId(int tableId)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_TableInfo where [TableId]=@TableId", new SqlParameter("TableId", tableId));
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Table table = new Table();
                table.TableId = (int)row["TableId"];
                table.Capacity = (int)row["Capacity"];
                table.LinkableTableId1 = (int)row["LinkableTableId1"];
                table.LinkableTableId2 = (int)row["LinkableTableId2"];
                table.LinkableTableId3 = (int)row["LinkableTableId3"];
                table.LinkableTableId4 = (int)row["LinkableTableId4"];
                table.CountDown = (DateTime)row["CountDown"];
                table.TableStatus = (TableStatus)row["TableStatus"];
                table.ReservationInfo = (string)row["ReservationInfo"];
                table.CustomerId = (int)row["CustomerId"];
                table.WaiterName = (string)row["WaiterName"];
                table.OrderId = (int)row["OrderId"];
                return table;
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception(string.Format("Error! TableId {0} is not unique!", tableId));
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_TableInfo");
        }
    }
}
