using Movie4Rent.DAO;
using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.BUS
{
    class ImportBUS
    {
        public static List<Importing> GetAll()
        {
            return ImportDAO.GetAll();
        }

        public static bool Insert(Importing import)
        {
            try
            {
                ImportDAO.Insert(import);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Importing import)
        {
            try
            {
                ImportDAO.Delete(import);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int? Sum(Importing import)
        {
            return ImportDAO.Sum(import);
        }
    }
}
