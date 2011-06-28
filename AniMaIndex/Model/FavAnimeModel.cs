using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class FavAnimeModel
    {
        // returns all names
        public static AnimeConstructModel[] ReturnAllFavAnime()
        {
            AnimeDataContext db = new AnimeDataContext();
            int?[] aniids = (from tp in db.FavAnimes where tp.UserID == UserLogModel.lastid select tp.TitleID).ToArray();
            AnimeConstructModel[] tmp = AnimeModel.ReturnAllAnimeNamesByID(aniids);
            return tmp;
        }

        // searches by genre
        public static AnimeConstructModel[] ReturnAllFavAnimeByGenre(string genrename, ref Anime[] anit)
        {
            AnimeDataContext db = new AnimeDataContext();
            AnimeConstructModel[] tmp = AnimeModel.ReturnAllAnimeNamesByGenre(GenreModel.ReturnGenreID(genrename), ref anit);
            return tmp;
        }

        public static object[] ReturnAllFavAnimeAsIs()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] tmp = (from tp in db.FavAnimes where tp.UserID == UserLogModel.lastid select tp).ToArray();
            return tmp;
        }

        public static void AddFavAnime(int tid, int uid)
        {
            AnimeDataContext db = new AnimeDataContext();
            FavAnime adan = new FavAnime() { TitleID = tid, UserID = uid};
            db.FavAnimes.InsertOnSubmit(adan);
            db.SubmitChanges();
        }

        public static void RemoveFavAnime(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            FavAnime[] temp = (from tp in db.FavAnimes select tp).ToArray();
            db.FavAnimes.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
