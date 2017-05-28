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
        CustomerManager customerMng;
        public WaitlistForm(DiningArea diningArea)
        {
            InitializeComponent();
            this.diningArea = diningArea;
            maxWaitID = 1;
            foreach (Customer customer in diningArea.Customers)
            {
                lbList.Items.Add("Number " + customer.WaitingNumber.ToString("000") + ":  " + customer.NumberofPeople.ToString("000") + " Customer");
                if (customer.WaitingNumber > maxWaitID)
                {
                    maxWaitID = customer.WaitingNumber;
                }
            }
            customerMng = new CustomerManager();
            nudNumber.Value = 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nudNumber.Value)>0)
            {
                Customer item_Customer = new Customer();
                item_Customer.WaitingNumber = ++maxWaitID;
                item_Customer.NumberofPeople = Convert.ToInt32(nudNumber.Value);
                item_Customer.ArriveTime = DateTime.Now;
                //update data base
                int flag = customerMng.AddNew(item_Customer);
                //if update success
                if (flag == 1)
                {
                    //update listbox control
                    lbList.Items.Add("Number " + item_Customer.WaitingNumber.ToString("000") + ":  " + item_Customer.NumberofPeople.ToString("000") + " Customer  " + txtName.Text);
                    //update customer list
                    diningArea.Customers.Add(item_Customer);

                    txtName.Clear();
                    nudNumber.Value = 2;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveListBoxItem();
        }

        private void RemoveListBoxItem()
        {
            int selected_idx = lbList.SelectedIndex;
            if (selected_idx != -1)
            {
                string str = (string)lbList.Items[selected_idx];
                int waitingNumber = Convert.ToInt32(str.Substring(7, 3));
                int flag = customerMng.DeleteByWaitingNumber(waitingNumber);
                if (flag == 1)
                {
                    //update listbox control
                    lbList.Items.RemoveAt(selected_idx);
                    //update customer list
                    diningArea.Customers.RemoveAt(selected_idx);
                }
            }
        }
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            RemoveListBoxItem();
            //(diningArea.CurrentStaff as Waiter).AllocateTableWaiter();
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCustomerId.DataSource = null;
            comboBoxCustomerId.DataSource = diningArea.Customers.Select(customer => customer.WaitingNumber).ToList();
            comboBoxWaiterId.DataSource = null;
            comboBoxWaiterId.DataSource = diningArea.Waiters.Select(waiter => waiter.Name).ToList();
            //Todo: waiter name order by workload, i.e. sum of customers 
        }
    }
}
