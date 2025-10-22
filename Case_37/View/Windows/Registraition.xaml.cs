using Case_37.Model;
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
using System.Windows.Shapes;

namespace Case_37
{
    /// <summary>
    /// Логика взаимодействия для Registraition.xaml
    /// </summary>
    public partial class Registraition : Window
    {
        public Registraition()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;
            


            // Создание нового пользователя
            User newUser = new User
            {
                Login = username,
                Password = password
            };
            // Добавление пользователя в базу данных

            App.context.User.Add(newUser);
            App.context.SaveChanges();

            // Создание профиля пользователя


            MessageBox.Show("Пользователь успешно зарегистрирован.");
            
            usernameTextBox.Text = string.Empty;
            passwordBox.Password = string.Empty;

        }
    }
}
