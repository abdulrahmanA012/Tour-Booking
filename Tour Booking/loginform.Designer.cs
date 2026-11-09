namespace Tour_Booking
{
    partial class loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            pnlloginform = new Panel();
            pcblogoarrow = new PictureBox();
            btnopengroupboxsignin = new Button();
            pcblogoalock = new PictureBox();
            btnopengroupboxsignup = new Button();
            pcbloginform = new PictureBox();
            grbsignup = new GroupBox();
            txtsignuppassword = new TextBox();
            lblsigninpassword = new Label();
            lblphonenumber = new Label();
            lblage = new Label();
            lblemale = new Label();
            txtage = new TextBox();
            txtphonenumber = new TextBox();
            txtlastname = new TextBox();
            txtemale = new TextBox();
            txtfristname = new TextBox();
            btnsignup = new Button();
            grbsignin = new GroupBox();
            lblusername = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lblpassword = new Label();
            btnsignin = new Button();
            pnlloginform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogoarrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcblogoalock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbloginform).BeginInit();
            grbsignup.SuspendLayout();
            grbsignin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlloginform
            // 
            pnlloginform.BackColor = Color.FromArgb(64, 64, 64);
            pnlloginform.Controls.Add(pcblogoarrow);
            pnlloginform.Controls.Add(btnopengroupboxsignin);
            pnlloginform.Controls.Add(pcblogoalock);
            pnlloginform.Controls.Add(btnopengroupboxsignup);
            pnlloginform.Dock = DockStyle.Left;
            pnlloginform.Location = new Point(0, 0);
            pnlloginform.Name = "pnlloginform";
            pnlloginform.Size = new Size(200, 489);
            pnlloginform.TabIndex = 0;
            // 
            // pcblogoarrow
            // 
            pcblogoarrow.Image = (Image)resources.GetObject("pcblogoarrow.Image");
            pcblogoarrow.Location = new Point(3, 98);
            pcblogoarrow.Name = "pcblogoarrow";
            pcblogoarrow.Size = new Size(67, 57);
            pcblogoarrow.SizeMode = PictureBoxSizeMode.Zoom;
            pcblogoarrow.TabIndex = 5;
            pcblogoarrow.TabStop = false;
            // 
            // btnopengroupboxsignin
            // 
            btnopengroupboxsignin.Location = new Point(76, 204);
            btnopengroupboxsignin.Name = "btnopengroupboxsignin";
            btnopengroupboxsignin.Size = new Size(94, 29);
            btnopengroupboxsignin.TabIndex = 4;
            btnopengroupboxsignin.Text = "Sign in ";
            btnopengroupboxsignin.UseVisualStyleBackColor = true;
            btnopengroupboxsignin.Click += btnopengroupboxsignin_Click;
            // 
            // pcblogoalock
            // 
            pcblogoalock.Image = (Image)resources.GetObject("pcblogoalock.Image");
            pcblogoalock.Location = new Point(3, 187);
            pcblogoalock.Name = "pcblogoalock";
            pcblogoalock.Size = new Size(67, 57);
            pcblogoalock.SizeMode = PictureBoxSizeMode.Zoom;
            pcblogoalock.TabIndex = 0;
            pcblogoalock.TabStop = false;
            // 
            // btnopengroupboxsignup
            // 
            btnopengroupboxsignup.Location = new Point(76, 110);
            btnopengroupboxsignup.Name = "btnopengroupboxsignup";
            btnopengroupboxsignup.Size = new Size(94, 33);
            btnopengroupboxsignup.TabIndex = 2;
            btnopengroupboxsignup.Text = "Sign up";
            btnopengroupboxsignup.UseVisualStyleBackColor = true;
            btnopengroupboxsignup.Click += btnopengroupboxsignup_Click;
            // 
            // pcbloginform
            // 
            pcbloginform.Image = Properties.Resources.WhatsApp_Image_2026_11_06_at_10_01_48_AM;
            pcbloginform.Location = new Point(194, 0);
            pcbloginform.Name = "pcbloginform";
            pcbloginform.Size = new Size(690, 489);
            pcbloginform.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbloginform.TabIndex = 6;
            pcbloginform.TabStop = false;
            pcbloginform.Tag = "";
            // 
            // grbsignup
            // 
            grbsignup.BackColor = Color.Gray;
            grbsignup.Controls.Add(txtsignuppassword);
            grbsignup.Controls.Add(lblsigninpassword);
            grbsignup.Controls.Add(lblphonenumber);
            grbsignup.Controls.Add(lblage);
            grbsignup.Controls.Add(lblemale);
            grbsignup.Controls.Add(txtage);
            grbsignup.Controls.Add(txtphonenumber);
            grbsignup.Controls.Add(txtlastname);
            grbsignup.Controls.Add(txtemale);
            grbsignup.Controls.Add(txtfristname);
            grbsignup.Controls.Add(btnsignup);
            grbsignup.Location = new Point(547, 61);
            grbsignup.Name = "grbsignup";
            grbsignup.Size = new Size(326, 396);
            grbsignup.TabIndex = 6;
            grbsignup.TabStop = false;
            grbsignup.Visible = false;
            // 
            // txtsignuppassword
            // 
            txtsignuppassword.Location = new Point(107, 295);
            txtsignuppassword.Name = "txtsignuppassword";
            txtsignuppassword.Size = new Size(125, 27);
            txtsignuppassword.TabIndex = 16;
            // 
            // lblsigninpassword
            // 
            lblsigninpassword.AutoSize = true;
            lblsigninpassword.Location = new Point(24, 302);
            lblsigninpassword.Name = "lblsigninpassword";
            lblsigninpassword.Size = new Size(70, 20);
            lblsigninpassword.TabIndex = 15;
            lblsigninpassword.Text = "Password";
            // 
            // lblphonenumber
            // 
            lblphonenumber.AutoSize = true;
            lblphonenumber.Location = new Point(0, 257);
            lblphonenumber.Name = "lblphonenumber";
            lblphonenumber.Size = new Size(108, 20);
            lblphonenumber.TabIndex = 14;
            lblphonenumber.Text = "Phone Number";
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Location = new Point(35, 207);
            lblage.Name = "lblage";
            lblage.Size = new Size(36, 20);
            lblage.TabIndex = 13;
            lblage.Text = "Age";
            // 
            // lblemale
            // 
            lblemale.AutoSize = true;
            lblemale.Location = new Point(35, 152);
            lblemale.Name = "lblemale";
            lblemale.Size = new Size(50, 20);
            lblemale.TabIndex = 12;
            lblemale.Text = "Emale";
            // 
            // txtage
            // 
            txtage.Location = new Point(107, 200);
            txtage.Name = "txtage";
            txtage.Size = new Size(125, 27);
            txtage.TabIndex = 11;
            // 
            // txtphonenumber
            // 
            txtphonenumber.Location = new Point(107, 250);
            txtphonenumber.Name = "txtphonenumber";
            txtphonenumber.Size = new Size(125, 27);
            txtphonenumber.TabIndex = 10;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(181, 84);
            txtlastname.Name = "txtlastname";
            txtlastname.PlaceholderText = "Last Name";
            txtlastname.Size = new Size(125, 27);
            txtlastname.TabIndex = 9;
            // 
            // txtemale
            // 
            txtemale.Location = new Point(107, 145);
            txtemale.Name = "txtemale";
            txtemale.Size = new Size(125, 27);
            txtemale.TabIndex = 8;
            // 
            // txtfristname
            // 
            txtfristname.Location = new Point(24, 84);
            txtfristname.Name = "txtfristname";
            txtfristname.PlaceholderText = "Frist Name";
            txtfristname.Size = new Size(125, 27);
            txtfristname.TabIndex = 7;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.DodgerBlue;
            btnsignup.Location = new Point(107, 337);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(113, 44);
            btnsignup.TabIndex = 6;
            btnsignup.Text = "Sign up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // grbsignin
            // 
            grbsignin.BackColor = Color.Gray;
            grbsignin.BackgroundImage = (Image)resources.GetObject("grbsignin.BackgroundImage");
            grbsignin.BackgroundImageLayout = ImageLayout.Stretch;
            grbsignin.Controls.Add(lblusername);
            grbsignin.Controls.Add(txtusername);
            grbsignin.Controls.Add(txtpassword);
            grbsignin.Controls.Add(lblpassword);
            grbsignin.Controls.Add(btnsignin);
            grbsignin.Location = new Point(215, 61);
            grbsignin.Name = "grbsignin";
            grbsignin.Size = new Size(326, 396);
            grbsignin.TabIndex = 17;
            grbsignin.TabStop = false;
            grbsignin.Visible = false;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Gray;
            lblusername.Location = new Point(24, 170);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(78, 20);
            lblusername.TabIndex = 18;
            lblusername.Text = "UserName";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(107, 167);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter UserName";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 17;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(107, 224);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "************";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 16;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(24, 227);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(70, 20);
            lblpassword.TabIndex = 15;
            lblpassword.Text = "Password";
            // 
            // btnsignin
            // 
            btnsignin.BackColor = Color.DodgerBlue;
            btnsignin.Location = new Point(107, 337);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(113, 44);
            btnsignin.TabIndex = 6;
            btnsignin.Text = "Sign in";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 489);
            Controls.Add(grbsignin);
            Controls.Add(grbsignup);
            Controls.Add(pcbloginform);
            Controls.Add(pnlloginform);
            Name = "loginform";
            Text = "Login Form";
            pnlloginform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcblogoarrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcblogoalock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbloginform).EndInit();
            grbsignup.ResumeLayout(false);
            grbsignup.PerformLayout();
            grbsignin.ResumeLayout(false);
            grbsignin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlloginform;
        private Button btnopengroupboxsignup;
        private PictureBox pcblogoalock;
        private Button btnopengroupboxsignin;
        private PictureBox pcblogoarrow;
        private PictureBox pcbloginform;
        private GroupBox grbsignup;
        private Label lblphonenumber;
        private Label lblage;
        private Label lblemale;
        private TextBox txtage;
        private TextBox txtphonenumber;
        private TextBox txtlastname;
        private TextBox txtemale;
        private TextBox txtfristname;
        private Button btnsignup;
        private TextBox txtsignuppassword;
        private Label lblsigninpassword;
        private GroupBox grbsignin;
        private Label lblusername;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblpassword;
        private Button btnsignin;
    }
}
