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
    /// Логика взаимодействия для BeginPage.xaml
    /// </summary>
    public partial class BeginPage : Page
    {
        public BeginPage()
        {
            InitializeComponent();
            loginTextBox.Focus();
        }

        private void Log_In_Click(object sender, RoutedEventArgs e)
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
            // add searching in file
            NavigationService.Navigate(Pages.MainPage);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.RegisterPage);
        }

        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Register_Click(null, null);
        }
    }
}
