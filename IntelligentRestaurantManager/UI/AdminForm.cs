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
    public partial class AdminForm : Form
    {
        private StaffManager staffManager;
        private TableManager tableManager;
        private ItemManager itemManager;

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            staffManager = new StaffManager();
            tableManager = new TableManager();
            itemManager = new ItemManager();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvStaff.DataSource = staffManager.GetAll();
            dgvStaff.ReadOnly = true;
            dgvTable.DataSource = tableManager.GetAll();
            dgvTable.ReadOnly = true;
            dgvTable.Columns["CountDown"].Visible = false;
            dgvTable.Columns["TableStatus"].Visible = false;
            dgvTable.Columns["ReservationInfo"].Visible = false;
            dgvTable.Columns["CustomerId"].Visible = false;
            dgvTable.Columns["WaiterName"].Visible = false;
            dgvTable.Columns["OrderId"].Visible = false;
            dgvItem.DataSource = itemManager.GetAll();
            dgvItem.ReadOnly = true;
        }

        #region Staff tab
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            StaffEditForm staffEditForm = new StaffEditForm();
            if (staffEditForm.ShowDialog() == DialogResult.OK)
            {
                dgvStaff.DataSource = staffManager.GetAll();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string name = dgvStaff.CurrentRow.Cells["name"].Value.ToString();
            //update data base
            if (MessageBox.Show("Are you sure to delete?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int flag = staffManager.DeleteByName(name);
                //if update success
                if (flag == 1)
                {
                    dgvStaff.DataSource = staffManager.GetAll();
                }
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            string name = dgvStaff.CurrentRow.Cells["name"].Value.ToString();
            Staff staff = staffManager.GetByName(name);
            //if update success
            if (staff != null)
            {
                StaffEditForm staffEditForm = new StaffEditForm(staff);
                if (staffEditForm.ShowDialog() == DialogResult.OK)
                {
                    dgvStaff.DataSource = staffManager.GetAll();
                }
            }
        }
        #endregion

        #region Table tab
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            TableEditForm tableEditForm = new TableEditForm();
            if (tableEditForm.ShowDialog() == DialogResult.OK)
            {
                dgvTable.DataSource = tableManager.GetAll();
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTable.CurrentRow.Cells["TableId"].Value;
            //update data base
            if (MessageBox.Show("Are you sure to delete?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int flag = tableManager.DeleteByTableId(id);
                //if update success
                if (flag == 1)
                {
                    dgvTable.DataSource = tableManager.GetAll();
                }
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTable.CurrentRow.Cells["TableId"].Value;
            Table table = tableManager.GetByTableId(id);
            //if update success
            if (table != null)
            {
                TableEditForm tableEditForm = new TableEditForm(table);
                if (tableEditForm.ShowDialog() == DialogResult.OK)
                {
                    dgvTable.DataSource = tableManager.GetAll();
                }
            }
        }
        #endregion

        #region Item tab
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemEditForm itemEditForm = new ItemEditForm();
            if (itemEditForm.ShowDialog() == DialogResult.OK)
            {
                dgvItem.DataSource = itemManager.GetAll();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItem.CurrentRow.Cells["ItemId"].Value;
            //update data base
            if (MessageBox.Show("Are you sure to delete?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int flag = itemManager.DeleteByItemId(id);
                //if update success
                if (flag == 1)
                {
                    dgvItem.DataSource = itemManager.GetAll();
                }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItem.CurrentRow.Cells["ItemId"].Value;
            Item item = itemManager.GetByItemId(id);
            //if update success
            if (item != null)
            {
                ItemEditForm itemEditForm = new ItemEditForm(item);
                if (itemEditForm.ShowDialog() == DialogResult.OK)
                {
                    dgvItem.DataSource = itemManager.GetAll();
                }
            }
        }
        #endregion
    }
}
