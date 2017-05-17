using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentRestaurantManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //test db
            IntelligentRestaurantManager.Model.Staff staff = new Model.Staff();
            DAL.StaffService staffService=new DAL.StaffService();
            staff = staffService.GetByName("manager1");
            MessageBox.Show(staff.Password + staff.Role);
            //test int[] to string
            int [] tableIds=new int []{1,2,3,4,5};
            
            MessageBox.Show(string.Join(",", tableIds));
        }
    }
}
