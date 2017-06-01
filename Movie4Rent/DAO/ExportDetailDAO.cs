using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.DAO
{
    class ExportDetailDAO
    {
        public static List<ExportingDetail> GetAll(Exporting export)
        {
            using (BaseModel model = new BaseModel())
            {
                return model.ExportingDetails.Where(x => x.ExportID == export.ExportID).ToList();
            }
        }

        public static void Insert(ExportingDetail detail)
        {
            using (BaseModel model = new BaseModel())
            {
                model.ExportingDetails.Add(detail);
                model.SaveChanges();
            }
        }

        public static void Update(ExportingDetail detail)
        {
            using (BaseModel model = new BaseModel())
            {
                var update = model.ExportingDetails.Find(detail.ExportID, detail.MovieID);
                model.Entry(update).CurrentValues.SetValues(detail);
                model.SaveChanges();
            }
        }

        public static void Delete(ExportingDetail detail)
        {
            using (BaseModel model = new BaseModel())
            {
                var del = model.ExportingDetails.Find(detail.ExportID);
                model.ExportingDetails.Remove(del);
                model.SaveChanges();
            }
        }


    }
}
