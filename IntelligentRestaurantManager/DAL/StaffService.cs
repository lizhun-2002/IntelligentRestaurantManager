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
    class StaffService
    {
        public int AddNew(Staff staff)
        {
            return SQLHelper.ExecuteNonQuery("insert into T_StaffInfo([Name],[Password],[Role]) values(@Name,@Password,@Role)",
                new SqlParameter("Name", staff.Name),
                new SqlParameter("Password", staff.Password),
                new SqlParameter("Role", staff.Role)
                );
        }

        public int DeleteByRole(StaffRole role)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_StaffInfo where [Role]=@Role", new SqlParameter("Role", role));
        }

        public int DeleteByName(string name)
        {
            return SQLHelper.ExecuteNonQuery("delete from T_StaffInfo where [Name]=@Name", new SqlParameter("Name", name));
        }

        public int DeleteAll()
        {
            return SQLHelper.ExecuteNonQuery("delete from T_StaffInfo");
        }

        public int Update(Staff staff)
        {
            return SQLHelper.ExecuteNonQuery("update T_StaffInfo set [Password]=@Password,[Role]=@Role where [Name]=@Name",
                new SqlParameter("Name", staff.Name),
                new SqlParameter("Password", staff.Password),
                new SqlParameter("Role", staff.Role)
                );
        }

        public IEnumerable<Staff> GetAll()
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_StaffInfo order by [Name]");
            List<Staff> list = new List<Staff>();
            foreach (DataRow row in dt.Rows)
            {
                Staff staff = new Staff();
                staff.Name = (string)row["Name"];
                staff.Password = (string)row["Password"];
                staff.Role = (StaffRole)row["Role"];
                list.Add(staff);
            }
            return list;
        }

        public IEnumerable<Staff> GetByRole(StaffRole role)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_StaffInfo where [Role]=@Role", new SqlParameter("Role", role));
            List<Staff> list = new List<Staff>();
            foreach (DataRow row in dt.Rows)
            {
                Staff staff = new Staff();
                staff.Name = (string)row["Name"];
                staff.Password = (string)row["Password"];
                staff.Role = (StaffRole)row["Role"];
                list.Add(staff);
            }
            return list;
        }

        public Staff GetByName(string name)
        {
            DataTable dt = new DataTable();
            dt = SQLHelper.ExecuteDataTable("select * from T_StaffInfo where [Name]=@Name", new SqlParameter("Name", name));
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Staff staff = new Staff();
                staff.Name = (string)row["Name"];
                staff.Password = (string)row["Password"];
                staff.Role = (StaffRole)row["Role"];
                return staff;
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception(string.Format("Error! Name {0} is not unique!", name));
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            return (int)SQLHelper.ExecuteScalar("select COUNT(*) from T_StaffInfo");
        }
    }
}
