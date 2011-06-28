using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class StudioModel
    {
        // return all data from table as is
        public static object[] ReturnAllStudios()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Studios select tp).ToArray();
            return temp;
        }

        public static object[] ReturnAllStudioNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Studios select tp.StudioName).ToArray();
            return temp;
        }

        public static int ReturnStudioID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.Studios
                        where tp.StudioName == name
                        select tp.StudioID).FirstOrDefault();
            return temp;
        }

        public static void AddStudios(string name, string url)
        {
            AnimeDataContext db = new AnimeDataContext();
            Studio adt = new Studio {StudioName = name, StudioPage = url};
            db.Studios.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemoveStudios(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            Studio[] temp = (from tp in db.Studios select tp).ToArray();
            db.Studios.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
