// class used for displaying information about object
// with normal names, hiding all IDs, relations etc

namespace AniMaIndex.Model
{
    class AnimeListConstructModel
    {
        public string title_name { get; set; }
        public int? year { get; set; }
        public string serial_type { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public decimal episodes { get; set; }
        public string manga_name { get; set; }
        public string studio_name { get; set; }
        public string aired_yet { get; set; }
        public int? score { get; set; }
        public int? epsw { get; set; }
        public string ustatus { get; set; }
        
        public AnimeListConstructModel(AnimeConstructModel a, int? sc, int? ep, string ust)
        {
            manga_name = a.manga_name;
            studio_name = a.studio_name;
            year = a.year;
            title_name = a.title_name;
            serial_type = a.serial_type;
            genre = a.genre;
            description = a.description;
            episodes = a.episodes;
            aired_yet = a.aired_yet;
            score = sc;
            epsw = ep;
            ustatus = ust;
        }
    }
}
