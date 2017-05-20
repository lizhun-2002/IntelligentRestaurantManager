using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.DAL;

namespace IntelligentRestaurantManager.BLL
{
    class StaffManager
    {
        private StaffService staffService = new StaffService();

        //check if given name is already used
        public bool CheckExists(string name)
        {
            Staff staff = staffService.GetByName(name);
            if (staff == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int AddNew(Staff staff)
        {
            if (this.CheckExists(staff.Name))
            {
                return 0;
            }
            else
            {
                return staffService.AddNew(staff);
            }

        }

        public int DeleteByRole(StaffRole role)
        {
            return staffService.DeleteByRole(role);
        }

        public int DeleteByName(string name)
        {
            return staffService.DeleteByName(name);
        }

        public int DeleteAll()
        {
            return staffService.DeleteAll();
        }

        public int Update(Staff staff)
        {
            return staffService.Update(staff);
        }

        public IEnumerable<Staff> GetAll()
        {
            return staffService.GetAll();
        }

        public IEnumerable<Staff> GetByRole(StaffRole role)
        {
            return staffService.GetByRole(role);
        }

        public Staff GetByName(string name)
        {
            return staffService.GetByName(name);
        }

        public int GetCount()
        {
            return this.staffService.GetCount();
        }
    }
}
