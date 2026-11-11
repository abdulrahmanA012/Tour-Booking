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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }



        private void profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform m = new mainform();
            m.Show();
        }

    }
}
