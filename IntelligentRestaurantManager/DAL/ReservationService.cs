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
    class ReservationService
    {
        public int AddNew(Reservation res)
        {
            return SQLHelper.ExecuteNonQuery("insert into T_ReservationsInfo([ReservationId],[Name],[TableId], [Year], [Month], [Day], [Hour], [Number]) "
                + "values(@ReservationId, @Name, @TableId, @Year, @Month, @Day, @Hour, @Number)",
                new SqlParameter("ReservationId", res.getId()),
                new SqlParameter("Name", res.getName()),
                new SqlParameter("TableId", res.getTableId()),
                new SqlParameter("Year", res.getYear()),
                new SqlParameter("Month", res.getMonth()),
                new SqlParameter("Day", res.getDay()),
                new SqlParameter("Hour", res.getHour()),
                new SqlParameter("Number", res.getNumber())
                );
        }

        public int DeleteByReservationId(int reservationId)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_ReservationsInfo where [ReservationId]=@ReservationId", new SqlParameter("ReservationId", reservationId));
        }

        public int DeleteAll()
        {
            return SQLHelper.ExecuteNonQuery("delete from T_ReservationsInfo");
        }

        public IEnumerable<Reservation> GetAll()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_ReservationsInfo order by [ReservationId]");
            List<Reservation> list = new List<Reservation>();
            foreach (DataRow row in dt.Rows)
            {
                Reservation res = new Reservation();
                res.id = (int)row["ReservationId"];
                res.name = (string)row["Name"];
                res.year = (int)row["Year"];
                res.month = (int)row["Month"];
                res.day = (int)row["Day"];
                res.hour = (int)row["Hour"];
                res.tableId = (int)row["TableId"];
                res.number = (int)row["Number"];
                list.Add(res);
            }
            return list;
        }

        public int GetCount()
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_ReservationsInfo");
        }
    }
}
