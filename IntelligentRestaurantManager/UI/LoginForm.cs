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
using System.Threading;

namespace IntelligentRestaurantManager.UI
{
    public partial class LoginForm : Form
    {
        //save selected role, which will be checked when login
        StaffRole selectedRole;

        public LoginForm()
        {
            InitializeComponent();
#if DEBUG
            txtPassword.Text = "2";
            txtUsername.Text = "w";
            //txtPassword.Text = "1";
            //txtUsername.Text = "m";
#endif

        }

        public Staff currentStaff = new Staff();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Staff staff = new StaffManager().GetByName(this.txtUsername.Text);
            // varify username and password        
            if (staff != null && staff.Password == this.txtPassword.Text && staff.Role == this.selectedRole)
            {
                this.DialogResult = DialogResult.OK;
                if (staff.Role == StaffRole.Manager)
                {
                    currentStaff = new Manager();
                    currentStaff.Name = staff.Name;
                    currentStaff.Password = staff.Password;
                    currentStaff.Role = staff.Role;
                }
                if (staff.Role == StaffRole.Waiter)
                {
                    currentStaff = new Waiter();
                    currentStaff.Name = staff.Name;
                    currentStaff.Password = staff.Password;
                    currentStaff.Role = staff.Role;
                }
            }
            else
            {
                MessageBox.Show("Input username or password error! Please try again!");
            }
        }

        //button,label透明设置方法:BackColor 属性,Web 选项卡,Transparent;(for button)FlatStyle 设置为 Flat 或 Popup
        private void labelCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(0);
        }

        //draw a green form border
        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkOliveGreen, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void pbManager_Click(object sender, EventArgs e)
        {
            selectedRole = StaffRole.Manager;
            labelLogo.Visible = false;

            pbWaiter.Visible = false;
            pbCook.Visible = false;
            pbCustomer.Visible = false;

            Point currentLocation = ((PictureBox)sender).Location;
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                pbManager.Location = new Point(currentLocation.X + i * (22 - currentLocation.X) / n, currentLocation.Y + i * (82 - currentLocation.Y) / n);
                Refresh();
                Thread.Sleep(5);
            }
            pbManager.Location = new Point(22, 82);
            labelUsername.Visible = true;
            labelPassword.Visible = true;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;
            txtUsername.Focus();
        }

        private void pbWaiter_Click(object sender, EventArgs e)
        {
            selectedRole = StaffRole.Waiter;
            labelLogo.Visible = false;

            pbManager.Visible = false;
            pbCook.Visible = false;
            pbCustomer.Visible = false;

            Point currentLocation = ((PictureBox)sender).Location;
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                pbWaiter.Location = new Point(currentLocation.X + i * (22 - currentLocation.X) / n, currentLocation.Y + i * (82 - currentLocation.Y) / n);
                Refresh();
                Thread.Sleep(5);
            }
            pbWaiter.Location = new Point(22, 82);
            labelUsername.Visible = true;
            labelPassword.Visible = true;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            btnLogin.Visible = true;
            txtUsername.Focus();
        }

        private void pbCook_Click(object sender, EventArgs e)
        {
            currentStaff = new Cook();
            currentStaff.Name = "CookName";
            currentStaff.Password = "CookPassword";
            currentStaff.Role = StaffRole.Cook;

            labelLogo.Visible = false;

            pbManager.Visible = false;
            pbWaiter.Visible = false;
            pbCustomer.Visible = false;

            Point currentLocation = ((PictureBox)sender).Location;
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                pbCook.Location = new Point(currentLocation.X + i * (120 - currentLocation.X) / n, currentLocation.Y + i * (82 - currentLocation.Y) / n);
                Refresh();
                Thread.Sleep(5);
            }
            pbCook.Location = new Point(100, 62);

            this.DialogResult = DialogResult.OK;
        }

        private void pbCustomer_Click(object sender, EventArgs e)
        {
            labelLogo.Visible = false;

            pbManager.Visible = false;
            pbWaiter.Visible = false;
            pbCook.Visible = false;

            Point currentLocation = ((PictureBox)sender).Location;
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                pbCustomer.Location = new Point(currentLocation.X + i * (120 - currentLocation.X) / n, currentLocation.Y + i * (82 - currentLocation.Y) / n);
                Refresh();
                Thread.Sleep(5);
            }
            pbCustomer.Location = new Point(100, 62);

            this.DialogResult = DialogResult.OK;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            labelUsername.Visible = false;
            labelPassword.Visible = false;
            txtUsername.Visible = false;
            txtPassword.Visible = false;
            btnLogin.Visible = false;
        }

    }
}
