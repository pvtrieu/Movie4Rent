using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.DAO
{
    class ImportDetailDAO
    {
        public static List<ImportingDetail> GetAll(Importing import)
        {
            using (BaseModel model = new BaseModel())
            {
                return model.ImportingDetails.Where(x => x.ImportID == import.ImportID).ToList();
            }
        }

        public static void Insert(ImportingDetail detail)
        {
            using (BaseModel model = new BaseModel())
            {
                model.ImportingDetails.Add(detail);
                model.SaveChanges();
            }
        }

        public static void Update(ImportingDetail detail)
        {
            using (BaseModel model = new BaseModel())
            {
                var update = model.ImportingDetails.Find(detail.ImportID, detail.MovieID);
                model.Entry(update).CurrentValues.SetValues(detail);
                model.SaveChanges();
            }
        }

        public static void Delete(ImportingDetail detail)
        {
            using (BaseModel model = new BaseModel())
            {
                var del = model.ImportingDetails.Find(detail.ImportID);
                model.ImportingDetails.Remove(del);
                model.SaveChanges();
            }
        }

        
    }
}
