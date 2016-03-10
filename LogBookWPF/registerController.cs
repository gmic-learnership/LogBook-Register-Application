using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookWPF
{
    class registerController
    {

        public string insertDetails(AttendanceDetailsTb details)
        {
            try
            {
                DVTEntities1 db = new DVTEntities1();

                db.AttendanceDetailsTbs.Add(details);
                db.SaveChanges();
                return "Inserted";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string insertMaster(AttendanceMasterTb details)
        {
            try
            {
                DVTEntities1 db = new DVTEntities1();

                db.AttendanceMasterTbs.Add(details);
                db.SaveChanges();
                return "Inserted";
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
