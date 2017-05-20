using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentRestaurantManager.Model
{
    enum StaffRole
    {
        Staff, Manager, Waiter, Cook
    }

    class Staff
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private StaffRole role;

        public StaffRole Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}
