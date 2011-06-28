using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class StaffModel
    {
        // return all data from table as is
        public static object[] ReturnAllStaff()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Staffs select tp).ToArray();
            return temp;
        }

        public static object[] ReturnAllStaffNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Staffs select tp.StaffName).ToArray();
            return temp;
        }

        public static int[] ReturnAllStaffAniIndexes(int id)
        {
            AnimeDataContext db = new AnimeDataContext();
            int[] temp = (from tp in db.Staffs where tp.TitleID == id select tp.StaffID).ToArray();
            return temp;
        }

        public static StaffConstructModel[] ReturnAllStaffNamesByID(int?[] aid)
        {
            AnimeDataContext db = new AnimeDataContext();
            StaffConstructModel[] temp = new StaffConstructModel[aid.Count()];
            for (int i = 0; i < aid.Count(); ++i)
            {
                temp[i] = (from tp in db.Staffs
                           where tp.StaffID == aid[i]
                           select new StaffConstructModel(tp.StaffName, tp.PersonalPage, tp.Occupation)).FirstOrDefault();
            }

            return temp;
        }

        public static StaffConstructModel[] ReturnAllStaffNamesByGenre(int genID, ref Staff[] anit)
        {
            AnimeDataContext db = new AnimeDataContext();
            StaffConstructModel[] temp = (from tp in db.Staffs
                                          join ant in db.Animes on tp.TitleID equals ant.TitleID
                                          join mang in db.Mangas on tp.MangaID equals mang.MangaID

                                          where ant.GenreID == genID || mang.GenreID == genID
                                          select new StaffConstructModel(tp.StaffName, tp.PersonalPage, tp.Occupation)).ToArray();
            anit = (from tp in db.Staffs
                    join ant in db.Animes on tp.TitleID equals ant.TitleID
                    join mang in db.Mangas on tp.MangaID equals mang.MangaID

                    where ant.GenreID == genID || mang.GenreID == genID
                    select tp).ToArray();
            return temp;
        }

        public static int[] ReturnAllStaffManIndexes(int id)
        {
            AnimeDataContext db = new AnimeDataContext();
            int[] temp = (from tp in db.Staffs where tp.MangaID == id select tp.StaffID).ToArray();
            return temp;
        }

        public static int ReturnStaffID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.Staffs
                        where tp.StaffName == name
                        select tp.StaffID).FirstOrDefault();
            return temp;
        }

        public static void AddStaff(int titleid, int manid, string staffname, string occ, string page)
        {
            AnimeDataContext db = new AnimeDataContext();
            Staff adt = new Staff
            {
                TitleID = titleid,
                MangaID = manid,
                StaffName = staffname,
                Occupation = occ,
                PersonalPage = page
            };
            db.Staffs.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemoveStaff(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            Staff[] temp = (from tp in db.Staffs select tp).ToArray();
            db.Staffs.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
