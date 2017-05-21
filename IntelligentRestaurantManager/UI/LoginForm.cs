using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntelligentRestaurantManager.BLL;
using IntelligentRestaurantManager.Model;

namespace IntelligentRestaurantManager.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Staff currentStaff = new Staff();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Staff staff = new StaffManager().GetByName(this.txtUsername.Text);
            // varify username and password        
            if (staff != null && staff.Password == this.txtPassword.Text)
            {
                this.DialogResult = DialogResult.OK;
                currentStaff = staff;
            }
            else
            {
                MessageBox.Show("Input username or password error! Please try again!");
            }
        }
    }
}
