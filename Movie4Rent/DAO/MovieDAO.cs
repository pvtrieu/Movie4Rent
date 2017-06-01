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

        public static List<Movie> Search(Movie searchMovie)
        {
            using (BaseModel model = new BaseModel())
            {
                var result = model.Movies.ToList();
                if (searchMovie.Title != null)
                    result = result.Where(x =>x.Title!=null && x.Title.Contains(searchMovie.Title)).ToList();
                if (searchMovie.Description != null)
                    result = result.Where(x => x.Description != null && x.Description.Contains(searchMovie.Description)).ToList();
                if (searchMovie.Director!= null)
                    result = result.Where(x => x.Director != null && x.Director.Contains(searchMovie.Director)).ToList();
                if (searchMovie.IMDB != null)
                    result = result.Where(x => x.IMDB != null && x.IMDB >= searchMovie.IMDB).ToList();

                if (searchMovie.Genre != null)
                {       
                    List<string> gerne = searchMovie.Genre.Split(',').Select(x => x.Trim()).ToList();
                    foreach (string s in gerne)
                        result = result.Where(x => x.Genre != null && x.Genre.Contains(s)).ToList();
                }

                if (searchMovie.Actor != null)
                {
                    List<string> actor = searchMovie.Actor.Split(',').Select(x => x.Trim()).ToList();
                    foreach (string s in actor)
                        result = result.Where(x => x.Actor != null && x.Actor.Contains(s)).ToList();
                }
                return result;
            }
        }
    }
}
