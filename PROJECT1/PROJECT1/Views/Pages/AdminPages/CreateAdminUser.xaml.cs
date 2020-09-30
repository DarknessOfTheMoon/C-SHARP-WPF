using PROJECT1.Context;
using PROJECT1.Models;
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

namespace PROJECT1.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для CreateAdminUser.xaml
    /// </summary>
    public partial class CreateAdminUser : Page
    {
        public CreateAdminUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                USER newUser = new USER();
                newUser.USERNAME = txbUsername.Text;
                newUser.PASSWORD = txbPassword.Text;
                newUser.IDROLE = "U";
                ContextConnect.db.USER.Add(newUser);
                ContextConnect.db.SaveChanges();
                MessageBox.Show("Новый пользователь успешно создан!", "Уведомление системы!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
