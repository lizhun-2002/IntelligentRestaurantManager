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
    public partial class StaffEditForm : Form
    {
        //two mode: add or edit
        string mode;
        //construct function for add new staff
        public StaffEditForm()
        {
            InitializeComponent();
            mode = "add";
            this.StartPosition = FormStartPosition.CenterScreen;
            txtName.Focus();
            comboBoxRole.DataSource = System.Enum.GetNames(typeof(StaffRole));
        }
        //construct function for edit staff
        public StaffEditForm(Staff staff)
        {
            if (staff != null)
            {
                InitializeComponent();
                mode = "edit";
                this.StartPosition = FormStartPosition.CenterScreen;
                txtPass.Focus();
                txtName.Text = staff.Name;
                txtName.Enabled = false;//name is primary key, cannot be changed
                txtPass.Text = staff.Password;
                comboBoxRole.DataSource = System.Enum.GetNames(typeof(StaffRole));
                comboBoxRole.SelectedIndex = (int)staff.Role;
            }
        }
        //construct function for edit staff: forbid editing current user's role
        public StaffEditForm(Staff staff, DiningArea diningArea):this(staff)
        {
            if (staff.Name==diningArea.CurrentStaff.Name)
            {
                comboBoxRole.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
            {
                Staff staff = new Staff();
                staff.Name = txtName.Text;
                staff.Password = txtPass.Text;
                staff.Role = (StaffRole)(comboBoxRole.SelectedIndex);
                int flag;
                if (mode == "add")
                {
                    flag = new StaffManager().AddNew(staff);
                }
                else
                {
                    flag = new StaffManager().Update(staff);
                }
                if (flag == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This staff name is exist. Please change.");
                }

            }
            //MessageBox.Show(comboBoxRole.SelectedItem.ToString());
            //MessageBox.Show(comboBoxRole.SelectedIndex.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
