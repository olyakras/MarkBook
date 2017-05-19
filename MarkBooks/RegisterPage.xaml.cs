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

namespace MarkBooks
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.BeginPage);
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести логин");
                loginTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести пароль");
                passwordTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text)!= string.IsNullOrWhiteSpace(repeatPasTextBox.Text))
            {
                MessageBox.Show("Пароли не совпадают");
                repeatPasTextBox.Focus();
                return;
            }

            MessageBox.Show("Регистрация прошла успешна");

            NavigationService.Navigate(Pages.MainPage);
        }
    }
}
