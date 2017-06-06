using IntelligentRestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.DAL
{
    class OrderService
    {
        public int AddNew(Order order)
        {
            int [] ItemIds = new int[order.Items.Count];
            int[] ItemStatusAll = new int[order.Items.Count];
            int[] ItemAmount = new int[order.Items.Count];
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i=0; i < order.Items.Count; i++)
            {
                ItemIds[i] = order.Items[i].ItemId;
                ItemStatusAll[i] = (int)order.Items[i].ItemStatus;
                ItemAmount[i] = order.Items[i].ItemAmount;
            }
            return SQLHelper.ExecuteNonQuery("insert into T_OrderFlow([OrderId],[StartTime],[NumberofPeople],[TableIds],[OrderStatus],[ItemIds],[ItemStatusAll],[ItemAmounts],[FinishTime]) values(@OrderId,@StartTime,@NumberofPeople,@TableIds,@OrderStatus,@ItemIds,@ItemStatusAll,@ItemAmounts,@FinishTime)",
                new SqlParameter("OrderId", order.OrderId),
                new SqlParameter("StartTime", order.StartTime),
                new SqlParameter("NumberofPeople", order.NumberofPeople),
                new SqlParameter("TableIds", string.Join(",",order.TableIds)),
                new SqlParameter("OrderStatus", order.OrderStatus),
                new SqlParameter("ItemIds", string.Join(",", ItemIds)),
                new SqlParameter("ItemStatusAll", string.Join(",", ItemStatusAll)),
                new SqlParameter("ItemAmounts", string.Join(",", ItemAmount)),
                new SqlParameter("FinishTime", order.FinishTime)
                );
        }

        public int DeleteByOrderId(int orderId)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_OrderFlow where [OrderId]=@OrderId", new SqlParameter("OrderId", orderId));
        }

        public int DeleteAll()
        {
            return SQLHelper.ExecuteNonQuery("delete from T_OrderFlow");
        }

        public int Update(Order order)
        {
            DeleteByOrderId(order.OrderId);
            return AddNew(order);
        }

        public IEnumerable<Order> GetAll()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_OrderFlow order by [OrderId]");
            List<Order> list = new List<Order>();
            foreach (DataRow row in dt.Rows)
            {
                Order order = new Order();
                order.OrderId = (int)row["OrderId"];
                order.StartTime = (DateTime)row["StartTime"];
                order.NumberofPeople = (int)row["NumberofPeople"];

                string[] strArray = ((string)row["TableIds"]).Split(new char[] { ',' });
                order.TableIds = Array.ConvertAll<string, int>(strArray, s => int.Parse(s));

                order.OrderStatus = (OrderStatus)row["OrderStatus"];

                string[] strArray2 = ((string)row["ItemIds"]).Split(new char[] { ',' });
                int[] intArray2 = Array.ConvertAll<string, int>(strArray2, s => int.Parse(s));
                string[] strArray3 = ((string)row["ItemStatusAll"]).Split(new char[] { ',' });
                int[] intArray3 = Array.ConvertAll<string, int>(strArray3, s => int.Parse(s));
                string[] strArray4 = ((string)row["ItemAmounts"]).Split(new char[] { ',' });
                int[] intArray4 = Array.ConvertAll<string, int>(strArray4, s => int.Parse(s));
                order.Items = (List<Item>)new ItemService().GetByItemIdArray(intArray2, intArray3, intArray4);

                order.FinishTime = (DateTime)row["FinishTime"];
                list.Add(order);
            }
            return list;
        }

        public IEnumerable<Order> GetByOrderDate(DateTime date)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_OrderFlow where [StartTime]=@StartTime", new SqlParameter("StartTime", date));
            List<Order> list = new List<Order>();
            foreach (DataRow row in dt.Rows)
            {
                Order order = new Order();
                order.OrderId = (int)row["OrderId"];
                order.StartTime = (DateTime)row["StartTime"];
                order.NumberofPeople = (int)row["NumberofPeople"];

                string[] strArray = ((string)row["TableIds"]).Split(new char[] { ',' });
                order.TableIds = Array.ConvertAll<string, int>(strArray, s => int.Parse(s));

                order.OrderStatus = (OrderStatus)row["OrderStatus"];

                string[] strArray2 = ((string)row["ItemIds"]).Split(new char[] { ',' });
                int[] intArray2 = Array.ConvertAll<string, int>(strArray2, s => int.Parse(s));
                string[] strArray3 = ((string)row["ItemStatusAll"]).Split(new char[] { ',' });
                int[] intArray3 = Array.ConvertAll<string, int>(strArray3, s => int.Parse(s));
                string[] strArray4 = ((string)row["ItemAmounts"]).Split(new char[] { ',' });
                int[] intArray4 = Array.ConvertAll<string, int>(strArray4, s => int.Parse(s));
                order.Items = (List<Item>)new ItemService().GetByItemIdArray(intArray2, intArray3, intArray4);

                order.FinishTime = (DateTime)row["FinishTime"];
                list.Add(order);
            }
            return list;
        }

        public IEnumerable<Order> GetByOrderStatus(OrderStatus orderStatus)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_OrderFlow where [OrderStatus]=@OrderStatus", new SqlParameter("OrderStatus", (int)orderStatus));
            List<Order> list = new List<Order>();
            foreach (DataRow row in dt.Rows)
            {
                Order order = new Order();
                order.OrderId = (int)row["OrderId"];
                order.StartTime = (DateTime)row["StartTime"];
                order.NumberofPeople = (int)row["NumberofPeople"];

                string[] strArray = ((string)row["TableIds"]).Split(new char[] { ',' });
                order.TableIds = Array.ConvertAll<string, int>(strArray, s => int.Parse(s));

                order.OrderStatus = (OrderStatus)row["OrderStatus"];

                string[] strArray2 = ((string)row["ItemIds"]).Split(new char[] { ',' });
                int[] intArray2 = Array.ConvertAll<string, int>(strArray2, s => int.Parse(s));
                string[] strArray3 = ((string)row["ItemStatusAll"]).Split(new char[] { ',' });
                int[] intArray3 = Array.ConvertAll<string, int>(strArray3, s => int.Parse(s));
                string[] strArray4 = ((string)row["ItemAmounts"]).Split(new char[] { ',' });
                int[] intArray4 = Array.ConvertAll<string, int>(strArray4, s => int.Parse(s));
                order.Items = (List<Item>)new ItemService().GetByItemIdArray(intArray2, intArray3, intArray4);

                order.FinishTime = (DateTime)row["FinishTime"];
                list.Add(order);
            }
            return list;
        }

        public Order GetByOrderId(int orderId)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_OrderFlow where [OrderId]=@OrderId", new SqlParameter("OrderId", orderId));
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Order order = new Order();
                order.OrderId = (int)row["OrderId"];
                order.StartTime = (DateTime)row["StartTime"];
                order.NumberofPeople = (int)row["NumberofPeople"];

                string [] strArray =((string)row["TableIds"]).Split(new char[]{ ',' });
                order.TableIds = Array.ConvertAll<string, int>(strArray, s => int.Parse(s));

                order.OrderStatus = (OrderStatus)row["OrderStatus"];

                string[] strArray2 = ((string)row["ItemIds"]).Split(new char[] { ',' });
                int[] intArray2 = Array.ConvertAll<string, int>(strArray2, s => int.Parse(s));
                string[] strArray3 = ((string)row["ItemStatusAll"]).Split(new char[] { ',' });
                int[] intArray3 = Array.ConvertAll<string, int>(strArray3, s => int.Parse(s));
                string[] strArray4 = ((string)row["ItemAmounts"]).Split(new char[] { ',' });
                int[] intArray4 = Array.ConvertAll<string, int>(strArray4, s => int.Parse(s));
                order.Items = (List<Item>)new ItemService().GetByItemIdArray(intArray2, intArray3, intArray4);

                order.FinishTime = (DateTime)row["FinishTime"];
                return order;
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception(string.Format("Error! OrderId {0} is not unique!", orderId));
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_OrderFlow");
        }

        public int GetCountByDate(DateTime date)
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_OrderFlow where [StartTime]=@StartTime", new SqlParameter("StartTime", date));
        }

        public int GetMaxOrderId()
        {
            return (int)SQLHelper.ExecuteScalar("select MAX([OrderId]) from T_OrderFlow");
        }
    }
}
