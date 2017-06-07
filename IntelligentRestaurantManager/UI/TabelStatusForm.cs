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
    //TabelStatusForm is main form for waiter
    public partial class TabelStatusForm : Form
    {
        DiningArea diningArea;
        private StaffManager staffManager;
        private TableManager tableManager;
        private ItemManager itemManager;
        private OrderManager orderManager;
        //WaitlistForm is a part of waiter main form, so...it's here
        WaitlistForm waitlistForm;

        public TabelStatusForm(DiningArea diningArea)
        {
            InitializeComponent();
            this.diningArea = diningArea;
            staffManager = new StaffManager();
            tableManager = new TableManager();
            itemManager = new ItemManager();
            orderManager = new OrderManager();

            diningArea.AWaitingTimePredictor.PredictWaitingTimeReg(diningArea.Tables, diningArea.Customers, diningArea.Orders, (List<Order>)orderManager.GetByOrderStatus(OrderStatus.Finish), (List<Item>)itemManager.GetAll());

            this.Text = this.Text + string.Format("  ({0}: {1})", diningArea.CurrentStaff.Role, diningArea.CurrentStaff.Name);
            InitTablePosition_Simple();

            waitlistForm = new WaitlistForm(diningArea);
            waitlistForm.OnAllocate += waitlistForm_OnAllocate;
            //set TabelStatusForm location
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Width + waitlistForm.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Height) / 2;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = (Point)new Size(x, y);
            //set waitlistForm location
            waitlistForm.ShowInTaskbar = false;
            waitlistForm.StartPosition = FormStartPosition.Manual;
            waitlistForm.Location = new Point(this.Location.X - waitlistForm.Width, this.Location.Y);
            waitlistForm.Height = this.Height;
            waitlistForm.Show();

            //groupbox:table information
            txtTableId.Enabled = false;
            txtCapacity.Enabled = false;
            comboBoxTableStatus.DataSource = System.Enum.GetNames(typeof(TableStatus));
            comboBoxWaiterName.DataSource = diningArea.Waiters.Select(waiter => waiter.Name).ToList();
            //groupbox:order information
            txtOrderId.Enabled = false;

            dgvItemMenu1.DataSource = itemManager.GetAll();
            dgvItemMenu1.ReadOnly = true;
            dgvItemMenu1.RowHeadersVisible = false;
            dgvItemMenu1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemMenu1.Columns["AverageTimeCost"].Visible = false;
            dgvItemMenu1.Columns["ItemStatus"].Visible = false;
            dgvItemMenu1.Columns["ItemAmount"].Visible = false;
            dgvItemMenu1.Columns["Description"].Visible = false;

            dgvSelectedItems.DataSource = new List<Item>();
            //dgvSelectedItems.ReadOnly = true;
            dgvSelectedItems.RowHeadersVisible = false;
            dgvSelectedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelectedItems.Columns["AverageTimeCost"].Visible = false;
            dgvSelectedItems.Columns["ItemStatus"].Visible = false;
            dgvSelectedItems.Columns["Description"].Visible = false;
            dgvSelectedItems.Columns["ItemId"].ReadOnly = true;
            dgvSelectedItems.Columns["Name"].ReadOnly = true;
            dgvSelectedItems.Columns["Price"].ReadOnly = true;
            dgvSelectedItems.AllowUserToAddRows = false;
        }

        void waitlistForm_OnAllocate(object sender, WaitlistForm.AllocateEventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            InitTablePosition_Simple();
            //flowLayoutPanel1.Refresh();
            //diningArea.Tables = (List<Table>)tableManager.GetAll();
        }

        private void TabelStatusForm_Load(object sender, EventArgs e)
        {
        }

        //Simplely initialize tables position order by table ID.
        private void InitTablePosition_Simple()
        {
            for (int i = 1; i <= diningArea.Tables.Count; i++)
            {
                Button btn = new Button();
                btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                btn.Width = 80;
                btn.Height = 80;
                btn.Text = i.ToString("000") + "_" + diningArea.Tables[i - 1].Capacity.ToString();
                if (diningArea.Tables[i - 1].CountDown > System.Data.SqlTypes.SqlDateTime.MinValue.Value && diningArea.Tables[i - 1].CountDown < System.Data.SqlTypes.SqlDateTime.MaxValue.Value)
                {
                    TimeSpan ts = diningArea.Tables[i - 1].CountDown - DateTime.Now;
                    if (diningArea.Tables[i - 1].CountDown < DateTime.Now)
                    {
                        btn.Text = btn.Text + "\n\n" + ("00:00:00");
                    }
                    else
                    {
                        btn.Text = btn.Text + "\n\n" + ts.ToString(@"hh\:mm\:ss");
                    }
                }
                btn.BackColor = SetTableBackColor(diningArea.Tables[i - 1].TableStatus);
                btn.ForeColor = Color.Black;
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.Tag = diningArea.Tables[i - 1];
                //btn.ContextMenuStrip = contextMenuStrip1;
                btn.MouseDown += btn_MouseDown;
                btn.Click += btn_Click;
                btn.MouseEnter += btn_MouseEnter;

                this.flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void btn_MouseEnter(object sender, EventArgs e)
        {
            Table table = (Table)(sender as Button).Tag;
            string text = string.Format("Table ID: {0}\nCapacity: {1}\nTable Status: {2}\nCustomer ID: {3}\nOrder ID: {4}\nWaiter Name: {5}\nReservation Information: {6}",
                table.TableId, table.Capacity, table.TableStatus, table.CustomerId, table.OrderId, table.WaiterName, table.ReservationInfo);
            toolTip1.SetToolTip((sender as Button), text);
            //toolTip1.Show(text, (sender as Button));
        }

        void btn_Click(object sender, EventArgs e)
        {
            //clear
            //comboBoxWaiterName.SelectedItem = null;

            //assign table value
            Table table = (Table)(sender as Button).Tag;
            txtTableId.Text = table.TableId.ToString();
            txtCapacity.Text = table.Capacity.ToString();
            comboBoxTableStatus.SelectedIndex = (int)table.TableStatus;
            comboBoxWaiterName.SelectedIndex = diningArea.Waiters.Select(waiter => waiter.Name).ToList().IndexOf(table.WaiterName);
            txtCustomerId.Text = table.CustomerId.ToString();
            txtResInfo.Text = table.ReservationInfo;

            //assign order value
            if (table.OrderId == -1)//there is no order and customer 
            {
                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = "";
                txtTableIds.Text = "";
                comboBoxOrderStatus.DataSource = null;
                dgvSelectedItems.DataSource = new BindingList<Item>();
            }
            else if (table.OrderId < -1)//there is customer, but not order yet
            {
                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = (-table.OrderId).ToString();
                int[] tableIds = diningArea.Tables.Where(t => t.CustomerId > 0 && t.CustomerId == table.CustomerId).Select(t => t.TableId).ToArray();
                txtTableIds.Text = string.Join(",", tableIds);
                comboBoxOrderStatus.DataSource = System.Enum.GetNames(typeof(OrderStatus)); ;
                dgvItemMenu1.DataSource = new List<Item>();
                dgvItemMenu1.DataSource = itemManager.GetAll();
                dgvSelectedItems.DataSource = new BindingList<Item>();
            }
            else//there is order already
            {
                txtOrderId.Text = table.OrderId.ToString();
                List<Order> temp = diningArea.Orders.Where(o => o.OrderId > 0 && o.OrderId == table.OrderId).ToList();
                if (temp.Count > 0)
                {
                    Order order = temp[0];
                    txtNoOfPeople.Text = order.NumberofPeople.ToString();
                    txtTableIds.Text = string.Join(",", order.TableIds);
                    comboBoxOrderStatus.DataSource = System.Enum.GetNames(typeof(OrderStatus));
                    comboBoxOrderStatus.SelectedIndex = (int)order.OrderStatus;
                    dgvItemMenu1.DataSource = new List<Item>();
                    dgvItemMenu1.DataSource = itemManager.GetAll();
                    dgvSelectedItems.DataSource = new BindingList<Item>();
                    dgvSelectedItems.DataSource = new BindingList<Item>(order.Items);
                    //MessageBox.Show("number of items {0}", itemManager.GetAll().ToList().Count.ToString());
                }
            }
        }

        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                contextMenuStrip1.Tag = (sender as Button).Tag;
            }
        }

        private Color SetTableBackColor(TableStatus tableStatus)
        {
            Color result = Color.PowderBlue;
            switch (tableStatus)
            {
                case TableStatus.Active:
                    result = Color.SpringGreen;
                    break;
                case TableStatus.Ordering:
                    result = Color.LightSalmon;
                    break;
                case TableStatus.Reserved:
                    result = Color.Violet;
                    break;
                case TableStatus.Breakdown:
                    result = Color.White;
                    break;
                case TableStatus.Cleaning:
                    result = Color.LightBlue;
                    break;
            }
            return result;
        }

        private void waitingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (waitlistForm == null || waitlistForm.IsDisposed)
            {
                waitlistForm = new WaitlistForm(diningArea);
                waitlistForm.ShowInTaskbar = false;
                waitlistForm.StartPosition = FormStartPosition.Manual;
                waitlistForm.Location = new Point(this.Location.X - waitlistForm.Size.Width, this.Location.Y);
                waitlistForm.Height = this.Height;
                waitlistForm.Show();
            }
            else
            {
                waitlistForm.WindowState = FormWindowState.Normal;
                waitlistForm.Activate();
                waitlistForm.Show();
            }
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm();
            reservationsForm.StartPosition = FormStartPosition.CenterScreen;
            if (reservationsForm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileEditForm profileEditForm = new ProfileEditForm(diningArea.CurrentStaff);
            if (profileEditForm.ShowDialog() == DialogResult.OK)
            {
                diningArea.CurrentStaff = staffManager.GetByName(diningArea.CurrentStaff.Name);
                profileEditForm.Dispose();
            }
        }

        private void closeDiningAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close dining area?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                diningArea.CloseDiningArea();
                waitlistForm.WaitingList.Items.Clear();
            }
            this.flowLayoutPanel1.Controls.Clear();
            InitTablePosition_Simple();
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            if (txtTableId.Text == "" || txtCustomerId.Text == "" || comboBoxWaiterName.Text == "")
            {
                MessageBox.Show("Please select a table and input all the information.");
            }
            else if (MessageBox.Show("Are you sure to save table information?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Table currentTable = diningArea.Tables.Where(t => t.TableId == int.Parse(txtTableId.Text)).ToList()[0];
                currentTable.TableId = int.Parse(txtTableId.Text);
                currentTable.Capacity = int.Parse(txtCapacity.Text);
                currentTable.TableStatus = (TableStatus)comboBoxTableStatus.SelectedIndex;
                currentTable.WaiterName = comboBoxWaiterName.Text;
                currentTable.CustomerId = int.Parse(txtCustomerId.Text);
                currentTable.OrderId = int.Parse(txtOrderId.Text);
                currentTable.ReservationInfo = txtResInfo.Text;

                int flag = (diningArea.CurrentStaff as Waiter).UpdateTable(diningArea.Tables, currentTable);
                if (flag == 1) MessageBox.Show("Success!");
                if (flag == 0) MessageBox.Show("Failed!");

                //MessageBox.Show("OK");
                this.flowLayoutPanel1.Controls.Clear();
                InitTablePosition_Simple();
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            List<Item> selectedItems = new List<Item>(dgvSelectedItems.DataSource as BindingList<Item>);
            if (txtTableId.Text == "" || txtNoOfPeople.Text == "" || txtTableIds.Text == "")
            {
                MessageBox.Show("Please select a table and input all the information.");
            }
            else if (selectedItems == null || selectedItems.Count == 0)
            {
                MessageBox.Show("Order should contain at least one item.");
            }
            else
            {
                Waiter waiter = diningArea.CurrentStaff as Waiter;
                if (int.Parse(txtOrderId.Text) == -1)
                {
                    if (MessageBox.Show("Are you sure to create new order?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int flag;
                        flag = waiter.CreateOrder(diningArea.Orders, int.Parse(txtCustomerId.Text), selectedItems, int.Parse(txtNoOfPeople.Text), diningArea.Tables);
                        //if (flag == 1) MessageBox.Show("Success!");
                        if (flag == 0) MessageBox.Show("Failed!");
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure to save order?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int flag;
                        flag = waiter.UpdateOrder(diningArea.Orders, int.Parse(txtOrderId.Text), int.Parse(txtCustomerId.Text), selectedItems, int.Parse(txtNoOfPeople.Text), (OrderStatus)comboBoxOrderStatus.SelectedIndex);
                        //if (flag == 1) MessageBox.Show("Success!");
                        if (flag == 0) MessageBox.Show("Failed!");
                    }
                }
            }
        }

        private void dgvItemMenu1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvSelectedItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSelectedItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingList<Item> selectedItems = dgvSelectedItems.DataSource as BindingList<Item>;
            if (selectedItems == null) selectedItems = new BindingList<Item>();
            if (e.RowIndex > -1)
            {
                selectedItems.Remove(selectedItems[e.RowIndex]);
                dgvSelectedItems.DataSource = new BindingList<Item>(selectedItems);
            }

        }

        private void dgvItemMenu1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Item> menuItems = dgvItemMenu1.DataSource as List<Item>;
            BindingList<Item> selectedItems = dgvSelectedItems.DataSource as BindingList<Item>;
            if (selectedItems == null) selectedItems = new BindingList<Item>();
            if (e.RowIndex > -1 && !selectedItems.Select(t => t.ItemId).ToList().Contains(menuItems[e.RowIndex].ItemId))
            {
                selectedItems.Add(menuItems[e.RowIndex]);
                dgvSelectedItems.DataSource = new BindingList<Item>(selectedItems);
            }

        }


        #region RightClickTableMenu actions

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = contextMenuStrip1.Tag as Table;
            Waiter waiter = diningArea.CurrentStaff as Waiter;
            Order order = new OrderManager().GetByOrderId(table.OrderId);
            if (order != null && order.OrderStatus == OrderStatus.Start)
            {
                MessageBox.Show("Please finish or cancel order first!");
                return;
            }
            bool flag = waiter.SetTableStatus(table, TableStatus.Active);
            if (flag == true)
            {
                //clear data
                table.CountDown = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
                table.ReservationInfo = "";
                table.CustomerId = -1;
                table.WaiterName = "";
                table.OrderId = -1;
                new TableManager().Update(table);

                //clean UI
                comboBoxTableStatus.SelectedIndex = (int)table.TableStatus;
                comboBoxWaiterName.Text = table.WaiterName;
                txtCustomerId.Text = table.CustomerId.ToString();
                txtResInfo.Text = table.ReservationInfo;

                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = "";
                txtTableIds.Text = "";
                comboBoxOrderStatus.DataSource = null;
                dgvSelectedItems.DataSource = new BindingList<Item>();

                this.flowLayoutPanel1.Controls.Clear();
                InitTablePosition_Simple();
            }
            else MessageBox.Show("Failed!");
        }

        private void cleaningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = contextMenuStrip1.Tag as Table;
            Waiter waiter = diningArea.CurrentStaff as Waiter;
            Order order = new OrderManager().GetByOrderId(table.OrderId);
            if (order != null && order.OrderStatus == OrderStatus.Start)
            {
                MessageBox.Show("Please finish or cancel order first!");
                return;
            }
            bool flag = waiter.SetTableStatus(table, TableStatus.Cleaning);
            if (flag == true)
            {
                //clear data
                table.CountDown = DateTime.Now.AddMinutes(5);
                table.ReservationInfo = "";
                table.CustomerId = -1;
                table.WaiterName = "";
                table.OrderId = -1;
                new TableManager().Update(table);

                //clean UI
                comboBoxTableStatus.SelectedIndex = (int)table.TableStatus;
                comboBoxWaiterName.Text = table.WaiterName;
                txtCustomerId.Text = table.CustomerId.ToString();
                txtResInfo.Text = table.ReservationInfo;

                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = "";
                txtTableIds.Text = "";
                comboBoxOrderStatus.DataSource = null;
                dgvSelectedItems.DataSource = new BindingList<Item>();

                this.flowLayoutPanel1.Controls.Clear();
                InitTablePosition_Simple();
            }
            else MessageBox.Show("Failed!");
        }

        private void reservedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = contextMenuStrip1.Tag as Table;
            Waiter waiter = diningArea.CurrentStaff as Waiter;
            Order order = new OrderManager().GetByOrderId(table.OrderId);
            if (order != null && order.OrderStatus == OrderStatus.Start)
            {
                MessageBox.Show("Please finish or cancel order first!");
                return;
            }
            bool flag = waiter.SetTableStatus(table, TableStatus.Reserved);
            if (flag == true)
            {
                //clear data
                //table.CountDown = DateTime.Now.AddMinutes(5);
                table.ReservationInfo = "";
                table.CustomerId = -1;
                table.WaiterName = "";
                table.OrderId = -1;
                new TableManager().Update(table);

                //clean UI
                comboBoxTableStatus.SelectedIndex = (int)table.TableStatus;
                comboBoxWaiterName.Text = table.WaiterName;
                txtCustomerId.Text = table.CustomerId.ToString();
                txtResInfo.Text = table.ReservationInfo;

                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = "";
                txtTableIds.Text = "";
                comboBoxOrderStatus.DataSource = null;
                dgvSelectedItems.DataSource = new BindingList<Item>();

                this.flowLayoutPanel1.Controls.Clear();
                InitTablePosition_Simple();
            }
            else MessageBox.Show("Failed!");
        }

        private void breakdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = contextMenuStrip1.Tag as Table;
            Waiter waiter = diningArea.CurrentStaff as Waiter;
            Order order = new OrderManager().GetByOrderId(table.OrderId);
            if (order != null && order.OrderStatus == OrderStatus.Start)
            {
                MessageBox.Show("Please finish or cancel order first!");
                return;
            }
            bool flag = waiter.SetTableStatus(table, TableStatus.Breakdown);
            if (flag == true)
            {
                //clear data
                table.CountDown = System.Data.SqlTypes.SqlDateTime.MaxValue.Value;
                table.ReservationInfo = "";
                table.CustomerId = -1;
                table.WaiterName = "";
                table.OrderId = -1;
                new TableManager().Update(table);

                //clean UI
                comboBoxTableStatus.SelectedIndex = (int)table.TableStatus;
                comboBoxWaiterName.Text = table.WaiterName;
                txtCustomerId.Text = table.CustomerId.ToString();
                txtResInfo.Text = table.ReservationInfo;

                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = "";
                txtTableIds.Text = "";
                comboBoxOrderStatus.DataSource = null;
                dgvSelectedItems.DataSource = new BindingList<Item>();

                this.flowLayoutPanel1.Controls.Clear();
                InitTablePosition_Simple();
            }
            else MessageBox.Show("Failed!");
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            diningArea.AWaitingTimePredictor.PredictWaitingTimeReg(diningArea.Tables, diningArea.Customers, diningArea.Orders, (List<Order>)orderManager.GetByOrderStatus(OrderStatus.Finish), (List<Item>)itemManager.GetAll());
            this.flowLayoutPanel1.Controls.Clear();
            InitTablePosition_Simple();
        }


    }
}
