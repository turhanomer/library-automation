using library_automation.Model;

namespace library_automation
{
    public partial class Form1 : Form
    {
        List<Person> myPersons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
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
                    AdminPage adminPage = new AdminPage();
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
            myPersons.Add(new Person(1, "Samet", "Çevik", DateTime.Now, "sametcevik", "sc2004", "member"));
            myPersons.Add(new Person(1, "Mehmet Sahaf", "Bayrakçý", DateTime.Now, "msbayrakci", "msb", "member"));
        }
    }
}
