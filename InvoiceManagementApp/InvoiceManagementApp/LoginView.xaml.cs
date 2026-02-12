using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace InvoiceManagementApp
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;

            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");

            if(envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("Entered correctly");
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }
        }

        public void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
