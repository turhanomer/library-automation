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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            clear_btn = new Button();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 639);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Panel";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Cursor = Cursors.IBeam;
            maskedTextBox1.Location = new Point(178, 187);
            maskedTextBox1.Mask = "00/00/0000 90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(174, 26);
            maskedTextBox1.TabIndex = 22;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.Tomato;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.ForeColor = SystemColors.ButtonHighlight;
            clear_btn.Location = new Point(178, 584);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(174, 49);
            clear_btn.TabIndex = 21;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.MediumTurquoise;
            update_btn.Cursor = Cursors.Hand;
            update_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.ForeColor = SystemColors.ButtonHighlight;
            update_btn.Location = new Point(178, 529);
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
            delete_btn.Location = new Point(178, 474);
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
            create_btn.Location = new Point(178, 419);
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
            txt_authorization.Location = new Point(178, 339);
            txt_authorization.Name = "txt_authorization";
            txt_authorization.Size = new Size(174, 26);
            txt_authorization.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(6, 335);
            label7.Name = "label7";
            label7.Size = new Size(147, 30);
            label7.TabIndex = 14;
            label7.Text = "Authorization:";
            // 
            // txt_password
            // 
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Location = new Point(178, 287);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(174, 26);
            txt_password.TabIndex = 13;
            // 
            // txt_username
            // 
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Location = new Point(178, 235);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(174, 26);
            txt_username.TabIndex = 12;
            // 
            // txt_surname
            // 
            txt_surname.Cursor = Cursors.IBeam;
            txt_surname.Location = new Point(178, 140);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(174, 26);
            txt_surname.TabIndex = 10;
            // 
            // txt_name
            // 
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Location = new Point(178, 94);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(174, 26);
            txt_name.TabIndex = 9;
            // 
            // txt_id
            // 
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Location = new Point(178, 46);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(174, 26);
            txt_id.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 281);
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
            label5.Location = new Point(6, 231);
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
            label4.Location = new Point(6, 183);
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
            label3.Location = new Point(6, 136);
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
            label1.Location = new Point(6, 90);
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
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 2;
            label2.Text = "Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, NAME, SURNAME, Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(393, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(795, 596);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 53;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            NAME.HeaderText = "NAME";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 82;
            // 
            // SURNAME
            // 
            SURNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SURNAME.HeaderText = "SURNAME";
            SURNAME.MinimumWidth = 6;
            SURNAME.Name = "SURNAME";
            SURNAME.Width = 110;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "CREATED TIME";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 138;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "USERNAME";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 118;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "PASSWORD";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 117;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "AUTHORIZATION";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 155;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(746, 12);
            label8.Name = "label8";
            label8.Size = new Size(130, 33);
            label8.TabIndex = 22;
            label8.Text = "Member";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1121, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 663);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn SURNAME;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
    }
}