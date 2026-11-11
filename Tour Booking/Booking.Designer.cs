namespace Tour_Booking
{
    partial class booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            grpCustomer = new GroupBox();
            lblBookingID = new Label();
            txtBookingID = new TextBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            grpBookingDetails = new GroupBox();
            lblSelectTour = new Label();
            cmbTour = new ComboBox();
            lblSchedule = new Label();
            cmbSchedule = new ComboBox();
            lblTravelers = new Label();
            numTravelers = new NumericUpDown();
            lblTotal = new Label();
            txtTotalPrice = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            grpPayment = new GroupBox();
            rdoCash = new RadioButton();
            rdoCard = new RadioButton();
            btnAddBooking = new Button();
            btnCancelBooking = new Button();
            btnClearBooking = new Button();
            btnBackBookings = new Button();
            grpCustomer.SuspendLayout();
            grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTravelers).BeginInit();
            grpPayment.SuspendLayout();
            SuspendLayout();
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(lblBookingID);
            grpCustomer.Controls.Add(txtBookingID);
            grpCustomer.Controls.Add(lblCustomerName);
            grpCustomer.Controls.Add(txtCustomerName);
            grpCustomer.Controls.Add(lblPhone);
            grpCustomer.Controls.Add(txtPhone);
            grpCustomer.Controls.Add(lblEmail);
            grpCustomer.Controls.Add(txtEmail);
            grpCustomer.Location = new Point(23, 20);
            grpCustomer.Margin = new Padding(3, 4, 3, 4);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Padding = new Padding(3, 4, 3, 4);
            grpCustomer.Size = new Size(983, 140);
            grpCustomer.TabIndex = 0;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer Information";
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Location = new Point(17, 38);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(86, 20);
            lblBookingID.TabIndex = 1;
            lblBookingID.Text = "Booking ID:";
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(154, 38);
            txtBookingID.Margin = new Padding(3, 4, 3, 4);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(228, 27);
            txtBookingID.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(503, 42);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(119, 20);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(640, 38);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(319, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(17, 92);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(154, 86);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(228, 27);
            txtPhone.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(503, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(640, 86);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 27);
            txtEmail.TabIndex = 8;
            // 
            // grpBookingDetails
            // 
            grpBookingDetails.Controls.Add(lblSelectTour);
            grpBookingDetails.Controls.Add(cmbTour);
            grpBookingDetails.Controls.Add(lblSchedule);
            grpBookingDetails.Controls.Add(cmbSchedule);
            grpBookingDetails.Controls.Add(lblTravelers);
            grpBookingDetails.Controls.Add(numTravelers);
            grpBookingDetails.Controls.Add(lblTotal);
            grpBookingDetails.Controls.Add(txtTotalPrice);
            grpBookingDetails.Controls.Add(lblStatus);
            grpBookingDetails.Controls.Add(cmbStatus);
            grpBookingDetails.Location = new Point(23, 208);
            grpBookingDetails.Margin = new Padding(3, 4, 3, 4);
            grpBookingDetails.Name = "grpBookingDetails";
            grpBookingDetails.Padding = new Padding(3, 4, 3, 4);
            grpBookingDetails.Size = new Size(983, 194);
            grpBookingDetails.TabIndex = 9;
            grpBookingDetails.TabStop = false;
            grpBookingDetails.Text = "Booking Details";
            // 
            // lblSelectTour
            // 
            lblSelectTour.AutoSize = true;
            lblSelectTour.Location = new Point(17, 42);
            lblSelectTour.Name = "lblSelectTour";
            lblSelectTour.Size = new Size(85, 20);
            lblSelectTour.TabIndex = 10;
            lblSelectTour.Text = "Select Tour:";
            // 
            // cmbTour
            // 
            cmbTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTour.FormattingEnabled = true;
            cmbTour.Items.AddRange(new object[] { "A", "B", "C" });
            cmbTour.Location = new Point(154, 38);
            cmbTour.Margin = new Padding(3, 4, 3, 4);
            cmbTour.Name = "cmbTour";
            cmbTour.Size = new Size(319, 28);
            cmbTour.TabIndex = 11;
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Location = new Point(503, 42);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(88, 20);
            lblSchedule.TabIndex = 12;
            lblSchedule.Text = "Select Date:";
            // 
            // cmbSchedule
            // 
            cmbSchedule.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchedule.FormattingEnabled = true;
            cmbSchedule.Items.AddRange(new object[] { "5/11/2026", "20/12/2026" });
            cmbSchedule.Location = new Point(640, 38);
            cmbSchedule.Margin = new Padding(3, 4, 3, 4);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Size = new Size(319, 28);
            cmbSchedule.TabIndex = 13;
            // 
            // lblTravelers
            // 
            lblTravelers.AutoSize = true;
            lblTravelers.Location = new Point(2, 89);
            lblTravelers.Name = "lblTravelers";
            lblTravelers.Size = new Size(146, 20);
            lblTravelers.TabIndex = 14;
            lblTravelers.Text = "Number of Travelers:";
            // 
            // numTravelers
            // 
            numTravelers.Location = new Point(154, 86);
            numTravelers.Margin = new Padding(3, 4, 3, 4);
            numTravelers.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numTravelers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTravelers.Name = "numTravelers";
            numTravelers.Size = new Size(114, 27);
            numTravelers.TabIndex = 15;
            numTravelers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(503, 92);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 20);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(640, 86);
            txtTotalPrice.Margin = new Padding(3, 4, 3, 4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(228, 27);
            txtTotalPrice.TabIndex = 17;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 141);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Cancelled" });
            cmbStatus.Location = new Point(154, 136);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(228, 28);
            cmbStatus.TabIndex = 19;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(rdoCash);
            grpPayment.Controls.Add(rdoCard);
            grpPayment.Location = new Point(23, 456);
            grpPayment.Margin = new Padding(3, 4, 3, 4);
            grpPayment.Name = "grpPayment";
            grpPayment.Padding = new Padding(3, 4, 3, 4);
            grpPayment.Size = new Size(983, 86);
            grpPayment.TabIndex = 21;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment Method";
            // 
            // rdoCash
            // 
            rdoCash.Checked = true;
            rdoCash.Location = new Point(23, 38);
            rdoCash.Margin = new Padding(3, 4, 3, 4);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(137, 32);
            rdoCash.TabIndex = 22;
            rdoCash.TabStop = true;
            rdoCash.Text = "Cash";
            rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoCard
            // 
            rdoCard.Location = new Point(233, 38);
            rdoCard.Margin = new Padding(3, 4, 3, 4);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(160, 32);
            rdoCard.TabIndex = 23;
            rdoCard.Text = "Credit Card";
            rdoCard.UseVisualStyleBackColor = true;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Location = new Point(38, 625);
            btnAddBooking.Margin = new Padding(3, 4, 3, 4);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(126, 42);
            btnAddBooking.TabIndex = 25;
            btnAddBooking.Text = "Book Now";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Location = new Point(170, 625);
            btnCancelBooking.Margin = new Padding(3, 4, 3, 4);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(149, 42);
            btnCancelBooking.TabIndex = 26;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = true;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // btnClearBooking
            // 
            btnClearBooking.Location = new Point(325, 625);
            btnClearBooking.Margin = new Padding(3, 4, 3, 4);
            btnClearBooking.Name = "btnClearBooking";
            btnClearBooking.Size = new Size(114, 42);
            btnClearBooking.TabIndex = 27;
            btnClearBooking.Text = "Clear";
            btnClearBooking.UseVisualStyleBackColor = true;
            btnClearBooking.Click += btnClearBooking_Click;
            // 
            // btnBackBookings
            // 
            btnBackBookings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackBookings.Location = new Point(870, 610);
            btnBackBookings.Margin = new Padding(3, 4, 3, 4);
            btnBackBookings.Name = "btnBackBookings";
            btnBackBookings.Size = new Size(114, 42);
            btnBackBookings.TabIndex = 32;
            btnBackBookings.Text = "Back";
            btnBackBookings.UseVisualStyleBackColor = true;
            btnBackBookings.Click += btnBackBookings_Click;
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 676);
            Controls.Add(grpCustomer);
            Controls.Add(grpBookingDetails);
            Controls.Add(grpPayment);
            Controls.Add(btnAddBooking);
            Controls.Add(btnCancelBooking);
            Controls.Add(btnClearBooking);
            Controls.Add(btnBackBookings);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            FormClosed += booking_FormClosed;
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpBookingDetails.ResumeLayout(false);
            grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTravelers).EndInit();
            grpPayment.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private GroupBox grpCustomer;
        private Label lblBookingID;
        private TextBox txtBookingID;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private GroupBox grpBookingDetails;
        private Label lblSelectTour;
        private ComboBox cmbTour;
        private Label lblSchedule;
        private ComboBox cmbSchedule;
        private Label lblTravelers;
        private NumericUpDown numTravelers;
        private Label lblTotal;
        private TextBox txtTotalPrice;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private GroupBox grpPayment;
        private RadioButton rdoCash;
        private RadioButton rdoCard;
        private Button btnAddBooking;
        private Button btnCancelBooking;
        private Button btnClearBooking;
        private Button btnBackBookings;
    }
}