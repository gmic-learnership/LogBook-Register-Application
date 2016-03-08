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


namespace LogBookWPF
{
    /// <summary>
    /// Interaction logic for DailyRegister.xaml
    /// </summary>
    public partial class DailyRegister : Window
    {
        string myCo = "Data Source=DVT-MVTEBEILA\\SQLEXPRESS;Initial Catalog=DVT;Integrated Security=True";

        DVTEntities1 myClass = new DVTEntities1();


        public DailyRegister()
        {
            InitializeComponent();

            personMentors();
           
        }



        public void personMentors()
        {

            SqlConnection Connection = new SqlConnection(myCo);

            try
            {
                Connection.Open();

                string daily = "SELECT * FROM PersonTb WHERE RoleId = '1' ";

                SqlCommand command = new SqlCommand(daily, Connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    string Roles = dr.GetString(2);
                    int id = dr.GetInt32(0);


                    txtMentors.Items.Add(Roles);
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public int getMentors(string name)
        {

            SqlConnection Connection = new SqlConnection(myCo);
            int personID = 0;
            try
            {
                Connection.Open();

                string daily = "SELECT * FROM PersonTb WHERE Names='" + name + "' AND RoleId = '1' AND RoleId != '3'";

                SqlCommand command = new SqlCommand(daily, Connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    string Roles = dr.GetString(2);
                    personID = dr.GetInt32(0);


                    txtMentors.Items.Add(personID);

                }
                return personID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        private void DpDates_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DpDates.SelectedDate == DateTime.Today)
            {
                btnSave.IsEnabled = true;

                //List<PersonTb> user = new List<PersonTb>();
                //user = (from m in myClass.PersonTbs
                //        where m.RoleId == 3
                //        select m).ToList();

                //List<string> ppl = new List<string>();
                //foreach (PersonTb items in user)
                //{

                //    ppl.Add(items.Names);
                //}
                //datadrid1.ItemsSource = user;
                //menteeCm.ItemsSource = ppl;
            }
            else
            {
                btnSave.IsEnabled = false;
            }

           
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            DpDates.Text = DateTime.Today.ToString();

            DpDates.Text = DateTime.Today.ToString();
            List<PersonTb> user = new List<PersonTb>();
            user = (from m in myClass.PersonTbs
                    where m.RoleId == 3
                    select m).ToList();

            List<string> mentee = new List<string>() { };

            foreach (PersonTb items in user)
            {

                mentee.Add(items.Names);

            }
            datadrid1.ItemsSource = user;
            menteeCm.ItemsSource = mentee;
        }

        private void txtMentors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(myCo);
            Connection.Open();

            int getPersons = getMentors(txtMentors.Text);
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM PersonTb WHERE RoleId = '1' AND Names = '" + txtMentors.Text + "' AND PersonId ='" + getPersons + "'; INSERT INTO AttendanceMasterTb(Date, MentorPersonId, Training) VALUES(@Date, @MentorPersonId, @Training ) ", Connection);
            cmd1.Parameters.AddWithValue("@Date", DpDates.Text);
            cmd1.Parameters.AddWithValue("@MentorPersonId", getPersons);
            cmd1.Parameters.AddWithValue("@Training", txtTraining.Text);
            personMentors();
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
            MessageBox.Show("Saved");
        }
    }
}
