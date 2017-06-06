using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*******************************
 * TODO:
 * 1. Refresh (get) reservation information from DB -> OK
 * 2. Refresh (get) table information from DB -> OK
 * 3. Send reservation information to DB -> OK
 * 4. Search for reservation info in DB and remove it -> OK
 * 5. Check mechanism to ensure that table is not already reserved
 * 5.1 Autoallocation
 * 6. Unique ID?
 * ****************************/

namespace IntelligentRestaurantManager
{
    public partial class ReservationsForm : Form
    {
        IEnumerable<Model.Table> myTable;
        IEnumerable<Model.Reservation> myReservation;
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // TODO: Refresh reservation information from DB to the listbox 
            refreshReservationsList(monthCalendar1.SelectionStart.Year,
                monthCalendar1.SelectionStart.Month,
                monthCalendar1.SelectionStart.Day);
        }

        // get Table info
        private void refreshTableList()
        {
            myTable = new BLL.TableManager().GetAll();
            tableComboBox.Items.Clear();
            foreach (Model.Table t in myTable)
            {
                tableComboBox.Items.Add(t.TableId);
            }

        }

        private void refreshReservationsList(int year, int month, int day)
        {
            myReservation = new DAL.ReservationService().GetAll();
            listBox1.Items.Clear();
            foreach (Model.Reservation r in myReservation)
            {
                if (r.year == year && r.month == month && r.day == day)
                {
                    listBox1.Items.Add(r.getId() + " " + r.getName() + r.getHour() + ":00 At table" + r.getTableId());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check that party name is valid
            if (textBox1.Text != "" && tableComboBox.Text != "")
            {
                // TODO : Check selected table is not reserved already!

                // Confirm Reservation
                if (MessageBox.Show("Confirm Reservation for " + textBox1.Text + "\nSize of Party : " + partyNumberUd.Value + "\nDate : " + monthCalendar1.SelectionRange.Start.ToShortDateString() +"\nTime : " + timeUd.Value +":00\n Table : " + tableComboBox.Text, "Confirm Reservation" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Send information to DB
                    DAL.ReservationService r = new DAL.ReservationService();
                    Model.Reservation res = new Model.Reservation();
                    // need a better way to allocate unique IDs!
                    res.id = (int)partyNumberUd.Value * textBox1.Text.Length * (int)timeUd.Value;
                    res.name = textBox1.Text;
                    res.tableId = int.Parse(tableComboBox.Text);
                    res.year = monthCalendar1.SelectionStart.Year;
                    res.month = monthCalendar1.SelectionStart.Month;
                    res.day = monthCalendar1.SelectionStart.Day;
                    res.hour = (int)timeUd.Value;
                    res.number = (int)partyNumberUd.Value;
                    r.AddNew(res);

                    // Get information from DB and load to listbox
                    refreshReservationsList(monthCalendar1.SelectionStart.Year,
                        monthCalendar1.SelectionStart.Month,
                        monthCalendar1.SelectionStart.Day);
                    MessageBox.Show("Reservation Successful");

                    // Reset all values
                    textBox1.Text = "";
                    partyNumberUd.Value = 1;
                    timeUd.Value = 12;
                }
            }
            else
            {
                MessageBox.Show("Please type in the party name.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check that a reservation is selected
            if (listBox1.SelectedItem != null)
            {
                // Confirm removal of reservation
                if (MessageBox.Show("Confirm reservation cancellation.", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // TODO : Search for selected info in DB and remove it
                    DAL.ReservationService r = new DAL.ReservationService();
                    string s = listBox1.SelectedItem.ToString();
                    string[] strarray = s.Split(' ');
                    r.DeleteByReservationId(int.Parse(strarray[0]));

                    // Refresh the listbox from DB
                    refreshReservationsList(monthCalendar1.SelectionStart.Year,
                        monthCalendar1.SelectionStart.Month,
                        monthCalendar1.SelectionStart.Day);
                    MessageBox.Show("Reservation Canceled.");
                }
            } else
            {
                MessageBox.Show("Please Select a reservation to cancel");
            }
        }


        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            refreshTableList();
            refreshReservationsList(monthCalendar1.SelectionStart.Year,
                monthCalendar1.SelectionStart.Month,
                monthCalendar1.SelectionStart.Day);
        }
    }
}
