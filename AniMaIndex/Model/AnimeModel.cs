using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class AnimeModel
    {
        // returns all titels as is
        public static object[] ReturnAllAnime()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Animes select tp).ToArray();
            return temp;
        }

        // returns all names
        public static object[] ReturnAllAnimeNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Animes select tp.TitleName).ToArray();
            return temp;
        }

        // returns all names by id
        public static AnimeConstructModel[] ReturnAllAnimeNamesByID(int?[] aid)
        {
            AnimeDataContext db = new AnimeDataContext();
            AnimeConstructModel[] temp = new AnimeConstructModel[aid.Count()];
            for (int i = 0; i < aid.Count(); ++i) // filling array with data from other tables
            {
                temp[i] = (from tp in db.Animes 
                           join ma in db.Mangas on tp.MangaID equals ma.MangaID
                           join st in db.Studios on tp.StudioID equals st.StudioID
                           join sty in db.SerialTypes on tp.SerialTypeID equals sty.SerialTypeID
                           join gen in db.Genres on tp.GenreID equals gen.GenreID
                           join air in db.AiredYets on tp.AiredID equals air.AiredID

                           where tp.TitleID == aid[i]
                           select new AnimeConstructModel(ma.MangaName, 
                                      st.StudioName,
                                      tp.AniYear,
                                      tp.TitleName,
                                      sty.SerialName,
                                      gen.GenreName,
                                      tp.ShortDescription,
                                      tp.Episodes,
                                      air.AiredName)).FirstOrDefault();
            }
            
            return temp;
        }

        // returns all names by genre
        public static AnimeConstructModel[] ReturnAllAnimeNamesByGenre(int?[] aid, int genID)
        {
            AnimeDataContext db = new AnimeDataContext();
            AnimeConstructModel[] temp = new AnimeConstructModel[aid.Count()];
            for (int i = 0; i < aid.Count(); ++i)
            {
                temp[i] = (from tp in db.Animes
                           join ma in db.Mangas on tp.MangaID equals ma.MangaID
                           join st in db.Studios on tp.StudioID equals st.StudioID
                           join sty in db.SerialTypes on tp.SerialTypeID equals sty.SerialTypeID
                           join gen in db.Genres on tp.GenreID equals gen.GenreID 
                           join air in db.AiredYets on tp.AiredID equals air.AiredID

                           where tp.TitleID == aid[i] 
                           && tp.GenreID == genID
                           select new AnimeConstructModel(ma.MangaName,
                                      st.StudioName,
                                      tp.AniYear,
                                      tp.TitleName,
                                      sty.SerialName,
                                      gen.GenreName,
                                      tp.ShortDescription,
                                      tp.Episodes,
                                      air.AiredName)).FirstOrDefault();
            }

            return temp;
        }

        // returns all names by genre and.. oh shit =O
        public static AnimeConstructModel[] ReturnAllAnimeNamesByGenre(int genID, ref Anime[] anit)
        {
            AnimeDataContext db = new AnimeDataContext();
            AnimeConstructModel[] temp = (from tp in db.Animes
                                          join ma in db.Mangas on tp.MangaID equals ma.MangaID
                                          join st in db.Studios on tp.StudioID equals st.StudioID
                                          join sty in db.SerialTypes on tp.SerialTypeID equals sty.SerialTypeID
                                          join gen in db.Genres on tp.GenreID equals gen.GenreID
                                          join air in db.AiredYets on tp.AiredID equals air.AiredID

                                          where tp.GenreID == genID
                                          select new AnimeConstructModel(ma.MangaName,
                                                     st.StudioName,
                                                     tp.AniYear,
                                                     tp.TitleName,
                                                     sty.SerialName,
                                                     gen.GenreName,
                                                     tp.ShortDescription,
                                                     tp.Episodes,
                                                     air.AiredName)).ToArray();
            anit = (from tp in db.Animes
                    where tp.GenreID == genID
                    select tp).ToArray();
            return temp;
        }

        // search for id by name
        public static int ReturnAnimeID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.Animes
                        where tp.TitleName == name
                        select tp.TitleID).First();
            return temp;
        }

        // adds title
        public static void AddAnime(int manid, int studid, int ayear, string tname, int stypeid, 
                                    int genid, string shortdesc, int eps, int airedid)
        {
            AnimeDataContext db = new AnimeDataContext();
            Anime adt = new Anime { MangaID = manid, StudioID = studid, AniYear = ayear,
                                        TitleName = tname, SerialTypeID = stypeid, GenreID = genid
                                    , ShortDescription = shortdesc, Episodes = eps, AiredID = airedid};
            db.Animes.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        // removes title
        public static void RemoveAnime(int index)
        {
            AnimeDataContext db = new AnimeDataContext();
            Anime[] temp = (from tp in db.Animes select tp).ToArray();
            
            db.Animes.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
