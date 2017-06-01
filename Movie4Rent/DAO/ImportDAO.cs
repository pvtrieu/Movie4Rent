using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie4Rent.DAO
{
    class ImportDAO
    {
        public static List<Importing> getAll()
        {
            using (BaseModel model = new BaseModel())
            {
                return model.Importings.ToList();
            }
        }

        public static void Insert(Importing import)
        {
            using (BaseModel model = new BaseModel())
            {
                model.Importings.Add(import);
                model.SaveChanges();
            }
        }

        public static void Delete(Importing import)
        {
            using (BaseModel model = new BaseModel())
            {
                var del = model.Importings.Find(import.ImportID);
                model.Importings.Remove(del);
                model.SaveChanges();
            }
        }
    }
}
