namespace Tour_Booking
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }



        private void btnopengroupboxsignin_Click(object sender, EventArgs e)
        {
            btnopengroupboxsignin.BackColor = Color.Blue;
            grbsignin.Visible = true;
            grbsignup.Visible = false;
            btnopengroupboxsignup.BackColor = Color.White;
        }

        private void btnopengroupboxsignup_Click(object sender, EventArgs e)
        {
            btnopengroupboxsignup.BackColor = Color.Blue;
            grbsignup.Visible = true;
            grbsignin.Visible = false;
            btnopengroupboxsignin.BackColor = Color.White;
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            grbsignup.Visible = false;
            grbsignin.Visible = true;
            btnopengroupboxsignin.BackColor = Color.Blue;
            btnopengroupboxsignup.BackColor = Color.White;
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "")
            {
                MessageBox.Show("Please enter your username and password.");
                txtusername.Focus();
                return;
            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Please enter your username.");
                txtusername.Focus();
                return; 
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please enter your password.");
                txtpassword.Focus();
                return;
            }
            mainform m = new mainform();
            m.Show();
            this.Hide();
        }
    }
}
