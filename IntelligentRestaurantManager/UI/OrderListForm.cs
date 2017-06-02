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
        int waitingLabelCount = 0;
        List<MenuItem> waitingMenuItemList = new List<MenuItem>();
        private class MenuItem
        {
            string type;
            int id;
            public MenuItem(string name, int i)
            {
                type = name;
                id = i;
            }
            public string getFoodType()
            {
                return type;
            }
            public int getID()
            {
                return id;
            }

        }
        /*
        public partial class MyLabel : Label
        {
            int id;
            public MyLabel(string str, int i)
            {
                id = i;
                this.Text = str;
            }
            public void setText(string str)
            {
                this.Text = str;
            }
        } */

        public OrderListForm()
        {
            InitializeComponent();
            
            //test code delete for final
            this.addNewItem("Pasta", 1001);
            this.addNewItem("Pizza", 1002);
            this.addNewItem("Burger", 2131);
            this.addNewItem("Burger", 2112);
            this.addNewItem("Rice", 1121);
            this.addNewItem("Rice", 1721);
            this.addNewItem("Rice", 1127);
            this.removeItem("Burger", 2131);
        }

        public void addNewItem(string str, int id)
        {
            // TODO : put network code for receiving new items
            // use ID as way to cancel orders
            MenuItem temp = new MenuItem(str, id);
            waitingMenuItemList.Add(temp);
            listBox1.Items.Add(temp.getFoodType() + " " + temp.getID());
            listbox1FlashTimer.Enabled = true;
        }

        public void removeItem(string str, int id)
        {
            if (listBox1.Items.Contains(str + " " + id.ToString()))
            {
                listBox1.Items.Remove(str + " " + id.ToString());
                // TODO : Signal successful removal
            }
            else
            {
                // TODO : Signal failure to remove
            }
        }
        
        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) { 
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox2.SelectedItem);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            if(listBox3.Items.Count > 5)
            {
                listBox3.Items.RemoveAt(0);
            }
            // TODO: put some kind of signalling mechanism here so waiters know the order is completed
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
    }
}
