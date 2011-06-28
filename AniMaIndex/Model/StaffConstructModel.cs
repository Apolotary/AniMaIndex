// class used for displaying information about object
// with normal names, hiding all IDs, relations etc

namespace AniMaIndex.Model
{
    class StaffConstructModel
    {
        public string staff_name { get; set; }
        public string staff_page { get; set; }
        public string staff_job { get; set; }
        
        public StaffConstructModel(
                                string name,
                                string page,
                                string job)
        {
            staff_name = name;
            staff_page = page;
            staff_job = job;
        }
    }
}
