using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Booking
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private void booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform m3 = new mainform();
            m3.Show();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.Show();
            this.Hide();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackBookings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearBooking_Click(object sender, EventArgs e)
        {
            txtBookingID.Clear();
            txtCustomerName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtTotalPrice.Clear();
            cmbSchedule.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbTour.SelectedIndex = -1;
            numTravelers.Value = 1;

        }
    }
}
