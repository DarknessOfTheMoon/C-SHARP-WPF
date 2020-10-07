using DZ1._0.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DZ1._0.Classes
{
    class LoadingData
    {
        public void LoadCountry(ComboBox comboBox)
        {
            try
            {
                var query = ContextConnect.db.CountryManufacture.Select(item => new
                {
                    ID = item.Title
                });
                var collection = from item in query select item.ID;
                comboBox.ItemsSource = collection.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
