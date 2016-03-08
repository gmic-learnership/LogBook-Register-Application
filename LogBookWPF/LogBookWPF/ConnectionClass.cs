using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;


namespace LogBookWPF
{
    class ConnectionClass
    {

        string myCo = "Data Source=DVT-MVTEBEILA\\SQLEXPRESS;Initial Catalog=DVT;Integrated Security=True";
        string Message;

        public void Signup(string Surname, string Names, string Gender, string EmailAddress, string Username, string Password, int RoleId)
        {

            try
            {
                SqlConnection Connection = new SqlConnection(myCo);
                Connection.Open();
                //  string role = "";
                string Query = "INSERT INTO PersonTb (Surname, Names, Gender, EmailAddress, Username, Password, RoleId) VALUES ('" + Surname + "', '" + Names + "',  '" + Gender + "', '" + EmailAddress + "', '" + Username + "', '" + Password + "', '" + RoleId + "' )";

                SqlCommand command = new SqlCommand(Query, Connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Saved");
                Connection.Close();
                LogBookTask task = new LogBookTask();
                task.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //public void Roles()
        //{
        //    SqlConnection Connection = new SqlConnection(myCo);

        //    try
        //    {
        //        Connection.Open();
        //        string Daily = "SELECT * FROM RoleTb";

        //        SqlCommand command = new SqlCommand(Daily, Connection);
        //        SqlDataReader dr = command.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            // string Id = dr.GetString(0);
        //            string Roles = dr.GetString(1);
        //            //  string FullName = Id + " " + Roles;

        //            SignUpForm signup = new SignUpForm();

        //            signup.cmRoles.Items.Add(Roles);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //public void Master(string date, int personId, string training)
        //{
        //    try
        //    {
        //        SqlConnection Connection = new SqlConnection(myCo);
        //        Connection.Open();
        //        //  string role = "";
        //        // string Query = "INSERT INTO  AttendanceMasterTb (Date, PersonId, Training)  Values('" + date + "', '" + personId + "','" + training + "')join  INSERT INTO AttendanceDetailsTb(PersonId, Hours)VALUES ('" + personId2 + "', '" + hours + "')";

        //        string Query = "SELECT * FROM PersonTb WHERE RoleId = '1'; INSERT INTO  AttendanceMasterTb( Date,  AttendanceMasterTb.PersonId, Training) Values('" + date + "', '" + personId + "', '" + training + "')";
        //        SqlCommand command = new SqlCommand(Query, Connection);

        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Saved");
        //        Connection.Close();
        //        // DailyRegister daily = new DailyRegister();
        //        //  daily.Show();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        //public void details(int personId, string hours)
        //{
        //    try
        //    {
        //        SqlConnection Connection = new SqlConnection(myCo);
        //        Connection.Open();


        //        string Query = "SELECT * FROM PersonTb WHERE RoleId = '3'; INSERT INTO  AttendanceDetailsTb (AttendanceDetailsTb.PersonId, Hours, MasterId)  Values('" + personId + "', '" + hours + "', @MasterId  ) ";
        //        SqlCommand command = new SqlCommand(Query, Connection);

        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Saved");
        //        Connection.Close();
        //        // DailyRegister daily = new DailyRegister();
        //        //  daily.Show();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}


        public string LoginMentors(string username, string password)
        {
            SqlConnection myConnection = new SqlConnection(myCo);
            myConnection.Open();
            try
            {
                string query = "SELECT * FROM PersonTb WHERE Username = '" + username + "' AND Password = '" + password + "' AND RoleId = '1'";



                SqlCommand command = new SqlCommand(query, myConnection);
                command.ExecuteNonQuery();

                //myConnection.Close();
                SqlDataReader dr = command.ExecuteReader();



                int count = 0;
                while (dr.Read())
                {
                    count++;
                }


                if (count == 1)
                {


                    Message = "Successfully login";
                    MessageBox.Show(Message);
                    LogBookTask task = new LogBookTask();
                    task.Show();

                }


                if (count > 1)
                {
                    Message = "duplicated";
                    MessageBox.Show(Message);
                }


                if (count < 1)
                {
                    Message = "Only Mentors and Manager  are allowed to login for daily register";
                    MessageBox.Show(Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConnection.Close();
            return Message;
           
        }

    }
}
