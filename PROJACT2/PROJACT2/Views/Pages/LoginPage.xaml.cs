﻿using System;
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

namespace PROJACT2.Views.Pages
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

        private void buttonLogin_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                User newUser = new User();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + "выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
        }
    }
}
