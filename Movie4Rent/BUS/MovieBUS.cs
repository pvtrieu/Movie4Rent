using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie4Rent.Entities;
using Movie4Rent.DAO;

namespace Movie4Rent.BUS
{
    class MovieBUS
    {
        public static List<Movie> GetAll()
        {
            return MovieDAO.GetAll();
        }

        public static bool Insert(Movie movie)
        {
            try
            {
                MovieDAO.Insert(movie);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Movie movie)
        {
            try
            {
                MovieDAO.Delete(movie);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Movie movie)
        {
            try
            {
                MovieDAO.Update(movie);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int? Quantity(Movie movie)
        {
            return MovieBUS.Quantity(movie);
        }

        public static List<Movie> Search(Movie searchMovie)
        {
            return MovieDAO.Search(searchMovie);
        }
    }
}
