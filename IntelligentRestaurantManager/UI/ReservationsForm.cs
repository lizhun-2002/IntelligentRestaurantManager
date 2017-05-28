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
 * 1. Refresh (get) reservation information from DB
 * 2. Refresh (get) table information from DB
 * 3. Send reservation information to DB
 * 4. Search for reservation info in DB and remove it
 * 5. Check mechanism to ensure that table is not already reserved
 * ****************************/

namespace IntelligentRestaurantManager
{
    public partial class ReservationsForm : Form
    {
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
        }

        // Refresh Reservation and Table information from DB
        private void refreshReservationList()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: send reservation info(Name, Table#, Time, Number of people) to DB

            // Check that party name is valid
            if (textBox1.Text != "")
            {
                // TODO : Check selected table is not reserved already!

                // Confirm Reservation
                if (MessageBox.Show("Confirm Reservation for " + textBox1.Text + "\nSize of Party : " + partyNumberUd.Value + "\nDate : " + monthCalendar1.SelectionRange.Start.ToShortDateString() +"\nTime : " + timeUd.Value +":00\n Table : " + tableComboBox.Text, "Confirm Reservation" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // TODO: Send information to DB
                    // TODO: Get information from DB and load to listbox
                    MessageBox.Show("Reservation Successful");

                    // Reset all values
                    checkBox1.Checked = false;
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
                    // TODO : Refresh the listbox from DB
                    MessageBox.Show("Reservation Canceled.");
                }
            } else
            {
                MessageBox.Show("Please Select a reservation to cancel");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // TODO : Get list of tables from DB and reservation info
            // Algorithm : from reservation info, get list of reserved tables
            //             then from table info, get a table of appropriate size
            //             if all tables are reserved, return an error message

            // Check if the checkbox is checked
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Table allocated to PLACEHOLDER");
            }
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            refreshReservationList();
        }
    }
}
