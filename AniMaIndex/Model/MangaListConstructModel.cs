// class used for displaying information about object
// with normal names, hiding all IDs, relations etc

namespace AniMaIndex.Model
{
    class MangaListConstructModel
    {
        public string manga_name { get; set; }
        public string publisher_name { get; set; }
        public int? year { get; set; }
        public string title_name { get; set; }
        public string description { get; set; }
        public decimal chapters { get; set; }
        public decimal thomes { get; set; }
        public string aired_yet { get; set; }
        public string genre { get; set; }

        public int? score { get; set; }
        public int? chaptes_read { get; set; }
        public int? thomes_read { get; set; }
        public string statusname { get; set; }

        
        public MangaListConstructModel(MangaConstructModel man, int? sco, int? chaps, int? thmsr, string stname)
        {
            manga_name = man.manga_name;
            publisher_name = man.publisher_name;
            year = man.year;
            title_name = man.title_name;
            description = man.description;
            chapters = man.chaps;
            thomes = man.thomes;
            aired_yet = man.aired_yet;
            genre = man.genre;

            score = sco;
            chaptes_read = chaps;
            thomes_read = thmsr;
            statusname = stname;
        }
    }
}
