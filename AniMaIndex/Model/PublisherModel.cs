using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class PublisherModel
    {
        // return all data from table as is
        public static object[] ReturnAllPublisher()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Publishers select tp).ToArray();
            return temp;
        }

        public static object[] ReturnAllPublisherName()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.Publishers select tp.PublisherName).ToArray();
            return temp;
        }

        public static int ReturnPublisherID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.Publishers
                        where tp.PublisherName == name
                        select tp.PublisherID).FirstOrDefault();
            return temp;
        }

        public static void AddPublisher(string name, string url)
        {
            AnimeDataContext db = new AnimeDataContext();
            Publisher adt = new Publisher { PublisherName = name, PublisherPage = url};
            db.Publishers.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemovePublisher(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            Publisher[] temp = (from tp in db.Publishers select tp).ToArray();
            db.Publishers.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
