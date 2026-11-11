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
    }
}
