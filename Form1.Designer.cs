namespace library_automation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            login_btn = new Button();
            clear_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 21.913044F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 119);
            label1.Name = "label1";
            label1.Size = new Size(186, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(117, 261);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(117, 328);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Location = new Point(239, 265);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(198, 26);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(239, 332);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(198, 26);
            txt_password.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(82, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 30);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(82, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(29, 30);
            panel2.TabIndex = 6;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.LimeGreen;
            login_btn.Cursor = Cursors.Hand;
            login_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(253, 396);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(90, 49);
            login_btn.TabIndex = 7;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.Red;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.Font = new Font("Arial Rounded MT Bold", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.ForeColor = SystemColors.ButtonHighlight;
            clear_btn.Location = new Point(347, 396);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(90, 49);
            clear_btn.TabIndex = 8;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(548, 703);
            Controls.Add(clear_btn);
            Controls.Add(login_btn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clear";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Panel panel1;
        private Panel panel2;
        private Button login_btn;
        private Button clear_btn;
    }
}
