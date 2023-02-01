using Lents.Page;
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

namespace Lents
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectOdb.ConObj = new BD.Model1();
            FrameObj.MainFrame = FrmMain;
            FrmMain.Navigate(new PageAvtoriz());
        }

        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {
            if (FrmMain.CanGoBack)
            {
                Hazad.Visibility = Visibility.Visible;
            }
            else
            {
                Hazad.Visibility = Visibility.Hidden;
            }
        }

        private void Hazad_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.GoBack();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Не, ну ты реально хочешь закрыть окно?", "закрытие приложения", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
    
}
