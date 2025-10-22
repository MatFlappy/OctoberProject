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

namespace Case_37
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var user = App.context.User.ToList().FirstOrDefault(u => u.Login == usernameTextBox.Text && u.Password == passwordBox.Password);

            if (user != null) 
            {
                Menu men = new Menu();
                men.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");

                usernameTextBox.Text = string.Empty;
                passwordBox.Password = string.Empty;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registraition reg = new Registraition();
            reg.Show();
            this.Close();
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    //string username = usernameTextBox.Text;
        //    //string password = passwordBox.Password;
        //    //App.currentUser = App.context.User.FirstOrDefault(u => u.Login == username && u.Password == password);
        //    //if (App.currentUser != null)
        //    //{
        //    //    roleId = App.currentUser.IdRole; // Присваиваем roleId значение IdRole пользователя
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //}
    }
}
