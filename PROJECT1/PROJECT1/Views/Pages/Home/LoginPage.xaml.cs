using System;
using PROJECT1.Context;
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
using PROJECT1.Views.Pages.AdminPages;

namespace PROJECT1.Views.Pages.Home
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

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();  // Выключить приложение
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var currentUser = ContextConnect.db.USER.FirstOrDefault(item => item.USERNAME == txbUsername.Text && item.PASSWORD == PasswordBox.Password);
                // Проверяем, есть ли в Базе Такой пользователь
                if (currentUser == null)
                    MessageBox.Show("Вы ввели неверные данные авторизации! Пожалуйста, повторите попытку...", "Не верно!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                else
                {
                    // Для этого идеально подходит Switch Case
                    switch (currentUser.IDROLE)
                    {
                        case "A":
                            MessageBox.Show("Привет Администратор " + currentUser.USERNAME);
                            NavigationService.Navigate(new CreateAdminUser());
                            break;
                        case "U":
                            MessageBox.Show("Привет Пользователь " + currentUser.USERNAME);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + "выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}