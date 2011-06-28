using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class UserLogModel
    {
        public static int lastid = 0;
        public static void AddUserLog(int uid)
        {
            AnimeDataContext db = new AnimeDataContext();
            UserLog adusr = new UserLog { UserID = uid};
            db.UserLogs.InsertOnSubmit(adusr);
            db.SubmitChanges();
            lastid = uid;
        }

    }
}
