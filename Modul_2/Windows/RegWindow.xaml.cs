using Modul_2.DataBase;
using Modul_2.Models.Users;
using System.Windows;

namespace Modul_2.Windows
{
    public partial class RegWindow : Window
    {
        ApplicationContext _context;
        public RegWindow()
        {
            InitializeComponent();
            _context = new ApplicationContext();
        }

        private void ButtonSave(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BoxLogin.Text) &&
                !string.IsNullOrWhiteSpace(BoxPass.Text) &&
                !string.IsNullOrWhiteSpace(BoxName.Text))
            {
                string login = _context.Users.FirstOrDefault(q => q.Login == BoxLogin.Text)?.Login;

                if (login != null)
                {
                    MessageBox.Show("Данный логин занят");
                }
                else
                {
                    User user = new()
                    {
                        Name = BoxName.Text,
                        Password = BoxPass.Text,
                        Login = BoxLogin.Text,
                        Role = _context.Roles.FirstOrDefault(q => q.Name == "Пользователь")
                    };
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    DialogResult = true;
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
