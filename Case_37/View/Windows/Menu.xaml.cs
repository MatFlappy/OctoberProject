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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        //List<Game> _game = new List<Game>();
        public Menu()
        {
           
            InitializeComponent();
            Lst.ItemsSource = App.context.Game.ToList();



        }

        //private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Lst.ItemsSource = App.context.Game.ToList();
        //}

        //private void SteachTb_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    if (SteachTb.Text == "Введите название")
        //    {
        //        SteachTb.Text = "";
        //    }
        //}

        //private void SteachTb_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (SteachTb.Text == "")
        //    {
        //        SteachTb.Text = "Введите название";
        //    }
        //}

        //private void Search()
        //{
        //    _game = App.context.Game.ToList();
        //   _game = _game.Where(x => x.Name.ToLower().Contains(SteachTb.Text.ToLower())).ToList();
            
        //}

        //private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        //{ 
        //    Search();
        //}
    }
}
