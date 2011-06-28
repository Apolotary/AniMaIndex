using System.Linq;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class AiredModel
    {
        // return all data from table as is
        public static object[] ReturnAllAired()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.AiredYets select tp).ToArray();
            return temp;
        }

        // return all aired titles by name
        public static object[] ReturnAllAiredNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] temp = (from tp in db.AiredYets select tp.AiredName).ToArray();
            return temp;
        }

        // search for id by name
        public static int ReturnAiredID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.AiredYets
                        where tp.AiredName == name
                        select tp.AiredID).FirstOrDefault();
            return temp;
        }

        // adds new aired title
        public static void AddAired(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            AiredYet adt = new AiredYet { AiredName = name };
            db.AiredYets.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        // removes aired title
        public static void RemoveAired(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            AiredYet[] temp = (from tp in db.AiredYets select tp).ToArray();
            db.AiredYets.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
