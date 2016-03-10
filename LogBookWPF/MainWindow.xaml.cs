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

namespace LogBookWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    SignUpForm signing = new SignUpForm();
        //    signing.Show();

        //}

        //private void btnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    LoginForm login = new LoginForm();
        //    login.Show();
        //}

        //private void btnSignup_Click(object sender, RoutedEventArgs e)
        //{
        //   SignUpForm signup = new SignUpForm();
        //    signup.Show();
        //    //LogBookTask lbt = new LogBookTask();
        //   // lbt.Show();
        //}

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            ConnectionClass login2 = new ConnectionClass();
            string loginSuccess = login2.LoginMentors(txtUsername.Text, Password.Password);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUpForm signing = new SignUpForm();
              signing.Show();
        }
    }
}
