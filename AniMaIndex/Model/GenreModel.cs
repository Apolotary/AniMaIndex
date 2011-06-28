using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class GenreModel
    {
        // return all data from table as is
        public static object[] ReturnAllGenre()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Genres select tp).ToArray();
            return temp;
        }

        // returns all names
        public static object[] ReturnAllGenreNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Genres select tp.GenreName).ToArray();
            return temp;
        }

        // searches id by name
        public static int ReturnGenreID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.Genres
                        where tp.GenreName == name
                        select tp.GenreID).First();
            return temp;
        }

        public static void AddGenre(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            Genre adt = new Genre { GenreName = name };
            db.Genres.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemoveGenre(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            Genre[] temp = (from tp in db.Genres select tp).ToArray();
            db.Genres.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
