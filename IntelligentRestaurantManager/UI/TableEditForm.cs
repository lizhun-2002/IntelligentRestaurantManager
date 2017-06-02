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
    public partial class TableEditForm : Form
    {
        //two mode: add or edit
        string mode;
        //construct function for add new table
        public TableEditForm()
        {
            InitializeComponent();
            mode = "add";
            this.StartPosition = FormStartPosition.CenterScreen;
            nudTableId.Focus();
        }
        //construct function for edit staff
        public TableEditForm(Table table)
        {
            if (table != null)
            {
                InitializeComponent();
                mode = "edit";
                this.StartPosition = FormStartPosition.CenterScreen;
                nudCapacity.Focus();
                nudTableId.Value = table.TableId;
                nudTableId.Enabled = false;//name is primary key, cannot be changed
                nudCapacity.Value = table.Capacity;
                nudLink1.Value = table.LinkableTableId1;
                nudLink2.Value = table.LinkableTableId2;
                nudLink3.Value = table.LinkableTableId3;
                nudLink4.Value = table.LinkableTableId4;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<NumericUpDown>().Select(nud => nud.Value).Min() >= 0 && nudTableId.Value > 0 && nudCapacity.Value > 0)
            {
                Table table = new Table();
                table.TableId = (int)nudTableId.Value;
                table.Capacity = (int)nudCapacity.Value;
                table.LinkableTableId1 = (int)nudLink1.Value;
                table.LinkableTableId2 = (int)nudLink2.Value;
                table.LinkableTableId3 = (int)nudLink3.Value;
                table.LinkableTableId4 = (int)nudLink4.Value;
                int flag;
                if (mode == "add")
                {
                    flag = new TableManager().AddNew(table);
                }
                else
                {
                    flag = new TableManager().Update(table);
                }
                if (flag == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This table ID is exist. Please change.");
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
