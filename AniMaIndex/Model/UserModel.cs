using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class UserModel
    {
        // return all data from table as is
        public static object[] ReturnAllUsers()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] usr = (from user in db.Users select user).ToArray();
            return usr;
        }

        public static void AddUser(string name, DateTime birthday, string gender)
        {
            AnimeDataContext db = new AnimeDataContext();
            User adusr = new User {Birthdate = birthday, Gender = gender, NickName = name};
            db.Users.InsertOnSubmit(adusr);
            db.SubmitChanges();
        }

        public static int ReturnUserID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from user in db.Users
                        where user.NickName == name
                        select user.UserID).FirstOrDefault();
            return temp;
        }

        public static string ReturnUserName(int uid)
        {
            AnimeDataContext db = new AnimeDataContext();
            if (uid == 0)
            {
                return "none";
            }
            string temp = (from user in db.Users
                        where user.UserID == uid
                           select user.NickName).FirstOrDefault();
            if (temp == null || uid == 0)
            {
                return "none";
            }
            return temp;
        }

        public static void RemoveUser(int index)
        {
            AnimeDataContext db = new AnimeDataContext();
            
            User[] temp = (from user in db.Users select user).ToArray();
            db.Users.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
        
    }
}
