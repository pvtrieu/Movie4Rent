using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie4Rent.DAO;

namespace Movie4Rent.BUS
{
    class ImportDetailBUS
    {
        public static List<ImportingDetail> GetAll(Importing import)
        {
            return ImportDetailDAO.GetAll(import);
        }

        public static bool Insert(ImportingDetail detail)
        {
            try
            {
                ImportDetailDAO.Insert(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(ImportingDetail detail)
        {
            try
            {
                ImportDetailDAO.Update(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(ImportingDetail detail)
        {
            try
            {
                ImportDetailDAO.Delete(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
