using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntelligentRestaurantManager.Model;
using IntelligentRestaurantManager.BLL;

//using System.Diagnostics;

namespace IntelligentRestaurantManager.UI
{
    public partial class WaitlistForm : Form
    {
        DiningArea diningArea;
        int maxWaitID;
        private CustomerManager customerManager;
        private TableManager tableManager;

        public ListBox WaitingList
        {
            get { return lbList; }
            set { lbList = value; }
        }

        public WaitlistForm(DiningArea diningArea)
        {
            InitializeComponent();
            this.diningArea = diningArea;
            maxWaitID = 1;
            customerManager = new CustomerManager();
            tableManager = new TableManager();
            foreach (Customer customer in diningArea.Customers)
            {
                lbList.Items.Add("Number " + customer.WaitingNumber.ToString("000") + ":  " + customer.NumberofPeople.ToString("00") + " Customer");
                if (customer.WaitingNumber > maxWaitID)
                {
                    maxWaitID = customer.WaitingNumber;
                }
            }
            nudNumber.Value = 2;
            txtCustomerId.Enabled = false;
            txtCustomerId.BackColor = Color.White;
            txtNoOfPeople.Enabled = false;
            txtNoOfPeople.BackColor = Color.White;
        }

        //define an EventArgs and an event
        public class AllocateEventArgs : EventArgs
        {
            private string title = "";
            public string Title
            {
                get { return title; }
                set { title = value; }
            }
        }
        public delegate void AllocateEventHandler(object sender, AllocateEventArgs e);
        public event AllocateEventHandler OnAllocate;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nudNumber.Value) > 0)
            {
                Customer item_Customer = new Customer();
                item_Customer.WaitingNumber = ++maxWaitID;
                item_Customer.NumberofPeople = Convert.ToInt32(nudNumber.Value);
                item_Customer.ArriveTime = DateTime.Now;
                //update data base
                int flag = (diningArea.CurrentStaff as Waiter).AddCustomer(diningArea.Customers, item_Customer);
                //if update success
                if (flag == 1)
                {
                    //update listbox control
                    lbList.Items.Add("Number " + item_Customer.WaitingNumber.ToString("000") + ":  " + item_Customer.NumberofPeople.ToString("00") + " Customer");
                    nudNumber.Value = 2;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveCustomer();
        }

        //remove customer from db,list,listBox
        private void RemoveCustomer()
        {
            int selected_idx = lbList.SelectedIndex;
            if (selected_idx != -1)
            {
                string str = (string)lbList.Items[selected_idx];
                int waitingNumber = Convert.ToInt32(str.Substring(7, 3));
                int flag = customerManager.DeleteByWaitingNumber(waitingNumber);
                if (flag == 1)
                {
                    //update customer list
                    diningArea.Customers.RemoveAt(selected_idx);
                    //update listbox control
                    lbList.Items.RemoveAt(selected_idx);
                }
            }
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            //var table = from tab in diningArea.Tables
            //            where tab.TableId == int.Parse(txtTableId.Text)
            //              //orderby tab.score
            //              select tab;
            //Table selectedTable = diningArea.Tables.Where(t => t.TableId == int.Parse(txtTableId.Text)) as Table;
            if (!string.IsNullOrWhiteSpace(txtCustomerId.Text) && !string.IsNullOrWhiteSpace(nudTableId1.Text))
            {
                int flag=0;
                List<NumericUpDown> nudTableIds = this.groupBox1.Controls.OfType<NumericUpDown>().ToList();
                foreach(NumericUpDown nud in nudTableIds)
                {
                    flag += (diningArea.CurrentStaff as Waiter).AllocateTableWaiter(diningArea.Tables, int.Parse(nud.Text), int.Parse(txtCustomerId.Text), int.Parse(txtNoOfPeople.Text), comboBoxWaiterName.Text);
                }
                if (flag > 0)
                {
                    RemoveCustomer();
                    txtCustomerId.Text = "";
                    txtNoOfPeople.Text = "";
                    comboBoxWaiterName.Text = "";
                    nudTableId3.Value = 0;//!!nudTableId1.Text is usable!
                    nudTableId2.Value = 0;
                    nudTableId1.Value = 0;

                    //call the OnAllcate event
                    AllocateEventArgs allocateE = new AllocateEventArgs();
                    if (this.OnAllocate != null)
                    {
                        OnAllocate(this, allocateE);
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Table is used or not exist! Please try again.", nudTableId1.Text));
                }
            }
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbList.SelectedIndex != -1)
            {
                List<Table> opt_seat;

                //clear data
                txtCustomerId.Text = "";
                txtNoOfPeople.Text = "";
                comboBoxWaiterName.Text = "";
                nudTableId3.Value = 0;
                nudTableId2.Value = 0;
                nudTableId1.Value = 0;
                //set new data
                Customer selectedCustomer = diningArea.Customers[lbList.SelectedIndex];
                txtCustomerId.Text = selectedCustomer.WaitingNumber.ToString();
                txtNoOfPeople.Text = selectedCustomer.NumberofPeople.ToString();
                comboBoxWaiterName.DataSource = diningArea.Waiters.Select(waiter => waiter.Name).ToList();


                IntelligentRestaurantManager.BLL.PlacementOptimizer opt_place = new IntelligentRestaurantManager.BLL.PlacementOptimizer();
                opt_place.PlaceTabletoCustomer((List<Table>)tableManager.GetAll(), selectedCustomer);
                opt_seat = opt_place.Get_opt_seat();

                System.Diagnostics.Debug.WriteLine("debug message");
                foreach (var k in opt_seat)
                {
                    System.Diagnostics.Debug.WriteLine("debug message" + k.TableId);
                }

                if (opt_seat.Count >= 3)
                    nudTableId3.Value = opt_seat[2].TableId;
                if (opt_seat.Count >= 2)
                    nudTableId2.Value = opt_seat[1].TableId;
                if (opt_seat.Count >= 1)
                    nudTableId1.Value = opt_seat[0].TableId;
                

                //get all NumericUpDown contral in groupBox1: 3
                List<NumericUpDown> nudTableIds = this.groupBox1.Controls.OfType<NumericUpDown>().ToList();
                for (int i = 0; i < selectedCustomer.RecommendedTableId.Length; i++)
                {
                    if (selectedCustomer.RecommendedTableId[i] > 0)
                    {
                        nudTableIds[i].Value = selectedCustomer.RecommendedTableId[i];
                    }
                }
            }
            //Todo: waiter name order by workload, i.e. sum of customers 
        }
    }
}
