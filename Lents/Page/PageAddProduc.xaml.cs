using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Lents.Page
{
    /// <summary>
    /// Логика взаимодействия для PageAddProduc.xaml
    /// </summary>
    public partial class PageAddProduc 
    {
        public PageAddProduc()
        {
            InitializeComponent();
            ConnectOdb.ConObj.Manufacturer.Load();
            comboBox2.ItemsSource = ConnectOdb.ConObj.Manufacturer.Local;
            ConnectOdb.ConObj.Provider.Load();
            comboBox3.ItemsSource = ConnectOdb.ConObj.Provider.Local;

        }

        private void saveAddBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
