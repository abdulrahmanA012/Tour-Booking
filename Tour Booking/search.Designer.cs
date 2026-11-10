namespace Tour_Booking
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            btnsearch = new Button();
            lblform = new Label();
            lblto = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnclear = new Button();
            dgvsearch = new DataGridView();
            FLGHT_NUM = new DataGridViewTextBoxColumn();
            SOURCE_PLACE = new DataGridViewTextBoxColumn();
            DEC_PLACE = new DataGridViewTextBoxColumn();
            LUNCH_TIME = new DataGridViewTextBoxColumn();
            NUM_OF_STATE = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvsearch).BeginInit();
            SuspendLayout();
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(615, 279);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // lblform
            // 
            lblform.AutoSize = true;
            lblform.ForeColor = Color.Black;
            lblform.Location = new Point(544, 72);
            lblform.Name = "lblform";
            lblform.Size = new Size(50, 20);
            lblform.TabIndex = 4;
            lblform.Text = "Form :";
            // 
            // lblto
            // 
            lblto.AutoSize = true;
            lblto.Location = new Point(562, 121);
            lblto.Name = "lblto";
            lblto.Size = new Size(32, 20);
            lblto.TabIndex = 5;
            lblto.Text = "To :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(600, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(600, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(615, 328);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 8;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // dgvsearch
            // 
            dgvsearch.BackgroundColor = Color.White;
            dgvsearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsearch.Columns.AddRange(new DataGridViewColumn[] { FLGHT_NUM, SOURCE_PLACE, DEC_PLACE, LUNCH_TIME, NUM_OF_STATE, PRICE });
            dgvsearch.Location = new Point(0, 1);
            dgvsearch.Name = "dgvsearch";
            dgvsearch.RowHeadersWidth = 51;
            dgvsearch.Size = new Size(525, 397);
            dgvsearch.TabIndex = 10;
            dgvsearch.Visible = false;
            // 
            // FLGHT_NUM
            // 
            FLGHT_NUM.HeaderText = "FLGHT_NUM";
            FLGHT_NUM.MinimumWidth = 6;
            FLGHT_NUM.Name = "FLGHT_NUM";
            FLGHT_NUM.Width = 125;
            // 
            // SOURCE_PLACE
            // 
            SOURCE_PLACE.HeaderText = "SOURCE_PLACE";
            SOURCE_PLACE.MinimumWidth = 6;
            SOURCE_PLACE.Name = "SOURCE_PLACE";
            SOURCE_PLACE.Width = 125;
            // 
            // DEC_PLACE
            // 
            DEC_PLACE.HeaderText = "DEC_PLACE";
            DEC_PLACE.MinimumWidth = 6;
            DEC_PLACE.Name = "DEC_PLACE";
            DEC_PLACE.Width = 125;
            // 
            // LUNCH_TIME
            // 
            LUNCH_TIME.HeaderText = "LUNCH_TIME";
            LUNCH_TIME.MinimumWidth = 6;
            LUNCH_TIME.Name = "LUNCH_TIME";
            LUNCH_TIME.Width = 125;
            // 
            // NUM_OF_STATE
            // 
            NUM_OF_STATE.HeaderText = "NUM_OF_STATE";
            NUM_OF_STATE.MinimumWidth = 6;
            NUM_OF_STATE.Name = "NUM_OF_STATE";
            NUM_OF_STATE.Width = 125;
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.MinimumWidth = 6;
            PRICE.Name = "PRICE";
            PRICE.Width = 60;
            // 
            // btnback
            // 
            btnback.BackColor = Color.Blue;
            btnback.ForeColor = Color.Black;
            btnback.Location = new Point(24, 404);
            btnback.Name = "btnback";
            btnback.Size = new Size(134, 34);
            btnback.TabIndex = 11;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Visible = false;
            btnback.Click += btnback_Click;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnback);
            Controls.Add(dgvsearch);
            Controls.Add(btnclear);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblto);
            Controls.Add(lblform);
            Controls.Add(btnsearch);
            Name = "search";
            Text = "Search";
            FormClosed += search_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvsearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnsearch;
        private Label lblform;
        private Label lblto;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnclear;
        private DataGridView dgvsearch;
        private DataGridViewTextBoxColumn FLGHT_NUM;
        private DataGridViewTextBoxColumn SOURCE_PLACE;
        private DataGridViewTextBoxColumn DEC_PLACE;
        private DataGridViewTextBoxColumn LUNCH_TIME;
        private DataGridViewTextBoxColumn NUM_OF_STATE;
        private DataGridViewTextBoxColumn PRICE;
        private Button btnback;
    }
}