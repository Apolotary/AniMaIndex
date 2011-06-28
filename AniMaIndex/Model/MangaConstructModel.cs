// class used for displaying information about object
// with normal names, hiding all IDs, relations etc

namespace AniMaIndex.Model
{
    class MangaConstructModel
    {
        public string manga_name { get; set; }
        public string publisher_name { get; set; }
        public int? year { get; set; }
        public string title_name { get; set; }
        public string description { get; set; }
        public decimal chaps { get; set; }
        public decimal thomes { get; set; }
        public string aired_yet { get; set; }
        public string genre { get; set; }
        
        public MangaConstructModel(
                                string man,
                                string publ,
                                int? y,
                                string tname,
                                string descr,
                                decimal chs,
                                decimal ths,
                                string aired2,
                                string genna)
        {
            manga_name = man;
            publisher_name = publ;
            year = y;
            title_name = tname;
            description = descr;
            chaps = chs;
            thomes = ths;
            aired_yet = aired2;
            genre = genna;
        }
    }
}
