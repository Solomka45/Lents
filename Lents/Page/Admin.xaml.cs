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

namespace Lents.Page
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin 
    {
        public Admin(object DataContext)
        {
            InitializeComponent();
        }

       

       

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageProduct());
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageAddProduc());
        }

       
    }
}
