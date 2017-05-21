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
            
        }

        //Simplely initialize tables position order by table ID.
        private void InitTablePosition_Simple()
        {
            for (int i = 0; i < diningArea.Tables.Count; i++)
            {
                // Label lb = new Label();
                Button lb = new Button();
                lb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                lb.Width = 80;
                lb.Height = 80;
                lb.Text = i.ToString("000");
                lb.BackColor = Color.PowderBlue;
                lb.ForeColor = Color.Red;
                lb.TextAlign = ContentAlignment.TopCenter;
                //lb.MouseMove += new MouseEventHandler(button_MouseMove);
                //lb.MouseLeave += new EventHandler(button_MouseLeave);
                //lb.Image = Image.FromFile(@"F:/VS2008ImageLibrary/Actions/AddTableHH.bmp");
                lb.ImageAlign = ContentAlignment.MiddleCenter;
                //for (int j = 0; j < 3; j++)
                //{
                //    Label lb1 = new Label();
                //    lb1.BackColor = Color.SlateGray;
                //    lb1.Location = new Point(j * 20 + 7, 60);
                //    lb1.Width = 10;
                //    lb1.Height = 11;
                //    lb.Controls.Add(lb1);
                //}
                this.flowLayoutPanel1.Controls.Add(lb);
            }
        }

        //Initialize real tables position according to relative table position.
        private void InitTablePosition_Real()
        {

        }
    }
}
