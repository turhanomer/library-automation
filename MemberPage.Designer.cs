namespace library_automation
{
    partial class MemberPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberPage));
            btn_search = new Button();
            ımageList1 = new ImageList(components);
            txt_bookID = new TextBox();
            btn_refresh = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            bookid = new DataGridViewTextBoxColumn();
            bookname = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            lang = new DataGridViewTextBoxColumn();
            publishhouse = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            numberofpages = new DataGridViewTextBoxColumn();
            yearofissue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.SandyBrown;
            btn_search.Cursor = Cursors.Hand;
            btn_search.Font = new Font("Arial Rounded MT Bold", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.ForeColor = SystemColors.ControlLightLight;
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.ImageKey = "search.png";
            btn_search.ImageList = ımageList1;
            btn_search.Location = new Point(119, 74);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(103, 37);
            btn_search.TabIndex = 2;
            btn_search.Text = "Search";
            btn_search.TextAlign = ContentAlignment.MiddleRight;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "refresh.png");
            ımageList1.Images.SetKeyName(1, "logout.png");
            ımageList1.Images.SetKeyName(2, "user (1).png");
            ımageList1.Images.SetKeyName(3, "search.png");
            // 
            // txt_bookID
            // 
            txt_bookID.Cursor = Cursors.IBeam;
            txt_bookID.Location = new Point(228, 81);
            txt_bookID.Name = "txt_bookID";
            txt_bookID.Size = new Size(150, 26);
            txt_bookID.TabIndex = 2;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.MediumTurquoise;
            btn_refresh.Cursor = Cursors.Hand;
            btn_refresh.Font = new Font("Arial Rounded MT Bold", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_refresh.ForeColor = SystemColors.ControlLightLight;
            btn_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_refresh.ImageKey = "refresh.png";
            btn_refresh.ImageList = ımageList1;
            btn_refresh.Location = new Point(384, 74);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(103, 37);
            btn_refresh.TabIndex = 3;
            btn_refresh.Text = "Refresh";
            btn_refresh.TextAlign = ContentAlignment.MiddleRight;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1211, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookid, bookname, author, lang, publishhouse, type, amount, numberofpages, yearofissue });
            dataGridView1.Location = new Point(119, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(1046, 530);
            dataGridView1.TabIndex = 27;
            // 
            // bookid
            // 
            bookid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookid.HeaderText = "BOOK ID";
            bookid.MinimumWidth = 6;
            bookid.Name = "bookid";
            bookid.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // bookname
            // 
            bookname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookname.HeaderText = "BOOK NAME";
            bookname.MinimumWidth = 6;
            bookname.Name = "bookname";
            bookname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // author
            // 
            author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author.HeaderText = "AUTHOR";
            author.MinimumWidth = 6;
            author.Name = "author";
            author.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lang
            // 
            lang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lang.HeaderText = "LANGUAGE";
            lang.MinimumWidth = 6;
            lang.Name = "lang";
            lang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // publishhouse
            // 
            publishhouse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            publishhouse.HeaderText = "PUBLISH HOUSE";
            publishhouse.MinimumWidth = 2;
            publishhouse.Name = "publishhouse";
            publishhouse.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            type.HeaderText = "TYPE";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amount.HeaderText = "AMOUNT";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // numberofpages
            // 
            numberofpages.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numberofpages.HeaderText = "NUMBER OF PAGES";
            numberofpages.MinimumWidth = 6;
            numberofpages.Name = "numberofpages";
            numberofpages.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // yearofissue
            // 
            yearofissue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            yearofissue.HeaderText = "YEAR OF ISSUE";
            yearofissue.MinimumWidth = 6;
            yearofissue.Name = "yearofissue";
            yearofissue.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MemberPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 712);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_refresh);
            Controls.Add(txt_bookID);
            Controls.Add(btn_search);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberPage";
            Load += MemberPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_search;
        private TextBox txt_bookID;
        private Button btn_refresh;
        private ImageList ımageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn bookid;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn lang;
        private DataGridViewTextBoxColumn publishhouse;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn numberofpages;
        private DataGridViewTextBoxColumn yearofissue;
    }
}