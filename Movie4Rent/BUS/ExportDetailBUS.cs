using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie4Rent.DAO;

namespace Movie4Rent.BUS
{
    class ExportDetailBUS
    {
        public static List<ExportingDetail> GetAll(Exporting export)
        {
            return ExportDetailDAO.GetAll(export);
        }

        public static bool Insert(ExportingDetail detail)
        {
            try
            {
                ExportDetailDAO.Insert(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(ExportingDetail detail)
        {
            try
            {
                ExportDetailDAO.Update(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(ExportingDetail detail)
        {
            try
            {
                ExportDetailDAO.Delete(detail);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
