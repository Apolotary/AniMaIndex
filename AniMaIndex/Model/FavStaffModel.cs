using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class FavStaffModel
    {
        // returns all staff
        public static StaffConstructModel[] ReturnAllFavStaff()
        {
            AnimeDataContext db = new AnimeDataContext();
            int?[] aniids = (from tp in db.FavStaffs where tp.UserID == UserLogModel.lastid select tp.StaffID).ToArray();
            StaffConstructModel[] tmp = StaffModel.ReturnAllStaffNamesByID(aniids);
            return tmp;
        }
        
        // returns all staff by genre
        public static StaffConstructModel[] ReturnAllFavStaffByGenre(string genrename, ref Staff[] anit)
        {
            AnimeDataContext db = new AnimeDataContext();
            StaffConstructModel[] tmp = StaffModel.ReturnAllStaffNamesByGenre(GenreModel.ReturnGenreID(genrename), ref anit);
            return tmp;
        }
        
        public static void AddFavStaff(int tid, int uid)
        {
            AnimeDataContext db = new AnimeDataContext();
            FavStaff adan = new FavStaff{ StaffID = tid, UserID = uid};
            db.FavStaffs.InsertOnSubmit(adan);
            db.SubmitChanges();
        }

        public static void RemoveFavStaff(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            FavStaff[] temp = (from tp in db.FavStaffs select tp).ToArray();
            db.FavStaffs.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
