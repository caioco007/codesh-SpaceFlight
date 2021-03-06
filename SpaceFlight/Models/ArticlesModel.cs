using System.Collections.Generic;

namespace SpaceFlight.Models
{
    public class ArticlesModel
    {
        public int Id { get; set; }
        public bool Featured { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string NewsSite { get; set; }
        public string Summary { get; set; }
        public string PublishedAt { get; set; }
        
        public List<LaunchesModel> Launches { get; set; }
        public List<EventsModel> Events { get; set; }
    }
}
