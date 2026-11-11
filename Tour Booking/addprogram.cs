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
    public partial class addprogram : Form
    {
        public addprogram()
        {
            InitializeComponent();
        }

        private void addprogram_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform m4 = new mainform();
            m4.Show();
        }
    }
}
