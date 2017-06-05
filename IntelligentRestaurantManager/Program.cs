using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.BLL;
using IntelligentRestaurantManager.UI;

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

            Staff currentStaff = new Staff();
            LoginForm loginForm = new LoginForm();

            // TEST PURPOSE CODE BELOW
            //Application.Run(new OrderListForm());
            // TEST PURPOSE CODE ABOVE

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                currentStaff = loginForm.currentStaff;
                DiningArea diningArea = new DiningArea(currentStaff);
                loginForm.Dispose();
                if (currentStaff.Role == StaffRole.Manager)
                {
                    //MessageBox.Show(string.Format("Welcome {0}! Your role is {1}", currentStaff.Name, currentStaff.Role));
                    //main form for Manager
                    Application.Run(new AdminForm(diningArea));
                }
                else if (currentStaff.Role == StaffRole.Waiter)
                {
                    //main form for waiter
                    Application.Run(new TabelStatusForm(diningArea));
                }
                else if (currentStaff.Role == StaffRole.Cook)
                {
                    MessageBox.Show(string.Format("Welcome {0}! Your role is {1}", currentStaff.Name, currentStaff.Role));
                    Application.Run(new OrderListForm());
                }
                else
                {
                    Application.Run(new WaitinglistScreenForm());
                    //MessageBox.Show(string.Format("Welcome {0}! Your role is {1}. And you will see customer UI.", currentStaff.Name, currentStaff.Role));
                }
            }
            

            ////test db
            //IntelligentRestaurantManager.Model.Staff staff = new Model.Staff();
            //DAL.StaffService staffService = new DAL.StaffService();
            //staff = staffService.GetByName("manager1");
            //MessageBox.Show(staff.Password + staff.Role);
            ////test int[] to string
            //int[] tableIds = new int[] { 1, 2, 3, 4, 5 };

            //MessageBox.Show(string.Join(",", tableIds));
        }
    }
}
