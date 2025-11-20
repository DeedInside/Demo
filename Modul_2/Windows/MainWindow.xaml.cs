using Modul_2.DataBase;
using Modul_2.Models;
using Modul_2.Models.Users;
using Modul_2.ViewControllers;
using Modul_2.Windows;
using System.Windows;
using System.Windows.Controls;

namespace Modul_2
{
    public partial class MainWindow : Window
    {
        ApplicationContext _context;
        public MainWindow(User user = null)
        {
            InitializeComponent();
            _context = new ApplicationContext();

            if (user != null)
            {
                RunUserName.Text = user.Name;

                switch(user.Role.Name)
                {
                    case "Пользователь":
                        {
                            //todo
                            break;
                        }
                    case "Менеджер":
                        {
                            PanelFind.Visibility = Visibility.Visible;
                            ButtonOrder.Visibility = Visibility.Visible;
                            break;
                        }
                    case "Админ":
                        {
                            PanelFind.Visibility = Visibility.Visible;
                            ButtonOrder.Visibility = Visibility.Visible;
                            PanelCRUD.Visibility = Visibility.Visible;
                            BoxProducts.MouseDoubleClick += MouseDoubleAddProduct;
                            break;
                        }
                }
            }
            else
            {
                RunUserName.Text = "гость";
            }

            DrawProduct(_context.Products.ToList());
        }
        public void DrawProduct(List<Product> products)
        {
            BoxProducts.ItemsSource = products.Select(p => new ProductItemController(p));
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
            this.Close();
        }

        private void ButtonRemoveProduct(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddProduct(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonListRequest(object sender, RoutedEventArgs e)
        {

        }

        private void MouseDoubleAddProduct(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListBox list = sender as ListBox;
            ProductItemController controller = list.SelectedItem as ProductItemController;
            Product product = controller.DataContext as Product;

            MessageBox.Show(product.ToString());
        }
    }
}