namespace LoginForm
{
    public partial class frmLoginForm : Form
    {
        private List<User> UsersList = new List<User>();
        public frmLoginForm()
        {
            InitializeComponent();

            User user1 = new User("mais", "123");
            User user2 = new User("hiba", "123");

            UsersList.Add(user1);
            UsersList.Add(user2);



        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            foreach(var user in UsersList)
            {
                if(user.Username == username && user.Password ==
                    password)
                {
                  frmNavigationForm frm = new frmNavigationForm();
                    frm.Show();
                }
            }
        }
    }
}