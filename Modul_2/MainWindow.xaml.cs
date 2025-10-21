using Modul_2.Models;
using Modul_2.ViewControllers;
using System.Windows;
using System.Windows.Controls;

namespace Modul_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawProduct(AppContext.Products);
        }
        public void DrawProduct(List<Product> products)
        {
            BoxProducts.ItemsSource = AppContext.Products.Select(p => new ProductItemController(p));
            
            //BoxProducts.Items.Clear();
            //foreach (var item in products)
            //{
            //    ProductItemController itemController = new ProductItemController(item);

            //    BoxProducts.Items.Add(itemController);
            //}
        }

        private void BoxProducts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            //ProductItemController item = (ProductItemController)listBox.SelectedItem;
            if(listBox.SelectedItem is not ProductItemController item)
            {
                return;
            }
            Product selectedProduct = item.DataContext as Product;

            selectedProduct.Discount += 10;

            DrawProduct(AppContext.Products);
        }
    }
}