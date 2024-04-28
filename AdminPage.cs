using library_automation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation
{
    public partial class AdminPage : Form
    {
        List<Person> mypersons;
        List<Book> mybooks;
        public AdminPage(List<Person> mypersons, List<Book> mybooks)
        {
            InitializeComponent();
            this.mypersons = mypersons;
            this.mybooks = mybooks;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_surname.Text, maskedTextBox1.Text, txt_username.Text, txt_password.Text, txt_authorization.Text);
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            foreach (var person in mypersons)
            {
                dataGridView1.Rows.Add(person.getId(), person.getName(), person.getSurname(), person.getTime(), person.getUsername(), person.getPassword(), person.getAuthorization());
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void fillTexts()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_username.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_password.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_authorization.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string authorization = txt_authorization.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, name, surname, username, password, authorization);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTexts();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

    }
}
