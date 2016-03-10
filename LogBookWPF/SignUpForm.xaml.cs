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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace LogBookWPF
{
    /// <summary>
    /// Interaction logic for SignUpForm.xaml
    /// </summary>
    public partial class SignUpForm : Window
    {
        string myCo = "Data Source=DVT-MVTEBEILA\\SQLEXPRESS;Initial Catalog=DVT;Integrated Security=True";
        public SignUpForm()
        {
            InitializeComponent();

            Gender.Items.Add("please select");
            Gender.Items.Add("Female");
            Gender.Items.Add("Male");

            Roles();
        }

        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (emailRegex.IsMatch(txtemail.Text))
            {
                
                ConnectionClass signup = new ConnectionClass();

                int roles = cmRoles.SelectedIndex + 1;

                signup.Signup(this.txtSurname.Text, this.txtFullName.Text, this.Gender.Text, this.txtemail.Text, this.txtUsername.Text, this.txtPassword.Text, roles);

            }
            else
            {
                label.Content = "*";
                MessageBox.Show("Invalid Email Address");
                txtemail.Clear();
                txtemail.Focus();
            }




            
        }



        public void Roles()
        {
            SqlConnection Connection = new SqlConnection(myCo);

            try
            {
                Connection.Open();
                string Daily = "SELECT * FROM RoleTb";

                SqlCommand command = new SqlCommand(Daily, Connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    // string Id = dr.GetString(0);
                    string Roles = dr.GetString(1);
                    //  string FullName = Id + " " + Roles;

                    cmRoles.Items.Add(Roles);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
