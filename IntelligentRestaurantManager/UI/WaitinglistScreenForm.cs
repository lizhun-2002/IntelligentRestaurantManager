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
        WaitingTimePredictor set_predic;
        CustomerManager customerMng;
        TableManager tableMng;
        IEnumerable<Model.Customer> lst_customers;

        public WaitinglistScreenForm()
        {
            InitializeComponent();
        }

        private void WaitinglistScreenForm_Load(object sender, EventArgs e)
        {
            tableMng = new TableManager();
            set_predic = new WaitingTimePredictor();
            customerMng = new CustomerManager();

            lbNumWaiting.Text = "Currently Waiting: " + customerMng.GetCount();
            lbCurrentTime.Text = System.DateTime.Now.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));

            lst_customers = customerMng.GetAll();

            set_predic.PredictWaitingTime((List<IntelligentRestaurantManager.Model.Table>)tableMng.GetAll(), (List<IntelligentRestaurantManager.Model.Customer>)lst_customers);

            foreach (var customer in lst_customers)
                lbWaitingPerson.Items.Add("Number " + customer.WaitingNumber.ToString("000") + ":  " + customer.NumberofPeople.ToString("000") + " Customer, Expected wait time: " + customer.EstimatedWaitingTime);

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
                lbNumWaiting.Text = "Currently Waiting: " + customerMng.GetCount();
                lbCurrentTime.Text = System.DateTime.Now.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));

                lst_customers = customerMng.GetAll();

                set_predic.PredictWaitingTime((List<IntelligentRestaurantManager.Model.Table>)tableMng.GetAll(), (List<IntelligentRestaurantManager.Model.Customer>)lst_customers);

                lbWaitingPerson.Items.Clear();
                
                foreach (var customer in lst_customers)
                    lbWaitingPerson.Items.Add("Number " + customer.WaitingNumber.ToString("000") + ":  " + customer.NumberofPeople.ToString("000") + " Customer, Expected wait time: " + customer.EstimatedWaitingTime);

            });
        }
    }
}
