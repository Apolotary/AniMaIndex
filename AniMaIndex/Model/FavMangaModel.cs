using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class FavMangaModel
    {
        // returns all manga
        public static MangaConstructModel[] ReturnAllFavManga()
        {
            AnimeDataContext db = new AnimeDataContext();
            int?[] aniids = (from tp in db.FavMangas where tp.UserID == UserLogModel.lastid select tp.MangaID).ToArray();
            MangaConstructModel[] tmp = MangaModel.ReturnAllMangaNamesByID(aniids);
            return tmp;
        }

        // searches by genre
        public static MangaConstructModel[] ReturnAllFavMangaByGenre(string genrename, ref Manga[] anit)
        {
            AnimeDataContext db = new AnimeDataContext();
            MangaConstructModel[] tmp = MangaModel.ReturnAllMangaNamesByGenre(GenreModel.ReturnGenreID(genrename), ref anit);
            return tmp;
        }

        public static void AddFavManga(int tid, int uid)
        {
            AnimeDataContext db = new AnimeDataContext();
            FavManga adan = new FavManga { MangaID = tid, UserID = uid };
            db.FavMangas.InsertOnSubmit(adan);
            db.SubmitChanges();
        }

        public static void RemoveFavManga(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            FavManga[] temp = (from tp in db.FavMangas select tp).ToArray();
            db.FavMangas.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
