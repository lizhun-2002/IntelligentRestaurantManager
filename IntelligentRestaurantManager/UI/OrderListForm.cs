using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentRestaurantManager
{
    public partial class OrderListForm : Form
    {
        //MenuItem[] waitingMenuItem = new MenuItem[100];
        int listbox1FlashTimerCount = 0;
        List<Model.Order> newOrders = new List<Model.Order>();
        List<Model.Order> procOrders = new List<Model.Order>();
        List<Model.Order> finishedOrders = new List<Model.Order>();
        IEnumerable<Model.Order> checker;
        BLL.OrderManager myOrderManager = new BLL.OrderManager();

        public void refreshLists()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (Model.Order o in newOrders) {
                listBox1.Items.Add(o.OrderId + " " + o.Items[0].Name);
            }
            foreach (Model.Order o in procOrders)
            {
                listBox2.Items.Add(o.OrderId + " " + o.Items[0].Name);
            }
            foreach (Model.Order o in finishedOrders)
            {
                listBox3.Items.Add(o.OrderId + " " + o.Items[0].Name);
            }
            if (listBox3.Items.Count > 5)
            {
                listBox3.Items.RemoveAt(0);
            }
        }
        public OrderListForm()
        {
            InitializeComponent();
        }
        
        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            /*if (listBox1.SelectedItem != null) { 
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }*/
            string s = listBox1.SelectedItem.ToString();
            string[] strarray = s.Split(' ');
            Model.Order temp = myOrderManager.GetByOrderId(int.Parse(strarray[0]));
            temp.OrderStatus = Model.OrderStatus.Processing;
            myOrderManager.DeleteByOrderId(int.Parse(strarray[0]));
            myOrderManager.AddNew(temp);

            refreshLists();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            /*listBox3.Items.Add(listBox2.SelectedItem);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);*/
            if(listBox3.Items.Count > 5)
            {
                listBox3.Items.RemoveAt(0);
            }
            string s = listBox2.SelectedItem.ToString();
            string[] strarray = s.Split(' ');
            Model.Order temp = myOrderManager.GetByOrderId(int.Parse(strarray[0]));
            temp.OrderStatus = Model.OrderStatus.Finish;
            myOrderManager.DeleteByOrderId(int.Parse(strarray[0]));
            myOrderManager.AddNew(temp);
            refreshLists();
        }

        private void listbox1FlashTimer_Tick(object sender, EventArgs e)
        {
            if(listBox1.BackColor == Color.Green)
            {
                listBox1.BackColor = SystemColors.Window;
            } else if(listBox1.BackColor == SystemColors.Window)
            {
                listBox1.BackColor = Color.Green;
            }

            listbox1FlashTimerCount++;
            if (listbox1FlashTimerCount == 6)
            {
                listbox1FlashTimerCount = 0;
                listbox1FlashTimer.Enabled = false;
            }
        }

        private void orderCheckTimer_Tick(object sender, EventArgs e)
        {
            IEnumerable<Model.Order> temp;
            temp = myOrderManager.GetAll();
                        
            newOrders.Clear();
            procOrders.Clear();
            finishedOrders.Clear();
    
            foreach (Model.Order o in temp){
                if(o.OrderStatus == Model.OrderStatus.Start)
                {
                    newOrders.Add(o);
                }
                else if(o.OrderStatus == Model.OrderStatus.Processing){
                    procOrders.Add(o);
                }
                else if (o.OrderStatus == Model.OrderStatus.Finish)
                {
                    finishedOrders.Add(o);
                }
            }
            if (newOrders != checker)
            {
                listbox1FlashTimer.Enabled = true;
            }
            checker = newOrders;
            refreshLists();
        }
    }
}
