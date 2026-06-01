using Magazine.Helpers;
using Magazine.Statics;
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

namespace Magazine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Entities _db = new Entities();
        private MessageHelper _mh = new MessageHelper();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginEnter.Text;
            string password = PasswordEnter.Password;

            var Users = _db.Users.Where(s => login == s.Login && s.Password == password).FirstOrDefault();
            if (Users == null)
            {
                _mh.ShowError("Введен не верный логин или пароль!");
                return;
            }
            else
            {
                CurrentSession.CurrentUser = Users;
                new ProductWindow(Users).Show();
                Close();
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new ProductWindow().Show();
            Close();
        }
    }
}
