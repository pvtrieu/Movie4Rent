using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.DAO
{
    class ExportDAO
    {
        public static List<Exporting> GetAll()
        {
            using (BaseModel model = new BaseModel())
            {
                return model.Exportings.ToList();
            }
        }

        public static void Insert(Exporting export)
        {
            using (BaseModel model = new BaseModel())
            {
                model.Exportings.Add(export);
                model.SaveChanges();
            }
        }

        public static void Delete(Exporting export)
        {
            using (BaseModel model = new BaseModel())
            {
                var del = model.Exportings.Find(export.ExportID);
                model.Exportings.Remove(del);
                model.SaveChanges();
            }
        }

        public static int? Sum(Exporting export)
        {
            using (BaseModel model = new BaseModel())
            {
                var sum = model.Exportings.Find(export.ExportID);
                export.TotalQuant = model.ExportingDetails.Where(x => x.ExportID == export.ExportID)
                                                          .Sum(x => x.Quant);
                model.Entry(sum).CurrentValues.SetValues(export);
                model.SaveChanges();
                return export.TotalQuant;
            }
        }
    }
}
