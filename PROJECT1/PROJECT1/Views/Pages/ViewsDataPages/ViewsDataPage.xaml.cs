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

namespace PROJECT1.Views.ViewsDataPages
{
    /// <summary>
    /// Логика взаимодействия для ViewsDataPage.xaml
    /// </summary>
    public partial class ViewsDataPage : Page
    {
        public ViewsDataPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = ContextConnect.db.USER.ToList();
        }

        private void   Button_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
