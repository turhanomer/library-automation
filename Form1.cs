using library_automation.Model;

namespace library_automation
{
    public partial class Form1 : Form
    {
        List<Person> myPersons = new List<Person>();
        List<Book> myBooks = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = login_btn;
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string username, password = "";
            username = txt_username.Text;
            password = txt_password.Text;
            bool control = false;

            foreach (var person in myPersons)
            {
                if (username.ToLower() == person.getUsername() && password.ToLower() == person.getPassword() && person.getAuthorization() == "admin")
                {
                    AdminPage adminPage = new AdminPage(myPersons, myBooks);
                    adminPage.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == person.getUsername() && password.ToLower() == person.getPassword() && person.getAuthorization() == "member")
                {
                    MemberPage memberPage = new MemberPage();
                    memberPage.Show();
                    this.Hide();
                    control = true;
                    break;
                }

            }
            if (!control)
            {
                MessageBox.Show("An Error Occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myPersons.Add(new Person(1, "Ömer", "Turhan", DateTime.Now, "omerturhan", "ot1211", "admin"));
            myPersons.Add(new Person(2, "Samet", "Çevik", DateTime.Now, "sametcevik", "sc2004", "member"));
            myPersons.Add(new Person(3, "Mehmet Sahaf", "Bayrakçý", DateTime.Now, "msbayrakci", "msb", "member"));

            myBooks.Add(new Book(1, "The Devil In Us", "Sebahattin Ali", "Turkish", "Yapý Kredi Publications", "Novel", 100, 250, 2016));
            myBooks.Add(new Book(2, "Game Of Thrones", "George R. R. Martin", "English", "Epilson Publications", "Novel", 910, 850, 2011));
            myBooks.Add(new Book(3, "The Lord Of The Rings", "J. R. R. Tolkien", "English", "Epilson Publications", "Novel", 800, 1026, 2001));
            myBooks.Add(new Book(4, "Crime and Punishment", "Dostoyevski", "Russian", "Ýþ Bankasý Kültür Publications", "Novel", 530, 856, 2006));
            myBooks.Add(new Book(4, "Transformation", "Franz Kafka", "German", "Can Publications", "Story", 260, 102, 2024));
            myBooks.Add(new Book(4, "Monte Cristo Kontu", "Alexandre Dumas", "French", "Ýþ Bankasý Kültür Publications", "Novel", 770, 592, 2018));
        }
    }
}
