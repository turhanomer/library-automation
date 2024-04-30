namespace library_automation
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            clear_btn = new Button();
            ımageList1 = new ImageList(components);
            update_btn = new Button();
            delete_btn = new Button();
            create_btn = new Button();
            txt_authorization = new TextBox();
            label7 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            txt_surname = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            SURNAME = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            bookid = new DataGridViewTextBoxColumn();
            bookname = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            lang = new DataGridViewTextBoxColumn();
            publishhouse = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            numberofpages = new DataGridViewTextBoxColumn();
            yearofissue = new DataGridViewTextBoxColumn();
            label9 = new Label();
            groupBox2 = new GroupBox();
            yearofissue_txt = new TextBox();
            numberofpages_txt = new TextBox();
            txt_yearofissue = new Label();
            txt_numberofpages = new Label();
            lang_txt = new TextBox();
            btn_bookclear = new Button();
            btn_bookupdate = new Button();
            btn_bookdelete = new Button();
            btn_bookadd = new Button();
            amount_txt = new TextBox();
            txt_amount = new Label();
            type_txt = new TextBox();
            publishhouse_txt = new TextBox();
            txt_author = new TextBox();
            txt_bookname = new TextBox();
            txt_bookid = new TextBox();
            txt_type = new Label();
            txt_publishhouse = new Label();
            txt_lang = new Label();
            txt_bookauthor = new Label();
            label15 = new Label();
            label16 = new Label();
            textBox1 = new TextBox();
            btn_searchMember = new Button();
            btn_refreshMember = new Button();
            btn_refreshBook = new Button();
            btn_searchBook = new Button();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(clear_btn);
            groupBox1.Controls.Add(update_btn);
            groupBox1.Controls.Add(delete_btn);
            groupBox1.Controls.Add(create_btn);
            groupBox1.Controls.Add(txt_authorization);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(txt_surname);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 331);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "member transactions";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Cursor = Cursors.IBeam;
            maskedTextBox1.Location = new Point(151, 163);
            maskedTextBox1.Mask = "00/00/0000 90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(199, 26);
            maskedTextBox1.TabIndex = 22;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.Tomato;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.ForeColor = SystemColors.ButtonHighlight;
            clear_btn.ImageAlign = ContentAlignment.MiddleLeft;
            clear_btn.ImageKey = "broom.png";
            clear_btn.ImageList = ımageList1;
            clear_btn.Location = new Point(388, 276);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(174, 49);
            clear_btn.TabIndex = 21;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "add-button.png");
            ımageList1.Images.SetKeyName(1, "broom.png");
            ımageList1.Images.SetKeyName(2, "clear.png");
            ımageList1.Images.SetKeyName(3, "refresh.png");
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.MediumTurquoise;
            update_btn.Cursor = Cursors.Hand;
            update_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.ForeColor = SystemColors.ButtonHighlight;
            update_btn.ImageAlign = ContentAlignment.MiddleLeft;
            update_btn.ImageIndex = 3;
            update_btn.ImageList = ımageList1;
            update_btn.Location = new Point(388, 221);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(174, 49);
            update_btn.TabIndex = 20;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Red;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = SystemColors.ButtonHighlight;
            delete_btn.ImageAlign = ContentAlignment.MiddleLeft;
            delete_btn.ImageIndex = 2;
            delete_btn.ImageList = ımageList1;
            delete_btn.Location = new Point(388, 166);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(174, 49);
            delete_btn.TabIndex = 19;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // create_btn
            // 
            create_btn.BackColor = Color.LimeGreen;
            create_btn.Cursor = Cursors.Hand;
            create_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            create_btn.ForeColor = SystemColors.ButtonHighlight;
            create_btn.ImageAlign = ContentAlignment.MiddleLeft;
            create_btn.ImageIndex = 0;
            create_btn.ImageList = ımageList1;
            create_btn.Location = new Point(388, 111);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(174, 49);
            create_btn.TabIndex = 18;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // txt_authorization
            // 
            txt_authorization.Cursor = Cursors.IBeam;
            txt_authorization.Location = new Point(149, 299);
            txt_authorization.Name = "txt_authorization";
            txt_authorization.Size = new Size(201, 26);
            txt_authorization.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(0, 295);
            label7.Name = "label7";
            label7.Size = new Size(147, 30);
            label7.TabIndex = 14;
            label7.Text = "Authorization:";
            // 
            // txt_password
            // 
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Location = new Point(149, 253);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(201, 26);
            txt_password.TabIndex = 13;
            // 
            // txt_username
            // 
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Location = new Point(149, 208);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(201, 26);
            txt_username.TabIndex = 12;
            // 
            // txt_surname
            // 
            txt_surname.Cursor = Cursors.IBeam;
            txt_surname.Location = new Point(149, 115);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(199, 26);
            txt_surname.TabIndex = 10;
            // 
            // txt_name
            // 
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Location = new Point(149, 70);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(201, 26);
            txt_name.TabIndex = 9;
            // 
            // txt_id
            // 
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Location = new Point(147, 22);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(201, 26);
            txt_id.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(0, 249);
            label6.Name = "label6";
            label6.Size = new Size(108, 30);
            label6.TabIndex = 7;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(0, 208);
            label5.Name = "label5";
            label5.Size = new Size(116, 30);
            label5.TabIndex = 6;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(0, 159);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 5;
            label4.Text = "Created Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 111);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 4;
            label3.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 66);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 22);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 2;
            label2.Text = "Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, SURNAME, Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(599, 317);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID.Width = 30;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            NAME.HeaderText = "NAME";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.SortMode = DataGridViewColumnSortMode.NotSortable;
            NAME.Width = 59;
            // 
            // SURNAME
            // 
            SURNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SURNAME.HeaderText = "SURNAME";
            SURNAME.MinimumWidth = 6;
            SURNAME.Name = "SURNAME";
            SURNAME.SortMode = DataGridViewColumnSortMode.NotSortable;
            SURNAME.Width = 87;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "CREATED TIME";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 115;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "USERNAME";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 95;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "PASSWORD";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 94;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "AUTHORIZATION";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 132;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(245, 12);
            label8.Name = "label8";
            label8.Size = new Size(146, 33);
            label8.TabIndex = 22;
            label8.Text = "Members";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1228, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { bookid, bookname, author, lang, publishhouse, type, amount, numberofpages, yearofissue });
            dataGridView2.Location = new Point(617, 91);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 49;
            dataGridView2.Size = new Size(677, 317);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // bookid
            // 
            bookid.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            bookid.HeaderText = "BOOK ID";
            bookid.MinimumWidth = 6;
            bookid.Name = "bookid";
            bookid.SortMode = DataGridViewColumnSortMode.NotSortable;
            bookid.Width = 67;
            // 
            // bookname
            // 
            bookname.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            bookname.HeaderText = "BOOK NAME";
            bookname.MinimumWidth = 6;
            bookname.Name = "bookname";
            bookname.SortMode = DataGridViewColumnSortMode.NotSortable;
            bookname.Width = 93;
            // 
            // author
            // 
            author.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            author.HeaderText = "AUTHOR";
            author.MinimumWidth = 6;
            author.Name = "author";
            author.SortMode = DataGridViewColumnSortMode.NotSortable;
            author.Width = 75;
            // 
            // lang
            // 
            lang.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            lang.HeaderText = "LANGUAGE";
            lang.MinimumWidth = 6;
            lang.Name = "lang";
            lang.SortMode = DataGridViewColumnSortMode.NotSortable;
            lang.Width = 93;
            // 
            // publishhouse
            // 
            publishhouse.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            publishhouse.HeaderText = "PUBLISH HOUSE";
            publishhouse.MinimumWidth = 2;
            publishhouse.Name = "publishhouse";
            publishhouse.SortMode = DataGridViewColumnSortMode.NotSortable;
            publishhouse.Width = 114;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            type.HeaderText = "TYPE";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.SortMode = DataGridViewColumnSortMode.NotSortable;
            type.Width = 49;
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            amount.HeaderText = "AMOUNT";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            amount.Width = 81;
            // 
            // numberofpages
            // 
            numberofpages.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            numberofpages.HeaderText = "NUMBER OF PAGES";
            numberofpages.MinimumWidth = 6;
            numberofpages.Name = "numberofpages";
            numberofpages.SortMode = DataGridViewColumnSortMode.NotSortable;
            numberofpages.Width = 95;
            // 
            // yearofissue
            // 
            yearofissue.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            yearofissue.HeaderText = "YEAR OF ISSUE";
            yearofissue.MinimumWidth = 6;
            yearofissue.Name = "yearofissue";
            yearofissue.SortMode = DataGridViewColumnSortMode.NotSortable;
            yearofissue.Width = 105;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Rounded MT Bold", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(922, 12);
            label9.Name = "label9";
            label9.Size = new Size(105, 33);
            label9.TabIndex = 25;
            label9.Text = "Books";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(yearofissue_txt);
            groupBox2.Controls.Add(numberofpages_txt);
            groupBox2.Controls.Add(txt_yearofissue);
            groupBox2.Controls.Add(txt_numberofpages);
            groupBox2.Controls.Add(lang_txt);
            groupBox2.Controls.Add(btn_bookclear);
            groupBox2.Controls.Add(btn_bookupdate);
            groupBox2.Controls.Add(btn_bookdelete);
            groupBox2.Controls.Add(btn_bookadd);
            groupBox2.Controls.Add(amount_txt);
            groupBox2.Controls.Add(txt_amount);
            groupBox2.Controls.Add(type_txt);
            groupBox2.Controls.Add(publishhouse_txt);
            groupBox2.Controls.Add(txt_author);
            groupBox2.Controls.Add(txt_bookname);
            groupBox2.Controls.Add(txt_bookid);
            groupBox2.Controls.Add(txt_type);
            groupBox2.Controls.Add(txt_publishhouse);
            groupBox2.Controls.Add(txt_lang);
            groupBox2.Controls.Add(txt_bookauthor);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(617, 414);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 331);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "book transactions";
            // 
            // yearofissue_txt
            // 
            yearofissue_txt.Cursor = Cursors.IBeam;
            yearofissue_txt.Location = new Point(510, 66);
            yearofissue_txt.Name = "yearofissue_txt";
            yearofissue_txt.Size = new Size(148, 26);
            yearofissue_txt.TabIndex = 26;
            // 
            // numberofpages_txt
            // 
            numberofpages_txt.Cursor = Cursors.IBeam;
            numberofpages_txt.Location = new Point(510, 26);
            numberofpages_txt.Name = "numberofpages_txt";
            numberofpages_txt.Size = new Size(148, 26);
            numberofpages_txt.TabIndex = 25;
            // 
            // txt_yearofissue
            // 
            txt_yearofissue.AutoSize = true;
            txt_yearofissue.BackColor = Color.Transparent;
            txt_yearofissue.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_yearofissue.Location = new Point(314, 66);
            txt_yearofissue.Name = "txt_yearofissue";
            txt_yearofissue.Size = new Size(143, 30);
            txt_yearofissue.TabIndex = 24;
            txt_yearofissue.Text = "Year Of Issue:";
            // 
            // txt_numberofpages
            // 
            txt_numberofpages.AutoSize = true;
            txt_numberofpages.BackColor = Color.Transparent;
            txt_numberofpages.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_numberofpages.Location = new Point(314, 22);
            txt_numberofpages.Name = "txt_numberofpages";
            txt_numberofpages.Size = new Size(190, 30);
            txt_numberofpages.TabIndex = 23;
            txt_numberofpages.Text = "Number Of Pages:";
            // 
            // lang_txt
            // 
            lang_txt.Cursor = Cursors.IBeam;
            lang_txt.Location = new Point(149, 159);
            lang_txt.Name = "lang_txt";
            lang_txt.Size = new Size(148, 26);
            lang_txt.TabIndex = 22;
            // 
            // btn_bookclear
            // 
            btn_bookclear.BackColor = Color.Tomato;
            btn_bookclear.Cursor = Cursors.Hand;
            btn_bookclear.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bookclear.ForeColor = SystemColors.ButtonHighlight;
            btn_bookclear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bookclear.ImageKey = "broom.png";
            btn_bookclear.ImageList = ımageList1;
            btn_bookclear.Location = new Point(403, 276);
            btn_bookclear.Name = "btn_bookclear";
            btn_bookclear.Size = new Size(174, 49);
            btn_bookclear.TabIndex = 21;
            btn_bookclear.Text = "Clear";
            btn_bookclear.UseVisualStyleBackColor = false;
            btn_bookclear.Click += btn_bookclear_Click;
            // 
            // btn_bookupdate
            // 
            btn_bookupdate.BackColor = Color.MediumTurquoise;
            btn_bookupdate.Cursor = Cursors.Hand;
            btn_bookupdate.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bookupdate.ForeColor = SystemColors.ButtonHighlight;
            btn_bookupdate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bookupdate.ImageKey = "refresh.png";
            btn_bookupdate.ImageList = ımageList1;
            btn_bookupdate.Location = new Point(403, 221);
            btn_bookupdate.Name = "btn_bookupdate";
            btn_bookupdate.Size = new Size(174, 49);
            btn_bookupdate.TabIndex = 20;
            btn_bookupdate.Text = "Update";
            btn_bookupdate.UseVisualStyleBackColor = false;
            btn_bookupdate.Click += btn_bookupdate_Click;
            // 
            // btn_bookdelete
            // 
            btn_bookdelete.BackColor = Color.Red;
            btn_bookdelete.Cursor = Cursors.Hand;
            btn_bookdelete.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bookdelete.ForeColor = SystemColors.ButtonHighlight;
            btn_bookdelete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bookdelete.ImageKey = "clear.png";
            btn_bookdelete.ImageList = ımageList1;
            btn_bookdelete.Location = new Point(403, 166);
            btn_bookdelete.Name = "btn_bookdelete";
            btn_bookdelete.Size = new Size(174, 49);
            btn_bookdelete.TabIndex = 19;
            btn_bookdelete.Text = "Delete";
            btn_bookdelete.UseVisualStyleBackColor = false;
            btn_bookdelete.Click += btn_bookdelete_Click;
            // 
            // btn_bookadd
            // 
            btn_bookadd.BackColor = Color.LimeGreen;
            btn_bookadd.Cursor = Cursors.Hand;
            btn_bookadd.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bookadd.ForeColor = SystemColors.ButtonHighlight;
            btn_bookadd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bookadd.ImageKey = "add-button.png";
            btn_bookadd.ImageList = ımageList1;
            btn_bookadd.Location = new Point(403, 111);
            btn_bookadd.Name = "btn_bookadd";
            btn_bookadd.Size = new Size(174, 49);
            btn_bookadd.TabIndex = 18;
            btn_bookadd.Text = "Create";
            btn_bookadd.UseVisualStyleBackColor = false;
            btn_bookadd.Click += btn_bookadd_Click;
            // 
            // amount_txt
            // 
            amount_txt.Cursor = Cursors.IBeam;
            amount_txt.Location = new Point(149, 299);
            amount_txt.Name = "amount_txt";
            amount_txt.Size = new Size(148, 26);
            amount_txt.TabIndex = 15;
            // 
            // txt_amount
            // 
            txt_amount.AutoSize = true;
            txt_amount.BackColor = Color.Transparent;
            txt_amount.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_amount.Location = new Point(0, 295);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(95, 30);
            txt_amount.TabIndex = 14;
            txt_amount.Text = "Amount:";
            // 
            // type_txt
            // 
            type_txt.Cursor = Cursors.IBeam;
            type_txt.Location = new Point(149, 253);
            type_txt.Name = "type_txt";
            type_txt.Size = new Size(148, 26);
            type_txt.TabIndex = 13;
            // 
            // publishhouse_txt
            // 
            publishhouse_txt.Cursor = Cursors.IBeam;
            publishhouse_txt.Location = new Point(149, 208);
            publishhouse_txt.Name = "publishhouse_txt";
            publishhouse_txt.Size = new Size(148, 26);
            publishhouse_txt.TabIndex = 12;
            // 
            // txt_author
            // 
            txt_author.Cursor = Cursors.IBeam;
            txt_author.Location = new Point(149, 111);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(148, 26);
            txt_author.TabIndex = 10;
            // 
            // txt_bookname
            // 
            txt_bookname.Cursor = Cursors.IBeam;
            txt_bookname.Location = new Point(149, 70);
            txt_bookname.Name = "txt_bookname";
            txt_bookname.Size = new Size(148, 26);
            txt_bookname.TabIndex = 9;
            // 
            // txt_bookid
            // 
            txt_bookid.Cursor = Cursors.IBeam;
            txt_bookid.Location = new Point(147, 22);
            txt_bookid.Name = "txt_bookid";
            txt_bookid.Size = new Size(150, 26);
            txt_bookid.TabIndex = 8;
            // 
            // txt_type
            // 
            txt_type.AutoSize = true;
            txt_type.BackColor = Color.Transparent;
            txt_type.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_type.Location = new Point(0, 249);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(65, 30);
            txt_type.TabIndex = 7;
            txt_type.Text = "Type:";
            // 
            // txt_publishhouse
            // 
            txt_publishhouse.AutoSize = true;
            txt_publishhouse.BackColor = Color.Transparent;
            txt_publishhouse.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_publishhouse.Location = new Point(0, 208);
            txt_publishhouse.Name = "txt_publishhouse";
            txt_publishhouse.Size = new Size(154, 30);
            txt_publishhouse.TabIndex = 6;
            txt_publishhouse.Text = "Publish House:";
            // 
            // txt_lang
            // 
            txt_lang.AutoSize = true;
            txt_lang.BackColor = Color.Transparent;
            txt_lang.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_lang.Location = new Point(0, 159);
            txt_lang.Name = "txt_lang";
            txt_lang.Size = new Size(112, 30);
            txt_lang.TabIndex = 5;
            txt_lang.Text = "Language:";
            // 
            // txt_bookauthor
            // 
            txt_bookauthor.AutoSize = true;
            txt_bookauthor.BackColor = Color.Transparent;
            txt_bookauthor.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_bookauthor.Location = new Point(0, 111);
            txt_bookauthor.Name = "txt_bookauthor";
            txt_bookauthor.Size = new Size(84, 30);
            txt_bookauthor.TabIndex = 4;
            txt_bookauthor.Text = "Author:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label15.Location = new Point(0, 66);
            label15.Name = "label15";
            label15.Size = new Size(132, 30);
            label15.TabIndex = 3;
            label15.Text = "Book Name:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.Location = new Point(0, 22);
            label16.Name = "label16";
            label16.Size = new Size(37, 30);
            label16.TabIndex = 2;
            label16.Text = "Id:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 26);
            textBox1.TabIndex = 27;
            // 
            // btn_searchMember
            // 
            btn_searchMember.BackColor = SystemColors.ButtonFace;
            btn_searchMember.Location = new Point(159, 57);
            btn_searchMember.Name = "btn_searchMember";
            btn_searchMember.Size = new Size(90, 28);
            btn_searchMember.TabIndex = 28;
            btn_searchMember.Text = "Search";
            btn_searchMember.UseVisualStyleBackColor = false;
            btn_searchMember.Click += btn_searchMember_Click;
            // 
            // btn_refreshMember
            // 
            btn_refreshMember.BackColor = SystemColors.ButtonFace;
            btn_refreshMember.Location = new Point(381, 55);
            btn_refreshMember.Name = "btn_refreshMember";
            btn_refreshMember.Size = new Size(90, 30);
            btn_refreshMember.TabIndex = 29;
            btn_refreshMember.Text = "Refresh";
            btn_refreshMember.UseVisualStyleBackColor = false;
            btn_refreshMember.Click += btn_refreshMember_Click;
            // 
            // btn_refreshBook
            // 
            btn_refreshBook.BackColor = SystemColors.ButtonFace;
            btn_refreshBook.Location = new Point(1039, 57);
            btn_refreshBook.Name = "btn_refreshBook";
            btn_refreshBook.Size = new Size(90, 28);
            btn_refreshBook.TabIndex = 32;
            btn_refreshBook.Text = "Refresh";
            btn_refreshBook.UseVisualStyleBackColor = false;
            btn_refreshBook.Click += btn_refreshBook_Click;
            // 
            // btn_searchBook
            // 
            btn_searchBook.BackColor = SystemColors.ButtonFace;
            btn_searchBook.Location = new Point(817, 59);
            btn_searchBook.Name = "btn_searchBook";
            btn_searchBook.Size = new Size(90, 28);
            btn_searchBook.TabIndex = 31;
            btn_searchBook.Text = "Search";
            btn_searchBook.UseVisualStyleBackColor = false;
            btn_searchBook.Click += btn_searchBook_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(913, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 26);
            textBox2.TabIndex = 30;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1308, 757);
            Controls.Add(btn_refreshBook);
            Controls.Add(btn_searchBook);
            Controls.Add(textBox2);
            Controls.Add(btn_refreshMember);
            Controls.Add(btn_searchMember);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            Load += AdminPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private TextBox txt_username;
        private TextBox txt_surname;
        private TextBox txt_name;
        private TextBox txt_id;
        private TextBox txt_authorization;
        private Label label7;
        private Button clear_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button create_btn;
        private DataGridView dataGridView1;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn SURNAME;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dataGridView2;
        private Label label9;
        private DataGridViewTextBoxColumn bookid;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn lang;
        private DataGridViewTextBoxColumn publishhouse;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn numberofpages;
        private DataGridViewTextBoxColumn yearofissue;
        private GroupBox groupBox2;
        private Button btn_bookclear;
        private Button btn_bookupdate;
        private Button btn_bookdelete;
        private Button btn_bookadd;
        private TextBox amount_txt;
        private Label txt_amount;
        private TextBox type_txt;
        private TextBox publishhouse_txt;
        private TextBox txt_author;
        private TextBox txt_bookname;
        private TextBox txt_bookid;
        private Label txt_type;
        private Label txt_publishhouse;
        private Label txt_lang;
        private Label txt_bookauthor;
        private Label label15;
        private Label label16;
        private TextBox yearofissue_txt;
        private TextBox numberofpages_txt;
        private Label txt_yearofissue;
        private Label txt_numberofpages;
        private TextBox lang_txt;
        private ImageList ımageList1;
        private TextBox textBox1;
        private Button btn_searchMember;
        private Button btn_refreshMember;
        private Button btn_refreshBook;
        private Button btn_searchBook;
        private TextBox textBox2;
    }
}