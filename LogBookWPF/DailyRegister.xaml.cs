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
    /// Interaction logic for Daily_regiater.xaml
    /// </summary>
    /// 


    public class Per
    {
        public string Names { get; set; }
        public string Hours { get; set; }

        public Per()
        {
            Names = Names;
            Hours = Hours;
        }
        public Per(string name, string hours)
        {
            Names = name;
            Hours = hours;
        }



    }
    public partial class DailyRegister : Window
    {
        string myCo = "Data Source=DVT-MVTEBEILA\\SQLEXPRESS;Initial Catalog=DVT;Integrated Security=True";

        DVTEntities1 myClass = new DVTEntities1();

        List<Per> person;
        public List<Per> personAttrib;

        public List<int> ID = new List<int>();
        public List<string> Names2 { get; set; }
        public List<int> MentorID = new List<int>();
        public List<int> MenID = new List<int>();
        public List<PersonTb> list2 = new List<PersonTb>() { };


        public  DailyRegister()
        {
            InitializeComponent();
            personMentors();

            new Per();
            datadrid1.ItemsSource = personAttrib;
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
                    string Surname = dr.GetString(1);
                    string Name = dr.GetString(2);
                    string Roles = Surname + " " + Name;
                    int id = dr.GetInt32(0);


                    txtMentors.Items.Add(Name );
                    //txtMentors.Items.Add(id);

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

     
        
        private void Window_Activated(object sender, EventArgs e)
        {

            DpDates.Text = DateTime.Today.ToString();
            List<PersonTb> user = new List<PersonTb>();

            SqlConnection Connection = new SqlConnection(myCo);

            Connection.Open();

            string daily = "SELECT * FROM PersonTb WHERE RoleId = '3' ";

            SqlCommand command = new SqlCommand(daily, Connection);
            SqlDataReader dr = command.ExecuteReader();
            List<string> ppl = new List<string>();
            foreach (var items in daily)
            {
                while (dr.Read())
                {
                    string Surname = dr.GetString(1);
                    string Name = dr.GetString(2);
                    int id = dr.GetInt32(0);
                    string Roles = Surname + " " + Name;
                    ppl.Add(Name );
                }
                datadrid1.ItemsSource = user;
                menteeCm.ItemsSource = ppl;
            }
        }

        private void AddMaster()
        {
            DVTEntities1 db = new DVTEntities1();
            registerController rc = new registerController();


            DataGridCell c = dataGridHelper.GetCell(datadrid1, 0, 0);
            DataGridCell bh = dataGridHelper.GetCell(datadrid1, 0, 1);//get rows and column

            ComboBox cmbNames = (ComboBox)c.Content; //get content
            TextBlock txthours = (TextBlock)bh.Content;
            var hr = txthours.Text;
            if (!Regex.IsMatch(hr, "^((?:[0-9]|1[0-9]|2[0-3])(?:\\.\\d{1,2})?|24(?:\\.00?)?)$"))
            {
                MessageBox.Show("Invalid input for Hours");

            }

            AttendanceMasterTb master = new AttendanceMasterTb();

            //master.Date = DpDates.SelectedDate;
            //master.MentorPersonId = 7;
            //master.Training = txtTraining.Text;

            var na1 = cmbNames.SelectedItem.ToString();//check the name

            var mentor = txtMentors.SelectedItem.ToString();
            List<PersonTb> query1 = (from x in db.PersonTbs
                                     where x.Names == mentor
                                     select x).ToList();

            foreach (var item in query1)//loop throur the list to get the person id
            {
                master.Date = DpDates.SelectedDate;
                master.MentorPersonId = item.PersonId;
                master.Training = txtTraining.Text;

            }
            rc.insertMaster(master);


            var na = cmbNames.SelectedItem.ToString();//check the name
            List<PersonTb> query = (from x in db.PersonTbs
                                    where x.Names == na
                                    select x).ToList();
            //MessageBox.Show(na.ToString());
            AttendanceDetailsTb details = new AttendanceDetailsTb();
            foreach (var item in query)//loop throur the list to get the person id
            {

                details.MasterId = master.MasterId;
                details.MenteeePersonId = item.PersonId;
                details.Hours = hr;
               

            }


            rc.insertDetails(details);
            MessageBox.Show("Saved");
         
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            AddMaster();
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            
            

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
           
            LogBookTask task = new LogBookTask();
            task.Show();
            this.Close();
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Close();
        
        }

        private void DpDates_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            datadrid1.ItemsSource = list2;
            datadrid1.SelectedIndex = 0;
            Display();
        }

        private void Display()
        {
            List<string> selectedNames = new List<string>();
            person = new List<Per>();

            using (DVTEntities1 context = new DVTEntities1())
            {
                List<AttendanceDetailsTb> queryDiteils =
                    (from D in context.AttendanceDetailsTbs
                     join M in context.AttendanceMasterTbs on D.MasterId equals M.MasterId
                     where M.Date == DpDates.SelectedDate
                     select D).ToList();


                List<AttendanceMasterTb> queryMaster = (from M in context.AttendanceMasterTbs
                                                        join D in context.AttendanceDetailsTbs on M.MasterId equals D.MasterId
                                                        where M.Date == DpDates.SelectedDate
                                                        select M).ToList();


                List<Per> persons = new List<Per>() { };

                foreach (var item in queryDiteils)
                {
                    List<AttendanceMasterTb> queryMentor = (from M in context.AttendanceMasterTbs
                                                            join D in context.AttendanceDetailsTbs on M.MasterId equals D.MasterId
                                                            join P in context.PersonTbs on D.MenteeePersonId equals P.PersonId
                                                            where M.Date == DpDates.SelectedDate
                                                            select M).ToList();


                    foreach (var item1 in queryMentor)
                    {
                        txtTraining.Text = item1.Training;
                        foreach (var i in ID)
                        {
                            datadrid1.ItemsSource = queryMentor;
                            foreach (var item3 in queryMentor)
                            {
                                txtTraining.Text = item3.Training;
                                if (DpDates.SelectedDate != item3.Date)
                                {
                                    txtMentors.SelectedIndex = 0;
                                    txtTraining.Text = item3.Training;
                                }
                            }

                            if (i.Equals(item1.MentorPersonId))
                            {

                                selectedNames.Add(Names2.ElementAt(MenID.IndexOf(item1.MasterId)));
                                txtMentors.SelectedIndex = ID.IndexOf(item1.MasterId);
                            }
                          
                        }
                        //menteeCm.ItemsSource = item1
                    }
                   
                    

                    person.Clear();
                    for (int i = 0; i < queryDiteils.Count; i++)
                    {
                        int id = Convert.ToInt32(queryDiteils[i].MenteeePersonId);

                        List<PersonTb> mentee = (from P in context.PersonTbs
                                                 where P.PersonId == id
                                                 select P).ToList();

                        person.Add(new Per(mentee[0].Names,
                            queryDiteils[i].Hours));
                    }
                    datadrid1.ItemsSource = person;
                    datadrid1.SelectedIndex = 0;
                }

            }

        }
    }
}
