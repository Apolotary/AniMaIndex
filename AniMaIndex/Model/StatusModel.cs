using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class StatusModel
    {
        // return all data from table as is
        public static object[] ReturnAllStatus()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.UserStatus select tp).ToArray();
            return temp;
        }

        public static object[] ReturnAllStatuNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.UserStatus select tp.StatusName).ToArray();
            return temp;
        }

        public static int ReturnStatusID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.UserStatus
                        where tp.StatusName == name
                        select tp.StatusID).FirstOrDefault();
            return temp;
        }

        public static string ReturnStatusName(int? sid)
        {
            AnimeDataContext db = new AnimeDataContext();
            string temp = (from tp in db.UserStatus
                        where tp.StatusID == sid
                           select tp.StatusName).FirstOrDefault();
            return temp;
        }

        public static void AddStatus(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            UserStatus adt = new UserStatus { StatusName = name};
            db.UserStatus.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemoveStatus(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            UserStatus[] temp = (from tp in db.UserStatus select tp).ToArray();
            db.UserStatus.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
