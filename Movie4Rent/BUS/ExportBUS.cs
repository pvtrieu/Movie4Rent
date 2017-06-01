using Movie4Rent.DAO;
using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.BUS
{
    class ExportBUS
    {
        public static List<Exporting> GetAll()
        {
            return ExportDAO.GetAll();
        }

        public static bool Insert(Exporting export)
        {
            try
            {
                ExportDAO.Insert(export);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Exporting export)
        {
            try
            {
                ExportDAO.Delete(export);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int? Sum(Exporting export)
        {
            return ExportDAO.Sum(export);
        }
    }
}
