// class used for displaying information about object
// with normal names, hiding all IDs, relations etc

namespace AniMaIndex.Model
{
    public class AnimeConstructModel
    {
        public string manga_name { get; set; }
        public string studio_name { get; set; }
        public int? year { get; set; }
        public string title_name { get; set; }
        public string serial_type { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public decimal episodes { get; set; }
        public string aired_yet { get; set; }
        public AnimeConstructModel(
                                string man,
                                string stn,
                                int? y,
                                string tna,
                                string sty,
                                string genna,
                                string desc,
                                decimal eps2,
                                string aired2)
        {
            manga_name = man;
            studio_name = stn;
            year = y;
            title_name = tna;
            serial_type = sty;
            genre = genna;
            description = desc;
            episodes = eps2;
            aired_yet = aired2;
        }
    }
}
