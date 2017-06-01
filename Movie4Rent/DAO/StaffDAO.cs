using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie4Rent.Entities;

namespace Movie4Rent.DAO
{
    class StaffDAO
    {
        public static Staff login(string username, string password)
        {
            using (BaseModel model = new BaseModel())
            {
                Staff staff = model.Staffs.Where(x => x.Username == username).First();
                if (staff != null && staff.Password == password)
                    return staff;
                else
                    return null;
            }
        }
    }
}
