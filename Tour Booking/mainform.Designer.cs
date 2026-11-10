namespace Tour_Booking
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            pnlmainform = new Panel();
            btnbooking = new Button();
            pcbbooking = new PictureBox();
            btnmanagebooking = new Button();
            pcbprofile = new PictureBox();
            pcbsearch = new PictureBox();
            btnprofie = new Button();
            pcbmanagebooking = new PictureBox();
            btnsearchmainform = new Button();
            pnlphotomainform = new Panel();
            pnlmainform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbbooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbprofile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbsearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbmanagebooking).BeginInit();
            SuspendLayout();
            // 
            // pnlmainform
            // 
            pnlmainform.BackColor = Color.FromArgb(40, 40, 40);
            pnlmainform.Controls.Add(btnbooking);
            pnlmainform.Controls.Add(pcbbooking);
            pnlmainform.Controls.Add(btnmanagebooking);
            pnlmainform.Controls.Add(pcbprofile);
            pnlmainform.Controls.Add(pcbsearch);
            pnlmainform.Controls.Add(btnprofie);
            pnlmainform.Controls.Add(pcbmanagebooking);
            pnlmainform.Controls.Add(btnsearchmainform);
            pnlmainform.Dock = DockStyle.Left;
            pnlmainform.Location = new Point(0, 0);
            pnlmainform.Name = "pnlmainform";
            pnlmainform.Size = new Size(218, 419);
            pnlmainform.TabIndex = 1;
            // 
            // btnbooking
            // 
            btnbooking.Location = new Point(73, 233);
            btnbooking.Name = "btnbooking";
            btnbooking.Size = new Size(94, 29);
            btnbooking.TabIndex = 9;
            btnbooking.Text = "Booking";
            btnbooking.UseVisualStyleBackColor = true;
            // 
            // pcbbooking
            // 
            pcbbooking.Image = (Image)resources.GetObject("pcbbooking.Image");
            pcbbooking.Location = new Point(-3, 215);
            pcbbooking.Name = "pcbbooking";
            pcbbooking.Size = new Size(70, 64);
            pcbbooking.SizeMode = PictureBoxSizeMode.Zoom;
            pcbbooking.TabIndex = 8;
            pcbbooking.TabStop = false;
            // 
            // btnmanagebooking
            // 
            btnmanagebooking.Location = new Point(73, 308);
            btnmanagebooking.Name = "btnmanagebooking";
            btnmanagebooking.Size = new Size(136, 29);
            btnmanagebooking.TabIndex = 7;
            btnmanagebooking.Text = "Manage Booking";
            btnmanagebooking.UseVisualStyleBackColor = true;
            // 
            // pcbprofile
            // 
            pcbprofile.Image = (Image)resources.GetObject("pcbprofile.Image");
            pcbprofile.Location = new Point(0, 60);
            pcbprofile.Name = "pcbprofile";
            pcbprofile.Size = new Size(67, 57);
            pcbprofile.SizeMode = PictureBoxSizeMode.Zoom;
            pcbprofile.TabIndex = 6;
            pcbprofile.TabStop = false;
            // 
            // pcbsearch
            // 
            pcbsearch.Image = (Image)resources.GetObject("pcbsearch.Image");
            pcbsearch.Location = new Point(-3, 134);
            pcbsearch.Name = "pcbsearch";
            pcbsearch.Size = new Size(70, 64);
            pcbsearch.SizeMode = PictureBoxSizeMode.Zoom;
            pcbsearch.TabIndex = 5;
            pcbsearch.TabStop = false;
            // 
            // btnprofie
            // 
            btnprofie.Location = new Point(73, 73);
            btnprofie.Name = "btnprofie";
            btnprofie.Size = new Size(94, 29);
            btnprofie.TabIndex = 4;
            btnprofie.Text = "Profie";
            btnprofie.UseVisualStyleBackColor = true;
            btnprofie.Click += btnprofie_Click;
            // 
            // pcbmanagebooking
            // 
            pcbmanagebooking.Image = (Image)resources.GetObject("pcbmanagebooking.Image");
            pcbmanagebooking.Location = new Point(0, 294);
            pcbmanagebooking.Name = "pcbmanagebooking";
            pcbmanagebooking.Size = new Size(67, 57);
            pcbmanagebooking.SizeMode = PictureBoxSizeMode.Zoom;
            pcbmanagebooking.TabIndex = 0;
            pcbmanagebooking.TabStop = false;
            // 
            // btnsearchmainform
            // 
            btnsearchmainform.Location = new Point(70, 154);
            btnsearchmainform.Name = "btnsearchmainform";
            btnsearchmainform.Size = new Size(145, 26);
            btnsearchmainform.TabIndex = 2;
            btnsearchmainform.Text = "Search about travel";
            btnsearchmainform.TextAlign = ContentAlignment.MiddleLeft;
            btnsearchmainform.UseVisualStyleBackColor = true;
            btnsearchmainform.Click += btnsearchmainform_Click;
            // 
            // pnlphotomainform
            // 
            pnlphotomainform.BackgroundImage = (Image)resources.GetObject("pnlphotomainform.BackgroundImage");
            pnlphotomainform.BackgroundImageLayout = ImageLayout.Stretch;
            pnlphotomainform.Location = new Point(215, 0);
            pnlphotomainform.Name = "pnlphotomainform";
            pnlphotomainform.Size = new Size(519, 420);
            pnlphotomainform.TabIndex = 2;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(733, 419);
            Controls.Add(pnlphotomainform);
            Controls.Add(pnlmainform);
            Name = "mainform";
            Text = "Main Form";
            FormClosed += mainform_FormClosed;
            pnlmainform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbbooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbprofile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbsearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbmanagebooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlmainform;
        private PictureBox pcbsearch;
        private Button btnprofie;
        private PictureBox pcbmanagebooking;
        private Button btnsearchmainform;
        private Button btnmanagebooking;
        private PictureBox pcbprofile;
        private PictureBox pcbbooking;
        private Button btnbooking;
        private Panel pnlphotomainform;
    }
}