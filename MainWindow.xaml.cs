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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductPrice = 75,
                ProductImage = "Data/bread.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Сыр",
                ProductPrice = 600,
                ProductImage = "Data/cheese.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Набор ножей",
                ProductPrice = 3500,
                ProductImage = "Data/knives.jpg",
                ProductType = ProductTypes.Device
            });
            products.Add(new Product()
            {
                ProductName = "Утюг",
                ProductPrice = 12000,
                ProductImage = "Data/iron.jpg",
                ProductType = ProductTypes.Device
            });
            lstBox.ItemsSource = products;
        }
    }
}