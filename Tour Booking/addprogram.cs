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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            lblDestination.Clear();
            txtRating.Clear();
            txtNotes.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            nudDuration.Value = 0;
            nudMaxParticipants.Value = 1;
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter program name");
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Select category");
                return;
            }

            MessageBox.Show("Program added");
        }
    }
}
