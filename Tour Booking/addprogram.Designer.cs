namespace Tour_Booking
{
    partial class addprogram
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpAdd = new GroupBox();
            txtDescription = new TextBox();
            lblDestination = new TextBox();
            lblImage = new Label();
            pbTour = new PictureBox();
            btnBrowse = new Button();
            lblDescription = new Label();
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            lblEnd = new Label();
            dtpEnd = new DateTimePicker();
            lblDuration = new Label();
            nudDuration = new NumericUpDown();
            lblMax = new Label();
            nudMaxParticipants = new NumericUpDown();
            lbldetination = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblRating = new Label();
            txtRating = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            pnlHeader.SuspendLayout();
            grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxParticipants).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(225, 245, 238);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(827, 94);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(8, 80, 65);
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add a program ";
            // 
            // grpAdd
            // 
            grpAdd.BackColor = Color.White;
            grpAdd.Controls.Add(txtDescription);
            grpAdd.Controls.Add(lblDestination);
            grpAdd.Controls.Add(lblImage);
            grpAdd.Controls.Add(pbTour);
            grpAdd.Controls.Add(btnBrowse);
            grpAdd.Controls.Add(lblDescription);
            grpAdd.Controls.Add(lblStart);
            grpAdd.Controls.Add(dtpStart);
            grpAdd.Controls.Add(lblEnd);
            grpAdd.Controls.Add(dtpEnd);
            grpAdd.Controls.Add(lblDuration);
            grpAdd.Controls.Add(nudDuration);
            grpAdd.Controls.Add(lblMax);
            grpAdd.Controls.Add(nudMaxParticipants);
            grpAdd.Controls.Add(lbldetination);
            grpAdd.Controls.Add(lblName);
            grpAdd.Controls.Add(txtName);
            grpAdd.Controls.Add(lblCategory);
            grpAdd.Controls.Add(cmbCategory);
            grpAdd.Controls.Add(lblRating);
            grpAdd.Controls.Add(txtRating);
            grpAdd.Controls.Add(lblNotes);
            grpAdd.Controls.Add(txtNotes);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Controls.Add(btnClear);
            grpAdd.ForeColor = Color.FromArgb(8, 80, 65);
            grpAdd.Location = new Point(18, 115);
            grpAdd.Margin = new Padding(3, 4, 3, 4);
            grpAdd.Name = "grpAdd";
            grpAdd.Padding = new Padding(3, 4, 3, 4);
            grpAdd.Size = new Size(793, 612);
            grpAdd.TabIndex = 1;
            grpAdd.TabStop = false;
            grpAdd.Text = "Program details";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(427, 306);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(338, 92);
            txtDescription.TabIndex = 24;
            // 
            // lblDestination
            // 
            lblDestination.Location = new Point(424, 66);
            lblDestination.Margin = new Padding(3, 4, 3, 4);
            lblDestination.MaxLength = 60;
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(338, 27);
            lblDestination.TabIndex = 23;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.ForeColor = Color.FromArgb(31, 42, 39);
            lblImage.Location = new Point(424, 429);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(84, 20);
            lblImage.TabIndex = 20;
            lblImage.Text = "Tour image";
            // 
            // pbTour
            // 
            pbTour.BorderStyle = BorderStyle.FixedSingle;
            pbTour.Location = new Point(424, 455);
            pbTour.Margin = new Padding(3, 4, 3, 4);
            pbTour.Name = "pbTour";
            pbTour.Size = new Size(341, 87);
            pbTour.SizeMode = PictureBoxSizeMode.Zoom;
            pbTour.TabIndex = 21;
            pbTour.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.White;
            btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(159, 179, 172);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.ForeColor = Color.FromArgb(31, 42, 39);
            btnBrowse.Location = new Point(640, 550);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(125, 38);
            btnBrowse.TabIndex = 22;
            btnBrowse.Text = "Browse image";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.FromArgb(31, 42, 39);
            lblDescription.Location = new Point(421, 280);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.ForeColor = Color.FromArgb(31, 42, 39);
            lblStart.Location = new Point(424, 200);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(74, 20);
            lblStart.TabIndex = 11;
            lblStart.Text = "Start date";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(424, 226);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(165, 27);
            dtpStart.TabIndex = 12;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.ForeColor = Color.FromArgb(31, 42, 39);
            lblEnd.Location = new Point(600, 200);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(68, 20);
            lblEnd.TabIndex = 13;
            lblEnd.Text = "End date";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd/MM/yyyy";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(600, 226);
            dtpEnd.Margin = new Padding(3, 4, 3, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(165, 27);
            dtpEnd.TabIndex = 14;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.ForeColor = Color.FromArgb(31, 42, 39);
            lblDuration.Location = new Point(424, 120);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(111, 20);
            lblDuration.TabIndex = 7;
            lblDuration.Text = "Duration (days)";
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(424, 146);
            nudDuration.Margin = new Padding(3, 4, 3, 4);
            nudDuration.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(90, 27);
            nudDuration.TabIndex = 8;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.ForeColor = Color.FromArgb(31, 42, 39);
            lblMax.Location = new Point(580, 120);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(119, 20);
            lblMax.TabIndex = 9;
            lblMax.Text = "Max participants";
            // 
            // nudMaxParticipants
            // 
            nudMaxParticipants.Location = new Point(580, 146);
            nudMaxParticipants.Margin = new Padding(3, 4, 3, 4);
            nudMaxParticipants.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudMaxParticipants.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxParticipants.Name = "nudMaxParticipants";
            nudMaxParticipants.Size = new Size(90, 27);
            nudMaxParticipants.TabIndex = 10;
            nudMaxParticipants.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lbldetination
            // 
            lbldetination.AutoSize = true;
            lbldetination.ForeColor = Color.FromArgb(31, 42, 39);
            lbldetination.Location = new Point(424, 40);
            lbldetination.Name = "lbldetination";
            lbldetination.Size = new Size(85, 20);
            lbldetination.TabIndex = 6;
            lbldetination.Text = "Destination";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(31, 42, 39);
            lblName.Location = new Point(18, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Program name";
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 66);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 60;
            txtName.Name = "txtName";
            txtName.Size = new Size(338, 27);
            txtName.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.FromArgb(31, 42, 39);
            lblCategory.Location = new Point(18, 120);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.ItemHeight = 20;
            cmbCategory.Items.AddRange(new object[] { "Adventure", "Historical", "Relaxation", "Family-friendly" });
            cmbCategory.Location = new Point(18, 146);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(338, 28);
            cmbCategory.TabIndex = 1;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.ForeColor = Color.FromArgb(31, 42, 39);
            lblRating.Location = new Point(18, 200);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(96, 20);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating (1-10)";
            // 
            // txtRating
            // 
            txtRating.Location = new Point(18, 226);
            txtRating.Margin = new Padding(3, 4, 3, 4);
            txtRating.MaxLength = 2;
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(338, 27);
            txtRating.TabIndex = 2;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.ForeColor = Color.FromArgb(31, 42, 39);
            lblNotes.Location = new Point(18, 280);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(48, 20);
            lblNotes.TabIndex = 3;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(18, 306);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(338, 92);
            txtNotes.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(15, 110, 86);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(18, 429);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 45);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add program";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(159, 179, 172);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(31, 42, 39);
            btnClear.Location = new Point(178, 429);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 45);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // addprogram
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 248);
            ClientSize = new Size(827, 704);
            Controls.Add(grpAdd);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "addprogram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Program";
            FormClosed += addprogram_FormClosed;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTour).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxParticipants).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbldetination;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown nudMaxParticipants;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbTour;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox lblDestination;
        private TextBox txtDescription;
    }
}
