using Modul_2.Models;
using System.Windows;

namespace Modul_2.Windows
{
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void ButtonSave(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BoxLogin.Text) &&
                !string.IsNullOrWhiteSpace(BoxPass.Text) &&
                !string.IsNullOrWhiteSpace(BoxName.Text))
            {
                string login = AppContext.Users.FirstOrDefault(q => q.Login == BoxLogin.Text)?.Login;

                if (login != null)
                {
                    MessageBox.Show("Данный логин занят");
                }
                else
                {
                    User user = new()
                    {
                        Id = AppContext.Users.Count + 1,
                        Name = BoxName.Text,
                        Password = BoxPass.Text,
                        Login = BoxLogin.Text,
                        Role = AppContext.Roles.FirstOrDefault(q => q.Name == "Пользователь")
                    };
                    AppContext.Users.Add(user);
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
