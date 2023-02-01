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
using Lents.BD;

namespace Lents.Page
{
    /// <summary>
    /// Логика взаимодействия для PageAvtoriz.xaml
    /// </summary>
    public partial class PageAvtoriz 
    {
        public PageAvtoriz()
        {
            InitializeComponent();
        }

        private void Reg1_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new Reg1());
        }

        private void Guestt_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageProduct());
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = ConnectOdb.ConObj.Users.FirstOrDefault(x => x.login == Login.Text && x.password == Pass.Text);
                DataContext = userObj.FIO;
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя не существует", "Ошибка авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    DataContext = userObj.FIO;
                }
                else
                {
                    switch (userObj.role)
                    {
                        case 1:
                            MessageBoxResult result = MessageBox.Show("Добро пожаловать. Вы авторизировались как администратор  " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (result == MessageBoxResult.OK)
                                FrameObj.MainFrame.Navigate(new Admin(DataContext));
                            break;
                        case 2:
                            MessageBoxResult result1 = MessageBox.Show("Добро пожаловать. Вы авторизировались как менеджер  " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (result1 == MessageBoxResult.OK)
                                FrameObj.MainFrame.Navigate(new PageProduct());
                            break;
                        case 3:
                            MessageBoxResult result2 = MessageBox.Show("Добро пожаловать. Вы авторизировались как пользователь  " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (result2 == MessageBoxResult.OK)
                                FrameObj.MainFrame.Navigate(new PageProduct());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены", "Уведомление",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка работы приложения!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public static System.Windows.MessageBoxResult Show(string messageBoxText,
            string caption, System.Windows.MessageBoxButton button, System.Windows.MessageBoxImage icon)
        {
            return new MessageBoxResult();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new Page1());
        }
    }
}
