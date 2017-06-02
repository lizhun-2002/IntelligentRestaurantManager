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
    public partial class ItemEditForm : Form
    {
        //two mode: add or edit
        string mode;
        //construct function for add new Item
        public ItemEditForm()
        {
            InitializeComponent();
            mode = "add";
            this.StartPosition = FormStartPosition.CenterScreen;
            nudItemId.Focus();
            nudPrice.DecimalPlaces = 2;
            nudPrice.Increment = 0.5m;
        }
        //construct function for edit staff
        public ItemEditForm(Item item)
        {
            if (item != null)
            {
                InitializeComponent();
                mode = "edit";
                this.StartPosition = FormStartPosition.CenterScreen;
                txtName.Focus();
                nudItemId.Value = item.ItemId;
                nudItemId.Enabled = false;//ID is primary key, cannot be changed
                txtName.Text = item.Name;
                nudPrice.Value = item.Price;
                nudPrice.DecimalPlaces = 2;
                nudPrice.Increment = 0.5m;
                nudAverageTimeCost.Value = item.AverageTimeCost;
                txtDescription.Text = item.Description;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<NumericUpDown>().Select(nud => nud.Value).Min() > 0 
                && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                Item item = new Item();
                item.ItemId = (int)nudItemId.Value;
                item.Name = txtName.Text;
                item.Price = (decimal)nudPrice.Value;
                item.AverageTimeCost = (int)nudAverageTimeCost.Value;
                item.Description = txtDescription.Text;
                int flag;
                if (mode == "add")
                {
                    flag = new ItemManager().AddNew(item);
                }
                else
                {
                    flag = new ItemManager().Update(item);
                }
                if (flag == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This item ID is exist. Please change.");
                }

            }
            //MessageBox.Show(comboBoxRole.SelectedItem.ToString());
            //MessageBox.Show(comboBoxRole.SelectedIndex.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
