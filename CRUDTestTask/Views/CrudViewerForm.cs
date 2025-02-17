using CRUDTestTask.Services;

namespace CRUDTestTask
{
    public partial class CrudViewerForm : Form
    {
        private readonly UserService _userService;
        public CrudViewerForm(UserService userService)
        {
            InitializeComponent();        
            _userService = userService;
            LoadUsers();
        }

        private void CrudViewerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void LoadUsers()
        {
            var users = _userService.GetAllUsers();
            userListBox.DataSource = users.ToList();
            userListBox.DisplayMember = "Login";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = loginTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text
            };

            try
            {
                _userService.AddUser(user);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex == -1)
                return;
            
            var selectedUser = (User) userListBox.SelectedItem;

            if (selectedUser != null)
            {
                selectedUser.Login = loginTextBox.Text;
                selectedUser.FirstName = firstNameTextBox.Text;
                selectedUser.LastName = lastNameTextBox.Text;

                try
                {
                    _userService.UpdateUser(selectedUser);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex == -1)
                return;

            var selectedUser = (User)userListBox.SelectedItem;

            if (selectedUser != null)
            {
                _userService.DeleteUser(selectedUser.Id);
                LoadUsers();
            }
        }
    }
}
