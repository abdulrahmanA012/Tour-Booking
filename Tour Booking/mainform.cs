using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour_booking_update.frmbooking;
using tourbooking;

namespace Tour_Booking
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnprofie_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.Show();
            this.Hide();
        }

        private void btnsearchmainform_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
            this.Hide();
        }

        private void btntripmanagement_Click(object sender, EventArgs e)
        {
            addprogram a = new addprogram();
            a.Show();
            this.Hide();
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
           Booking b = new Booking();
            b.Show();
            this.Hide();
        }
    }
}
