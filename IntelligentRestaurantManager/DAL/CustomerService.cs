using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;

namespace IntelligentRestaurantManager.DAL
{
    class CustomerService
    {
        public int AddNew(Customer customer)
        {
            return SQLHelper.ExecuteNonQuery("insert into T_CustomerInfo([WaitingNumber],[NumberofPeople],[ArriveTime],[RecommendedTableId],[EstimatedWaitingTime]) values(@WaitingNumber,@NumberofPeople,@ArriveTime,@RecommendedTableId,@EstimatedWaitingTime)",
                new SqlParameter("WaitingNumber", customer.WaitingNumber),
                new SqlParameter("NumberofPeople", customer.NumberofPeople),
                new SqlParameter("ArriveTime", customer.ArriveTime),
                new SqlParameter("RecommendedTableId", customer.RecommendedTableId),
                new SqlParameter("EstimatedWaitingTime", customer.EstimatedWaitingTime)
                );
        }

        public int DeleteByWaitingNumber(int waitingNumber)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_CustomerInfo where [WaitingNumber]=@WaitingNumber", new SqlParameter("WaitingNumber", waitingNumber));
        }
        
        //public int DeleteByName(string name)
        //{
        //    return SQLHelper.ExecuteNonQuery("delete from T_CustomerInfo where [Name]=@Name", new SqlParameter("Name", name));
        //}
        
        public int DeleteAll()
        {
            return SQLHelper.ExecuteNonQuery("delete from T_CustomerInfo");
        }

        public int Update(Customer customer)
        {
            return SQLHelper.ExecuteNonQuery("update T_CustomerInfo set [NumberofPeople]=@NumberofPeople,[ArriveTime]=@ArriveTime,[RecommendedTableId]=@RecommendedTableId,[EstimatedWaitingTime]=@EstimatedWaitingTime where [WaitingNumber]=@WaitingNumber",
                new SqlParameter("WaitingNumber", customer.WaitingNumber),
                new SqlParameter("NumberofPeople", customer.NumberofPeople),
                new SqlParameter("ArriveTime", customer.ArriveTime),
                new SqlParameter("RecommendedTableId", customer.RecommendedTableId),
                new SqlParameter("EstimatedWaitingTime", customer.EstimatedWaitingTime)
                );
        }

        public IEnumerable<Customer> GetAll()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_CustomerInfo order by [CustomerId]");
            List<Customer> list = new List<Customer>();
            foreach (DataRow row in dt.Rows)
            {
                Customer customer = new Customer();
                customer.WaitingNumber = (int)row["WaitingNumber"];
                customer.NumberofPeople = (int)row["NumberofPeople"];
                customer.ArriveTime = (DateTime)row["ArriveTime"];
                customer.RecommendedTableId = (int)row["RecommendedTableId"];
                customer.EstimatedWaitingTime = (int)row["EstimatedWaitingTime"];
                list.Add(customer);
            }
            return list;
        }

        public IEnumerable<Customer> GetByNumberofPeople(int numberofPeople)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_CustomerInfo where [NumberofPeople]=@NumberofPeople", new SqlParameter("NumberofPeople", numberofPeople));
            List<Customer> list = new List<Customer>();
            foreach (DataRow row in dt.Rows)
            {
                Customer customer = new Customer();
                customer.WaitingNumber = (int)row["WaitingNumber"];
                customer.NumberofPeople = (int)row["NumberofPeople"];
                customer.ArriveTime = (DateTime)row["ArriveTime"];
                customer.RecommendedTableId = (int)row["RecommendedTableId"];
                customer.EstimatedWaitingTime = (int)row["EstimatedWaitingTime"];
                list.Add(customer);
            }
            return list;
        }

        public Customer GetByWaitingNumber(int waitingNumber)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_CustomerInfo where [WaitingNumber]=@WaitingNumber", new SqlParameter("WaitingNumber", waitingNumber));
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Customer customer = new Customer();
                customer.WaitingNumber = (int)row["WaitingNumber"];
                customer.NumberofPeople = (int)row["NumberofPeople"];
                customer.ArriveTime = (DateTime)row["ArriveTime"];
                customer.RecommendedTableId = (int)row["RecommendedTableId"];
                customer.EstimatedWaitingTime = (int)row["EstimatedWaitingTime"];
                return customer;
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception(string.Format("Error! WaitingNumber {0} is not unique!", waitingNumber));
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_CustomerInfo");
        }
    }
}
