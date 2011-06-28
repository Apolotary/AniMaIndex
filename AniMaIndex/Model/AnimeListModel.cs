using System.Linq;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class AnimeListModel
    {
        // returns a specific animelist
        public static AnimeListConstructModel[] ReturnAllAnimeList()
        {
            AnimeDataContext db = new AnimeDataContext();
            // getting all title names by id
            int?[] aniids = (from tp in db.AnimeLists where tp.UserID == UserLogModel.lastid select tp.TitleID).ToArray();
            AnimeConstructModel[] tmp2 = AnimeModel.ReturnAllAnimeNamesByID(aniids);
            // this array will be displayed
            AnimeListConstructModel[] tmp = new AnimeListConstructModel[tmp2.Count()];
            for (int i = 0; i < tmp2.Count(); ++i) // filling array with all required data
            { 
                int? score = (from tp in db.AnimeLists
                                          where tp.TitleID == AnimeModel.ReturnAnimeID(tmp2[i].title_name)
                                          select tp.Score).FirstOrDefault();
                int? eps = (from tp in db.AnimeLists
                                          where tp.TitleID == AnimeModel.ReturnAnimeID(tmp2[i].title_name)
                                          select tp.EpsWatched).FirstOrDefault();
                int? statid = (from tp in db.AnimeLists
                               where tp.TitleID == AnimeModel.ReturnAnimeID(tmp2[i].title_name)
                               select tp.StatusID).FirstOrDefault();
                tmp[i] = new AnimeListConstructModel(tmp2[i], score, eps, StatusModel.ReturnStatusName(statid));
            }
                return tmp;
        }

        // adds new list
        public static void AddAnimeList(int tid, int uid, int stat, int score, int eps)
        {
            AnimeDataContext db = new AnimeDataContext();
            AnimeList adan = new AnimeList { TitleID = tid, UserID = uid, StatusID = stat, Score = score, EpsWatched = eps};
            db.AnimeLists.InsertOnSubmit(adan);
            db.SubmitChanges();
        }

        // removes list by index
        public static void RemoveAnimeList(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            AnimeList[] temp = (from tp in db.AnimeLists select tp).ToArray();
            db.AnimeLists.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
