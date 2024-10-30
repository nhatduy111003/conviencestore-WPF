using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObject.Models;
using System.Data;
namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private IUserRepository _userRepository;
        public AdminWindow()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.LoadInitData();
        }
        private void LoadInitData()
        {
            this.dgUser.ItemsSource = _userRepository.GetAllUsers();
            this.cbRole.ItemsSource = _userRepository.GetUserRoles();
        }

        private void dgUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;

            if (dataGrid.SelectedItem == null)
                return;

            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.SelectedItem);
            if (row == null)
                return;

            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            if (RowColumn == null)
                return;

            int id = int.Parse(((TextBlock)RowColumn.Content).Text);
            userContext user = _userRepository.GetUser(id);
            txtEmail.Text = user.Email.ToString();
            txtUsername.Text = user.Username.ToString();
            txtPassword.Text = user.Password.ToString();
            txtUserId.Text = user.Id.ToString();
            cbRole.SelectedValue = user.Role;
          
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = (string)cbRole.SelectedValue;
            DateTime createAt = DateTime.Now;
            DateTime updateAt = DateTime.Now;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Tất cả các trường đều phải được điền.");
                return;
            }

            userContext newUser = new userContext
            {
                Username = fullName,
                Email = email,
                Password = password,
                Role = role,
                CreatedAt = createAt,
                UpdatedAt = updateAt,
                
            };

            bool isSuccess = _userRepository.AddUser(newUser);

            if (isSuccess)
            {
                MessageBox.Show("Người dùng đã được tạo thành công.");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình tạo người dùng.");
            }
        }

        private void btnUpdate1_Click(object sender, RoutedEventArgs e)
        {
            int userId = int.Parse(txtUserId.Text);
            userContext updatedUser = new userContext
            {
                Id = userId,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = (string)cbRole.SelectedValue,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            bool isUpdated = _userRepository.UpdateUser(updatedUser);

            if (isUpdated)
            {
                MessageBox.Show("Cập nhật người dùng thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật người dùng thất bại!");
            }

            this.LoadInitData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgUser.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một người dùng để xóa.");
                return;
            }

            DataGridRow row = (DataGridRow)dgUser.ItemContainerGenerator.ContainerFromItem(dgUser.SelectedItem);
            DataGridCell RowColumn = dgUser.Columns[0].GetCellContent(row).Parent as DataGridCell;
            int id = int.Parse(((TextBlock)RowColumn.Content).Text);

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                bool isSuccess = _userRepository.DeleteUser(id);

                if (isSuccess)
                {
                    MessageBox.Show("Người dùng đã được xóa thành công.");
                    dgUser.ItemsSource = _userRepository.GetAllUsers();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình xóa người dùng.");
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
