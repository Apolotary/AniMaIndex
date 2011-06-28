using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.Model
{
    class TypeModel
    {
        // return all data from table as is
        public static object[] ReturnAllTypes()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] type = (from tp in db.SerialTypes select tp).ToArray();
            return type;
        }

        public static object[] ReturnAllTypeNames()
        {
            AnimeDataContext db = new AnimeDataContext();
            object[] type = (from tp in db.SerialTypes select tp.SerialName).ToArray();
            return type;
        }

        public static int ReturnTypeID(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            int temp = (from tp in db.SerialTypes
                        where tp.SerialName == name
                        select tp.SerialTypeID).FirstOrDefault();
            return temp;
        }

        public static void AddType(string name)
        {
            AnimeDataContext db = new AnimeDataContext();
            SerialType adt = new SerialType {SerialName = name};
            db.SerialTypes.InsertOnSubmit(adt);
            db.SubmitChanges();
        }

        public static void RemoveType(int index)
        {
            AnimeDataContext db = new AnimeDataContext();

            SerialType[] temp = (from tp in db.SerialTypes select tp).ToArray();
            db.SerialTypes.DeleteOnSubmit(temp[index]);
            db.SubmitChanges();
        }
    }
}
