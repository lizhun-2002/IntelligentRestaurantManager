using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using IntelligentRestaurantManager.BLL;


namespace IntelligentRestaurantManager.UI
{
    public partial class WaitinglistScreenForm : Form
    {
        CustomerManager customerMng;
        IEnumerable<Model.Customer> lst_customers;

        public WaitinglistScreenForm()
        {
            InitializeComponent();
        }

        private void WaitinglistScreenForm_Load(object sender, EventArgs e)
        {
            customerMng = new CustomerManager();

            //lbNumWaiting.Text = "Currently Waiting : " + customerMng.GetCount();
            lbNumWaiting.Text = "Currently Waiting : ";
            lbWaitTime.Text = "Estimated Wait Time : ";
            lbCurrentTime.Text = System.DateTime.Now.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            
            /*
            lst_customers = customerMng.GetAll();
            foreach (var x in lst_customers)
            {
                lbWaitingPerson.Items.Add(x.NumberofPeople);
            }
            */
            
            // Set up a timer to trigger every minute.
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;                          
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            Invoke((MethodInvoker)delegate
            {
                //lbNumWaiting.Text = "Currently Waiting : " + customerMng.GetCount();
                lbNumWaiting.Text = "Currently Waiting : ";
                lbWaitTime.Text = "Estimated Wait Time : ";
                lbCurrentTime.Text = System.DateTime.Now.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));

                /*
                lst_customers = customerMng.GetAll();
                foreach (var x in lst_customers)
                {
                    lbWaitingPerson.Items.Add(x.NumberofPeople);
                }
                 */
            });
        }
    }
}
