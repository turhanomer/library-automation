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
    public partial class MemberPage : Form
    {
        List<Book> mybooks;
        public MemberPage(List<Book> mybooks, List<Person> mypersons)
        {
            InitializeComponent();
            this.mybooks = mybooks;
            // this.mypersons = mypersons;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txt_bookID.Text);
            Book targetID = null;

            foreach (Book book in mybooks)
            {
                if (book.getBookId() == selectedID)
                {
                    targetID = book;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(targetID.getBookId(), targetID.getBookName(), targetID.getAuthor(), targetID.getBookLang(), targetID.getPublishHouse, targetID.getType(), targetID.getAmount(), targetID.getNumberOfPages(), targetID.getYearOfIssue());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Book book in mybooks)
            {
                dataGridView1.Rows.Add(book.getBookId(), book.getBookName(), book.getAuthor(), book.getBookLang(), book.getPublishHouse, book.getType(), book.getAmount(), book.getNumberOfPages(), book.getYearOfIssue());
            }
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            foreach (Book book in mybooks)
            {
                dataGridView1.Rows.Add(book.getBookId(), book.getBookName(), book.getAuthor(), book.getBookLang(), book.getPublishHouse, book.getType(), book.getAmount(), book.getNumberOfPages(), book.getYearOfIssue());
            }
        }
    }
}
