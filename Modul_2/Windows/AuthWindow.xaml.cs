using Modul_2.DataBase;
using Modul_2.Models.Users;
using System.Windows;

namespace Modul_2.Windows
{
    public partial class AuthWindow : Window
    {
        private ApplicationContext _context;
        public AuthWindow()
        {
            InitializeComponent();
            _context = new ApplicationContext();
        }
        private void ButtonAuth(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(BoxLogin.Text) &&
                !string.IsNullOrWhiteSpace(BoxPass.Text))
            {
                User? user = _context.Users.FirstOrDefault(q => q.Login == BoxLogin.Text &&
                q.Password == BoxPass.Text);
                if (user != null)
                {
                    MainWindow main = new MainWindow(user);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void ButtonReg(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();

            regWindow.ShowDialog();

            if(regWindow.DialogResult == true)
            {
                BoxLogin.Text = regWindow.BoxLogin.Text;
                BoxPass.Text = regWindow.BoxPass.Text;
            }
            else
            {
                //todo
            }
        }

        private void ButtonGuest(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
