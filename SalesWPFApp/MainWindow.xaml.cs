using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUserRepository userRepository;
        public MainWindow()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            userContext user = userRepository.GetUser(txtEmail.Text);
            if (user != null && txtPassword.Password.Equals(user.Password) && user.Role.Equals("admin"))
            {
                AdminWindow iWindow = new AdminWindow();
                iWindow.Show();

            }
            if (user != null && txtPassword.Password.Equals(user.Password) && user.Role.Equals("manager"))
            {
                ManagerWindow iWindow = new ManagerWindow();
                iWindow.Show();
            }
            else
            {
                MessageBox.Show("Login Fail!");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}