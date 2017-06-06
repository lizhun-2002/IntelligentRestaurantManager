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
        //WaitlistForm is a part of waiter main form, so...it's here
        WaitlistForm waitlistForm;

        public TabelStatusForm(DiningArea diningArea)
        {
            InitializeComponent();
            this.diningArea = diningArea;
            staffManager = new StaffManager();
            tableManager = new TableManager();
            itemManager = new ItemManager();
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
            //groupbox:order information
            txtOrderId.Enabled = false;
            dgvItemMenu1.DataSource = itemManager.GetAll();
            dgvItemMenu1.ReadOnly = true;
            dgvItemMenu1.Columns["ItemId"].Visible = false;
            dgvItemMenu1.Columns["AverageTimeCost"].Visible = false;
            dgvItemMenu1.Columns["ItemStatus"].Visible = false;
            dgvItemMenu1.Columns["ItemStatus"].Visible = false;
            dgvItemMenu1.Columns["ItemAmount"].Visible = false;
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
            comboBoxTableStatus.DataSource = System.Enum.GetNames(typeof(TableStatus));
            comboBoxTableStatus.SelectedIndex = (int)table.TableStatus;
            comboBoxWaiterName.DataSource = diningArea.Waiters.Select(waiter => waiter.Name).ToList();
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

            }
            else if (table.OrderId < -1)//there is customer, but not order yet
            {
                txtOrderId.Text = "-1";
                txtNoOfPeople.Text = (-table.OrderId).ToString();
                int[] tableIds = diningArea.Tables.Where(t => t.CustomerId > 0 && t.CustomerId == table.CustomerId).Select(t => t.CustomerId).ToArray();
                txtTableIds.Text = string.Join(",", tableIds);
                comboBoxOrderStatus.DataSource = System.Enum.GetNames(typeof(OrderStatus)); ;
                dgvItemMenu1.DataSource = null;
                dgvItemMenu1.DataSource = itemManager.GetAll();
                dgvSelectedItems.DataSource = null;
                dgvSelectedItems.DataSource = itemManager.GetAll();//new List<Item>() { new Item()};
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
                    dgvItemMenu1.DataSource = null;
                    dgvItemMenu1.DataSource = itemManager.GetAll();
                    dgvSelectedItems.DataSource = null;
                    dgvSelectedItems.DataSource = order.Items;
                    //MessageBox.Show("number of items {0}", itemManager.GetAll().ToList().Count.ToString());
                }
            }
            //txtNoOfPeople=
            //comboBoxOrderStatus.SelectedIndex = (int)Order.OrderStatus;

            //comboBoxWaiterId.DataSource = diningArea.Waiters.Select(waiter=>waiter.Name).ToList();
            //comboBoxOrderStatus.DataSource = diningArea.Tables.Select(waiter => waiter.TableStatus).ToList();
            //Todo: waiter name order by workload, i.e. sum of customers 

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

        private void allocateTableWaiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = contextMenuStrip1.Tag as Table;
            MessageBox.Show(string.Format("Table ID is {0}! It's capacity {1}", table.TableId, table.Capacity));

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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileEditForm profileEditForm = new ProfileEditForm(diningArea.CurrentStaff);
            if (profileEditForm.ShowDialog() == DialogResult.OK)
            {
                diningArea.CurrentStaff = staffManager.GetByName(diningArea.CurrentStaff.Name);
                profileEditForm.Dispose();
            }
        }

        //private void btnCreateOrder_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(string.Format("There are {0} customers waiting.", diningArea.Customers.Count));
        //    //(diningArea.CurrentStaff as Waiter).CreateOrder(diningArea.Orders,(Table)labelTabelId.Tag,
        //    MessageBox.Show(diningArea.Tables.Select(t => t.TableStatus).ToString());
        //}

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            Table currentTable = diningArea.Tables.Where(t => t.TableId == int.Parse(txtTableId.Text)).ToList()[0];
            currentTable.TableId = int.Parse(txtTableId.Text);
            currentTable.Capacity = int.Parse(txtCapacity.Text);
            currentTable.TableStatus = (TableStatus)comboBoxTableStatus.SelectedIndex;
            currentTable.WaiterName = comboBoxWaiterName.Text;
            currentTable.CustomerId = int.Parse(txtCustomerId.Text);
            currentTable.OrderId = int.Parse(txtOrderId.Text);
            currentTable.ReservationInfo = txtResInfo.Text;

            (diningArea.CurrentStaff as Waiter).UpdateTable(diningArea.Tables, currentTable);
            MessageBox.Show("OK");
            this.flowLayoutPanel1.Controls.Clear();
            InitTablePosition_Simple();
        }

    }
}
