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
        DiningArea diningArea;
        private StaffManager staffManager;
        private TableManager tableManager;
        private ItemManager itemManager;
        private OrderManager orderManager;

        public AdminForm(DiningArea diningArea)
        {
            InitializeComponent();
            this.diningArea = diningArea;
            this.StartPosition = FormStartPosition.CenterScreen;
            staffManager = new StaffManager();
            tableManager = new TableManager();
            itemManager = new ItemManager();
            orderManager = new OrderManager();
            this.Text = this.Text + string.Format("  ({0}: {1})", diningArea.CurrentStaff.Role, diningArea.CurrentStaff.Name);
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
            dgvItem.Columns["ItemStatus"].Visible = false;
            dgvItem.Columns["ItemAmount"].Visible = false;
            monthCalendar1.Visible = false;
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatistics.ReadOnly = true;
            dgvStatistics.AllowUserToAddRows = false;
       }

        #region Staff tab
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            StaffEditForm staffEditForm = new StaffEditForm();
            if (staffEditForm.ShowDialog() == DialogResult.OK)
            {
                dgvStaff.DataSource = staffManager.GetAll();
                staffEditForm.Dispose();
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
                StaffEditForm staffEditForm = new StaffEditForm(staff, diningArea);
                if (staffEditForm.ShowDialog() == DialogResult.OK)
                {
                    dgvStaff.DataSource = staffManager.GetAll();
                    staffEditForm.Dispose();
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
                tableEditForm.Dispose();
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
                    tableEditForm.Dispose();
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
                itemEditForm.Dispose();
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
                    itemEditForm.Dispose();
                }
            }
        }
        #endregion

        #region Item statistics
        private class OrderStatistics
        {
            public int OrderId{get; set;}
            public int NumberOfPeople { get; set; }
            public decimal TotalAmount { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime FinishTime { get; set; }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime date;
            try
            {
                date = DateTime.Parse(txtDate.Text);
            }
            catch (Exception)
            {
                return;
            }
            List<Order> orders = (List<Order>)orderManager.GetByOrderDate(date);
            List<OrderStatistics> orderStatistics = new List<OrderStatistics>();
            foreach (Order order in orders)
            {
                OrderStatistics oS = new OrderStatistics();
                oS.OrderId = order.OrderId;
                oS.NumberOfPeople = order.NumberofPeople;
                oS.TotalAmount = order.Items.Select(it => it.Price * it.ItemAmount).Sum();
                oS.StartTime = order.StartTime;
                oS.FinishTime = order.FinishTime;
                orderStatistics.Add(oS);
            }
            dgvStatistics.DataSource = new BindingList<OrderStatistics>(orderStatistics);
            txtTurnover.Text = orderStatistics.Select(os => os.TotalAmount).Sum().ToString();
            txtCustomerVolume.Text = orderStatistics.Select(os => os.NumberOfPeople).Sum().ToString();
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
            txtDate.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
        }

        #endregion


    }
}
