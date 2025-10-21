using Modul_2.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Modul_2.ViewControllers
{
    public partial class ProductItemController : UserControl
    {
        public ProductItemController(Product product)
        {
            InitializeComponent();
            DataContext = product;

            if(product.Discount > 15)
            {
                BoxDiscont.Background = new BrushConverter().ConvertFrom("#2E8B57") as SolidColorBrush;
            }
            if(product.Discount > 0)
            {
                BoxPrice.Foreground = Brushes.Red;
                BoxPrice.TextDecorations.Add(TextDecorations.Strikethrough);

                BoxNewPrice.Text = (product.Price * (1 - product.Discount / 100.0)).ToString();
                //BoxNewPrice.Text = (product.Price - product.Price * product.Discount / 100).ToString();
            }
            if(product.Count == 0)
            {
                BoxCount.Foreground = Brushes.Blue;
            }
        }
    }
}
