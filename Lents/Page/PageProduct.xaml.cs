using Lents.BD;
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
using System.Windows.Threading;

namespace Lents.Page
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct 
    {
        public PageProduct()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }
        public void UpdateData(object sender, object e)
        {
            var HistoryProduct = ConnectOdb.ConObj.Product.ToList();
            ListProduct.ItemsSource = HistoryProduct;
            ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Where(x => x.name.StartsWith(TxtSearch.Text)).ToList();

            ConnectOdb.ConObj.Manufacturer.Load();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageEditNew((sender as Button).DataContext as Product));

        }
    }
}
