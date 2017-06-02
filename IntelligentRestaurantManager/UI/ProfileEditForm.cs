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
    public partial class ProfileEditForm : Form
    {
        Staff currentStaff;
        public ProfileEditForm()
        {
            InitializeComponent();
        }
        //construct function for edit staff
        public ProfileEditForm(Staff staff)
        {
            currentStaff = staff;
            if (staff != null)
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterScreen;
                txtNewPass.Focus();
                txtName.Text = staff.Name;
                txtName.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                if (txtNewPass.Text == txtNewPassAgain.Text && txtOldPass.Text == currentStaff.Password)
                {
                    currentStaff.Password = txtNewPass.Text;
                    int flag;
                    flag = new StaffManager().Update(currentStaff);
                    if (flag == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    MessageBox.Show(string.Format("Success!"));
                }
                else
                {
                    MessageBox.Show(string.Format("Input error! Please try again."));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
