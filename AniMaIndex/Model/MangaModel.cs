using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class MangaModel
    {
        // return all data from table as is
        public static object[] ReturnAllManga()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Mangas select tp).ToArray();
            return temp;
        }
        
        public static object[] ReturnAllMangaNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Mangas select tp.MangaName).ToArray();
            return temp;
        }

        public static int ReturnMangaID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.Mangas
                        where tp.MangaName == name
                        select tp.MangaID).FirstOrDefault();
            return temp;
        }

        public static MangaConstructModel[] ReturnAllMangaNamesByID(int?[] aid)
        {
            AnimeDataContext db = new AnimeDataContext();
            // filling array with appropriate data, only first search result will be added to array
            MangaConstructModel[] temp = new MangaConstructModel[aid.Count()];
            for (int i = 0; i < aid.Count(); ++i)
            {
                temp[i] = (from tp in db.Mangas
                           join pub in db.Publishers on tp.PublisherID equals pub.PublisherID
                           join gen in db.Genres on tp.GenreID equals gen.GenreID
                           join air in db.AiredYets on tp.AiredID equals air.AiredID

                           where tp.MangaID == aid[i]
                           select new MangaConstructModel(tp.MangaName, 
                               pub.PublisherName, tp.MangaYear,
                               tp.MangaName, tp.ShortDescription, tp.Chapters, tp.Thomes, air.AiredName,
                               gen.GenreName
                               )).FirstOrDefault();
            }

            return temp;
        }

        public static MangaConstructModel[] ReturnAllMangaNamesByGenre(int genID, ref Manga[] anit)
        {
            AnimeDataContext db = new AnimeDataContext();
            MangaConstructModel[] temp = (from tp in db.Mangas
                                          join pub in db.Publishers on tp.PublisherID equals pub.PublisherID
                                          join gen in db.Genres on tp.GenreID equals gen.GenreID
                                          join air in db.AiredYets on tp.AiredID equals air.AiredID

                                          where tp.GenreID == genID
                                          select new MangaConstructModel(tp.MangaName,
                                           pub.PublisherName, tp.MangaYear,
                                           tp.MangaName, tp.ShortDescription, tp.Chapters, tp.Thomes, air.AiredName,
                                           gen.GenreName)).ToArray();
            anit = (from tp in db.Mangas
                    join pub in db.Publishers on tp.PublisherID equals pub.PublisherID
                    join gen in db.Genres on tp.GenreID equals gen.GenreID
                    join air in db.AiredYets on tp.AiredID equals air.AiredID

                    where tp.GenreID == genID
                    select tp).ToArray();
            return temp;
        }

        public static void AddManga(int airedid, int chaps, int genreid, string mname, int myear, 
            int pubid, string shortd, int thomes)
        {
            AnimeDataContext db = new AnimeDataContext();
            Manga adt = new Manga {AiredID = airedid, Chapters = chaps, GenreID = genreid, MangaName = mname, 
                MangaYear = myear, PublisherID = pubid, ShortDescription = shortd, Thomes = thomes};
            
            db.Mangas.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemoveManga(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            Manga[] temp = (from tp in db.Mangas select tp).ToArray();
            db.Mangas.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
