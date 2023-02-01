using Lents.BD;
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
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew 
    {
        public PageEditNew( Product product)
        {
            InitializeComponent();
            comboBox2.SelectedIndex = (int)product.manufacturer - 1;
            comboBox2.SelectedValuePath = "ID";
            comboBox2.DisplayMemberPath = "Manufacturer1";
            comboBox2.ItemsSource = ConnectOdb.ConObj.Manufacturer.ToList();


            comboBox3.SelectedIndex = (int)product.provider - 1;
            comboBox3.SelectedValuePath = "ID";
            comboBox3.DisplayMemberPath = "provider1";
            comboBox3.ItemsSource = ConnectOdb.ConObj.Provider.ToList();



            ProductObj.article_number = product.article_number;

            titleTX.Text = product.name;
            StoimTX.Text = Convert.ToString(product.stoimost);
            MaxSkdTX.Text = Convert.ToString(product.max_discout);
            descTX.Text = product.description;
            StringImage.Text = product.photo;
        }

        private void saveAddBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
