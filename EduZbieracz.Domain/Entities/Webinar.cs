namespace EduZbieracz.Domain.Entities
{
    internal class Webinars
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string FacebookEventUrl { get; set; }
        public string SlidesUrl { get; set; }

        public string WatchFacebookUrl { get; set; }
        public string WatchYoutubeLink { get; set; }

        public DateTime Date { get; set; }
        public string AlreadyHappend { get; set; }


    }
}
