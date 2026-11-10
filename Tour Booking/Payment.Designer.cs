using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tour_booking_update
{
    partial class Payment
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTitle = new Label();
            lblPersonal = new Label();
            lblName = new Label();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtStreet1 = new TextBox();
            txtCity = new TextBox();
            txtPostal = new TextBox();
            cmbCountry = new ComboBox();
            lblCardSection = new Label();
            lblCardNumber = new Label();
            txtCardNumber = new TextBox();
            lblExpiry = new Label();
            txtExpiry = new TextBox();
            lblCVV = new Label();
            txtCVV = new TextBox();
            lblCardTitle = new Label();
            txtCardTitle = new TextBox();
            chkRemember = new CheckBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            btnConfirm = new Button();
            btnsubmet = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(177, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 62);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Payment";
            // 
            // lblPersonal
            // 
            lblPersonal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPersonal.ForeColor = Color.FromArgb(50, 50, 50);
            lblPersonal.Location = new Point(23, 74);
            lblPersonal.Name = "lblPersonal";
            lblPersonal.Size = new Size(286, 29);
            lblPersonal.TabIndex = 26;
            lblPersonal.Text = "Personal Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.ForeColor = Color.FromArgb(80, 80, 80);
            lblName.Location = new Point(21, 111);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 20);
            lblName.TabIndex = 25;
            lblName.Text = "Full Name ";
            // 
            // txtFirst
            // 
            txtFirst.BackColor = SystemColors.Info;
            txtFirst.BorderStyle = BorderStyle.FixedSingle;
            txtFirst.Font = new Font("Segoe UI", 10F);
            txtFirst.Location = new Point(25, 140);
            txtFirst.Margin = new Padding(3, 4, 3, 4);
            txtFirst.Name = "txtFirst";
            txtFirst.PlaceholderText = "First Name";
            txtFirst.Size = new Size(240, 30);
            txtFirst.TabIndex = 24;
            // 
            // txtLast
            // 
            txtLast.BackColor = SystemColors.HighlightText;
            txtLast.BorderStyle = BorderStyle.FixedSingle;
            txtLast.Font = new Font("Segoe UI", 10F);
            txtLast.ForeColor = SystemColors.MenuText;
            txtLast.Location = new Point(280, 140);
            txtLast.Margin = new Padding(3, 4, 3, 4);
            txtLast.Name = "txtLast";
            txtLast.PlaceholderText = "Last Name";
            txtLast.Size = new Size(240, 30);
            txtLast.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(25, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email ";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(25, 216);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 30);
            txtEmail.TabIndex = 21;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.Location = new Point(280, 189);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 20);
            lblPhone.TabIndex = 20;
            lblPhone.Text = "Phone ";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(280, 216);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 30);
            txtPhone.TabIndex = 19;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(25, 266);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Address";
            // 
            // txtStreet1
            // 
            txtStreet1.BorderStyle = BorderStyle.FixedSingle;
            txtStreet1.Font = new Font("Segoe UI", 10F);
            txtStreet1.Location = new Point(25, 294);
            txtStreet1.Margin = new Padding(3, 4, 3, 4);
            txtStreet1.Name = "txtStreet1";
            txtStreet1.PlaceholderText = "Street Address";
            txtStreet1.Size = new Size(495, 30);
            txtStreet1.TabIndex = 17;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(25, 336);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(160, 30);
            txtCity.TabIndex = 16;
            // 
            // txtPostal
            // 
            txtPostal.BorderStyle = BorderStyle.FixedSingle;
            txtPostal.Font = new Font("Segoe UI", 10F);
            txtPostal.Location = new Point(197, 336);
            txtPostal.Margin = new Padding(3, 4, 3, 4);
            txtPostal.Name = "txtPostal";
            txtPostal.PlaceholderText = "Postal Code";
            txtPostal.Size = new Size(137, 30);
            txtPostal.TabIndex = 15;
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = SystemColors.Info;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.Font = new Font("Segoe UI", 10F);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Egypt", "Romania", "United States", "United Kingdom", "Germany", "France" });
            cmbCountry.Location = new Point(345, 336);
            cmbCountry.Margin = new Padding(3, 4, 3, 4);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(174, 31);
            cmbCountry.TabIndex = 14;
            // 
            // lblCardSection
            // 
            lblCardSection.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCardSection.Location = new Point(23, 400);
            lblCardSection.Name = "lblCardSection";
            lblCardSection.Size = new Size(286, 29);
            lblCardSection.TabIndex = 13;
            lblCardSection.Text = "Card Information";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Segoe UI", 9F);
            lblCardNumber.Location = new Point(25, 440);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(102, 20);
            lblCardNumber.TabIndex = 12;
            lblCardNumber.Text = "Card Number ";
            // 
            // txtCardNumber
            // 
            txtCardNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCardNumber.Font = new Font("Segoe UI", 11F);
            txtCardNumber.Location = new Point(25, 466);
            txtCardNumber.Margin = new Padding(3, 4, 3, 4);
            txtCardNumber.MaxLength = 19;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(495, 32);
            txtCardNumber.TabIndex = 11;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI", 9F);
            lblExpiry.Location = new Point(25, 520);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(53, 20);
            lblExpiry.TabIndex = 10;
            lblExpiry.Text = "Expiry ";
            // 
            // txtExpiry
            // 
            txtExpiry.BorderStyle = BorderStyle.FixedSingle;
            txtExpiry.Font = new Font("Segoe UI", 11F);
            txtExpiry.ForeColor = Color.Gray;
            txtExpiry.Location = new Point(25, 546);
            txtExpiry.Margin = new Padding(3, 4, 3, 4);
            txtExpiry.MaxLength = 7;
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(228, 32);
            txtExpiry.TabIndex = 9;
            txtExpiry.Text = "MM / YY";
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Segoe UI", 9F);
            lblCVV.Location = new Point(286, 520);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(40, 20);
            lblCVV.TabIndex = 8;
            lblCVV.Text = "CVV ";
            // 
            // txtCVV
            // 
            txtCVV.BorderStyle = BorderStyle.FixedSingle;
            txtCVV.Font = new Font("Segoe UI", 11F);
            txtCVV.Location = new Point(286, 546);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.MaxLength = 4;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(234, 32);
            txtCVV.TabIndex = 7;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 9F);
            lblCardTitle.Location = new Point(25, 600);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(145, 20);
            lblCardTitle.TabIndex = 6;
            lblCardTitle.Text = "Card Title (Optional)";
            // 
            // txtCardTitle
            // 
            txtCardTitle.BorderStyle = BorderStyle.FixedSingle;
            txtCardTitle.Font = new Font("Segoe UI", 10F);
            txtCardTitle.ForeColor = Color.Gray;
            txtCardTitle.Location = new Point(25, 626);
            txtCardTitle.Margin = new Padding(3, 4, 3, 4);
            txtCardTitle.Name = "txtCardTitle";
            txtCardTitle.Size = new Size(495, 30);
            txtCardTitle.TabIndex = 5;
            txtCardTitle.Text = "e.g. My Cashback Card";
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Checked = true;
            chkRemember.CheckState = CheckState.Checked;
            chkRemember.Font = new Font("Segoe UI", 9.5F);
            chkRemember.Location = new Point(25, 680);
            chkRemember.Margin = new Padding(3, 4, 3, 4);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(172, 25);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "Remember this card";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9F);
            lblAmount.Location = new Point(24, 741);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(139, 20);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Authorized Amount";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Font = new Font("Segoe UI", 11F);
            txtAmount.Location = new Point(25, 770);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(228, 32);
            txtAmount.TabIndex = 1;
            txtAmount.Text = "0.00";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.RoyalBlue;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.DarkTurquoise;
            btnConfirm.Location = new Point(25, 860);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(495, 59);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "CONFIRM PAYMENT";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnsubmet
            // 
            btnsubmet.Location = new Point(330, 700);
            btnsubmet.Name = "btnsubmet";
            btnsubmet.Size = new Size(123, 29);
            btnsubmet.TabIndex = 29;
            btnsubmet.Text = "Submet";
            btnsubmet.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 946);
            Controls.Add(btnsubmet);
            Controls.Add(btnConfirm);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(chkRemember);
            Controls.Add(txtCardTitle);
            Controls.Add(lblCardTitle);
            Controls.Add(txtCVV);
            Controls.Add(lblCVV);
            Controls.Add(txtExpiry);
            Controls.Add(lblExpiry);
            Controls.Add(txtCardNumber);
            Controls.Add(lblCardNumber);
            Controls.Add(lblCardSection);
            Controls.Add(cmbCountry);
            Controls.Add(txtPostal);
            Controls.Add(txtCity);
            Controls.Add(txtStreet1);
            Controls.Add(lblAddress);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(lblName);
            Controls.Add(lblPersonal);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment ";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Title
        private Label lblTitle;

        // Personal
        private Label lblPersonal;
        private Label lblName;
        private TextBox txtFirst;
        private TextBox txtLast;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtStreet1;
        private TextBox txtCity;
        private TextBox txtPostal;
        private ComboBox cmbCountry;

        // Card
        private Label lblCardSection;
        private Label lblCardNumber;
        private TextBox txtCardNumber;
        private Label lblExpiry;
        private TextBox txtExpiry;
        private Label lblCVV;
        private TextBox txtCVV;
        private Label lblCardTitle;
        private TextBox txtCardTitle;
        private CheckBox chkRemember;

        // Amount + Button
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnConfirm;
        private Button btnsubmet;
    }
}