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

using System.Diagnostics;

namespace IntelligentRestaurantManager.UI
{
    public partial class WaitlistForm : Form
    {
        int lastID=0;
        List<int> waitID;
        CustomerManager customerMng;
        public WaitlistForm()
        {
            InitializeComponent();
            waitID = new List<int>();
            customerMng = new CustomerManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbName.Text)))
            {
                Model.Customer item_Customer;

                lbList.Items.Add(tbName.Text + ", " + slNumber.Value);
                waitID.Add(++lastID);

                item_Customer = new Model.Customer();
                item_Customer.WaitingNumber = lastID;
                item_Customer.NumberofPeople = Convert.ToInt32(slNumber.Value);
                
                //customerMng.AddNew(item_Customer);

                tbName.Clear();
                slNumber.Value = 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedIndex != -1)
            {
                int selected_idx = lbList.SelectedIndex;

                //customerMng.DeleteByWaitingNumber(waitID[selected_idx]);

                waitID.RemoveAt(selected_idx);
                lbList.Items.RemoveAt(selected_idx);
            }
        }
    }
}
