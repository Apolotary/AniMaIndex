using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class MangaListModel
    {
        // returns a mangalist
        public static MangaListConstructModel[] ReturnAllMangaList()
        {
            AnimeDataContext db = new AnimeDataContext();
            int?[] aniids = (from tp in db.MangaLists where tp.UserID == UserLogModel.lastid select tp.MangaID).ToArray();
            MangaConstructModel[] tmp2 = MangaModel.ReturnAllMangaNamesByID(aniids);
            // filling array that will be displayed with data
            MangaListConstructModel[] tmp = new MangaListConstructModel[tmp2.Count()];
            for (int i = 0; i < tmp2.Count(); ++i)
            {
                int? score = (from tp in db.MangaLists
                              where tp.MangaID == MangaModel.ReturnMangaID(tmp2[i].title_name)
                              select tp.Score).FirstOrDefault();
                int? thomes = (from tp in db.MangaLists
                            where tp.MangaID == MangaModel.ReturnMangaID(tmp2[i].title_name)
                            select tp.ThomesRead).FirstOrDefault();
                int? chapters = (from tp in db.MangaLists
                            where tp.MangaID == MangaModel.ReturnMangaID(tmp2[i].title_name)
                            select tp.ChaptersRead).FirstOrDefault();
                int? stid = (from tp in db.MangaLists
                                 where tp.MangaID == MangaModel.ReturnMangaID(tmp2[i].title_name)
                                 select tp.StatusID).FirstOrDefault();
                tmp[i] = new MangaListConstructModel(tmp2[i], score, chapters, thomes, StatusModel.ReturnStatusName(stid));
            }
            return tmp;
        }
        

        public static void AddMangaList(int tid, int uid, int stat, int score, int thomes, int chaps)
        {
            AnimeDataContext db = new AnimeDataContext();
            MangaList adan = new MangaList { MangaID = tid, UserID = uid, StatusID = stat, Score = score, ThomesRead = thomes, ChaptersRead = chaps};
            db.MangaLists.InsertOnSubmit(adan);
            db.SubmitChanges();
        }

        public static void RemoveMangaList(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            MangaList[] temp = (from tp in db.MangaLists select tp).ToArray();
            db.MangaLists.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
