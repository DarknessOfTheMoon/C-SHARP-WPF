using DZ1._0.Context;
using DZ1._0.Views.Pages.Users;
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

namespace DZ1._0.Views.Pages.MainPages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void Authorization()
        {
            try
            {
                var currentUser = ContextConnect.db.SignIn.FirstOrDefault(item => item.Username == txbUsername.Text &&
                item.Password == psbPassword.Password);
                if (currentUser == null)
                    MessageBox.Show("Такого пользователя не в Базе Данных!", "НЕ ВЕРНО!", MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                else
                {
                    switch (currentUser.IDRole)
                    {
                        case "A":
                            NavigationService.Navigate(new UserViewData());
                            break;
                        case "U":
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + "выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Authorization();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            Authorization();
        }

        private void buttonCancel_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); 
        }
    }
 }

