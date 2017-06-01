using Movie4Rent.DAO;
using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.BUS
{
    class StaffBUS
    {
        public static Staff login (string username, string password)
        {
            return StaffDAO.login(username, password);
        }
    }
}
