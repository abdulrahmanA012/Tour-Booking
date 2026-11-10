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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform m1 = new mainform();
            m1.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dgvsearch.Visible = true;
            btnback.Visible = true;
            dgvsearch.Location = new Point(0, 28);
            dgvsearch.Size = new Size(
                this.ClientSize.Width,
                this.ClientSize.Height - 80
            );
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dgvsearch.Visible = false;
            btnback.Visible = false;
        }
    }
}
