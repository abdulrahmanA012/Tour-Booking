using System.Windows.Forms;
using Tour_Booking;

namespace tourbooking
{
    public partial class addprogram : Form
    {
        public addprogram()
        {
            InitializeComponent();
        }

        private void addprogram_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform m2 = new mainform();
            m2.Show();
        }
    }
}
