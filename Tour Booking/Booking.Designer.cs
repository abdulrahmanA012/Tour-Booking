using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tour_booking_update.frmbooking
{
    partial class Booking
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblSelectTour = new System.Windows.Forms.Label();
            this.cmbTour = new System.Windows.Forms.ComboBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.lblTravelers = new System.Windows.Forms.Label();
            this.numTravelers = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnClearBooking = new System.Windows.Forms.Button();
            this.btnBackBookings = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelers)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblBookingID);
            this.grpCustomer.Controls.Add(this.txtBookingID);
            this.grpCustomer.Controls.Add(this.lblCustomerName);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblPhone);
            this.grpCustomer.Controls.Add(this.txtPhone);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Location = new System.Drawing.Point(23, 16);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(983, 112);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(17, 30);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(76, 16);
            this.lblBookingID.TabIndex = 1;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(154, 30);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(228, 22);
            this.txtBookingID.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(503, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(107, 16);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(640, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(319, 22);
            this.txtCustomerName.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 74);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 16);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(154, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(503, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(640, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.lblSelectTour);
            this.grpBookingDetails.Controls.Add(this.cmbTour);
            this.grpBookingDetails.Controls.Add(this.lblSchedule);
            this.grpBookingDetails.Controls.Add(this.cmbSchedule);
            this.grpBookingDetails.Controls.Add(this.lblTravelers);
            this.grpBookingDetails.Controls.Add(this.numTravelers);
            this.grpBookingDetails.Controls.Add(this.lblTotal);
            this.grpBookingDetails.Controls.Add(this.txtTotalPrice);
            this.grpBookingDetails.Controls.Add(this.lblStatus);
            this.grpBookingDetails.Controls.Add(this.cmbStatus);
            this.grpBookingDetails.Location = new System.Drawing.Point(23, 166);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(983, 155);
            this.grpBookingDetails.TabIndex = 9;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // lblSelectTour
            // 
            this.lblSelectTour.AutoSize = true;
            this.lblSelectTour.Location = new System.Drawing.Point(17, 34);
            this.lblSelectTour.Name = "lblSelectTour";
            this.lblSelectTour.Size = new System.Drawing.Size(79, 16);
            this.lblSelectTour.TabIndex = 10;
            this.lblSelectTour.Text = "Select Tour:";
            // 
            // cmbTour
            // 
            this.cmbTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTour.FormattingEnabled = true;
            this.cmbTour.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTour.Location = new System.Drawing.Point(154, 30);
            this.cmbTour.Name = "cmbTour";
            this.cmbTour.Size = new System.Drawing.Size(319, 24);
            this.cmbTour.TabIndex = 11;
            this.cmbTour.SelectedIndexChanged += new System.EventHandler(this.cmbTour_SelectedIndexChanged);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(503, 34);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(80, 16);
            this.lblSchedule.TabIndex = 12;
            this.lblSchedule.Text = "Select Date:";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Items.AddRange(new object[] {
            "5/11/2026",
            "20/12/2026"});
            this.cmbSchedule.Location = new System.Drawing.Point(640, 30);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(319, 24);
            this.cmbSchedule.TabIndex = 13;
            // 
            // lblTravelers
            // 
            this.lblTravelers.AutoSize = true;
            this.lblTravelers.Location = new System.Drawing.Point(17, 74);
            this.lblTravelers.Name = "lblTravelers";
            this.lblTravelers.Size = new System.Drawing.Size(133, 16);
            this.lblTravelers.TabIndex = 14;
            this.lblTravelers.Text = "Number of Travelers:";
            this.lblTravelers.Click += new System.EventHandler(this.lblTravelers_Click);
            // 
            // numTravelers
            // 
            this.numTravelers.Location = new System.Drawing.Point(154, 69);
            this.numTravelers.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTravelers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTravelers.Name = "numTravelers";
            this.numTravelers.Size = new System.Drawing.Size(114, 22);
            this.numTravelers.TabIndex = 15;
            this.numTravelers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(503, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(640, 69);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(228, 22);
            this.txtTotalPrice.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 113);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(154, 109);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(228, 24);
            this.cmbStatus.TabIndex = 19;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.rdoCash);
            this.grpPayment.Controls.Add(this.rdoCard);
            this.grpPayment.Location = new System.Drawing.Point(23, 365);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(983, 69);
            this.grpPayment.TabIndex = 21;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Method";
            this.grpPayment.Enter += new System.EventHandler(this.grpPayment_Enter);
            // 
            // rdoCash
            // 
            this.rdoCash.Checked = true;
            this.rdoCash.Location = new System.Drawing.Point(23, 30);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(137, 26);
            this.rdoCash.TabIndex = 22;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoCard
            // 
            this.rdoCard.Location = new System.Drawing.Point(233, 30);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(160, 26);
            this.rdoCard.TabIndex = 23;
            this.rdoCard.Text = "Credit Card";
            this.rdoCard.UseVisualStyleBackColor = true;
            this.rdoCard.CheckedChanged += new System.EventHandler(this.rdoCard_CheckedChanged);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(38, 500);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(126, 34);
            this.btnAddBooking.TabIndex = 25;
            this.btnAddBooking.Text = "Book Now";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(170, 500);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(149, 34);
            this.btnCancelBooking.TabIndex = 26;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // btnClearBooking
            // 
            this.btnClearBooking.Location = new System.Drawing.Point(325, 500);
            this.btnClearBooking.Name = "btnClearBooking";
            this.btnClearBooking.Size = new System.Drawing.Size(114, 34);
            this.btnClearBooking.TabIndex = 27;
            this.btnClearBooking.Text = "Clear";
            this.btnClearBooking.UseVisualStyleBackColor = true;
            this.btnClearBooking.Click += new System.EventHandler(this.btnClearBooking_Click);
            // 
            // btnBackBookings
            // 
            this.btnBackBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackBookings.Location = new System.Drawing.Point(881, 500);
            this.btnBackBookings.Name = "btnBackBookings";
            this.btnBackBookings.Size = new System.Drawing.Size(114, 34);
            this.btnBackBookings.TabIndex = 32;
            this.btnBackBookings.Text = "Back";
            this.btnBackBookings.UseVisualStyleBackColor = true;
            this.btnBackBookings.Click += new System.EventHandler(this.btnBackBookings_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 553);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnClearBooking);
            this.Controls.Add(this.btnBackBookings);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelers)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.ResumeLayout(false);

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