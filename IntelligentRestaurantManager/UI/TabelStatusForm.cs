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
    public partial class TabelStatusForm : Form
    {
        public TabelStatusForm(DiningArea diningArea)
        {
            InitializeComponent();
            this.diningArea = diningArea;
            this.Text = string.Format("Welcome {0}! Your role is {1}", diningArea.CurrentStaff.Name, diningArea.CurrentStaff.Role);
        }

        DiningArea diningArea;

        private void TabelStatusForm_Load(object sender, EventArgs e)
        {
            InitTablePosition_Simple();
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


                //btn.MouseMove += new MouseEventHandler(button_MouseMove);
                //btn.MouseLeave += new EventHandler(button_MouseLeave);
                //btn.Image = Image.FromFile(@"F:/VS2008ImageLibrary/Actions/AddTableHH.bmp");
                //btn.ImageAlign = ContentAlignment.MiddleCenter;
                //for (int j = 0; j < 3; j++)
                //{
                //    Label lb1 = new Label();
                //    lb1.BackColor = Color.SlateGray;
                //    lb1.Location = new Point(j * 20 + 7, 60);
                //    lb1.Width = 10;
                //    lb1.Height = 11;
                //    lb.Controls.Add(lb1);
                //}
                this.flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Table table = (Table)(sender as Button).Tag;
            string text = string.Format("Table ID: {0}\nCapacity: {1}\nTable Status: {2}\nOrder ID: {3}\nWaiter Name: {4}\nReservation Information: {5}", 
                table.TableId, table.Capacity,table.TableStatus,table.OrderId,table.WaiterName,table.ReservationInfo);
            //toolTip1.SetToolTip()
            toolTip1.Show(text, (sender as Button));
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
    }
}
