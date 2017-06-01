using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie4Rent.Entities;

namespace Movie4Rent.DAO
{
    class MovieDAO
    {
        public static List<Movie> GetAll()
        {
            using (BaseModel model = new BaseModel())
            {
                return model.Movies.ToList();
            }
        }

        public static void Insert(Movie movie)
        {
            using (BaseModel model = new BaseModel())
            {
                model.Movies.Add(movie);
                model.SaveChanges();
            }
        }

        public static void Update(Movie movie)
        {
            using (BaseModel model = new BaseModel())
            {
                var updateMovie = model.Movies.Find(movie.MovieID);
                model.Entry(updateMovie).CurrentValues.SetValues(movie);
                model.SaveChanges();
            }
        }

        public static int? Quantity(Movie movie)
        {
            using (BaseModel model = new BaseModel())
            {
                int? SumImport = model.ImportingDetails.Where(x => x.MovieID == movie.MovieID)
                                                      .Sum(x => x.Quant);
                int? SumExport = model.ExportingDetails.Where(x => x.MovieID == movie.MovieID)
                                                      .Sum(x => x.Quant);
                int? result = SumImport - SumExport;

                return result;
            }
        }
        public static void Delete(Movie movie)
        {
            using (BaseModel model = new BaseModel())
            {
                var del = model.Movies.Find(movie.MovieID);
                model.Movies.Remove(del);
                model.SaveChanges();
            }
        }
    }
}
