using BusinessObject.Models;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        public ManagerWindow()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.LoadInitData();
        }
        private void LoadInitData()
        {
            this.dgProduct.ItemsSource = _productRepository.GetProducts();
            this.cbCategory.ItemsSource = _categoryRepository.GetAllCategories();
            this.cbCategory.DisplayMemberPath = "Name";
            this.cbCategory.SelectedValuePath = "Id";
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = txtProductName.Text;
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                product.Price = price;
            }
            product.Description = txtDescription.Text;
            product.CategoryId = int.Parse(this.cbCategory.SelectedValue.ToString());
            if (_productRepository.AddProduct(product))
            {
                MessageBox.Show("Add Successfully");
                this.LoadInitData();
            }
            else
            {
                MessageBox.Show("Fail to add");
            };
        }

        private void btnUpdate1_Click(object sender, RoutedEventArgs e)
        {
            int productId = int.Parse(txtProductId.Text);

           Product product = new Product

            {
                Id = productId,
                Name = txtProductName.Text
            };

            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                product.Price = price;
            }

            product.Description = txtDescription.Text;
            product.CategoryId = int.Parse(this.cbCategory.SelectedValue.ToString());

            if (_productRepository.UpdateProduct(product))
            {
                MessageBox.Show("Update Successfully");
                this.LoadInitData();
            }
            else
            {
                MessageBox.Show("Fail to update");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgProduct.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                return;
            }

            DataGridRow row = (DataGridRow)dgProduct.ItemContainerGenerator.ContainerFromItem(dgProduct.SelectedItem);
            DataGridCell RowColumn = dgProduct.Columns[0].GetCellContent(row).Parent as DataGridCell;
            int id = int.Parse(((TextBlock)RowColumn.Content).Text);

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                bool isDeleted = _productRepository.DeleteProduct(id);

                if (isDeleted)
                {
                    MessageBox.Show("Sản phẩm đã được xóa thành công.");
                    LoadInitData();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm không thành công. Vui lòng thử lại.");
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            Product productRepo = _productRepository.GetProduct(id);
            Category categoryRepo = _categoryRepository.GetCategory(id);
            txtProductId.Text = productRepo.Id.ToString();
            txtProductName.Text = productRepo.Name.ToString();
            txtPrice.Text = productRepo.Price.ToString();
            txtDescription.Text = productRepo?.Description?.ToString() ?? string.Empty;
            cbCategory.SelectedValue = productRepo?.CategoryId.ToString();
        }
    }
}
