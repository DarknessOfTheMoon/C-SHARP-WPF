using DZ1._0.Classes;
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

namespace DZ1._0.Views.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для UserCreateProduct.xaml
    /// </summary>
    public partial class UserCreateProduct : Page
    {
        public UserCreateProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadingData dbLoad = new LoadingData();
            dbLoad.LoadCountry(txbCountryManufacture);
        }
    }
}
